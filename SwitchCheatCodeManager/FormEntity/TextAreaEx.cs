using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms;

namespace SwitchCheatCodeManager.FormEntity
{
    public class TextAreaEx : RichTextBox
    {

        [DllImport(@"User32.dll", EntryPoint = @"SendMessage", CharSet = CharSet.Auto)]
        private static extern int SendMessageRefRect(IntPtr hWnd, uint msg, int wParam, ref RECT rect);

        [DllImport(@"user32.dll", EntryPoint = @"SendMessage", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, ref Rectangle lParam);

        private const int EmGetrect = 0xB2;
        private const int EmSetrect = 0xB3;

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public readonly int Left;
            public readonly int Top;
            public readonly int Right;
            public readonly int Bottom;

            private RECT(int left, int top, int right, int bottom)
            {
                Left = left;
                Top = top;
                Right = right;
                Bottom = bottom;
            }

            public RECT(Rectangle r) : this(r.Left, r.Top, r.Right, r.Bottom)
            {
            }
        }

        public TextAreaEx() : base()
        {
            AutoSize = false;
            Padding = new Padding(0);
            this.SetInnerMargins(15, 10, 15, 10);
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
        }

        public void SetInnerMargins(int left, int top, int right, int bottom)
        {
            var rect = this.GetFormattingRect();

            var newRect = new Rectangle(left, top, rect.Width - left - right, rect.Height - top - bottom);
            this.SetFormattingRect(newRect);
        }

        private void SetFormattingRect(Rectangle rect)
        {
            var rc = new RECT(rect);
            SendMessageRefRect(this.Handle, EmSetrect, 0, ref rc);
        }

        private Rectangle GetFormattingRect()
        {
            var rect = new Rectangle();
            SendMessage(this.Handle, EmGetrect, (IntPtr)0, ref rect);
            return rect;
        }
    }
}
