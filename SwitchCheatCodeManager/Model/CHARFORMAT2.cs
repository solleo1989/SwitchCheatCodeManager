using System.Runtime.InteropServices;

namespace SwitchCheatCodeManager.Model
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public class CHARFORMAT2
    {
        // Reference:
        // http://referencesource.microsoft.com/#System.Windows.Forms/winforms/Managed/System/WinForms/NativeMethods.cs,acde044a28b57a48
        // http://pinvoke.net/default.aspx/Structures/CHARFORMAT2.html

        public int cbSize = Marshal.SizeOf(typeof(CHARFORMAT2));
        public int dwMask;
        public int dwEffects;
        public int yHeight;
        public int yOffset;
        public int crTextColor;
        public byte bCharSet;
        public byte bPitchAndFamily;
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x40)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]        
        public string szFaceName;
        public short wWeight;
        public short sSpacing;
        public int crBackColor;
        public int lcid;
        public int dwReserved;
        public short sStyle;
        public short wKerning;
        public byte bUnderlineType;
        public byte bAnimation;
        public byte bRevAuthor;
        public byte bReserved1;
    }
}
