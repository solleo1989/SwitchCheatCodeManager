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

        public LanguageModel(string name, int hex)
        {
            this.Name = name;
            this.Hex = hex;
        }
    }
}
