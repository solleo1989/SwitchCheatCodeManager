using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCheatCodeManager.Model
{
    public class LanguageModel
    {
        public int Hex { get; set; }
        public string Name { get; set; }
        public string Decimal { get; set; }

        public LanguageModel(string name, int hex)
        {
            this.Name = name;
            this.Hex = hex;
            //this.Decimal = GetDecimal(hex);
        }

        public int GetDecimalFromHex(string hex) => Convert.ToInt32(hex, 16);
        public string GetHexInString() => "0x" + String.Format("{0:0000}", this.Hex);
        public string GetDecimalInString() => string.Format("", this.Decimal);
    }
}
