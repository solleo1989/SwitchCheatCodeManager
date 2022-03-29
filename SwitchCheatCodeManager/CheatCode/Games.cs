using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SwitchCheatCodeManager.CheatCode
{
    public class Games
    {
        public int Number;
        public string GameName;
        public string BuildId;
        public string UrlAddress;
        public IList<string> VersionId;

        public Games(string number, string gamename, string buiildId, string versions)
        { 
            this.Number = int.Parse(number);
            this.GameName = gamename;

            this.BuildId = String.Empty;
            this.UrlAddress = String.Empty;
            SplitBuildIdAndUrl(buiildId);
            this.VersionId = versions.Trim().Split(", ");
        }

        private void SplitBuildIdAndUrl(string build)
        {
            var regex = new Regex(@"\[(?<bid>[0-9a-zA-Z]+)\]\((?<url>\S+)\)");
            var result = regex.Match(build);
            
            if (result.Success)
            {
                this.BuildId = result.Groups["bid"].Value;
                this.UrlAddress = result.Groups["url"].Value;
            }
        }
    }
}
