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
    public partial class LoadRegisterWithMemoryValueForm : SubViewForm
    {
        private MainHelper Helper;

        private string TextBoxTemplateValue { get; set; }

        public LoadRegisterWithMemoryValueForm(MainHelper helper)
        {
            InitializeComponent();
            this.Helper = helper;

            this.ThirtyTwoBitRadioButton.Checked = true;
            this.FixedAddressEncodingRadioButton.Checked = true;
            this.RegisterListComboBox.SelectedIndex = 0;

        }

        public override string GetCode()
        {
            // 5TMR00AA AAAAAAAA            
            string relativeTo = "0";
            string register = this.RegisterListComboBox.SelectedItem.ToString();
            string address = Helper.FormatHexAddressValue(this.AddressValueTextBox.Text, 10);
            string addressEncodingBit = this.FixedAddressEncodingRadioButton.Checked ?
                "0"
                : this.RegisterAddressEncodingRadioButton.Checked
                    ? "1"
                    : "0";
            if (this.FixedAddressEncodingRadioButton.Checked)
            {
                relativeTo = this.ToNsoRadioButton.Checked
                ? "0"
                : this.ToHeapRadioButton.Checked
                    ? "1"
                    : this.ToAliasRadioButton.Checked
                        ? "2"
                        : this.ToAslrRadioButton.Checked
                            ? "3"
                            : "0";
            }
            else if (this.RegisterAddressEncodingRadioButton.Checked)
            {
                relativeTo = "0";
            }

            return
                this.EightBitRadioButton.Checked
                ? string.Format("51{0}{1}{2}0{3}", relativeTo, register, addressEncodingBit, address)
                : this.SixteenBitRadioButton.Checked
                    ? string.Format("52{0}{1}{2}0{3}", relativeTo, register, addressEncodingBit, address)
                    : this.ThirtyTwoBitRadioButton.Checked
                        ? string.Format("54{0}{1}{2}0{3}", relativeTo, register, addressEncodingBit, address)
                        : this.SixtyFourBitRadioButton.Checked
                        ? string.Format("58{0}{1}{2}0{3}", relativeTo, register, addressEncodingBit, address)
                        : string.Format("50{0}{1}{2}0{3}", relativeTo, register, addressEncodingBit, address);
        }

        private void AddressValueTextBox_TextChanged(object sender, EventArgs e)
        {
            // If the text does not match regex
            if (Regex.IsMatch(this.AddressValueTextBox.Text, "[^0-9A-Fa-f]"))
            {
                MessageBox.Show("Please only enter HEX numbers.");
                this.AddressValueTextBox.Text = this.TextBoxTemplateValue;
                this.AddressValueTextBox.SelectionStart = this.TextBoxTemplateValue.Length;
                this.AddressValueTextBox.SelectionLength = 0;
            }
            else
            {
                this.AddressValueTextBox.Text = this.AddressValueTextBox.Text.ToUpper();
                this.TextBoxTemplateValue = this.AddressValueTextBox.Text;
                this.AddressValueTextBox.SelectionStart = this.TextBoxTemplateValue.Length;
                this.AddressValueTextBox.SelectionLength = 0;
            }
        }

        private void BitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateExampleText();
        }

        private void UpdateExampleText()
        {
            string memoryRegionBit = this.FixedAddressEncodingRadioButton.Checked ?
                "M"
                : this.RegisterAddressEncodingRadioButton.Checked
                    ? "0"
                    : "M";
            string addressEncodingBit = this.FixedAddressEncodingRadioButton.Checked ?
                "0"
                : this.RegisterAddressEncodingRadioButton.Checked
                    ? "1"
                    : "0";

            if (this.EightBitRadioButton.Checked)
            {
                this.TemplateLabel.Text = string.Format("51{0}R{1}0AA AAAAAAAA", memoryRegionBit, addressEncodingBit);
            }
            else if (this.SixteenBitRadioButton.Checked)
            {
                this.TemplateLabel.Text = string.Format("52{0}R{1}0AA AAAAAAAA", memoryRegionBit, addressEncodingBit);
            }
            else if (this.ThirtyTwoBitRadioButton.Checked)
            {
                this.TemplateLabel.Text = string.Format("54{0}R{1}0AA AAAAAAAA", memoryRegionBit, addressEncodingBit);
            }
            else if (this.SixtyFourBitRadioButton.Checked)
            {
                this.TemplateLabel.Text = string.Format("58{0}R{1}0AA AAAAAAAA", memoryRegionBit, addressEncodingBit);
            }
        }

        private void AddressEncodingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.FixedAddressEncodingRadioButton.Checked)
            {
                this.RelativeToGroupBox.Show();
                this.ToNsoRadioButton.Checked = true;
            }
            else if (this.RegisterAddressEncodingRadioButton.Checked)
            {
                this.RelativeToGroupBox.Hide();
            }

            UpdateExampleText();
        }
    }
}
