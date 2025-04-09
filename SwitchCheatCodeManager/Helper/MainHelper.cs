using SwitchCheatCodeManager.CheatCode;
using SwitchCheatCodeManager.Constant;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using SwitchCheatCodeManager.Mode;
using DirectoryMode = SwitchCheatCodeManager.Mode.EnumMode.DirectoryMode;
using Language = SwitchCheatCodeManager.Mode.EnumMode.Language;

namespace SwitchCheatCodeManager.Helper
{
    public class MainHelper
    {
        #region Getter        
        public String GetPath(string path) => path.EndsWith("\\") ? path : path + "\\";
        public String GetDirectoryPath(string path)
        {
            var cheatPath = GetPath(path);
            return cheatPath.EndsWith("\\cheats\\") ? cheatPath.Substring(0, cheatPath.Length - 8) : cheatPath;
        }
        public String GetCheatsPath(String path)
        {
            var cheatPath = GetPath(path);
            return cheatPath.EndsWith("\\cheats\\") ? cheatPath : (cheatPath + "cheats\\");
        }
        public string GetTxtFileBuildId(string filename) => filename.Length >= 4 && filename.EndsWith(Constants.TXT_FILE_SUFFIX)
            ? filename.Substring(0, filename.Length - 4) : filename;

        public string GetTitleId(string path)
        {
            var rPath = path;
            if (path.EndsWith("\\"))
            {
                rPath = path.Substring(0, path.Length - 1);
            }
            return rPath.Substring(rPath.LastIndexOf("\\") + 1);
        }
        public string GetBuildId(string path)
        {
            var rPath = path;
            if (path.EndsWith("\\"))
            {
                rPath = path.Substring(0, path.Length - 1);
            }

            return rPath.Substring(rPath.LastIndexOf("\\") + 1);
        }

        /// <summary>
        /// Get the info file name within 45 characters.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public string GetInfoFileName(FileInfo file)
        {
            var infoFileName = file != null ? " - " + GetTxtFileBuildId(file.Name) : string.Empty;
            if (infoFileName.Length == 0)
            { 
                return string.Empty;
            }

            return infoFileName.Length >= Constants.DEFAULT_DROPDOWNLIST_ITEM_MAX_LENGTH
                ? infoFileName.Substring(0, Constants.DEFAULT_DROPDOWNLIST_ITEM_MAX_LENGTH - 3) + "..." 
                : infoFileName;
        }
        public string GetTxtFileNameExtension(string filename) => !filename.EndsWith(Constants.TXT_FILE_SUFFIX)
            ? filename + Constants.TXT_FILE_SUFFIX : filename;
        public string GetVersionNameSuffix(string version)
        {
            if (version.Length <= 7)
            { 
                return $" (v{version})";
            }
            return $" (v{version.Substring(0, Constants.DEFAULT_SELECTORBOX_ITEM_MAX_LENGTH) + ".."}";
        }

        public string GetCorrectedFilename(string filename)
        {
            var correctedFilename = string.Empty;
            foreach (char c in filename)
            {
                if (!Constants.FilenameIllegalChars.Contains(c))
                {
                    correctedFilename += c;
                }   
            }
            return correctedFilename;
        }

        public string GetFileSizeInFormat(Int64 bytes)
        {
            string[] suffixes = { "Bytes", "KB", "MB", "GB", "TB", "PB" };

            int counter = 0;
            decimal number = (decimal)bytes;
            while (Math.Round(number / 1024) >= 1)
            {
                number = number / 1024;
                counter++;
            }
            return string.Format("{0:n1}{1}", number, suffixes[counter]);
        }
        #endregion

        /// <summary>
        /// Check the directory mode of the selected path.
        /// </summary>
        /// <param name="selectedPath"></param>
        /// <returns>ListMode/SingleMode/OtherMode</returns>
        public DirectoryMode CheckDirectory(string selectedPath, out string errorMessage)
        {
            errorMessage = Environment.NewLine;
            DirectoryInfo dir = new DirectoryInfo(selectedPath);
            if (dir.Name.Equals(Constants.CHEATS_FOLDER_PATH_SUB_PREFIX))
            {
                return DirectoryMode.SingleMode;
            }

            DirectoryInfo[] titles = dir.GetDirectories();
            bool isListMode = true;
            bool isSingleMode = false;
            foreach (var title in titles)
            {
                /**
                if (title.Name.StartsWith("010")
                    || title.Name.ToUpper().StartsWith("05")
                    || title.Name.ToUpper().StartsWith("100")
                    || title.Name.ToUpper().StartsWith("207")
                    || title.Name.ToUpper().StartsWith("35F")
                    || title.Name.ToUpper().StartsWith("360")
                    )*/
                if (title.Name.Length == 15 || title.Name.Length == 16)
                {
                    // DO STH
                }
                else if (title.Name.Equals(Constants.CHEATS_FOLDER_PATH_SUB_PREFIX))
                {
                    isSingleMode = true;
                }
                else
                {
                    errorMessage += "-" + title.Name + Environment.NewLine;
                    isListMode = false;
                }
            }

            return isSingleMode ? DirectoryMode.SingleMode : isListMode ? DirectoryMode.ListMode : DirectoryMode.OtherMode;
        }


        /// <summary>
        /// Check if check version info file exists.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public FileInfo CheckInfoFileExist(string path)
        {
            if (path.EndsWith(Constants.TXT_FILE_SUFFIX))
            { 
                FileInfo file = new FileInfo(path);
                if (file.Exists)
                {
                    return file;
                }
            }
            DirectoryInfo cheatFileDir = new DirectoryInfo(path);

            if (cheatFileDir.Exists)
            {
                FileInfo[] titles = cheatFileDir.GetFiles();
                var file = titles?.FirstOrDefault(t => t.Extension.Equals(Constants.TXT_FILE_SUFFIX));
                if (file?.Name?.Length > 4)
                {
                    return file;
                }
            }
            return null;
        }

