using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.ComponentModel.Design.Serialization;
using SwitchCheatCodeManager.Helper;

namespace SwitchCheatCodeManager.SubView
{
    public partial class MemoryWriteForm : SubViewForm
    {
        private MainHelper Helper;

        private string TextBoxRelevantAddress = string.Empty;
        private string TextBoxTemplateValue = string.Empty;

        public MemoryWriteForm(MainHelper helper)
        {
            InitializeComponent();
            this.Helper = helper;

            this.NsoRadioButton.Checked = true;
            this.OffsetRegisterComboBox.SelectedIndex = 15;
            this.ThirtyTwoBitRadioButton.Checked = true;
        }

        public override string GetCode()
        {
            string addressType = this.NsoRadioButton.Checked
                ? addressType = "0"
                : this.HeapRadioButton.Checked
                    ? addressType = "1"
                    : this.AliasRadioButton.Checked
                        ? addressType = "2"
                        : this.AslrRadioButton.Checked
                            ? addressType = "3"
                            : addressType = "0";

            string register = this.OffsetRegisterComboBox.SelectedItem.ToString();
            string value = this.ValueTextBox.Text;
            string template = GetTemplateValueFormat(value);
            string address = Helper.FormatHexAddressValue(this.RelevantAddressTextBox.Text, 10);

            return string.Format(template, addressType, register, address);
        }

        public string GetTemplateValueFormat(string value)
        {
            // 0TMR00AA AAAAAAAA VVVVVVVV
            string template = string.Empty;
            if (this.EightBitRadioButton.Checked)
            {
                template = "01{0}{1}00{2} 000000";
                value = Helper.GetHexValueFormat(value, 2);
            }
            else if (this.SixteenBitRadioButton.Checked)
            {
                template = "02{0}{1}00{2} 0000";
                value = Helper.GetHexValueFormat(value, 4);
            }
            else if (this.ThirtyTwoBitRadioButton.Checked)
            {
                template = "04{0}{1}00{2} ";
                value = Helper.GetHexValueFormat(value, 8);
            }
            else if (this.SixtyFourBitRadioButton.Checked)
            {
                template = "08{0}{1}00{2} ";
                value = Helper.GetHexValueFormat(value, 16);
            }
            template += value;
            return template;
        }

        private void RelevantAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            // If the text does not match regex
            if (Regex.IsMatch(this.RelevantAddressTextBox.Text, "[^0-9A-Fa-f]"))
            {
                MessageBox.Show("Please only enter HEX numbers.");
                this.RelevantAddressTextBox.Text = this.TextBoxRelevantAddress;
                this.RelevantAddressTextBox.SelectionStart = this.TextBoxRelevantAddress.Length;
                this.RelevantAddressTextBox.SelectionLength = 0;
            }
            else
            {
                this.RelevantAddressTextBox.Text = this.RelevantAddressTextBox.Text.ToUpper();
                this.TextBoxRelevantAddress = this.RelevantAddressTextBox.Text;
                this.RelevantAddressTextBox.SelectionStart = this.TextBoxRelevantAddress.Length;
                this.RelevantAddressTextBox.SelectionLength = 0;
            }
        }

        private void ValueTextBox_TextChanged(object sender, EventArgs e)
        {
            // If the text does not match regex
            if (Regex.IsMatch(this.ValueTextBox.Text, "[^0-9A-Fa-f]"))
            {
                MessageBox.Show("Please only enter HEX numbers.");
                this.ValueTextBox.Text = this.TextBoxTemplateValue;
                this.ValueTextBox.SelectionStart = this.TextBoxTemplateValue.Length;
                this.ValueTextBox.SelectionLength = 0;
            }
            else
            {
                this.ValueTextBox.Text = this.ValueTextBox.Text.ToUpper();
                this.TextBoxTemplateValue = this.ValueTextBox.Text;
                this.ValueTextBox.SelectionStart = this.TextBoxTemplateValue.Length;
                this.ValueTextBox.SelectionLength = 0;
            }
        }

        private void AddressTypeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.NsoRadioButton.Checked)
            {
                this.RelevantAddressLabel.Text = "Address relevant to NSO (A): (Max 10 hex numbers)";
            }
            else if (this.HeapRadioButton.Checked)
            {
                this.RelevantAddressLabel.Text = "Address relevant to Heap (A): (Max 10 hex numbers)";
            }
            else if (this.AliasRadioButton.Checked)
            {
                this.RelevantAddressLabel.Text = "Address relevant to Alias (A): (Max 10 hex numbers)";
            }
            else if (this.AslrRadioButton.Checked)
            {
                this.RelevantAddressLabel.Text = "Address relevant to Aslr (A): (Max 10 hex numbers)";
            }
        }

        private void BitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.EightBitRadioButton.Checked)
            {
                this.ValueTextBox.MaxLength = 2;
                this.ValueTextBox.Text = this.ValueTextBox.Text.GetLast(2);
                this.ValueTextBox.PlaceholderText = " e.g. VV (0~2 hex-numbers)";
                this.TemplateLabel.Text = "01MR00AA AAAAAAAA 000000VV";
            }
            else if (this.SixteenBitRadioButton.Checked)
            {
                this.ValueTextBox.MaxLength = 4;
                this.ValueTextBox.Text = this.ValueTextBox.Text.GetLast(4);
                this.ValueTextBox.PlaceholderText = " e.g. VVVV (0~4 hex-numbers)";
                this.TemplateLabel.Text = "02MR00AA AAAAAAAA 0000VVVV";
            }
            else if (this.ThirtyTwoBitRadioButton.Checked)
            {
                this.ValueTextBox.MaxLength = 8;
                this.ValueTextBox.Text = this.ValueTextBox.Text.GetLast(8);
                this.ValueTextBox.PlaceholderText = " e.g. VVVVVVVV (0~8 hex-numbers)";
                this.TemplateLabel.Text = "04MR00AA AAAAAAAA VVVVVVVV";
            }
            else if (this.SixtyFourBitRadioButton.Checked)
            {
                this.ValueTextBox.MaxLength = 16;
                this.ValueTextBox.Text = this.ValueTextBox.Text.GetLast(16);
                this.ValueTextBox.PlaceholderText = " e.g. VVVVVVVVVVVVVVVV (0~16 hex-numbers)";
                this.TemplateLabel.Text = "08MR00AA AAAAAAAA VVVVVVVV VVVVVVVV";
            }
        }

    }
}
