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
    public partial class LoopEndForm : SubViewForm
    {
        public string CurrentLoopStartValue { get; set; }
        public LoopEndForm(string startValue)
        {
            InitializeComponent();
            this.CurrentLoopStartValue = startValue;
            this.CurrentValueLabel.Text = GetCode();
        }

        public override string GetCode()
        {
            return GetLoopEndCode(this.CurrentLoopStartValue);
        }

        private string GetLoopEndCode(string startCode)
        {
            return startCode.Substring(0, 1) + "1" + startCode.Substring(2);
        }
    }
}
