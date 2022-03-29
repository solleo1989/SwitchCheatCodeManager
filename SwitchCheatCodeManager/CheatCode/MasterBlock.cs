using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwitchCheatCodeManager.CheatCode
{
    public  class MasterBlock
    {
        public String CodeTitle;
        private List<CodeLine> Codes;
        public bool Legit;
        public int NumberOfLines => Codes.Count;
        public string ErrorLine;
        public bool HasCheatLine;
        public bool HasLineWithAllZeros;
        public MasterBlock(string code) 
        {
            if (code.Contains("}"))
            {
                var parts = code.Split("}");
                if (parts.Length == 2)
                {
                    this.CodeTitle = (parts[0].Length > 0 ? parts[0].Substring(1) : parts[0]).Trim();
                    var codeLines = parts[1].Trim().Split("\n");
                    if (codeLines.Length > 0)
                    {
                        this.Codes = new List<CodeLine>();
                        this.Legit = true;
                        if (codeLines.Length == 1 && String.IsNullOrEmpty(codeLines[0].Trim()))
                        {
                            this.Codes.Add(new CodeLine(codeLines[0]));
                            HasCheatLine = false;
                        }
                        else
                        {
                            HasCheatLine = true;
                            foreach (var codeLine in codeLines)
                            {
                                var cl = new CodeLine(codeLine);
                                if (!String.IsNullOrEmpty(codeLine.Trim()))
                                {
                                    this.Codes.Add(cl);
                                }

                                Legit &= cl.Legit;
                                HasLineWithAllZeros &= cl.LineWithAllZeroes;
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
        }

        public String Output()
        {
            //var title = UpdateTitle();
            return OutputMasterBlock(
                string.IsNullOrEmpty(this.CodeTitle) ? "Mastercode" : this.CodeTitle,
                String.Join(Environment.NewLine, Codes.Select(cl => cl.Output())));
        }

        /// <summary>
        /// Return a Master block by given title and cheats list
        /// </summary>
        /// <param name="title"></param>
        /// <param name="cheats"></param>
        /// <returns></returns>
        public static String OutputMasterBlock(string title, string cheats = "")
        {
            return
                Environment.NewLine +
                $"{{{title}}}" +
                Environment.NewLine +
                cheats +
                Environment.NewLine;
        }
    }
}
