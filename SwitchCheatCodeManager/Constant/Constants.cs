using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwitchCheatCodeManager.Mode;

namespace SwitchCheatCodeManager.Constant
{
    /// <summary>
    /// Class for all constants variables.
    /// </summary>
    public class Constants
    {
        #region Number
        public const int DEFAULT_GAMENAME_MIN_LENGTH = 5;
        public const int DEFAULT_GAMEID_MIN_LENGTH = 15;
        public const int DEFAULT_GAMEID_MAX_LENGTH = 16;
        public const int DEFAULT_BUILDID_LENGTH = 16;
        public const int DEFAULT_CHEAT_FILE_NAME_LENGTH = 20;
        #endregion

        #region String
        public const string DEFAULT_NO_IMAGE_FOUND_PLACEHOLDER_PATH = "img\\NoImage.jpg";
        public const string DEFAULT_CONFIG_FILE_PATH = "config\\settings.ini";
        public const string DEFAULT_INPUT_PATH_PREFIX = "[input_folder]";
        public const string DEFAULT_OUTPUT_PATH_PREFIX = "[output_folder]";
        public const string DEFAULT_OUTPUT_FOLDER_PATH_SUFFIX = "atmosphere\\contents\\";
        public const string DEFAULT_DEFAULT_INPUT_FOLDER_LABEL_TEXT = "Input folder: ";
        public const string DEFAULT_DEFAULT_OUTPUT_FOLDER_LABEL_TEXT = "Output folder: ";
        public const string TXT_FILE_SUFFIX = ".txt";
        public const string JPG_FILE_SUFFIX = ".jpg";
        public const string PNG_FILE_SUFFIX = ".png";
        public const string CHEATS_FOLDER_PATH_SUB_PREFIX = "cheats";
        public const string DEFAULT_CHEAT_VERSION_NUMBER = "1.0.0";
        public const string DEFAULT_VERSION_RELEASE_URL = "https://github.com/solleo1989/SwitchCheatCodeManager/releases";
        #endregion

        #region Color
        public static Color DEFAULT_SUBSECTION_START_BACKGROUND_COLOR = Color.LightSteelBlue;
        public static Color DEFAULT_SUBSECTION_END_BACKGROUND_COLOR = Color.SlateGray;
        public static Color DEFAULT_CHEATS_TITLE_BACKGROUND_COLOR = Color.Lavender;
        #endregion

        #region Language
        public static EnumMode.Language DEFAULT_FORM_LANGUAGE = EnumMode.Language.English;
        #endregion

        #region Font
        public static Font DEFAULT_POPUP_DIALOGUE_TITLE_FONT = new Font("Arial", 14F, System.Drawing.FontStyle.Regular);
        public static Font DEFAULT_POPUP_DIALOGUE_TEXT_FONT = new Font("Arial", 9F, System.Drawing.FontStyle.Regular);
        #endregion
    }
}
