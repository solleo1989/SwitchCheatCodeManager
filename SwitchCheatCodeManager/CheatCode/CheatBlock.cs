using System;
using System.Collections.Generic;
using System.Linq;

namespace SwitchCheatCodeManager.CheatCode
{
    public class CheatBlock
    {
        private String CodeTitle;
        private List<CodeLine> Codes;
        public bool Legit;
        public int NumberOfLines => Codes.Count;
        public string ErrorLine;

        public CheatBlock(String code)
        {
            if (code.Contains("]"))
            {
                var parts = code.Split("]");
                if (parts.Length == 2)
                {
                    this.CodeTitle = parts[0].Trim();
                    var codeLines = parts[1].Trim().Split("\n");
                    if (codeLines.Length > 0)
                    {
                        this.Codes = new List<CodeLine>();
                        this.Legit = true;
                        if (codeLines.Count() == 1 && String.IsNullOrEmpty(codeLines[0].Trim()))
                        {
                            this.Codes.Add(new CodeLine(codeLines[0]));
                        }
                        else
                        {
                            foreach (var codeLine in codeLines)
                            {
                                var cl = new CodeLine(codeLine);
                                if (!String.IsNullOrEmpty(codeLine.Trim()))
                                {
                                    this.Codes.Add(cl);
                                }

                                Legit &= cl.Legit;
                                if (!cl.Legit)
                                {
                                    this.ErrorLine += cl.ErrorLine;
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
                else
                {
                    Legit = false;
                    ErrorLine += code;
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
            var title = UpdateTitle();
            String cheats = $"[{title}]\r\n";

            foreach (var cl in Codes)
            {
                cheats += cl.Output();
            }

            return cheats;
        }

        private string UpdateTitle()
        {
            // 1. Update On/Off switch
            var title = this.CodeTitle;
            if (title.ToUpper().Contains("(ON)") || title.ToUpper().Contains("(OFF)"))
            {
                title = title
                    .Replace("(on)", "(ON)")
                    .Replace("(On)", "(ON)");

                title = title
                    .Replace("(off)", "(OFF)")
                    .Replace("(Off)", "(OFF)")
                    .Replace("(OFf)", "(OFF)");
            }

            // 2. Rename Pokemon related stuffs
            if (title.Contains("é"))
            {
                title = title
                    .Replace("é", "e");
            }

            return title;
        }
    }
}
