using SwitchCheatCodeManager.CheatCode;
using SwitchCheatCodeManager.Comparator;
using SwitchCheatCodeManager.Constant;
using SwitchCheatCodeManager.FormEntity;
using SwitchCheatCodeManager.Helper;
using SwitchCheatCodeManager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SwitchCheatCodeManager.WinForm
{
    public partial class CodeCompareForm : Form
    {
        private MainHelper Helper;
        private ActionHelper Action;
        private CultureInfo Culture;
        private ConfigSettings Configs;
        private string CurrentPath { get; set; }
        private Dictionary<string, string> Versions;

        public CodeCompareForm(
            MainHelper mainHelper,
            ActionHelper actionHelper,
            CultureInfo cultureInfo,
            ConfigSettings configs,
            string selectedPath)
        {
            this.Helper = mainHelper;
            this.Action = actionHelper;
            this.Culture = cultureInfo;
            this.Configs = configs;
            this.CurrentPath = selectedPath;
            this.Versions = new Dictionary<string, string>();


            InitializeComponent();
            ResetCultureInfo();
            InitializeForm();
        }

        public void InitializeForm(bool isDescendingOrder = true)
        {
            EnableComboBox();

            this.CheatPathTextBox.Text = this.CurrentPath;
            var correctedPath = Helper.GetCheatsPath(this.CurrentPath);
            DirectoryInfo dir = new DirectoryInfo(correctedPath);
            if (dir.Exists)
            {
                // Check the game title
                var cheatFileDirPath = Helper.GetDirectoryPath(correctedPath);
                var cheatFileDir = new DirectoryInfo(cheatFileDirPath);
                if (cheatFileDir.Exists)
                {
                    var file = Helper.CheckInfoFileExist(cheatFileDirPath);
                    var title = file?.Name;
                    if (file != null)
                    {
                        this.GameNameTextBox.Text = Helper.GetTxtFileBuildId(title);
                        //var buildId = Helper.GetBuildId(cheatFileDirPath + "\\");
                        this.GameTitleTextBox.Text = Helper.GetTitleId(cheatFileDirPath);
                        this.Versions = Action.LoadVersionFile(file.FullName);
                    }
                    else
                    {
                        GameNameTextBox.Text = string.Empty;
                        GameNameTextBox.PlaceholderText = Resources.DEFAULT_GAME_NAME_LABEL_TEXT;
                    }
                }
                FileInfo[] files = dir.GetFiles();
                List<String> filenames = new List<string>();
                if (files.Length > 0)
                {
                    foreach (FileInfo fi in files)
                    {
                        if (fi.Extension.Equals(Constants.TXT_FILE_SUFFIX) && fi.Name.Length == Constants.DEFAULT_CHEAT_FILE_NAME_LENGTH)
                        {
                            filenames.Add(fi.Name);
                        }
                    }
                }
                if (filenames.Count > 0)
                {

                    InsertItemsIntoCodeSelectorBox(filenames, isDescendingOrder);
                }
                else
                {
                    this.LeftComboBoxEx.Items.Add(new DropDownItem("", Resources.DEFAULT_CODE_SELECTOR_LIST_BOX_MESSAGE));
                    this.RightComboBoxEx.Items.Add(new DropDownItem("", Resources.DEFAULT_CODE_SELECTOR_LIST_BOX_MESSAGE));
                }
            }
        }

        private void InsertItemsIntoCodeSelectorBox(List<string> filenames, bool isDescendingOrder)
        {
            var sortedFileNames = new List<string>();
            List<string> values = new List<string>();
            values.AddRange(this.Versions.Values);
            var orderedValues = values.OrderBy(v => v, new VersionComparator()).ToArray();
            if (isDescendingOrder)
            {
                orderedValues = orderedValues.Reverse().ToArray();
            }

            for (var i = 0; i < orderedValues.Length; i++)
            {
                var key = Helper.GetTxtFileNameExtension(this.Versions.First(kv => kv.Value.Equals(orderedValues[i])).Key);
                if (filenames.Contains(key))
                {
                    filenames.Remove(key);
                    sortedFileNames.Add(key);
                }
            }
            sortedFileNames.AddRange(filenames);

            foreach (var filename in sortedFileNames)
            {
                var displayName = filename.Substring(0, Constants.DEFAULT_CHEAT_FILE_NAME_LENGTH - 4);
                var dropdownVal = Helper.GetTxtFileNameExtension(displayName);
                var dropdownTxt = displayName;
                if (this.Versions.Keys.Contains(displayName))
                {
                    var version = this.Versions.First(kv => kv.Key.Equals(displayName)).Value;
                    dropdownTxt += Helper.GetVersionNameSuffix(version);
                }
                var item = new DropDownItem(dropdownVal, dropdownTxt);
                this.LeftComboBoxEx.Items.Add(item);
                this.RightComboBoxEx.Items.Add(item);
            }
            if (LeftComboBoxEx.Items.Count >= 1)
            { 
                LeftComboBoxEx.SelectedIndex = 0;
                if (RightComboBoxEx.Items.Count > 1)
                { 
                    RightComboBoxEx.SelectedIndex = 1;
                }
            }
        }

        private void ReadSelectedCheatFile(
            ComboBoxEx dropdown,
            TextAreaEx textbox,
            TextBox buildbox,
            TextBox versionbox
            )
        {
            var correctedPath = Helper.GetCheatsPath(this.CurrentPath);
            var fileName = ((DropDownItem)dropdown.SelectedItem).Value;
            var cheatPath = correctedPath + fileName;
            var buildId = Helper.GetTxtFileBuildId(fileName);
            buildbox.Text = buildId;
            versionbox.Text = this.Versions.ContainsKey(buildId)
                    ? this.Versions[buildId]
                    : Resources.DEFAULT_VERSION_NUMBER;

            String contents = File.ReadAllText(cheatPath);
            textbox.Text = contents;
            CompareLeftAndRight();
        }

        private void CompareLeftAndRight()
        {
            var leftLines = this.LeftTextAreaEx.Lines;
            var rightLines = this.RightTextAreaEx.Lines;
            var lindex = 0;
            var rindex = 0;
            if (leftLines.Count() >= rightLines.Count())
            {
                for (var i = 0; i < rightLines.Count(); i++, lindex++, rindex++)
                {
                    var left = leftLines[i];
                    var right = rightLines[i];
                    LineCompare(left, right, ref lindex, ref rindex);
                }
            }
            else // this.LeftTextAreaEx.Lines.Count() < this.RightTextAreaEx.Lines.Count()
            { 
            }
        }

        private void LineCompare(
            string left, 
            string right, 
            ref int lindex, 
            ref int rindex)
        {
            if (left.Count() >= right.Count())
            {
                for (var j = 0; j < right.Count(); j++)
                {
                    var lchar = left.ToCharArray()[j];
                    var rchar = right.ToCharArray()[j];
                    if (lchar != rchar)
                    {
                        this.LeftTextAreaEx.SelectionStart = lindex;
                        this.LeftTextAreaEx.SelectionLength = 1;
                        this.LeftTextAreaEx.SelectionColor = Configs.CompareMismatchColor;
                        this.LeftTextAreaEx.SelectionBackColor = Configs.CompareMismatchBackColor;

                        this.RightTextAreaEx.SelectionStart = rindex;
                        this.RightTextAreaEx.SelectionLength = 1;
                        this.RightTextAreaEx.SelectionColor = Configs.CompareMismatchColor;
                        this.RightTextAreaEx.SelectionBackColor = Configs.CompareMismatchBackColor;
                    }
                    else // equal
                    {
                        this.LeftTextAreaEx.SelectionStart = lindex;
                        this.LeftTextAreaEx.SelectionLength = 1;
                        this.LeftTextAreaEx.SelectionColor = Configs.CompareSameColor;
                        this.LeftTextAreaEx.SelectionBackColor = Configs.CompareMismatchBackColor;

                        this.RightTextAreaEx.SelectionStart = rindex;
                        this.RightTextAreaEx.SelectionLength = 1;
                        this.RightTextAreaEx.SelectionColor = Configs.CompareMismatchColor;
                        this.RightTextAreaEx.SelectionBackColor = Configs.CompareMismatchBackColor;
                    }
                    lindex++;
                    rindex++;
                }
                for (var j = right.Count(); j < left.Count(); j++)
                {
                    this.LeftTextAreaEx.SelectionStart = lindex;
                    this.LeftTextAreaEx.SelectionLength = 1;
                    this.LeftTextAreaEx.SelectionColor = Configs.CompareLeftExtraColor;
                    this.LeftTextAreaEx.SelectionBackColor = Configs.CompareLeftExtraBackColor;

                    lindex++;
                }
            }
            else // left.Count() < right.Count()
            {
                for (var j = 0; j < left.Count(); j++)
                {
                    var lchar = left.ToCharArray()[j];
                    var rchar = right.ToCharArray()[j];
                    if (lchar != rchar)
                    {
                        this.LeftTextAreaEx.SelectionStart = lindex;
                        this.LeftTextAreaEx.SelectionLength = 1;
                        this.LeftTextAreaEx.SelectionColor = Configs.CompareMismatchColor;
                        this.LeftTextAreaEx.SelectionBackColor = Configs.CompareMismatchBackColor;

                        this.RightTextAreaEx.SelectionStart = rindex;
                        this.RightTextAreaEx.SelectionLength = 1;
                        this.RightTextAreaEx.SelectionColor = Configs.CompareMismatchColor;
                        this.RightTextAreaEx.SelectionBackColor = Configs.CompareMismatchBackColor;
                    }
                    lindex++;
                    rindex++;
                }
                for (var j = left.Count(); j < right.Count(); j++)
                {
                    this.RightTextAreaEx.SelectionStart = rindex;
                    this.RightTextAreaEx.SelectionLength = 1;
                    this.RightTextAreaEx.SelectionColor = Configs.CompareRightExtraColor;
                    this.RightTextAreaEx.SelectionBackColor = Configs.CompareRightExtraBackColor;

                    rindex++;
                }
            }
        }

        private void EnableComboBox()
        {
            this.LeftComboBoxEx.Enabled = true;
            this.RightComboBoxEx.Enabled = true;

            this.LeftComboBoxEx.Items.Clear();
            this.RightComboBoxEx.Items.Clear();
        }

        private void LeftComboBoxEx_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadSelectedCheatFile(
                this.LeftComboBoxEx, 
                this.LeftTextAreaEx,
                this.LeftBuildTextBox, 
                this.LeftVersionTextBox);
        }

        private void RightComboBoxEx_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadSelectedCheatFile(
                this.RightComboBoxEx,
                this.RightTextAreaEx,
                this.RightBuildTextBox,
                this.RightVersionTextBox);
        }

        private void ResetCultureInfo()
        {
            Thread.CurrentThread.CurrentUICulture = this.Culture;
        }
    }
}
