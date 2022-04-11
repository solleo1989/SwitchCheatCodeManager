using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwitchCheatCodeManager.Constant;
using SwitchCheatCodeManager.Model;
using SwitchCheatCodeManager.FormEntity;

namespace SwitchCheatCodeManager.Helper
{
    public static class NativeMethods
    {
        // http://referencesource.microsoft.com/#System.Windows.Forms/winforms/Managed/System/WinForms/NativeMethods.cs,e75041b5218ff60b

        public const int EM_GETRECT = 0xB2;
        public const int EM_SETRECT = 0xB3;
        public const int WM_USER = 0x0400;

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
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

        public static void SetInnerMargins(this RichTextBox richTextBox, int left, int top, int right, int bottom)
        {
            var rect = richTextBox.GetFormattingRect();
            var newRect = new Rectangle(left, top, rect.Width - left - right, rect.Height - top - bottom);
            richTextBox.SetFormattingRect(newRect);
        }

        /// <summary>
        /// Function to get the Rectangle stats.
        /// Left, Top, Width, Height
        /// </summary>
        /// <param name="richTextBox"></param>
        /// <returns></returns>
        private static Rectangle GetFormattingRect(this RichTextBox richTextBox)
        {
            var rect = new Rectangle();
            TextAreaEx.SendMessage(richTextBox.Handle, EM_GETRECT, (IntPtr)0, ref rect);
            return rect;
        }
        
        /// <summary>
        /// Set the Rectangle (display box) with in the rich textbox.
        /// </summary>
        /// <param name="richTextBox"></param>
        /// <param name="rect"></param>
        private static void SetFormattingRect(this RichTextBox richTextBox, Rectangle rect)
        {
            var rc = new RECT(rect);
            TextAreaEx.SendMessageRefRect(richTextBox.Handle, EM_SETRECT, 0, ref rc);
        }

        public static void SetSelectionBackColor(this RichTextBox richTextBox, Color value)
        {
            if (richTextBox.IsHandleCreated && value == Color.Empty)
            {
                var cf2 = new CHARFORMAT2();

                cf2.dwEffects = RichTextBoxConstants.CFE_AUTOBACKCOLOR;
                cf2.dwMask = RichTextBoxConstants.CFM_BACKCOLOR;
                cf2.crBackColor = ColorTranslator.ToWin32(value);

                TextAreaEx.SendMessage(new HandleRef(richTextBox, richTextBox.Handle), 
                    RichTextBoxConstants.EM_SETCHARFORMAT, RichTextBoxConstants.SCF_SELECTION, cf2);
            }
            else
            {
                richTextBox.SelectionBackColor = value;
            }
        }

        public static float GetLineSpacing(this RichTextBox richTextBox)
        {
            PARAFORMAT2 fmt = new PARAFORMAT2();
            fmt.cbSize = Marshal.SizeOf(fmt);
            fmt.dwMask = RichTextBoxConstants.PFM_LINESPACING;

            IntPtr lParam = Marshal.AllocCoTaskMem(fmt.cbSize);
            Marshal.StructureToPtr(fmt, lParam, true);
            TextAreaEx.SendMessage(richTextBox.Handle, RichTextBoxConstants.EM_GETPARAFORMAT, IntPtr.Zero, lParam);
            Marshal.FreeCoTaskMem(lParam);
            return fmt.dyLineSpacing / 100f;
        }

        public static void SetLineSpacing(this RichTextBox richTextBox, float lineSpacing)
        {
            PARAFORMAT2 fmt = new PARAFORMAT2();
            fmt.cbSize = Marshal.SizeOf(fmt);
            fmt.bLineSpacingRule = 4;
            fmt.dyLineSpacing = (int)(lineSpacing * 100);
            fmt.dwMask = RichTextBoxConstants.PFM_LINESPACING;

            IntPtr lParam = Marshal.AllocCoTaskMem(fmt.cbSize);
            Marshal.StructureToPtr(fmt, lParam, true);
            TextAreaEx.SendMessage(
                richTextBox.Handle, 
                RichTextBoxConstants.EM_SETPARAFORMAT, 
                IntPtr.Zero, 
                lParam);
            Marshal.FreeCoTaskMem(lParam);
        }

        private static CHARFORMAT2 GetCharFormat(this RichTextBox richTextBox, bool fSelection)
        {
            // Either CHARFORMAT or CHARFORMAT2 can be used as long as the cbSize is set correctly.
            // https://msdn.microsoft.com/en-us/library/windows/desktop/bb774230.aspx

            // Force handle creation
            if (!richTextBox.IsHandleCreated)
            {
                var handle = richTextBox.Handle;
            }

            var cf2 = new CHARFORMAT2();
            TextAreaEx.SendMessage(
                new HandleRef(richTextBox, richTextBox.Handle), 
                RichTextBoxConstants.EM_GETCHARFORMAT, 
                fSelection ? RichTextBoxConstants.SCF_SELECTION : RichTextBoxConstants.SCF_DEFAULT, 
                cf2);
            return cf2;
        }


        public static void SetCharacterSet(this RichTextBox richTextBox)
        {
            var cf2 = GetCharFormat(richTextBox, true);
            var lcid = new LCID();
            var charSet = new CharacterSet();

            cf2.dwMask = RichTextBoxConstants.CFM_FACE
                | RichTextBoxConstants.CFM_SIZE
                | RichTextBoxConstants.CFM_CHARSET
                | RichTextBoxConstants.CFM_LCID;
            cf2.yHeight = Constants.DEFAULT_TEXTBOX_CHARACTER_HEIGHT;  //30 x font size;

            // Japanese
            cf2.lcid = lcid.Japanese.Hex;
            cf2.bCharSet = charSet.SHIFTJIS_CHARSET;
            cf2.szFaceName = Constants.Font_MSGothic;
            TextAreaEx.SendMessage(new HandleRef(richTextBox, richTextBox.Handle),
                RichTextBoxConstants.EM_SETCHARFORMAT,  //0x444
                RichTextBoxConstants.SCF_WORD, cf2);

            // T.Chinese
            cf2.lcid = lcid.ChineseSimplified.Hex;
            cf2.bCharSet = charSet.CHINESEBIG5_CHARSET;
            cf2.szFaceName = Constants.Font_MingLiu;
            TextAreaEx.SendMessage(new HandleRef(richTextBox, richTextBox.Handle),
                RichTextBoxConstants.EM_SETCHARFORMAT,  //0x444
                RichTextBoxConstants.SCF_WORD, cf2);

            // S.Chinese
            cf2.lcid = lcid.ChineseSimplified.Hex;
            cf2.bCharSet = charSet.GB2312_CHARSET;
            cf2.szFaceName = Constants.Font_MSYaHei;
            TextAreaEx.SendMessage(new HandleRef(richTextBox, richTextBox.Handle),
                RichTextBoxConstants.EM_SETCHARFORMAT,  //0x444
                RichTextBoxConstants.SCF_WORD, cf2);

            // English / Default
            cf2.lcid = lcid.English.Hex;
            cf2.bCharSet = charSet.DEFAULT_CHARSET;
            cf2.szFaceName = Constants.Font_Consolas;
            TextAreaEx.SendMessage(new HandleRef(richTextBox, richTextBox.Handle),
                RichTextBoxConstants.EM_SETCHARFORMAT,  //0x444
                RichTextBoxConstants.SCF_DEFAULT, cf2);
        }

    }
}
