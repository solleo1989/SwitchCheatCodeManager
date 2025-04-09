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
    public partial class LoadRegisterWithStaticValueForm : SubViewForm
    {
        private MainHelper Helper;

        private string TextBoxTemplateValue { get; set; }

        public LoadRegisterWithStaticValueForm(MainHelper helper)
        {
            InitializeComponent();
            this.Helper = helper;

            this.RegisterListComboBox.SelectedIndex = 0;
        }

        public override string GetCode()
        {
            // 40020000 00000000 00000001
            string register = this.RegisterListComboBox.SelectedItem.ToString();
            string address = Helper.FormatHexAddressValue(this.AddressValueTextBox.Text, 16);
            return string.Format("400{0}0000 {1}", register, address);
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

        private void UpdateExampleText()
        {
            this.TemplateLabel.Text = "400R0000 VVVVVVVV VVVVVVVV";
        }
    }
}
