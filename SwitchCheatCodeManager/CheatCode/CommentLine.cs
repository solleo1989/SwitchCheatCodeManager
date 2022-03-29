using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCheatCodeManager.CheatCode
{
    public class CommentLine
    {
        private String Line;
        public bool Legit;
        public CommentLine(string comment)
        {
            comment = comment.Substring(1, comment.Length - 2);
            this.Line = comment;
            this.Legit = true;
        }
        public String Output()
        {
            return String.IsNullOrEmpty(this.Line) ? String.Empty : $"{{{this.Line.Trim()}}}";
        }
    }
}
