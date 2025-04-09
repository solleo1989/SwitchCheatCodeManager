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
    public partial class StoreRegisterToMemoryAddressForm : SubViewForm
    {
        private MainHelper Helper;
        private string TextBoxOffsetValue = string.Empty;

        public StoreRegisterToMemoryAddressForm(MainHelper helper)
        {
            InitializeComponent();
            this.Helper = helper;

            this.ThirtyTwoBitRadioButton.Checked = true;
            this.WriteToRegisterComboBox.SelectedIndex = 0;
            this.NotIncrementalRadioButton.Checked = true;
            this.NoOffsetRadioButton.Checked = true;
        }
        public override string GetCode()
        {
            //ATSRIOxa (aaaaaaaa)
            string memoryWidthBit = this.EightBitRadioButton.Checked
                ? "1"
                : this.SixteenBitRadioButton.Checked
                    ? "2"
                    : this.ThirtyTwoBitRadioButton.Checked
                        ? "4"
                        : this.SixtyFourBitRadioButton.Checked
                            ? "8"
                            : "0";
            string memoryRegister = this.WriteToRegisterComboBox.SelectedItem.ToString();
            string incrementalFlagBit = this.NotIncrementalRadioButton.Checked
                ? "0"
                : this.IncrementalRadioButton.Checked
                    ? "1"
                    : "0";

            if (this.NoOffsetRadioButton.Checked)
            {
                return string.Format("A{0}{1}{2}{3}000", memoryWidthBit, memoryRegister, 0, incrementalFlagBit);
            }
            else if (this.OffsetRegisterRadioButton.Checked)
            {
                string offsetRegister = this.OffsetRegisterComboBox.SelectedItem.ToString();
                return string.Format("A{0}{1}{2}{3}1{4}0", memoryWidthBit, memoryRegister, 0, incrementalFlagBit, offsetRegister);
            }
            else if (this.FixedOffsetRadioButton.Checked)
            {
                var offsetValue = Helper.FormatHexAddressValue(this.OffsetValueTextBox.Text, 9);
                return string.Format("A{0}{1}{2}{3}20{4}", memoryWidthBit, memoryRegister, 0, incrementalFlagBit, offsetValue);
            }
            else if (this.MemoryRegionBaseRegisterRadioButton.Checked)
            {
                string baseyRegister = this.BaseMemoryRegisterComboBox.SelectedItem.ToString();
                string memoryRegionBit = this.NsoRadioButton.Checked
                ? "0"
                : this.HeapRadioButton.Checked
                    ? "1"
                    : this.AliasRadioButton.Checked
                        ? "2"
                        : this.AslrRadioButton.Checked
                            ? "3"
                            : "0";
                return string.Format("A{0}{1}{2}{3}3{4}0", memoryWidthBit, memoryRegister, baseyRegister, incrementalFlagBit, memoryRegionBit);
            }
            else if (this.MemoryRegionRelativeAddressRadioButton.Checked)
            {
                string memoryRegionBit = this.NsoRadioButton.Checked
                ? "0"
                : this.HeapRadioButton.Checked
                    ? "1"
                    : this.AliasRadioButton.Checked
                        ? "2"
                        : this.AslrRadioButton.Checked
                            ? "3"
                            : "0";
                var offsetValue = Helper.FormatHexAddressValue(this.OffsetValueTextBox.Text, 9);
                return string.Format("A{0}{1}{2}{3}4{4}{5}", memoryWidthBit, memoryRegister, 0, incrementalFlagBit, memoryRegionBit, offsetValue);
            }
            else if (this.MemoryRegionRelativeAddressOffsetRegisteradioButton.Checked)
            {
                string offsetRegister = this.BaseMemoryRegisterComboBox.SelectedItem.ToString();
                string memoryRegionBit = this.NsoRadioButton.Checked
                ? "0"
                : this.HeapRadioButton.Checked
                    ? "1"
                    : this.AliasRadioButton.Checked
                        ? "2"
                        : this.AslrRadioButton.Checked
                            ? "3"
                            : "0";
                var offsetValue = Helper.FormatHexAddressValue(this.OffsetValueTextBox.Text, 9);
                return string.Format("A{0}{1}{2}{3}5{4}{5}", memoryWidthBit, memoryRegister, offsetRegister, incrementalFlagBit, memoryRegionBit, offsetValue);
            }
            return "";
        }

        private void OffsetTypesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            /**
              * 
              * x: Register used as offset when O is 1, Memory type when O is 3, 4 or 5.
              * a: Value used as offset when O is 2, 4 or 5.
                0: No Offset
                1: Use Offset Register
                2: Use Fixed Offset
                3: Memory Region + Base Register
                4: Memory Region + Relative Address (ignore address register)
                5: Memory Region + Relative Address + Offset Register
              * 
              */

            if (this.NoOffsetRadioButton.Checked)
            {
                this.BaseMemoryRegisterGroupBox.Hide();
                this.MemoryRegionGroupBox.Hide();
                this.OffsetRegisterGroupBox.Hide();
                this.OffsetValueGroupBox.Hide();
                this.TemplateLabel.Text = "ATS0I000";
            }
            else if (this.OffsetRegisterRadioButton.Checked)
            {
                this.BaseMemoryRegisterGroupBox.Hide();
                this.MemoryRegionGroupBox.Hide();
                this.OffsetRegisterGroupBox.Show();
                this.OffsetRegisterComboBox.SelectedIndex = 0;
                this.OffsetValueGroupBox.Hide();
                this.TemplateLabel.Text = "ATS0I1x0";
            }
            else if (this.FixedOffsetRadioButton.Checked)
            {
                this.BaseMemoryRegisterGroupBox.Hide();
                this.MemoryRegionGroupBox.Hide();
                this.OffsetRegisterGroupBox.Hide();
                this.OffsetValueGroupBox.Show();
                this.TemplateLabel.Text = "ATS0I20a aaaaaaaa";
            }
            else if (this.MemoryRegionBaseRegisterRadioButton.Checked)
            {
                this.BaseMemoryRegisterGroupBox.Show();
                this.MemoryRegionGroupBox.Show();
                this.BaseMemoryRegisterComboBox.SelectedIndex = 0;
                this.NsoRadioButton.Checked = true;
                this.OffsetRegisterGroupBox.Hide();
                this.OffsetValueGroupBox.Hide();
                this.TemplateLabel.Text = "ATSRI3x0";
            }
            else if (this.MemoryRegionRelativeAddressRadioButton.Checked)
            {
                this.BaseMemoryRegisterGroupBox.Hide();
                this.MemoryRegionGroupBox.Show();
                this.NsoRadioButton.Checked = true;
                this.OffsetRegisterGroupBox.Hide();
                this.OffsetValueGroupBox.Show();
                this.TemplateLabel.Text = "ATS0I4xa aaaaaaaa";
            }
            else if (this.MemoryRegionRelativeAddressOffsetRegisteradioButton.Checked)
            {
                this.BaseMemoryRegisterGroupBox.Show();
                this.MemoryRegionGroupBox.Show();
                this.OffsetRegisterComboBox.SelectedIndex = 0;
                this.NsoRadioButton.Checked = true;
                this.OffsetRegisterGroupBox.Hide(); // How it gonna show in code
                this.OffsetValueGroupBox.Show();
                this.TemplateLabel.Text = "ATSRI5xa aaaaaaaa";
            }
        }
        private void OffsetValueTextBox_TextChanged(object sender, EventArgs e)
        {
            // If the text does not match regex
            if (Regex.IsMatch(this.OffsetValueTextBox.Text, "[^0-9A-Fa-f]"))
            {
                MessageBox.Show("Please only enter HEX numbers.");
                this.OffsetValueTextBox.Text = this.TextBoxOffsetValue;
                this.OffsetValueTextBox.SelectionStart = this.TextBoxOffsetValue.Length;
                this.OffsetValueTextBox.SelectionLength = 0;
            }
            else
            {
                this.OffsetValueTextBox.Text = this.OffsetValueTextBox.Text.ToUpper();
                this.TextBoxOffsetValue = this.OffsetValueTextBox.Text;
                this.OffsetValueTextBox.SelectionStart = this.TextBoxOffsetValue.Length;
                this.OffsetValueTextBox.SelectionLength = 0;
            }
        }
    }
}
