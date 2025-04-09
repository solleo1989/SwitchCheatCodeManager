using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCheatCodeManager.Constant
{
    /// <summary>
    /// Class defined each character set based.
    /// Reference
    /// https://docwiki.embarcadero.com/Libraries/Alexandria/en/Vcl.Graphics.TFontCharset
    /// </summary>
    internal class CharacterSet
    {
        /// <summary>
        /// ANSI characters.
        /// </summary>
        public byte ANSI_CHARSET = 0;

        /// <summary>
        /// Font is chosen based solely on Name and Size. If the described font is not
        /// available on the system, Windows will substitute another font. 
        /// </summary>
        public byte DEFAULT_CHARSET = 1;

        /// <summary>
        /// Standard symbol set.
        /// </summary>
        public byte SYMBOL_CHARSET = 2;

        /// <summary>
        /// Macintosh characters. Not available on NT 3.51.
        /// </summary>
        public byte MAC_CHARSET = 77;

        /// <summary>
        /// Japanese shift-JIS characters.
        /// </summary>
        public byte SHIFTJIS_CHARSET = 128;

        /// <summary>
        /// Korean characters (Wansung).
        /// </summary>
        public byte HANGEUL_CHARSET = 129;
        public byte HANGUL_CHARSET = 129;

        /// <summary>
        /// Korean characters (Johab). Not available on NT 3.51
        /// </summary>
        public byte JOHAB_CHARSET = 130;

        /// <summary>
        /// Simplified Chinese characters(mainland china).
        /// </summary>
        public byte GB2312_CHARSET = 134;

        /// <summary>
        /// Traditional Chinese characters (Taiwanese).
        /// </summary>
        public byte CHINESEBIG5_CHARSET = 136;

        /// <summary>
        /// Greek characters.Not available on NT 3.51.
        /// </summary>
        public byte GREEK_CHARSET = 161;

        /// <summary>
        /// Turkish characters. Not available on NT 3.51
        /// </summary>
        public byte TURKISH_CHARSET = 162;

        /// <summary>
        /// Vietnamese characters. Not available on NT 3.51.
        /// </summary>
        public byte VIETNAMESE_CHARSET = 163;

        /// <summary>
        /// Hebrew characters.Not available on NT 3.51
        /// </summary>
        public byte HEBREW_CHARSET = 177;

        /// <summary>
        /// Arabic characters. Not available on NT 3.51
        /// </summary>
        public byte ARABIC_CHARSET = 178;

        /// <summary>
        /// Baltic characters. Not available on NT 3.51.
        /// </summary>
        public byte BALTIC_CHARSET = 186;

        /// <summary>
        /// Cyrillic characters. Not available on NT 3.51.
        /// </summary>
        public byte RUSSIAN_CHARSET = 204;

        /// <summary>
        /// Arabic characters. Not available on NT 3.51
        /// </summary>
        public byte THAI_CHARSET = 222;

        /// <summary>
        /// Includes diacritical marks for eastern european countries. Not available on NT 3.51.
        /// </summary>
        public byte EASTEUROPE_CHARSET = 238;

        /// <summary>
        /// Depends on the codepage of the operating system.
        /// </summary>
        public byte OEM_CHARSET = 255;

        
    }
}
