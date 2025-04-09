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
    public partial class ApplyArithmeticOperationForm : SubViewForm
    {

        private MainHelper Helper;
        private string TextBoxTemplateValue = string.Empty;

        public ApplyArithmeticOperationForm(MainHelper helper)
        {
            InitializeComponent();

            this.Helper = helper;
            this.EightBitRadioButton.Checked = true;
            this.OperationAdditionRadioButton.Checked = true;
            this.ArithmeticRegisterComboBox.SelectedIndex = 0;
            this.LeftHandOperandRegisterComboBox.SelectedIndex = 0;
            this.RightHandOperandRegisterComboBox.SelectedIndex = 0;
        }

        public override string GetCode()
        {
            // T
            string memRegion = this.EightBitRadioButton.Checked
                ? "1"
                : this.SixteenBitRadioButton.Checked
                    ? "2"
                    : this.ThirtyTwoBitRadioButton.Checked
                        ? "4"
                        : this.SixtyFourBitRadioButton.Checked
                            ? "8"
                            : "1";
            // C
            string arithop = this.OperationAdditionRadioButton.Checked ? "0"
                : this.OperationSubtractionRadioButton.Checked ? "1"
                    : this.OperationMultiplicationRadioButton.Checked ? "2"
                        : this.OperationLeftShiftRadioButton.Checked ? "3"
                            : this.OperationrRightShiftRadioButton.Checked ? "4"
                                : this.OperationLogicalAndRadioButton.Checked ? "5"
                                    : this.OperationLogicalOrRadioButton.Checked ? "6"
                                        : this.OperationLogicalNotRadioButton.Checked ? "7"
                                            : this.OperationLogicalXorRadioButton.Checked ? "8"
                                                : this.OperationNoneMoveRadioButton.Checked ? "9"
                                                    : "0";
            // R
            string registerR = this.ArithmeticRegisterComboBox.SelectedItem.ToString();
            // S
            string registerLS = this.LeftHandOperandRegisterComboBox.SelectedItem.ToString();

            // 9TCRS0s0                         Register Arithmetic Encoding
            // 9TCRS100 VVVVVVVV (VVVVVVVV)     Immediate Value Arithmetic Encoding            
            if (this.RegisterArithmeticButton.Checked)
            {
                // s
                string registerRS = this.RightHandOperandRegisterComboBox.SelectedIndex.ToString();

                string template = "9{0}{1}{2}{3}0{4}0";
                return string.Format(template, memRegion, arithop, registerR, registerLS, registerRS);
            }
            else if (this.ValueArithmeticButton.Checked)
            {
                // V
                string value = this.SixtyFourBitRadioButton.Checked
                    ? Helper.FormatHexAddressValue(this.ValueTextBox.Text, 16)
                    : Helper.FormatHexAddressValue(this.ValueTextBox.Text, 8);

                string template = "9{0}{1}{2}{3}100 {4}";
                return string.Format(template, memRegion, arithop, registerR, registerLS, value);
            }
            else
            {
                return string.Empty;
            }
        }

        private void RegisterArithmeticButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRadioButtonActions();
        }

        private void ValueArithmeticButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRadioButtonActions();
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

        private void ThirtyTwoBitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRadioButtonActions();
        }
        private void EightBitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRadioButtonActions();
        }

        private void SixteenBitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRadioButtonActions();
        }

        private void SixtyFourBitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRadioButtonActions();
        }

        private void UpdateRadioButtonActions()
        {
            if (this.RegisterArithmeticButton.Checked)
            {
                this.RightHandOperandRegisterGroupBox.Show();
                this.RightHandOperandRegisterComboBox.SelectedIndex = 0;
                this.RightHandOperandValueGroupBox.Hide();
                this.TemplateLabel.Text = "9TCRS0s0";
            }
            else if (this.ValueArithmeticButton.Checked)
            {
                this.RightHandOperandRegisterGroupBox.Hide();
                this.RightHandOperandValueGroupBox.Show();
                this.TemplateLabel.Text = this.SixtyFourBitRadioButton.Checked
                        ? "9TCRS100 VVVVVVVV VVVVVVVV"
                        : "9TCRS100 VVVVVVVV";
            }

            if (this.EightBitRadioButton.Checked
                || this.SixteenBitRadioButton.Checked
                || this.ThirtyTwoBitRadioButton.Checked)
            {
                this.ValueTextBox.MaxLength = 8;
                this.ValueTextBox.Text = this.ValueTextBox.Text.Length > 8
                    ? this.ValueTextBox.Text.Substring(0, 8)
                    : this.ValueTextBox.Text;

                this.TemplateLabel.Text = this.RegisterArithmeticButton.Checked
                        ? "9TCRS0s0"
                        : "9TCRS100 VVVVVVVV";
            }
            else if (this.SixtyFourBitRadioButton.Checked)
            {
                this.ValueTextBox.MaxLength = 16;
                this.TemplateLabel.Text = this.RegisterArithmeticButton.Checked
                        ? "9TCRS0s0"
                        : "9TCRS100 VVVVVVVV VVVVVVVV";
            }
        }

    }
}
