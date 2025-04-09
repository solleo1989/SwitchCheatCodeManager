using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;

namespace SwitchCheatCodeManager.Builder
{
    public class ColorBuilder
    {


        public ColorBuilder()
        { 
        }

        public Color GetColorFromHex(string color) 
        {
            if (!ValidateHexFormat(color))
            {
                return Color.Empty;
            }

            var hex = color.Replace("#", string.Empty);
            var h = NumberStyles.HexNumber;

            var r = int.Parse(hex.Substring(0, 2), h);
            var g = int.Parse(hex.Substring(2, 2), h);
            var b = int.Parse(hex.Substring(4, 2), h);
            var a = 255;

            if (hex.Length == 8)
            {
                a = int.Parse(hex.Substring(6, 2), h);
            }


            return Color.FromArgb(a, r, g, b);
        }

        public string GetHexStrFromColor(Color color)
            => $"#{color.R:X2}{color.G:X2}{color.B:X2}" + (color.A < 255 ? $"{color.A:X2}" : "");

        public string GetRgbFromColor(Color color)
            => color.A < 255 ? $"ARGB({color.A}, {color.R}, {color.G}, {color.B})" 
            : $"RGB({color.R}, {color.G}, {color.B})";

        private bool ValidateHexFormat(string hex)
        {
            Regex reg = new Regex(@"^(#[0-9a-fA-F]{6})|(#[0-9a-fA-F]{8})$");
            return reg.IsMatch(hex);
        }
    }
}
