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
    public partial class LoopStartEndForm : SubViewForm
    {
        private MainHelper Helper;

        private string TextBoxTemplateValue = string.Empty;
        public LoopStartEndForm(MainHelper helper)
        {
            InitializeComponent();
            this.Helper = helper;

            this.StartRadioButton.Checked = true;
            this.CountRegisterComboBox.SelectedIndex = 0;
        }

        public override string GetCode()
        {
            string register = this.CountRegisterComboBox.SelectedItem.ToString();
            string value = Helper.FormatHexAddressValue(this.NumOfLoopsTextBox.Text, 8);
            string template = this.StartRadioButton.Checked
                ? "300{0}0000 {1}"
                : this.EndRadioButton.Checked
                    ? "310{0}0000"
                    : "3000000000";

            return string.Format(template, register, value);
        }

        private void CountRegisterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.CurrentValueLabel.Text = GetCode();
        }

        private void NumOfLoopsTextBox_TextChanged(object sender, EventArgs e)
        {
            // If the text does not match regex
            if (Regex.IsMatch(this.NumOfLoopsTextBox.Text, "[^0-9A-Fa-f]"))
            {
                MessageBox.Show("Please only enter HEX numbers.");
                this.NumOfLoopsTextBox.Text = this.TextBoxTemplateValue;
                this.NumOfLoopsTextBox.SelectionStart = this.TextBoxTemplateValue.Length;
                this.NumOfLoopsTextBox.SelectionLength = 0;
            }
            else
            {
                this.NumOfLoopsTextBox.Text = this.NumOfLoopsTextBox.Text.ToUpper();
                this.TextBoxTemplateValue = this.NumOfLoopsTextBox.Text;
                this.NumOfLoopsTextBox.SelectionStart = this.TextBoxTemplateValue.Length;
                this.NumOfLoopsTextBox.SelectionLength = 0;
            }

            //this.CurrentValueLabel.Text = GetCode();
        }

        private void StartRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.StartRadioButton.Checked)
            {
                this.NumOfLoopsLabel.Show();
                this.NumOfLoopsTextBox.Show();
                this.CurrentValueLabel.Text = "300R0000 VVVVVVVV";
            }
            else if (this.EndRadioButton.Checked)
            {
                this.NumOfLoopsLabel.Hide();
                this.NumOfLoopsTextBox.Hide();
                this.CurrentValueLabel.Text = "310R0000";
            }
        }
    }
}
