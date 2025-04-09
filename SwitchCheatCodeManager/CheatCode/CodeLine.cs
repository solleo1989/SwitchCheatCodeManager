using System;
using System.Text.RegularExpressions;

namespace SwitchCheatCodeManager.CheatCode
{
    public class CodeLine
    {
        private String Line;
        public bool Legit;
        public int NumberOfPieces;
        public bool LineWithAllZeroes;
        public string ErrorLine;

        public CodeLine() 
        {
            Line = String.Empty;
            Legit = false;
            NumberOfPieces = 0;
        }

        public CodeLine(String code)
        {
            LineWithAllZeroes = false;
            if (code.Trim() == string.Empty)
            {
                this.Line = string.Empty;
                this.Legit = true;
                NumberOfPieces = 0;
            }
            else
            {
                this.Line = code.Trim();
                if (IsLegitZeroLine())
                {
                    Legit = true;
                    NumberOfPieces = 3;
                    LineWithAllZeroes = true;
                }
                else if (IsLegitOnePiece())
                {
                    Legit = true;
                    NumberOfPieces = 1;
                }
                else if (IsLegitTwoPieces())
                {
                    Legit = true;
                    NumberOfPieces = 2;
                }
                else if (IsLegitThreePieces())
                {
                    Legit = true;
                    NumberOfPieces = 3;
                }
                else if (IsLegitFourPieces())
                {
                    Legit = true;
                    NumberOfPieces = 4;
                }
                else
                {
                    Legit = false;
                    NumberOfPieces = 0;
                    ErrorLine = code;
                }
            }
        }

        public bool IsLegitZeroLine()
        {
            Regex reg = new Regex(@"^(([0]{8})\s([0]{8})\s([0]{8}))$");
            return reg.IsMatch(this.Line);
        }

        public bool IsLegitOnePiece()
        {
            Regex reg = new Regex(@"^(([0-9]|[a-f]|[A-F]){8})$");
            return reg.IsMatch(this.Line);
        }

        public bool IsLegitTwoPieces()
        {
            Regex reg = new Regex(@"^(([0-9]|[a-f]|[A-F]){8}\s([0-9]|[a-f]|[A-F]){8})$");
            return reg.IsMatch(this.Line);
        }

        public bool IsLegitThreePieces()
        {
            Regex reg = new Regex(@"^(([0-9]|[a-f]|[A-F]){8}\s([0-9]|[a-f]|[A-F]){8}\s([0-9]|[a-f]|[A-F]){8})$");
            return reg.IsMatch(this.Line);
        }

        public bool IsLegitFourPieces()
        {
            Regex reg = new Regex(@"^(([0-9]|[a-f]|[A-F]){8}\s([0-9]|[a-f]|[A-F]){8}\s([0-9]|[a-f]|[A-F]){8}\s([0-9]|[a-f]|[A-F]){8})$");
            return reg.IsMatch(this.Line);
        }

        public String Output()
        {
            return String.IsNullOrEmpty(this.Line) ? String.Empty : this.Line.Trim().ToUpper();
        }

    }
}
