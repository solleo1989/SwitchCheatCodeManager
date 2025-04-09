using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchCheatCodeManager.SubView
{
    public partial class TerminatorForm : SubViewForm
    {
        public TerminatorForm()
        {
            InitializeComponent();
        }
        public override string GetCode()
        {
            // 2X000000
            // X: End type (0 = End, 1 = Else).
            if (this.ConditionEndRadioButton.Checked)
            {
                return string.Format("2{0}000000", "X");
            }
            else if (this.ConditionElseRadioButton.Checked)
            {
                return string.Format("2{0}000000", "X");
            }

            return "20000000";
        }

        private void ConditionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.TemplateLabel.Text = GetCode();
        }
    }
}
