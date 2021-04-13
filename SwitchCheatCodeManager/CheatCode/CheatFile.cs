using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SwitchCheatCodeManager.CheatCode
{
    public class CheatFile
    {
        private List<CheatBlock> Cheats;
        public bool Legit;
        public string ErrorLine;

        public CheatFile()
        {
            Cheats = new List<CheatBlock>();
            Legit = false;
        }

        public CheatFile(String code)
        {
            if (code.Contains("["))
            {
                String[] codePieces = code.Split("[");
                Cheats = new List<CheatBlock>();
                Legit = true;
                foreach (var codePiece in codePieces)
                {
                    if (!codePiece.Trim().Equals(string.Empty))
                    {
                        var cc = new CheatBlock(codePiece);
                        Cheats.Add(cc);
                        Legit &= cc.Legit;
                        if (!cc.Legit)
                        {
                            ErrorLine += cc.ErrorLine;
                        }
                    }                    
                }
            }
            else
            {
                Legit = false;
                ErrorLine += code;
            }
        }

        public String Output()
        {
            String cheatFile = String.Join<string>("\r\n", this.Cheats.Select(cb => cb.Output()));
            return cheatFile;
        }
        
    }
}
