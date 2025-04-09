using SwitchCheatCodeManager.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchCheatCodeManager.SubView
{
    public partial class StoreStaticValueToRegisterMemoryAddressForm : SubViewForm
    {
        private MainHelper Helper;

        private string TextBoxTemplateValue = string.Empty;

        public StoreStaticValueToRegisterMemoryAddressForm(
            MainHelper helper
            )
        {
            InitializeComponent();
            this.Helper = helper;

            this.ThirtyTwoBitRadioButton.Checked = true;
            this.BaseMemoryRegisterComboBox.SelectedIndex = 0;
            this.NotIncrementalRadioButton.Checked = true;
            this.NotAddToAddressRadioButton.Checked = true;
        }

        public override string GetCode()
        {
            // 6T0RIor0 VVVVVVVV VVVVVVVV
            string memoryWidthBit = this.EightBitRadioButton.Checked
                ? "1"
                : this.SixteenBitRadioButton.Checked
                    ? "2"
                    : this.ThirtyTwoBitRadioButton.Checked
                        ? "4"
                        : this.SixtyFourBitRadioButton.Checked
                            ? "8"
                            : "0";

            string memoryRegister = this.BaseMemoryRegisterComboBox.SelectedItem.ToString();
            string incrementalBit = this.NotIncrementalRadioButton.Checked
                ? "0"
                : this.IncrementalRadioButton.Checked
                    ? "1"
                    : "0";

            string value = Helper.FormatHexAddressValue(this.ValueWriteToMemoryTextBox.Text, 16);

            string template = "";
            if (this.AddToAddressRadioButton.Checked)
            {
                string offsetRegister = this.OffsetRegisterComboBox.SelectedItem.ToString();
                template = "6{0}0{1}{2}1{3}0 {4}";
                return string.Format(template, memoryWidthBit, memoryRegister, incrementalBit, offsetRegister, value);
            }
            else if (this.NotAddToAddressRadioButton.Checked)
            {
                template = "6{0}0{1}{2}000 {3}";
                return string.Format(template, memoryWidthBit, memoryRegister, incrementalBit, value);
            }

            return "64000000 00000000 00000000";
        }

        private void BitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.EightBitRadioButton.Checked)
            {
                this.ValueWriteToMemoryTextBox.MaxLength = 2;
                this.ValueWriteToMemoryTextBox.Text = this.ValueWriteToMemoryTextBox.Text.GetLast(2);
                this.ValueWriteToMemoryTextBox.PlaceholderText = " e.g. VV (0~2 hex-numbers)";
            }
            else if (this.SixteenBitRadioButton.Checked)
            {
                this.ValueWriteToMemoryTextBox.MaxLength = 4;
                this.ValueWriteToMemoryTextBox.Text = this.ValueWriteToMemoryTextBox.Text.GetLast(4);
                this.ValueWriteToMemoryTextBox.PlaceholderText = " e.g. VVVV (0~4 hex-numbers)";
            }
            else if (this.ThirtyTwoBitRadioButton.Checked)
            {
                this.ValueWriteToMemoryTextBox.MaxLength = 8;
                this.ValueWriteToMemoryTextBox.Text = this.ValueWriteToMemoryTextBox.Text.GetLast(8);
                this.ValueWriteToMemoryTextBox.PlaceholderText = " e.g. VVVVVVVV (0~8 hex-numbers)";
            }
            else if (this.SixtyFourBitRadioButton.Checked)
            {
                this.ValueWriteToMemoryTextBox.MaxLength = 16;
                this.ValueWriteToMemoryTextBox.Text = this.ValueWriteToMemoryTextBox.Text.GetLast(16);
                this.ValueWriteToMemoryTextBox.PlaceholderText = " e.g. VVVVVVVVVVVVVVVV (0~16 hex-numbers)";
            }

            UpdateExampleText();
        }

        private void ValueWriteToMemoryTextBox_TextChanged(object sender, EventArgs e)
        {
            // If the text does not match regex
            if (Regex.IsMatch(this.ValueWriteToMemoryTextBox.Text, "[^0-9A-Fa-f]"))
            {
                MessageBox.Show("Please only enter HEX numbers.");
                this.ValueWriteToMemoryTextBox.Text = this.TextBoxTemplateValue;
                this.ValueWriteToMemoryTextBox.SelectionStart = this.TextBoxTemplateValue.Length;
                this.ValueWriteToMemoryTextBox.SelectionLength = 0;
            }
            else
            {
                this.ValueWriteToMemoryTextBox.Text = this.ValueWriteToMemoryTextBox.Text.ToUpper();
                this.TextBoxTemplateValue = this.ValueWriteToMemoryTextBox.Text;
                this.ValueWriteToMemoryTextBox.SelectionStart = this.TextBoxTemplateValue.Length;
                this.ValueWriteToMemoryTextBox.SelectionLength = 0;
            }
        }

        private void OffsetRegisterAddToAddressRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.NotAddToAddressRadioButton.Checked)
            {
                this.OffsetRegisterGroupBox.Hide();
            }
            else if (this.AddToAddressRadioButton.Checked)
            {
                this.OffsetRegisterGroupBox.Show();
                this.OffsetRegisterComboBox.SelectedIndex = 0;
            }

            UpdateExampleText();
        }

        private void IncrementalRegisterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Nothing to do
        }

        private void UpdateExampleText()
        {
            string template = string.Empty;
            string value = this.EightBitRadioButton.Checked
                ? "00000000 000000VV"
                : this.SixteenBitRadioButton.Checked
                    ? "00000000 0000VVVV"
                    : this.ThirtyTwoBitRadioButton.Checked
                        ? "00000000 VVVVVVVV"
                        : this.SixtyFourBitRadioButton.Checked
                            ? "VVVVVVVV VVVVVVVV"
                            : "00000000 00000000";
            if (this.NotAddToAddressRadioButton.Checked)
            {
                template = "6T0RI000 {0}";
            }
            else if (this.AddToAddressRadioButton.Checked)
            {
                template = "6T0RI1r0 {0}";
            }
            this.TemplateLabel.Text = string.Format(template, value);
        }
    }
}