        /// <summary>
        /// Check if cheat file exists or not.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public FileInfo CheckCheatFileExist(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return null;
            }

            FileInfo file = new FileInfo(path);
            return file.Exists ? file : null;
        }

        /// <summary>
        /// Check if the image exists or not.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public FileInfo CheckImageExist(string path, Language lang)
        {
            DirectoryInfo cheatFileDir = new DirectoryInfo(path);

            if (cheatFileDir.Exists)
            {
                FileInfo[] titles = cheatFileDir.GetFiles();
                var images = titles?.Where(t 
                    => t.Extension.Equals(Constants.JPG_FILE_SUFFIX, StringComparison.OrdinalIgnoreCase) 
                    || t.Extension.Equals(Constants.PNG_FILE_SUFFIX, StringComparison.OrdinalIgnoreCase));

                var image = images?.FirstOrDefault();
                if (lang != Language.NotSet)
                {
                    var tImage = images?.Where(i => (i.Name.Contains(GetName(lang)))).FirstOrDefault();
                    if (tImage?.Name?.Length > 4)
                    {
                        return tImage;
                    }
                    foreach (int i in Enum.GetValues(typeof(Language)))
                    {
                        var langName = GetName((Language)i);
                        tImage = images?.Where(i => (i.Name.Contains(langName))).FirstOrDefault();
                        if (tImage?.Name?.Length > 4)
                        {
                            return tImage;
                        }
                    }
                }

                if (image?.Name?.Length > 4)
                {
                    return image;
                }

            }
            return null;
        }

        /// <summary>
        /// Update Build ID - Version mapping and return.
        /// </summary>
        /// <param name="versions"></param>
        /// <returns></returns>
        public Dictionary<string, string> UpdateVersionMapping(IDictionary<string, string>  versions)
        {
            var newVersions = new Dictionary<string, string>();
            foreach (var kv in versions)
            {
                newVersions.Add(kv.Key.ToUpper(), kv.Value);
            }
            return newVersions;
        }

        /// <summary>
        /// Function to validate the game name based on System naming rule.
        /// </summary>
        /// <param name="gameName"></param>
        /// <returns></returns>
        public bool ValidateGameName(string gameName)
        {
            if (string.IsNullOrEmpty(gameName)
                || gameName.Length < Constants.DEFAULT_GAMENAME_MIN_LENGTH)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Function to validate the game based on Nintendo Switch Title/Build ID rule
        /// HEX 16-digit string i.e. 0123456789ABCDEF
        /// </summary>
        /// <param name="gameId"></param>
        /// <returns></returns>
        public bool ValidateGameId(string gameId)
        {
            
            if (string.IsNullOrEmpty(gameId)  
                || gameId.Length < Constants.DEFAULT_GAMEID_MIN_LENGTH
                || gameId.Length > Constants.DEFAULT_GAMEID_MAX_LENGTH)
            {
                return false;
            }
            Regex reg = new Regex(@"^(([0-9]|[a-f]|[A-F]){15}|([0-9]|[a-f]|[A-F]){16})$");
            return reg.IsMatch(gameId);
        }

        public bool ValidateBuildId(string buildId)
        { 
            if (string.IsNullOrEmpty(buildId) || buildId.Length != Constants.DEFAULT_BUILDID_LENGTH)
            {
                return false;
            }
            Regex reg = new Regex(@"^([0-9]|[a-f]|[A-F]){16}$");
            return reg.IsMatch(buildId);
        }

        public EnumMode.Language GetFormLanguageMode(string lang)
        {
            switch (lang)
            {
                case "en-us":
                    return Language.English;
                case "zh-cn":
                    return Language.Chinese;
                default:
                    return Language.English;
            }
        }

        public EnumMode.Language GetPreferredImageLanguageMode(string lang)
        {
            switch (lang)
            {
                case "English":
                    return Language.English;
                case "Japanese":
                    return Language.Japanese;
                case "Chinese":
                    return Language.Chinese;
                default:
                    return Language.English;
            }
        }

        public string GetLcid(Language lang)
        {
            var lcid = new LCID();
            switch (lang)
            {
                case Language.English:
                    return lcid.English.Name;
                case Language.Chinese:
                    return lcid.ChineseSimplified.Name;
                default:
                    return lcid.English.Name;
            }
        }
        public string GetName(Language lang)
        {
            switch (lang)
            {
                case Language.English:
                    return "English";
                case Language.Chinese:
                    return "Chinese";
                case Language.Japanese:
                    return "Japanese";
                default:
                    return "English";
            }
        }

        #region SubViewForm
        public string FormatHexAddressValue(string value, int maxlen)
        {
            if (value.Length > maxlen)
            {
                value = value.GetLast(maxlen);
            }
            string output = "";
            for (int i = value.Length - 1; i >= 0 && output.Length <= maxlen + 1; i--)
            {
                if (output.Length == 8)
                {
                    output = " " + output;
                }
                output = value[i] + output;
            }
            for (int i = maxlen - value.Length; i > 0; i--)
            {
                if (output.Length == 8)
                {
                    output = " " + output;
                }
                output = "0" + output;
            }
            return output;
        }

        public string GetHexValueFormat(string value, int maxlen)
        {
            value = value.GetLast(maxlen);
            var output = value;
            if (output.Length > 8)
            { 
                output = output.Substring(0, output.Length - 8) + " " + output.GetLast(8);
            }
            for (int i = value.Length; i < maxlen; i++)
            {
                if (output.Length == 8)
                {
                    output = " " + output;
                }
                output = "0" + output;
            }

            return output;
        }
        #endregion
    }
}
