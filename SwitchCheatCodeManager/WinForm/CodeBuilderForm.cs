using System;
using System.Collections.Generic;

using System.Text.RegularExpressions;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwitchCheatCodeManager.Helper;
using SwitchCheatCodeManager.SubView;
using SwitchCheatCodeManager.FormEntity;
using static SwitchCheatCodeManager.Mode.EnumMode;


namespace SwitchCheatCodeManager.WinForm
{
    public partial class CodeBuilderForm : Form
    {
        public string CurrentLoopStartValue { get; set; }

        private MainHelper Helper;
        private ActionHelper Action;
        private CultureInfo Culture;
        private SubViewForm CurrentForm;

        public CodeBuilderForm(
            MainHelper mainHelper,
            ActionHelper actionHelper,
            CultureInfo cultureInfo)
        {
            this.Helper = mainHelper;
            this.Action = actionHelper;
            this.Culture = cultureInfo;

            InitializeComponent();
            this.MethodsComboBox.SelectedIndex = 0;
            this.CurrentLoopStartValue = Constant.Constants.DefaultLoopStartValue;
            this.SymbolComboBox.DataSource = new List<string> { "+ Addition", "- Subtraction", "x Multiplication" };
        }

        private void LoadSubForms(int index)
        {
            if (this.CurrentForm != null)
            {
                this.CurrentForm.Dispose();
            }
            SubViewForm subform;
            switch (index)
            {
                case 0:
                    subform = new MemoryWriteForm(Helper);
                    break;
                case 1:
                    subform = new ConditionalForm(Helper);
                    break;
                case 2:
                    subform = new TerminatorForm();
                    break;
                case 3:
                    subform = new LoopStartEndForm(Helper);
                    break;
                case 4:
                    subform = new LoadRegisterWithStaticValueForm(Helper);
                    break;
                case 5:
                    subform = new LoadRegisterWithMemoryValueForm(Helper);
                    break;
                case 6:
                    subform = new StoreStaticValueToRegisterMemoryAddressForm(Helper);
                    break;
                case 7:
                    subform = new ApplyLegacyArithmeticOperationForm(Helper);
                    break;
                case 8:
                    subform = new ButtonActivatorForm();
                    break;
                case 9:
                    subform = new ApplyArithmeticOperationForm(Helper);
                    break;
                case 10:
                    subform = new StoreRegisterToMemoryAddressForm(Helper);
                    break;
                default:
                    subform = new SubViewForm();
                    break;
            }
            subform.FormBorderStyle = FormBorderStyle.None;
            subform.Dock = DockStyle.Fill;
            subform.TopLevel = false;
            subform.TopMost = true;
            this.MemoryWritePanel.Controls.Add(subform);
            subform.Show();
            ASMHelper asm = new ASMHelper();
            string s = asm.ToString(ASMOperationType.LoadRegisterWithStaticValue, "40050000 00000012 00000012");
            this.CurrentForm = subform;
        }

        private void Hex2DecTextBox_TextChanged(object sender, EventArgs e)
        {

            var input = Hex2DecTextBox.Text;
            Regex reg = new Regex(@"^((([0-9a-fA-F])+)|(0x(([0-9a-fA-F])+)))$");
            //Regex reg = new Regex(@"^(([0-9a-zA-Z])+)$");
            if (reg.IsMatch(input))
            {
                this.DecResultTextBox.Text = Convert.ToInt64(input, 16).ToString();
            }
            else
            {
                this.DecResultTextBox.Text = "Invalid Input";
            }
        }

        private void Dec2HexTextBox_TextChanged(object sender, EventArgs e)
        {
            var input = Dec2HexTextBox.Text;
            Regex reg = new Regex(@"^([0-9]+)$");
            if (reg.IsMatch(input))
            {
                long dec = long.Parse(input);
                this.HexResultTextBox.Text = string.Format("0x{0:X}", dec); // lowcase: x, uppercase: X
            }
            else
            {
                this.HexResultTextBox.Text = "Invalid Input";
            }
        }

        private void AddCodeButton_Click(object sender, EventArgs e)
        {
            if (this.CurrentForm != null && this.CurrentForm.GetType() == typeof(LoopStartEndForm))
            {
                this.CurrentLoopStartValue = this.CurrentForm.GetCode().Substring(0, 8);
            }
            this.OutputTextBox.Text += this.CurrentForm.GetCode() + System.Environment.NewLine;
        }

        private void MethodsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSubForms(this.MethodsComboBox.SelectedIndex);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.OutputTextBox.Text = string.Empty;
        }

        private void CopyToClipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.OutputTextBox.Text);
        }

        private void InitializeArithmaticOperationSection()
        {
            this.LeftFactorTextBox.ResetBackColor();
            this.RightFactorTextBox.ResetBackColor();
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            InitializeArithmaticOperationSection();

            bool valid = true;
            Regex reg = new Regex(@"^((([0-9a-fA-F])+)|(0x(([0-9a-fA-F])+)))$");
            if (string.IsNullOrEmpty(this.LeftFactorTextBox.Text)
                || !reg.IsMatch(this.LeftFactorTextBox.Text))
            {
                valid = false;
                this.LeftFactorTextBox.BackColor = Color.Red;
            }

            if (string.IsNullOrEmpty(this.RightFactorTextBox.Text)
                || !reg.IsMatch(this.RightFactorTextBox.Text))
            {
                valid = false;
                this.RightFactorTextBox.BackColor = Color.Red;
            }

            if (valid)
            {
                long left = Convert.ToInt64(this.LeftFactorTextBox.Text, 16);
                long right = Convert.ToInt64(this.RightFactorTextBox.Text, 16);
                long result = 0;
                switch (this.SymbolComboBox.SelectedIndex)
                {
                    case 0:
                        result = left + right;
                        break;
                    case 1:
                        result = left - right;
                        break;
                    case 2:
                        result = left * right;
                        break;
                    default:
                        result = left;
                        break;
                }
                this.ResultTextBox.Text = string.Format("0x{0:X}", result); // lowcase: x, uppercase: X
            }
        }        
    }
}
