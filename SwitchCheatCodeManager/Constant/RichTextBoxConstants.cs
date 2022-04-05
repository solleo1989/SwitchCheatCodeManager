using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwitchCheatCodeManager.Helper;

namespace SwitchCheatCodeManager.Constant
{
    public static class RichTextBoxConstants
    {
        // Reference:
        // http://referencesource.microsoft.com/#System.Windows.Forms/winforms/Managed/System/WinForms/RichTextBoxConstants.cs,31b52ac41e96a888
        /* EM_SETCHARFORMAT wparam masks */
        internal const int EM_GETCHARFORMAT = (NativeMethods.WM_USER + 58);
        internal const int EM_SETCHARFORMAT = (NativeMethods.WM_USER + 68);

        // Reference
        // https://referencesource.microsoft.com/#System.Windows.Forms/winforms/Managed/System/WinForms/RichTextBoxConstants.cs,355d591685547539

        internal const int EM_GETPARAFORMAT = (NativeMethods.WM_USER + 61);
        internal const int EM_SETPARAFORMAT = (NativeMethods.WM_USER + 71);
        /// <summary>
        /// Applies the formatting to the current selection. If the selection is empty, the character formatting is applied to 
        /// the insertion point, and the new character format is in effect only until the insertion point changes.
        /// </summary>
        /* EM_SETCHARFORMAT wparam masks */
        internal const int SCF_SELECTION = 0x0001;
        internal const int SCF_WORD = 0x0002;
        internal const int SCF_DEFAULT = 0x0000;    // set the default charformat or paraformat
        internal const int SCF_ALL = 0x0004;        // not valid with SCF_SELECTION or SCF_WORD
        internal const int SCF_USEUIRULES = 0x0008; // modifier for SCF_SELECTION; says that

        internal const int CFM_BACKCOLOR = 0x04000000;        
        internal const int CFM_FACE = 0x20000000;
        internal const int CFM_SIZE = unchecked((int)0x80000000);
        internal const int CFM_CHARSET = 0x08000000;
        internal const int CFM_LCID = 0x02000000;

        /* PARAFORMAT 2.0 masks and effects */
        internal const int PFM_LINESPACING = 0x00000100;

        /* NOTE: CFE_AUTOCOLOR and CFE_AUTOBACKCOLOR correspond to CFM_COLOR and
           CFM_BACKCOLOR, respectively, which control them */
        internal const int CFE_AUTOBACKCOLOR = CFM_BACKCOLOR;
    }
}
