using SwitchCheatCodeManager.Constant;
using SwitchCheatCodeManager.Entity;
using SwitchCheatCodeManager.Helper;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using RECT = SwitchCheatCodeManager.Helper.NativeMethods.RECT;

namespace SwitchCheatCodeManager.FormEntity
{
    public class TextAreaEx : RichTextBox
    {

        [DllImport(@"User32.dll", EntryPoint = @"SendMessage", CharSet = CharSet.Auto)]
        public static extern int SendMessageRefRect(IntPtr hWnd, uint msg, int wParam, ref RECT rect);

        [DllImport(@"user32.dll", EntryPoint = @"SendMessage", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, ref Rectangle lParam);

        // For RichTextBox
        // http://referencesource.microsoft.com/#System.Windows.Forms/winforms/Managed/System/WinForms/UnsafeNativeMethods.cs,0d546f58103867e3
        [DllImport(@"user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(HandleRef hWnd, int msg, int wParam, [In, Out, MarshalAs(UnmanagedType.LPStruct)] CHARFORMAT2 lParam);
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(HandleRef hWnd, int msg, int wParam, [In, Out, MarshalAs(UnmanagedType.LPStruct)] PARAFORMAT2 lParam);
        
        public TextAreaEx() : base()
        {
            AutoSize = false;
            Padding = new Padding(0);
            this.SetInnerMargins(15, 10, 15, 0);
            this.SetCharacterSet();
            this.SetLineSpacing(Constants.DEFAULT_TEXTBOX_CHARACTER_LINE_SPACING);
        }
    }
}
