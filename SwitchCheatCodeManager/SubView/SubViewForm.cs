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
    public partial class SubViewForm : Form
    {
        public SubViewForm()
        {
            InitializeComponent();
        }

        public virtual string GetCode()
        {
            return string.Empty;
        }
    }
}
