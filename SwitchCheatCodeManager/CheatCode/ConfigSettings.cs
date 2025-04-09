using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Threading.Tasks;
using SwitchCheatCodeManager.Constant;
using SwitchCheatCodeManager.Builder;
using SwitchCheatCodeManager.Mode;
using SwitchCheatCodeManager.Helper;
using Language = SwitchCheatCodeManager.Mode.EnumMode.Language;

namespace SwitchCheatCodeManager.CheatCode
{
    public class ConfigSettings
    {
        public string InputFolder { get; set; }
        public string OutputFolder { get; set; }

        public Color TitleColor { get; set; }
        public Color TitleColorEnabled { get; set; }
        public Color SectionStartColor { get; set; }
        public Color SectionEndColor { get; set; }

        public Color CompareMismatchColor { get; set; }
        public Color CompareMismatchBackColor { get; set; }
        public Color CompareEqualColor { get; set; }
        public Color CompareEqualBackColor { get; set; }
        public Color CompareLeftExtraColor { get; set; }
        public Color CompareLeftExtraBackColor { get; set; }
        public Color CompareRightExtraColor { get; set; }
        public Color CompareRightExtraBackColor { get; set; }
        public Color CompareSameColor { get; set; }

        public Language FormLanguage { get; set; }
        public Language ImagePreferred { get; set; }
        
        public bool HasInputFolder() => !string.IsNullOrEmpty(InputFolder);
        public bool HasOutputFolder() => !string.IsNullOrEmpty(OutputFolder);

        private ColorBuilder Builder;
        private MainHelper Helper;

        public ConfigSettings()
        {
            this.Builder = new ColorBuilder();
            this.Helper = new MainHelper();

            this.InputFolder = string.Empty;
            this.OutputFolder = string.Empty;

            this.TitleColor = Constants.DEFAULT_CHEATS_TITLE_BACKGROUND_COLOR;
            this.TitleColorEnabled = Constants.DEFAULT_CHEATS_TITLE_ENABLED_BACKGROUND_COLOR;
            this.SectionStartColor = Constants.DEFAULT_SUBSECTION_START_BACKGROUND_COLOR;
            this.SectionEndColor = Constants.DEFAULT_SUBSECTION_END_BACKGROUND_COLOR;

            this.FormLanguage = Language.NotSet;
            this.ImagePreferred = Language.NotSet;

            this.CompareMismatchColor = Color.Red;
            this.CompareMismatchBackColor = Color.Pink;
            this.CompareLeftExtraColor = Color.Blue;
            this.CompareLeftExtraBackColor = Color.SkyBlue;
            this.CompareRightExtraColor = Color.Green;
            this.CompareRightExtraBackColor = Color.SpringGreen;

        }

