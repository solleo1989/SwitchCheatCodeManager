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
    public partial class ApplyLegacyArithmeticOperationForm : SubViewForm
    {
        private MainHelper Helper;

        private string TextBoxTemplateValue = string.Empty;

        public ApplyLegacyArithmeticOperationForm(MainHelper helper)
        {
            InitializeComponent();

            this.Helper = helper;
            this.ThirtyTwoBitRadioButton.Checked = true;
            this.ArithmeticRegisterComboBox.SelectedIndex = 0;
            this.AdditionRadioButton.Checked = true;
        }

        public override string GetCode()
        {
            //7T0RC000 VVVVVVVV
            string template = "7{0}0{1}{2}000 {3}";
            string memRegion = this.EightBitRadioButton.Checked
                ? "1"
                : this.SixteenBitRadioButton.Checked
                    ? "2"
                    : this.ThirtyTwoBitRadioButton.Checked
                        ? "4"
                        : this.SixtyFourBitRadioButton.Checked
                            ? "8"
                            : "1";
            string register = this.ArithmeticRegisterComboBox.SelectedItem.ToString();
            string operation = this.AdditionRadioButton.Checked
                ? "0"
                : this.SubtractionRadioButton.Checked
                    ? "1"
                    : this.MultiplicationRadioButton.Checked
                        ? "2"
                        : this.LeftShiftRadioButton.Checked
                            ? "3"
                            : this.RightShiftRadioButton.Checked
                                ? "4"
                                : "0";
            string value = Helper.FormatHexAddressValue(this.ValueTextBox.Text, 8);
            return string.Format(template, memRegion, register, operation, value);
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

        private void BitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            /**
            if (this.EightBitRadioButton.Checked)
            {
                this.ValueTextBox.MaxLength = 2;
                this.ValueTextBox.Text = this.ValueTextBox.Text.GetLast(2);
                this.ValueTextBox.PlaceholderText = " e.g. VV (0~2 hex-numbers)";
            }
            else if (this.SixteenBitRadioButton.Checked)
            {
                this.ValueTextBox.MaxLength = 4;
                this.ValueTextBox.Text = this.ValueTextBox.Text.GetLast(4);
                this.ValueTextBox.PlaceholderText = " e.g. VVVV (0~4 hex-numbers)";
            }
            else if (this.ThirtyTwoBitRadioButton.Checked)
            {
                this.ValueTextBox.MaxLength = 8;
                this.ValueTextBox.Text = this.ValueTextBox.Text.GetLast(8);
                this.ValueTextBox.PlaceholderText = " e.g. VVVVVVVV (0~8 hex-numbers)";
            }
            else if (this.SixtyFourBitRadioButton.Checked)
            {
                this.ValueTextBox.MaxLength = 16;
                this.ValueTextBox.Text = this.ValueTextBox.Text.GetLast(16);
                this.ValueTextBox.PlaceholderText = " e.g. VVVVVVVVVVVVVVVV (0~16 hex-numbers)";
            }
            */
            this.ValueTextBox.MaxLength = 8;
            this.ValueTextBox.Text = this.ValueTextBox.Text.GetLast(8);
            this.ValueTextBox.PlaceholderText = " e.g. VVVVVVVV (0~8 hex-numbers)";
            UpdateExampleText();
        }

        private void UpdateExampleText()
        {            
            this.TemplateLabel.Text = "7T0RC000 VVVVVVVV";
        }
    }
}
