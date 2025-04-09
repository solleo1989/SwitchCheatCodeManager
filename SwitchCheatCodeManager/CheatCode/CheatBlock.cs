using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;

using SCConstant = SwitchCheatCodeManager.Constant.Constants;

namespace SwitchCheatCodeManager.CheatCode
{
    public class CheatBlock
    {
        public String CodeTitle;
        private List<CommentLine> Comments;
        private List<CodeLine> Codes;

        public bool Enabled;
        public bool Legit;
        public int NumberOfLines => Codes.Count;
        public string ErrorLine;
        public bool HasCheatLine;
        public bool HasLineWithAllZeros;
        public bool HasComments => Comments?.Count > 0;

        private String[] ReplaceStrings =
        {
            "MAX",
            "MIN",
            "ALL",
        };

        public CheatBlock(String code)
        {
            HasLineWithAllZeros = true;
            if (code.Contains("]"))
            {
                var parts = code.Split("]");
                if (parts.Length == 2)
                {
                    var codeTitles = SplitTitle(parts[0].Trim());
                    this.CodeTitle = codeTitles.First();
                    this.Enabled = !string.IsNullOrEmpty(codeTitles.Last());
                    var codeLines = parts[1].Trim().Split("\n");
                    if (codeLines.Length > 0)
                    {
                        this.Codes = new List<CodeLine>();
                        this.Comments = new List<CommentLine>();
                        this.Legit = true;
                        if (codeLines.Count() == 1 && String.IsNullOrEmpty(codeLines[0].Trim()))
                        {
                            this.Codes.Add(new CodeLine(codeLines[0]));
                            HasCheatLine = false;
                        }
                        else
                        {
                            HasCheatLine = true;
                            foreach (var codeLine in codeLines)
                            {
                                bool legit;
                                if (codeLine.StartsWith("{") && codeLine.Trim().EndsWith("}"))
                                {
                                    var co = new CommentLine(codeLine.Trim());
                                    this.Comments.Add(co);
                                    legit = co.Legit;
                                }
                                else 
                                {
                                    var cl = new CodeLine(codeLine);
                                    if (!String.IsNullOrEmpty(codeLine.Trim()))
                                    {
                                        this.Codes.Add(cl);
                                    }
                                    legit = cl.Legit;
                                    HasLineWithAllZeros &= cl.LineWithAllZeroes;
                                    if (!cl.Legit)
                                    {
                                        this.ErrorLine += cl.ErrorLine;
                                    }
                                }
                                
                                Legit &= legit;
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
            else if (code.Contains(""))
            { 
            }
            else
            {
                Legit = false;
                ErrorLine += code;
            }
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

            foreach (var repalceStr in this.ReplaceStrings)
            {
                if (title.ToUpper().StartsWith($"{repalceStr}")
                    || title.ToUpper().Contains($" {repalceStr} ")
                    || title.ToUpper().EndsWith($" {repalceStr}"))
                {
                    title = title
                        .Replace($"{repalceStr.ToLower()}", $"{repalceStr.ToUpper()}")
                        .Replace($"{repalceStr.Substring(0, 1).ToUpper() + repalceStr.Substring(1).ToLower()}", $"{repalceStr.ToUpper()}");
                }
            }

            // 2. Rename Pokemon related stuffs
            if (title.Contains("é"))
            {
                title = title
                    .Replace("é", "e");
            }

            return title;
        }

        public String Output()
        {
            var title = UpdateTitle();
            var enabled = this.Enabled ? SCConstant.DEFAULT_CHEAT_BLOCK_TITLE_ENABLE_SUFFIX : "";
            String cheats = $"[{title}{enabled}]{Environment.NewLine}";
            if (Comments?.Count > 0)
            {
                cheats += string.Join(Environment.NewLine, Comments.Select(co => co.Output())) + Environment.NewLine;
            }
            
            cheats += string.Join(Environment.NewLine, Codes.Select(cl => cl.Output()));
            cheats += Environment.NewLine;
            return cheats;
        }

        private string[] SplitTitle(string title)
        {
            title = title.Trim();
            if (title.EndsWith(SCConstant.DEFAULT_CHEAT_BLOCK_TITLE_ENABLE_SUFFIX))
            {
                title = title.Substring(0, title.Length - SCConstant.DEFAULT_CHEAT_BLOCK_TITLE_ENABLE_SUFFIX.Length);
                return new string[] { title, SCConstant.DEFAULT_CHEAT_BLOCK_TITLE_ENABLE_SUFFIX };
            }

            return new string[] { title, string.Empty };
        }
    }
}
