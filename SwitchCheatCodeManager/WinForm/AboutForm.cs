using SwitchCheatCodeManager.Helper;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace SwitchCheatCodeManager.WinForm
{
    public partial class AboutForm : Form
    {
        private MainHelper Helper;
        private ActionHelper Action;
        private CultureInfo Culture;
        public AboutForm(
            MainHelper mainHelper,
            ActionHelper actionHelper,
            CultureInfo cultureInfo
            )
        {
            this.Helper = mainHelper;
            this.Action = actionHelper;
            this.Culture = cultureInfo;

            ResetCultureInfo();
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReleaseLinkLabel_LinkClicked(Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            string target = e.Link.LinkData as string;
            
            if (target != null && target.StartsWith("http"))
            {
                Process.Start(new ProcessStartInfo(target) { UseShellExecute = true });
            }
        }

        private void ResetCultureInfo()
        {
            Thread.CurrentThread.CurrentUICulture = this.Culture;
        }
    }
}
