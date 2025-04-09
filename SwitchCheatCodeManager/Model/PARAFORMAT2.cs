using System.Runtime.InteropServices;

namespace SwitchCheatCodeManager.Model
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public class PARAFORMAT2
    {
        // Reference:
        // https://docs.microsoft.com/en-us/windows/win32/api/richedit/ns-richedit-paraformat2
        // https://pinvoke.net/default.aspx/Structures/PARAFORMAT2.html

        public int cbSize;
        public int dwMask;
        public short wNumbering;
        public short wReserved;
        public int dxStartIndent;
        public int dxRightIndent;
        public int dxOffset;
        public short wAlignment;
        public short cTabCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public int[] rgxTabs;
        public int dySpaceBefore;
        public int dySpaceAfter;
        public int dyLineSpacing;
        public short sStyle;
        public byte bLineSpacingRule;
        public byte bOutlineLevel;
        public short wShadingWeight;
        public short wShadingStyle;
        public short wNumberingStart;
        public short wNumberingStyle;
        public short wNumberingTab;
        public short wBorderSpace;
        public short wBorderWidth;
        public short wBorders;
    }
}
