using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwitchCheatCodeManager.CheatCode
{
    public class SubCheat
    {
        public String SubTile;
        public List<CheatBlock> Cheats;
        public bool Legit;
        public string ErrorLine;

        public SubCheat(String code)
        {
            Legit = true;
            if (code.Contains("--]") && code.Contains("--]")) {
                //code.Split
                var codes = code.Split("[--SectionEnd:");
                if (codes.Length == 2)
                {
                    var sectionEnd = codes[1].Split("--]");
                    var cc = new CheatBlock(codes[1]);
                    if (!String.IsNullOrEmpty(cc.CodeTitle) && cc.HasLineWithAllZeros)
                    {
                        var endTitle = cc.CodeTitle;

                        Cheats = new List<CheatBlock>();
                        var cheats = codes[0].Trim();
                        // Start to match cheats
                        String[] codePieces = cheats.Split("[");
                        Legit = true;
                        int index = 0;
                        foreach (var codePiece in codePieces)
                        {
                            if (!String.IsNullOrEmpty(codePiece.Trim()))
                            {
                                cc = new CheatBlock(codePiece);
                                if (index == 0 && cc.HasLineWithAllZeros)
                                {
                                    var startTitle = cc.CodeTitle;
                                    if (startTitle == endTitle)
                                    {
                                        SubTile = startTitle.Substring(0, startTitle.Length - 2);
                                    }
                                    else
                                    {
                                        Legit = false;
                                        ErrorLine += $"SectionStart [{startTitle}] And SectionEnd [{endTitle}] Not Match\n";

                                    }
                                }
                                else
                                {
                                    Cheats.Add(cc);
                                    Legit &= cc.Legit;
                                    if (!cc.Legit)
                                    {
                                        ErrorLine += cc.ErrorLine;
                                    }
                                }

                            }
                            index++;
                        }
                    }
                }
                else
                {
                    Legit = false;
                    ErrorLine += "Redudant SectionEnd\n";
                }
            }
            else
            {
                Legit = false;
                ErrorLine += "Missing EndWidth\n";
            }
        }

        public SubCheat(List<CheatBlock> cheats)
        {
            SubTile = "Others";
            this.Cheats = cheats;
        }

        public String Output() =>
            OutputSubSectionBlock(this.SubTile, String.Join<string>(Environment.NewLine, this.Cheats.Select(cl => cl.Output())));

        public static String OutputSubSectionBlock(string subTitle, string cheats = null)
        {
            return Environment.NewLine +
                $"[--SectionStart:{subTitle}--]" + Environment.NewLine +
                "00000000 00000000 00000000" + Environment.NewLine +
                (string.IsNullOrEmpty(cheats)
                    ? Environment.NewLine
                    : Environment.NewLine + cheats + Environment.NewLine) +
                $"[--SectionEnd:{subTitle}--]" + Environment.NewLine +
                "00000000 00000000 00000000" + Environment.NewLine;
        }
    }
}
