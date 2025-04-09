using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchCheatCodeManager.SubView
{
    public partial class ButtonActivatorForm : SubViewForm
    {
        public ButtonActivatorForm()
        {
            InitializeComponent();
        }
        public override string GetCode()
        {
            string hex = "8{0}{1}{2}{3}{4}{5}{6}";
            int dOne
                = 1 * (AButtonCheckBox.Checked ? 1 : 0)     // 80000001
                + 2 * (BButtonCheckBox.Checked ? 1 : 0)     // 80000002
                + 4 * (XButtonCheckBox.Checked ? 1 : 0)     // 80000004
                + 8 * (YButtonCheckBox.Checked ? 1 : 0)     // 80000008
                ;
            int dTwo
                = 1 * (LStickCheckBox.Checked ? 1 : 0)      // 80000010
                + 2 * (RStickCheckBox.Checked ? 1 : 0)      // 80000020
                + 4 * (LButtonCheckBox.Checked ? 1 : 0)     // 80000040
                + 8 * (RButtonCheckBox.Checked ? 1 : 0)     // 80000080
                ;
            int dThree
                = 1 * (ZLButtonCheckBox.Checked ? 1 : 0)    // 80000100
                + 2 * (ZRButtonCheckBox.Checked ? 1 : 0)    // 80000200
                + 4 * (PlusButtonCheckBox.Checked ? 1 : 0)  // 80000400
                + 8 * (MinusButtonCheckBox.Checked ? 1 : 0) // 80000800
                ;
            int dFour
                = 1 * (DLeftCheckBox.Checked ? 1 : 0)       // 80001000
                + 2 * (DUpCheckBox.Checked ? 1 : 0)         // 80002000
                + 4 * (DRightCheckBox.Checked ? 1 : 0)      // 80004000
                + 8 * (DDownCheckBox.Checked ? 1 : 0)       // 80008000
                ;
            int dFive
                = 1 * (LSLeftCheckBox.Checked ? 1 : 0)       // 80010000
                + 2 * (LSUpCheckBox.Checked ? 1 : 0)         // 80020000
                + 4 * (LSRightCheckBox.Checked ? 1 : 0)      // 80040000
                + 8 * (LSDownCheckBox.Checked ? 1 : 0)       // 80080000
                ;
            int dSix
                = 1 * (RSLeftCheckBox.Checked ? 1 : 0)       // 80100000
                + 2 * (RSUpCheckBox.Checked ? 1 : 0)         // 80200000
                + 4 * (RSRightCheckBox.Checked ? 1 : 0)      // 80400000
                + 8 * (RSDownCheckBox.Checked ? 1 : 0)       // 80800000
                ;
            int dFront
                = 1 * (SLButtonCheckBox.Checked ? 1 : 0)     // 81000000
                + 2 * (SRButtonCheckBox.Checked ? 1 : 0)     // 82000000
                ;
            return string.Format(hex,
                string.Format("{0:X}", dFront),
                string.Format("{0:X}", dSix),
                string.Format("{0:X}", dFive),
                string.Format("{0:X}", dFour),
                string.Format("{0:X}", dThree),
                string.Format("{0:X}", dTwo),
                string.Format("{0:X}", dOne));
        }

        private void ButtonsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.TemplateLabel.Text = GetCode();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            foreach (Control gbox in this.Controls)
            {
                if (gbox.GetType() == typeof(GroupBox))
                {
                    foreach (Control cb in gbox.Controls)
                    {
                        if (cb.GetType() == typeof(CheckBox))
                        {
                            ((CheckBox)cb).Checked = false;
                        }
                    }
                }
            }
        }
    }
}
