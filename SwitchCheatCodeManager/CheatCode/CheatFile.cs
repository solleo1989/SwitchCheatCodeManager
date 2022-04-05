using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SwitchCheatCodeManager.CheatCode
{
    public class CheatFile
    {
        private string Title;
        public List<MasterBlock> Masters;
        public List<CheatBlock> Cheats;
        public List<SubCheat> SubCheats;
        public bool Legit;
        public bool HasMasterCodes;
        public bool HasSubCheats;
        public string ErrorLine;
        public string FilePath;

        public CheatFile()
        {
            Cheats = new List<CheatBlock>();
            Legit = false;
            HasMasterCodes = false;
            HasSubCheats = false;
            FilePath = null;
        }

        public CheatFile(String code, string filePath = null)
        {
            code = this.ProcessMasterCode(code);
            this.FilePath = filePath;
            if (code.Contains("[--SectionStart:"))
            {
                String[] subCheats = code.Split("[--SectionStart:");
                SubCheats = new List<SubCheat>();
                Cheats = new List<CheatBlock>();
                Legit = true;
                HasSubCheats = true;
                int index = 0;
                foreach (var subCheat in subCheats)
                {
                    if (!subCheat.Trim().Equals(string.Empty)) {
                        if (index == 0 && !subCheat.Contains("[--SectionEnd:") && subCheat.Contains("["))
                        {
                            var separateCheats = subCheat.Trim().Split("[");
                            foreach (var codePiece in separateCheats)
                            {
                                if (!codePiece.Trim().Equals(string.Empty))
                                {
                                    var cc = new CheatBlock(codePiece);
                                    if (index == 1 && !cc.HasCheatLine)
                                    {
                                        Title = cc.CodeTitle;
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
                        else if (subCheat.Contains("[--SectionEnd:"))
                        {
                            var pivot = subCheat.IndexOf("--SectionEnd");
                            var endStr = subCheat.Substring(pivot);
                            var contents = subCheat;
                            if (endStr.Contains("[")) // Still has cheats
                            {
                                var nextH = endStr.IndexOf("[");
                                var firstPart = subCheat.Substring(0, pivot + nextH);
                                var secondPart = subCheat.Substring(pivot + nextH);

                                var separateCheats = secondPart.Trim().Split("[");
                                foreach (var codePiece in separateCheats)
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
                                    index++;
                                }

                                contents = firstPart;
                             }

                            var sc = new SubCheat(contents);
                            SubCheats.Add(sc);
                            Legit &= sc.Legit;
                            if (!sc.Legit)
                            {
                                ErrorLine += sc.ErrorLine;
                            }
                        }
                        else
                        {
                            Legit = false;
                            ErrorLine += "Invalid Section Format!";
                        }
                    }
                    index++;
                }
                if (this.Cheats.Count > 0)
                {
                    SubCheats.Add(new SubCheat(this.Cheats));
                }                
            }
            else if (code.Contains("["))
            {
                String[] codePieces = code.Split("[");
                Cheats = new List<CheatBlock>();
                Legit = true;
                int index = 0;
                foreach (var codePiece in codePieces)
                {
                    if (!codePiece.Trim().Equals(string.Empty))
                    {
                        var cc = new CheatBlock(codePiece);
                        if (index == 1 && !cc.HasCheatLine)
                        {
                            Title = cc.CodeTitle;
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
            else
            {
                Legit = false;
                ErrorLine += code;
            }
        }

        public String ProcessMasterCode(String code)
        {
            this.HasMasterCodes = false;
            if (code.Contains("{"))
            {
                var pivot = code.IndexOf("{");
                string[] firstPart = { code.Substring(0, pivot), code.Substring(pivot) };
                if (firstPart[1].Contains("}") 
                    && firstPart[1].Contains("["))
                {
                    pivot = firstPart[1].IndexOf("[");
                    var secondPart = firstPart[1].Substring(0, pivot);
                    if (!secondPart.Contains("]") && secondPart.Contains("}"))
                    {
                        var thirdPart = firstPart[1].Substring(pivot + 1);
                        this.Masters = new List<MasterBlock>();
                        Masters.Add(new MasterBlock(secondPart));
                        this.HasMasterCodes = true;
                        return firstPart[0] + "[" + thirdPart;
                    }
                    
                }
            }
            return code;
        }

        public String Output()
        {
            String cheatFile = $"[{Title}]{Environment.NewLine}";
            if (HasMasterCodes)
            { 
                cheatFile += String.Join<string>(Environment.NewLine, this.Masters.Select(sc => sc.Output()));
            }

            if (HasSubCheats)
            {
                cheatFile += String.Join<string>(Environment.NewLine, this.SubCheats.Select(sc => sc.Output()));
            }
            else 
            {
                cheatFile += Environment.NewLine + 
                    String.Join<string>(Environment.NewLine, this.Cheats.Select(cb => cb.Output()));
            }
            
            return cheatFile;
        }        
    }
}
