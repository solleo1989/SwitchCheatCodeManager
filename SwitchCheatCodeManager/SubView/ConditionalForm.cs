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
using System.Web;
using System.Windows.Forms;

namespace SwitchCheatCodeManager.SubView
{
    public partial class ConditionalForm : SubViewForm
    {
        private MainHelper Helper;

        private string TextBoxRelevantAddress = string.Empty;
        private string TextBoxTemplateValue = string.Empty;

        public ConditionalForm(MainHelper helper)
        {
            InitializeComponent();
            this.Helper = helper;

            this.CompareNsoRadioButton.Checked = true;
            this.ThirtyTwoBitRadioButton.Checked = true;
            this.EqualRadioButton.Checked = true;
        }

        public override string GetCode()
        {
            string address = this.RelevantAddressTextBox.Text;
            string value = this.ValueCompareTextBox.Text;
            string template = string.Empty;
            string addressType = this.CompareNsoRadioButton.Checked
                ? "0"
                : this.CompareHeapRadioButton.Checked
                    ? "1"
                    : this.CompareAliasRadioButton.Checked
                    ? "2"
                        : this.CompareAslrRadioButton.Checked
                            ? "3"
                            : "0";
            template = GetTemplateValueFormat(value);
            address = Helper.FormatHexAddressValue(address, 10);
            string comparisonBit = GetComparisonBit();

            return string.Format(template, addressType, comparisonBit, address);
        }

        public string GetTemplateValueFormat(string value)
        {
            string template = string.Empty;
            if (this.EightBitRadioButton.Checked)
            {
                template = "11{0}{1}00{2} 000000";
                value = value.GetLast(2);
                for (int i = value.Length; i < 2; i++)
                {
                    value = "0" + value;
                }
                template += value;
            }
            else if (this.SixteenBitRadioButton.Checked)
            {
                template = "12{0}{1}00{2} 0000";
                value = value.GetLast(4);
                for (int i = value.Length; i < 4; i++)
                {
                    value = "0" + value;
                }
                template += value;
            }
            else if (this.ThirtyTwoBitRadioButton.Checked)
            {
                template = "14{0}{1}00{2} ";
                value = value.GetLast(8);
                for (int i = value.Length; i < 8; i++)
                {
                    value = "0" + value;
                }
                template += value;
            }
            else if (this.SixtyFourBitRadioButton.Checked)
            {
                template = "18{0}{1}00{2} ";
                var output = "";
                if (value.Length > 16)
                {
                    value = value.GetLast(16);
                }
                for (int i = value.Length - 1; i >= 0 && output.Length <= 17; i--)
                {
                    if (output.Length == 8)
                    {
                        output = " " + output;
                    }
                    output = value[i] + output;
                }
                for (int i = value.Length; i < 16; i++)
                {
                    if (i == 8)
                    {
                        output = " " + output;
                    }
                    output = "0" + output;
                }
                template += output;
            }
            return template;
        }

        private string GetComparisonBit()
        {
            if (this.EqualRadioButton.Checked)
            {
                return "5";
            }
            else if (this.NotEqualRadioButton.Checked)
            {
                return "6";
            }
            else if (this.GreaterThanRadioButton.Checked)
            {
                return "1";
            }
            else if (this.GreaterThanOrEqualToRadioButton.Checked)
            {
                return "2";
            }
            else if (this.LessThanRadioButton.Checked)
            {
                return "3";
            }
            else if (this.LessThanOrEqualToRadioButton.Checked)
            {
                return "4";
            }
            return "0";
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
            if (Regex.IsMatch(this.ValueCompareTextBox.Text, "[^0-9A-Fa-f]"))
            {
                MessageBox.Show("Please only enter HEX numbers.");
                this.ValueCompareTextBox.Text = this.TextBoxTemplateValue;
                this.ValueCompareTextBox.SelectionStart = this.TextBoxTemplateValue.Length;
                this.ValueCompareTextBox.SelectionLength = 0;
            }
            else
            {
                this.ValueCompareTextBox.Text = this.ValueCompareTextBox.Text.ToUpper();
                this.TextBoxTemplateValue = this.ValueCompareTextBox.Text;
                this.ValueCompareTextBox.SelectionStart = this.TextBoxTemplateValue.Length;
                this.ValueCompareTextBox.SelectionLength = 0;
            }
        }

        private void AddressTypeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CompareNsoRadioButton.Checked)
            {
                this.RelevantAddressLabel.Text = "Address relevant to NSO: (Max 10 hex numbers)";
            }
            else if (this.CompareHeapRadioButton.Checked)
            {
                this.RelevantAddressLabel.Text = "Address relevant to Heap: (Max 10 hex numbers)";
            }
            else if (this.CompareAliasRadioButton.Checked)
            {
                this.RelevantAddressLabel.Text = "Address relevant to Alias: (Max 10 hex numbers)";
            }
            else if (this.CompareAslrRadioButton.Checked)
            {
                this.RelevantAddressLabel.Text = "Address relevant to Aslr: (Max 10 hex numbers)";
            }
        }

        private void BitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.EightBitRadioButton.Checked)
            {
                this.ValueCompareTextBox.MaxLength = 2;
                this.ValueCompareTextBox.Text = this.ValueCompareTextBox.Text.GetLast(2);
                this.ValueCompareTextBox.PlaceholderText = " e.g. YY (0~2 hex-numbers)";
                this.TemplateLabel.Text = "11MC00AA AAAAAAAA VVVVVVVV";
            }
            else if (this.SixteenBitRadioButton.Checked)
            {
                this.ValueCompareTextBox.MaxLength = 4;
                this.ValueCompareTextBox.Text = this.ValueCompareTextBox.Text.GetLast(4);
                this.ValueCompareTextBox.PlaceholderText = " e.g. YYYY (0~4 hex-numbers)";
                this.TemplateLabel.Text = "12MC00AA AAAAAAAA VVVVVVVV";
            }
            else if (this.ThirtyTwoBitRadioButton.Checked)
            {
                this.ValueCompareTextBox.MaxLength = 8;
                this.ValueCompareTextBox.Text = this.ValueCompareTextBox.Text.GetLast(8);
                this.ValueCompareTextBox.PlaceholderText = " e.g. VVVVVVVV (0~8 hex-numbers)";
                this.TemplateLabel.Text = "14MC00AA AAAAAAAA VVVVVVVV";
            }
            else if (this.SixtyFourBitRadioButton.Checked)
            {
                this.ValueCompareTextBox.MaxLength = 16;
                this.ValueCompareTextBox.Text = this.ValueCompareTextBox.Text.GetLast(16);
                this.ValueCompareTextBox.PlaceholderText = " e.g. VVVVVVVVVVVVVVVV (0~16 hex-numbers)";
                this.TemplateLabel.Text = "18MC00AA AAAAAAAA VVVVVVVV VVVVVVVV";
            }
        }
    }
}