        public void LoadFromContents(IEnumerable<string> contents)
        {
            foreach (var line in contents)
            {
                string[] parts;
                switch (line)
                {
                    case string key when line.StartsWith(Constants.DEFAULT_INPUT_PATH_PREFIX):
                        parts = line.Split(Constants.DEFAULT_INPUT_PATH_PREFIX);
                        if (parts.Length > 1 && !string.IsNullOrEmpty(parts[1]))
                        {
                            var inputPath = parts[1];
                            DirectoryInfo cheatFileDir = new DirectoryInfo(inputPath);
                            if (cheatFileDir.Exists)
                            {
                                this.InputFolder = inputPath;
                            }
                        }

                        break;
                    case string key when line.StartsWith(Constants.DEFAULT_OUTPUT_PATH_PREFIX):
                        parts = line.Split(Constants.DEFAULT_OUTPUT_PATH_PREFIX);
                        if (parts.Length > 1 && !string.IsNullOrEmpty(parts[1]))
                        {
                            var outputPath = this.Helper.GetPath(parts[1]);
                            DirectoryInfo cheatFileDir = new DirectoryInfo(outputPath);
                            if (cheatFileDir.Exists)
                            {
                                this.OutputFolder = outputPath;
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
                                        this.OutputFolder = oPath;
                                    }
                                }
                            }
                        }

                        break;
                    case String key when line.StartsWith(Constants.DEFAULT_BACKGROUND_TITLE_COLOR_PREFIX):
                        parts = line.Split(Constants.DEFAULT_BACKGROUND_TITLE_COLOR_PREFIX);
                        if (parts.Length > 1 && !string.IsNullOrEmpty(parts[1]))
                        {
                            this.TitleColor = this.Builder.GetColorFromHex(parts[1]);
                        }
                        break;
                    case String key when line.StartsWith(Constants.DEFAULT_BACKGROUND_TITLE_COLOR_ENABLED_PREFIX):
                        parts = line.Split(Constants.DEFAULT_BACKGROUND_TITLE_COLOR_ENABLED_PREFIX);
                        if (parts.Length > 1 && !string.IsNullOrEmpty(parts[1]))
                        {
                            this.TitleColorEnabled = this.Builder.GetColorFromHex(parts[1]);
                        }
                        break;
                    case String key when line.StartsWith(Constants.DEFAULT_BACKGROUND_SECTIONSTART_COLOR_PREFIX):
                        parts = line.Split(Constants.DEFAULT_BACKGROUND_SECTIONSTART_COLOR_PREFIX);
                        if (parts.Length > 1 && !string.IsNullOrEmpty(parts[1]))
                        {
                            this.SectionStartColor = this.Builder.GetColorFromHex(parts[1]);
                        }
                        break;
                    case String key when line.StartsWith(Constants.DEFAULT_BACKGROUND_SECTIONEND_COLOR_PREFIX):
                        parts = line.Split(Constants.DEFAULT_BACKGROUND_SECTIONEND_COLOR_PREFIX);
                        if (parts.Length > 1 && !string.IsNullOrEmpty(parts[1]))
                        {
                            this.SectionEndColor = this.Builder.GetColorFromHex(parts[1]);
                        }
                        break;
                    case String key when line.StartsWith(Constants.DEFAULT_FORM_LANGUAGE_COLOR_PREFIX):
                        parts = line.Split(Constants.DEFAULT_FORM_LANGUAGE_COLOR_PREFIX);
                        if (parts.Length > 1 && !string.IsNullOrEmpty(parts[1]))
                        {
                            this.FormLanguage = Helper.GetFormLanguageMode(parts[1]);
                        }
                        break;
                    case String key when line.StartsWith(Constants.DEFAULT_PREVIEW_IMAGE_PREFERRED_LANGUAGE_COLOR_PREFIX):
                        parts = line.Split(Constants.DEFAULT_PREVIEW_IMAGE_PREFERRED_LANGUAGE_COLOR_PREFIX);
                        if (parts.Length > 1 && !string.IsNullOrEmpty(parts[1]))
                        {
                            this.ImagePreferred = Helper.GetPreferredImageLanguageMode(parts[1]);
                        }
                        break;
                    default:
                        break;
                } // End of switch
            }
        }

        public string Output()
        {
            var output = 
                $"{Constants.DEFAULT_INPUT_PATH_PREFIX}{this.InputFolder}{Environment.NewLine}" +
                $"{Constants.DEFAULT_OUTPUT_PATH_PREFIX}{this.OutputFolder}{Environment.NewLine}" +                
                $"{Constants.DEFAULT_BACKGROUND_TITLE_COLOR_PREFIX}{Builder.GetHexStrFromColor(this.TitleColor)}{Environment.NewLine}" +
                $"{Constants.DEFAULT_BACKGROUND_TITLE_COLOR_ENABLED_PREFIX}{Builder.GetHexStrFromColor(this.TitleColorEnabled)}{Environment.NewLine}" +
                $"{Constants.DEFAULT_BACKGROUND_SECTIONSTART_COLOR_PREFIX}{Builder.GetHexStrFromColor(this.SectionStartColor)}{Environment.NewLine}" +
                $"{Constants.DEFAULT_BACKGROUND_SECTIONEND_COLOR_PREFIX}{Builder.GetHexStrFromColor(this.SectionEndColor)}{Environment.NewLine}"
                ;
            if (this.FormLanguage != Language.NotSet)
            {
                output += $"{Constants.DEFAULT_FORM_LANGUAGE_COLOR_PREFIX}{Helper.GetLcid(this.FormLanguage)}{Environment.NewLine}";
            }
            if (this.ImagePreferred != Language.NotSet)
            {
                output += $"{Constants.DEFAULT_PREVIEW_IMAGE_PREFERRED_LANGUAGE_COLOR_PREFIX}{Helper.GetName(this.ImagePreferred)}{Environment.NewLine}";
            }
            return output;
        }
    }
}
