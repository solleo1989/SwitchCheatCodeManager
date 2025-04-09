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
        public const int DEFAULT_TEXTBOX_CHARACTER_HEIGHT = 210;
        public const int DEFAULT_TEXTBOX_CHARACTER_LINE_SPACING = 3;
        public const int DEFAULT_DROPDOWNLIST_ITEM_MAX_LENGTH = 85;
        public const int DEFAULT_SELECTORBOX_ITEM_MAX_LENGTH = 7;
        public const int DEFAULT_MAXMIUM_NUMBER_OF_LINES_PER_CHEAT_BLOCK = 64; // 0x400 / 0x10 = 0x40
        #endregion

        #region String
        // File path
        public const string DEFAULT_NO_IMAGE_FOUND_PLACEHOLDER_PATH = "img\\NoImage.jpg";
        public const string DEFAULT_CONFIG_FILE_PATH = "config\\settings.ini";
        // Config settings
        public const string DEFAULT_INPUT_PATH_PREFIX = "[input_folder]";
        public const string DEFAULT_OUTPUT_PATH_PREFIX = "[output_folder]";
        public const string DEFAULT_BACKGROUND_TITLE_COLOR_PREFIX = "[title_color]";
        public const string DEFAULT_BACKGROUND_TITLE_COLOR_ENABLED_PREFIX = "[title_color_enabled]";
        public const string DEFAULT_BACKGROUND_SECTIONSTART_COLOR_PREFIX = "[section_start_color]";
        public const string DEFAULT_BACKGROUND_SECTIONEND_COLOR_PREFIX = "[section_end_color]";
        public const string DEFAULT_FORM_LANGUAGE_COLOR_PREFIX = "[form_language]";
        public const string DEFAULT_PREVIEW_IMAGE_PREFERRED_LANGUAGE_COLOR_PREFIX = "[image_preferred]";

        public const string DEFAULT_OUTPUT_FOLDER_PATH_SUFFIX = "atmosphere\\contents\\";
        public const string TXT_FILE_SUFFIX = ".txt";
        public const string JPG_FILE_SUFFIX = ".jpg";
        public const string PNG_FILE_SUFFIX = ".png";
        public const string CHEATS_FOLDER_PATH_SUB_PREFIX = "cheats";
        public const string DEFAULT_CHEAT_VERSION_NUMBER = "1.0.0";
        public const string DEFAULT_VERSION_RELEASE_URL = "https://github.com/solleo1989/SwitchCheatCodeManager/releases";

        public const string DEFAULT_CHEAT_BLOCK_TITLE_ENABLE_SUFFIX = ":ENABLED";
        #endregion

        #region SubCheatsConstants
        public static string DEFAULT_SUBSECTION_START_PREFIX = "[--SectionStart:";
        public static string DEFAULT_SUBSECTION_START_SUFFIX = "--]";
        public static string DEFAULT_SUBSECTION_END_PREFIX = "[--SectionEnd:";
        public static string DEFAULT_SUBSECTION_END_SUFFIX = "--]";
        #endregion

        #region Color
        public static Color DEFAULT_SUBSECTION_START_BACKGROUND_COLOR = Color.LightSteelBlue;
        public static Color DEFAULT_SUBSECTION_END_BACKGROUND_COLOR = Color.SlateGray;
        public static Color DEFAULT_CHEATS_TITLE_BACKGROUND_COLOR = Color.Lavender;
        public static Color DEFAULT_CHEATS_TITLE_ENABLED_BACKGROUND_COLOR = Color.Coral;
        #endregion

        #region Language
        public static EnumMode.Language DEFAULT_FORM_LANGUAGE = EnumMode.Language.English;
        #endregion

        #region Font
        public static Font DEFAULT_POPUP_DIALOGUE_TITLE_FONT = new Font("Arial", 14F, System.Drawing.FontStyle.Regular);
        public static Font DEFAULT_POPUP_DIALOGUE_TEXT_FONT = new Font("Arial", 9F, System.Drawing.FontStyle.Regular);

        public static string Font_Arial = "Arial";
        public static string Font_Ubuntu = "Ubuntu Mono";
        public static string Font_Consolas = "Consolas";
        public static string Font_MSYaHei = "Microsoft Yahei";      // SChinese Character
        public static string Font_KaiTi = "KaiTi";                  // SChinese Character
        public static string Font_MingLiu = "MingLiU";              // TChinese Character
        public static string Font_MSGothic = "MS Gothic";           // Japanese Character
        public static string Font_MSMincho = "MS Mincho";           // Japanese Character
        #endregion

        /// <summary>
        /// Illegal Filename Characters
        /// Do not use any of these common illegal characters or symbols in your filenames or folders:
        /// </summary>
        public static ISet<char> FilenameIllegalChars = new HashSet<char>(){
            //'#',    // pound
            //'%',    // percent
            //'&',    // ampersand
            //'{',    // left curly bracket
            //'}',    // right curly bracket
            '|',    // vertical bar
            '\\',   // back slash
            '<',    // left angle bracket
            '>',    // right angle bracket
            '*',    // asterisk
            '?',    // question mark
            '/',    // forward slash
                    // blank spaces
            //'$',    // dollar sign
            //'!',    // exclamation point
            //'\'',   // single quotes
            '\"',   // double quotes
            ':',    //  colon
            //'@'     // at sign@ 
        };

        public static string[] DisplayLanguageSet = new string[] {
            "English",
            "Chinese",
        };

        public static string[] PreviewImageLanguageSet = new string[] {
            "English",
            "Chinese",
            "Japanese",
        };

        public static string DefaultLoopStartValue = "31000000";
    }
}
