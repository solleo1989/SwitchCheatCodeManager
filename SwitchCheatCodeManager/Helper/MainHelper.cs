using SwitchCheatCodeManager.CheatCode;
using SwitchCheatCodeManager.Constant;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using DirectoryMode = SwitchCheatCodeManager.Mode.EnumMode.DirectoryMode;

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
        public string GetInfoFileName(FileInfo file, int maxLength)
        {
            var infoFileName = file != null ? " - " + GetTxtFileBuildId(file.Name) : string.Empty;
            return (infoFileName.Length > 0 ? infoFileName.Substring(0, Math.Min(infoFileName.Length, maxLength)) : string.Empty);
        }
        public string GetTxtFileNameExtension(string filename) => !filename.EndsWith(Constants.TXT_FILE_SUFFIX)
            ? filename + Constants.TXT_FILE_SUFFIX : filename;
        public string GetVersionNameSuffix(string version) => $" (v{ (version.Length <= 7 ? version : version.Substring(0, 7)) })";
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
        public FileInfo CheckImageExist(string path)
        {
            DirectoryInfo cheatFileDir = new DirectoryInfo(path);

            if (cheatFileDir.Exists)
            {
                FileInfo[] titles = cheatFileDir.GetFiles();
                var image = titles?.FirstOrDefault(t 
                    => t.Extension.Equals(Constants.JPG_FILE_SUFFIX, StringComparison.OrdinalIgnoreCase) 
                    || t.Extension.Equals(Constants.PNG_FILE_SUFFIX, StringComparison.OrdinalIgnoreCase));
                if (image?.Name?.Length > 4)
                {
                    return image;
                }
            }
            return null;
        }

        public ConfigSettings LoadDefinedPathsConfig()
        {
            var configSettings = new ConfigSettings();
            var configFile = CheckCheatFileExist(Constants.DEFAULT_CONFIG_FILE_PATH);
            if (configFile != null)
            {
                IEnumerable<string> contents = File.ReadLines(Constants.DEFAULT_CONFIG_FILE_PATH);
                foreach (var line in contents)
                {
                    string[] parts;
                    switch (line)
                    {
                        case string s when line.StartsWith(Constants.DEFAULT_INPUT_PATH_PREFIX):
                            parts = line.Split(Constants.DEFAULT_INPUT_PATH_PREFIX);
                            if (parts.Count() > 1 && !string.IsNullOrEmpty(parts[1]))
                            {
                                var inputPath = parts[1];
                                DirectoryInfo cheatFileDir = new DirectoryInfo(inputPath);
                                if (cheatFileDir.Exists)
                                {
                                    configSettings.InputFolder = inputPath;
                                }
                            }
                            
                            break;
                        case string s when line.StartsWith(Constants.DEFAULT_OUTPUT_PATH_PREFIX):
                            parts = line.Split(Constants.DEFAULT_OUTPUT_PATH_PREFIX);
                            if (parts.Count() > 1 && !string.IsNullOrEmpty(parts[1]))
                            {
                                var outputPath = parts[1];
                                DirectoryInfo cheatFileDir = new DirectoryInfo(outputPath);
                                if (cheatFileDir.Exists)
                                {
                                    configSettings.OutputFolder = outputPath;
                                }
                                else
                                {
                                    // Try to scan each drive to see if the folder exists.
                                    DriveInfo[] drives = DriveInfo.GetDrives();
                                    foreach (var drive in drives)
                                    {
                                        var oPath = drive.Name + Constants.DEFAULT_OUTPUT_FOLDER_PATH_SUFFIX;
                                        DirectoryInfo cfwPath = new DirectoryInfo(oPath);
                                        if (cfwPath.Exists)
                                        {
                                            configSettings.OutputFolder = oPath;
                                        }
                                    }
                                }
                            }
                            break;
                        default:
                            break;

                    }
                        
                }
            }
            return configSettings;
        }
        public void SaveDefinedPathsConfig(ConfigSettings configs)
        {
            var configFile = CheckCheatFileExist(Constants.DEFAULT_CONFIG_FILE_PATH);
            if (configFile != null)
            {
                File.WriteAllText(Constants.DEFAULT_CONFIG_FILE_PATH, configs.Output());
            }
        }

        public Dictionary<string, string> UpdateVersionMapping(IDictionary<string, string>  versions)
        {
            var newVersions = new Dictionary<string, string>();
            foreach (var kv in versions)
            {
                newVersions.Add(kv.Key.ToUpper(), kv.Value);
            }
            return newVersions;
        }

        public bool ValidateGameName(string gameName)
        {
            if (string.IsNullOrEmpty(gameName) || gameName.Length < Constants.DEFAULT_GAMENAME_MIN_LENGTH)
            {
                return false;
            }
            return true;
        }

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
    }
}
