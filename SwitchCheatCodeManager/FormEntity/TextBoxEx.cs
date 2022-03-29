using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SwitchCheatCodeManager.FormEntity
{
    class TextBoxEx : TextBox
    {

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        private const int EM_SETMARGINS = 0xd3;
        private const int EC_RIGHTMARGIN = 2;
        private const int EC_LEFTMARGIN = 1;
        private int p = 5;
        public TextBoxEx() : base()
        {
            var b = new Label { Dock = DockStyle.Bottom, Height = 0, BackColor = Color.Transparent };
            var l = new Label { Dock = DockStyle.Left, Width = p, BackColor = Color.Transparent };
            var r = new Label { Dock = DockStyle.Right, Width = p, BackColor = Color.Transparent };
            AutoSize = false;
            Padding = new Padding(0);
            ///BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Controls.AddRange(new Control[] { l, r, b });
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            SetMargin();
        }
        private void SetMargin()
        {
            SendMessage(Handle, EM_SETMARGINS, EC_RIGHTMARGIN, p << 16);
            SendMessage(Handle, EM_SETMARGINS, EC_LEFTMARGIN, p);
        }
    }
}
