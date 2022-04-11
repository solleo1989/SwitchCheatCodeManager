using SwitchCheatCodeManager.CheatCode;
using SwitchCheatCodeManager.Comparator;
using SwitchCheatCodeManager.Constant;
using SwitchCheatCodeManager.FormEntity;
using SwitchCheatCodeManager.Helper;
using SwitchCheatCodeManager.Mode;
using SwitchCheatCodeManager.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DirectoryMode = SwitchCheatCodeManager.Mode.EnumMode.DirectoryMode;
using VersionFileMode = SwitchCheatCodeManager.Mode.EnumMode.VersionFileMode;

namespace SwitchCheatCodeManager.WinForm
{
    public partial class MainForm : Form
    {
        #region Variables
        
        private string CurrentPath { get; set; }
        private string CurrentGamePath { get; set; }
        private string OriginalContents { get; set; }
        private string CurrentOpenFilePath { get; set; }
        private CheatFile CurrentCheatFile { get; set; }
        private Image CurrentPreviewImage { get; set; }
        private IList<Games> GamesList;
        private IList<DropDownItem> OriginalDropDownItems;
        private Dictionary<string, string> Versions;
        public static FileInfo CurrentVersionFile;
        private ConfigSettings Configs;
        
        // Display different file changing logic.       
        private DirectoryMode CurrentEditMode = DirectoryMode.OtherMode;
        // Choose to display/edit different version file
        private VersionFileMode CurrentVersionFileMode = VersionFileMode.None;
        #endregion

        private MainHelper Helper;
        private ActionHelper Action;
        private CultureInfo CurrentCulture;

        public MainForm(
            MainHelper mainHelper,
            ActionHelper actionHelper)
        {
            this.Helper = mainHelper;
            this.Action = actionHelper;
            this.Configs = Action.LoadDefinedPathsConfig();
            this.CurrentCulture = CultureInfo.GetCultureInfo(Helper.GetLcid(this.Configs.FormLanguage));
            ResetCultureInfo();
            InitializeComponent();
            InitializeStatusBar();
        }

        /// <summary>
        /// Override few shortcuts in the form.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Keys keyOnly = keyData & ~Keys.Modifiers;
            Keys modifiersOnly = Control.ModifierKeys & (Keys.Shift | Keys.Control | Keys.Alt);
            if (modifiersOnly == 0)
            {
                // Key alone
            }
            else if ((modifiersOnly & Keys.Control) != 0)
            {
                // Control + key
                switch (keyOnly)
                {
                    case Keys.E:
                        OpenVersionIndexEditForm();
                        return true;
                    case Keys.D1:
                        SelectCodeSelectorListBox(0);
                        return true;
                    case Keys.D2:
                        SelectCodeSelectorListBox(1);
                        return true;
                    case Keys.D3:
                        SelectCodeSelectorListBox(2);
                        return true;
                    case Keys.D4:
                        SelectCodeSelectorListBox(3);
                        return true;
                    case Keys.D5:
                        SelectCodeSelectorListBox(4);
                        return true;
                    case Keys.D6:
                        SelectCodeSelectorListBox(5);
                        return true;
                    case Keys.D7:
                        SelectCodeSelectorListBox(6);
                        return true;
                    case Keys.D8:
                        SelectCodeSelectorListBox(7);
                        return true;
                    case Keys.D9:
                        SelectCodeSelectorListBox(8);
                        return true;

                    default:
                        return base.ProcessCmdKey(ref msg, keyData);
                }
            }


            return base.ProcessCmdKey(ref msg, keyData);
        }

        #region Initializers

        private void InitializeForm()
        {

            this.CurrentCheatFile = new CheatFile();
            this.OriginalContents = string.Empty;
            CurrentVersionFile = null;

            this.GameDBNameTextBox.Text = String.Empty;
            this.GameDBTidTextBox.Text = String.Empty;

            //this.FilterTextBox.Enabled = false;
            this.CodeTextBox.Text = String.Empty;
            this.CodeTextBox.Enabled = false;
            this.CodeSelectorListBox.Items.Clear();
            this.CodeSelectorListBox.Enabled = false;

            InitializeButtons();
            InitializeImages();
            InitializeStatusBar();

            //this.PathTextBox.Focus();
            this.GameNameTextBox.PlaceholderText = Resources.DEFAULT_GAME_NAME_LABEL_TEXT;
            this.CodeStatusLabel.Text = Resources.DEFAULT_CODE_STATUS_LABEL_TEXT;
            this.CodeStatusLabel.BackColor = System.Drawing.Color.Empty;

            this.Versions = new Dictionary<string, string>();
            this.VersionNumberTextBox.Text = Resources.DEFAULT_VERSION_NUMBER;
            this.BuildIdTextBox.Text = String.Empty;

            this.CurrentVersionFileMode = VersionFileMode.None;
            this.OriginalDropDownItems = new List<DropDownItem>();
        }

        private void InitializeButtons()
        {
            this.VersionFileModeUpdateButton.Enabled = false;
            this.UpdateButton.Enabled = false;
            this.FormatFilesButton.Enabled = false;
            this.InsertNewCheatButton.Enabled = false;
            this.RemoveFolderButton.Enabled = false;

            this.AscendingOrderButton.Enabled = false;
            this.DescendingOrderButton.Enabled = false;

            this.DisableFolderButtons();
            this.DisableFileButtons();

            // Initialize menu buttons
            this.SaveToolStripMenuItem.Enabled = false;
            this.SaveAsToolStripMenuItem.Enabled = false;
        }
        private void InitializeImages()
        {
            this.PreviewImage.Image = null;
            this.CurrentPreviewImage = null;
        }
        private void InitializeStatusBar()
        {
            InputFolderPathLabelToolStripStatusLabel.Text = 
                string.Format(Resources.DEFAULT_INPUT_FOLDER_LABEL_TEXT, (String.IsNullOrEmpty(Configs.InputFolder))
                    ? Resources.DEFAULT_DEFAULT_INPUT_FOLDER_NOT_SET_TEXT
                    : Configs.InputFolder);
            if (!String.IsNullOrEmpty(Configs.InputFolder))
            { 
                this.NewToolStripMenuItem.Enabled = true;
                this.DefaultFileButton.Enabled = true;
            }

            OutputFolderPathLabelToolStripStatusLabel.Text = 
                string.Format(Resources.DEFAULT_OUTPUT_FOLDER_LABEL_TEXT, (String.IsNullOrEmpty(Configs.OutputFolder)
                    ? Resources.DEFAULT_DEFAULT_OUTPUT_FOLDER_NOT_SET_TEXT
                    : Configs.OutputFolder));
        }
        
        private void EnableFolderButtons()
        {
            if (IsListMode())
            {
                this.InsertNewCheatsButton.Enabled = true;
                this.OpenFolderButton.Enabled = true;
                this.CopyFolderButton.Enabled = !String.IsNullOrEmpty(Configs.OutputFolder) ? true : false;
                this.RemoveFolderButton.Enabled = true;
            }
            else if (IsSingleMode())
            {
                this.InsertNewCheatsButton.Enabled = false;
                this.OpenFolderButton.Enabled = true;
                this.FormatFilesButton.Enabled = false;
            }
            this.InsertNewCheatButton.Enabled = true;            
            this.FormatFilesButton.Enabled = true;
            this.AscendingOrderButton.Enabled = true;
            this.DescendingOrderButton.Enabled = true;
        }
        private void DisableFolderButtons()
        {
            this.OpenFolderButton.Enabled = false;
            this.CopyFolderButton.Enabled = false;
        }
        private void EnableFileButtons()
        {
            this.CopyFileButton.Enabled = true;
            this.NewBlockButton.Enabled = true;
            this.RemoveCheatButton.Enabled = true;
        }
        private void DisableFileButtons()
        {
            this.SaveOriginalButton.Enabled = false;
            this.SaveFormatedButton.Enabled = false;
            this.CopyFileButton.Enabled = false;
            this.NewBlockButton.Enabled = false;
            this.RemoveCheatButton.Enabled = false;
        }
        private void ResetFilterKeyword()
        {
            this.FilterTextBox.Text = String.Empty;
        }
        private void ResetSubCheatsSection()
        {
            this.SubCheatsGroupBox.Controls.Clear();
            this.SubCheatsGroupBox.Visible = false;
        }
        private void ResetCultureInfo()
        {
            Thread.CurrentThread.CurrentUICulture = this.CurrentCulture;
        }
        private void UpdateGameDBName(string buildId)
            => this.GameDBNameTextBox.Text = this.GamesList.Where(g => g.BuildId == buildId).FirstOrDefault()?.GameName;
        #endregion

        #region RealActions

        /// <summary>
        /// Function to refresh the code editor form
        /// </summary>
        /// <param name="correctedPath"></param>
        /// <param name="isDescendingOrder"></param>
        private void RefreshForm(string correctedPath, bool isDescendingOrder = true)
        {
            InitializeForm();
            this.PathTextBox.Text = this.CurrentPath;
            this.NumOfCheatsLabel.Text = string.Empty;
            //this.FilterTextBox.Text = string.Empty;
            DirectoryInfo dir = new DirectoryInfo(correctedPath);
            if (dir.Exists)
            {
                // Check the game title
                var cheatFileDirPath = Helper.GetDirectoryPath(correctedPath);
                var cheatFileDir = new DirectoryInfo(cheatFileDirPath);

                if (cheatFileDir.Exists)
                {
                    var file = Helper.CheckInfoFileExist(cheatFileDirPath);
                    var image = Helper.CheckImageExist(cheatFileDirPath, Configs.ImagePreferred);
                    var title = file?.Name;

                    this.CurrentVersionFileMode = file != null ? VersionFileMode.Edit : VersionFileMode.Create;
                    UpdateVersionFileModeUpdateButton();
                    if (file != null)
                    {
                        GameNameTextBox.Text = Helper.GetTxtFileBuildId(title);
                        CurrentVersionFile = file;
                        this.Versions = Action.LoadVersionFile(file.FullName);
                        var buildId = Helper.GetBuildId(cheatFileDirPath + "\\");
                        if (IsListMode())
                        {
                            UpdateGameDBName(buildId);
                            this.GameDBTidTextBox.Text = (this.GameListComboBox.SelectedItem as DropDownItem).Value;
                        }
                    }
                    else
                    {
                        GameNameTextBox.Text = string.Empty;
                        GameNameTextBox.PlaceholderText = Resources.DEFAULT_GAME_NAME_LABEL_TEXT;
                    }
                    // Update preview image
                    if (image != null)
                    {
                        Image prevImg = Image.FromFile(image.FullName);
                        Image resizeImg = Action.ResizeImage(prevImg, new Size(350, 350));
                        this.PreviewImage.Image = resizeImg;
                        this.CurrentPreviewImage = resizeImg;
                    }
                    else
                    {
                        Image resizeImg = Action.ResizeImage(this.PreviewImageList.Images[0], new Size(350, 350));
                        this.PreviewImage.Image = resizeImg;
                    }

                    EnableFolderButtons();
                }
                else
                {
                    GameNameTextBox.Text = string.Empty;
                    GameNameTextBox.PlaceholderText = Resources.DEFAULT_GAME_NAME_LABEL_TEXT;

                    DisableFolderButtons();
                }

                // Load files
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

                this.NumOfCheatsLabel.Text = string.Format(Resources.DEFAULT_NUMBER_OF_CHEATS_LOADED_LABEL, filenames.Count);
                if (filenames.Count > 0)
                {
                    this.CodeSelectorListBox.Enabled = true;
                    InsertItemsIntoCodeSelectorBox(filenames, isDescendingOrder);
                }
                else
                {
                    this.CodeSelectorListBox.Items.Add(new DropDownItem("", Resources.DEFAULT_CODE_SELECTOR_LIST_BOX_MESSAGE));
                }
            }
            else
            {
                ShowErrorMessage(Resources.DEFAULT_INVALID_DIRECTORY_MESSAGE);
            }
        }

        /// <summary>
        /// Function to insert cheat file list into code selector box
        /// </summary>
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
                this.CodeSelectorListBox.Items.Add(item);
            }
        }

        /// <summary>
        /// This function is invoked when the page being refreshed
        /// Game folder change
        /// </summary>
        private void RefreshSelectedForm(bool isDescendingOrder = true)
        {
            
            if (!this.CurrentPath.EndsWith(Constants.CHEATS_FOLDER_PATH_SUB_PREFIX))
            {
                var correctedPath = Helper.GetCheatsPath(this.CurrentPath + "\\" + ((DropDownItem)this.GameListComboBox.SelectedItem).Value);
                this.CurrentGamePath = correctedPath;
                RefreshForm(correctedPath, isDescendingOrder);
            }
            else
            {
                RefreshForm(this.CurrentPath, isDescendingOrder);
            }

            ResetSubCheatsSection();
        }

        /// <summary>
        /// Function to read certain cheat file
        /// </summary>
        /// <param name="path"></param>
        private void ReadSelectedCheatFile(string path)
        {
            this.CodeTextBox.Enabled = true;
            this.SaveToolStripMenuItem.Enabled = true;
            this.SaveAsToolStripMenuItem.Enabled = true;
            String contents = File.ReadAllText(path);
            this.CodeTextBox.Text = contents;
            OriginalContents = contents;
            CheatFile cheats = new CheatFile(contents, path);
            ResetSubCheatsSection();
            HighlightCheatTitleSection();
            if (cheats.Legit)
            {
                if (cheats.HasSubCheats)
                {
                    this.CodeStatusLabel.Text = Resources.VALIDATION_CHECK_FOR_CHEATS_VALID;
                    this.CodeStatusLabel.BackColor = Color.Blue;
                    UpdateSubCheatsSectionOnPanel(cheats);
                }
                else
                {
                    this.CodeStatusLabel.Text = Resources.VALIDATION_CHECK_FOR_CHEATS_VALID;
                    this.CodeStatusLabel.BackColor = System.Drawing.Color.Green;
                    UpdateMainCheatsSectionOnPanel(cheats);
                }
            }
            else
            {
                ShowErrorMessage(string.Format(Resources.ERROR_MESSAGE_MESSAGE_PREFIX, cheats.ErrorLine));
                this.CodeStatusLabel.Text = Resources.VALIDATION_CHECK_FOR_CHEATS_INVALID;
                this.CodeStatusLabel.BackColor = System.Drawing.Color.Red;
            }
        }

        /// <summary>
        /// Save specific contents to the current open file.
        /// </summary>
        /// <param name="contents"></param>
        private void SaveContentsIntoSelectedFile(string contents)
        {
            if (this.CodeTextBox.Enabled)
            {
                File.WriteAllText(this.CurrentOpenFilePath, contents);
            }
        }

        /// <summary>
        /// Update  dropdown combo box under specific path
        /// </summary>
        /// <param name="mode">Given directory mode, i.e. ListMode, SingleMode</param>
        /// <param name="path">The path contains each game folder</param>
        private void UpdateDropdownComboBox(DirectoryMode mode, string path, string keyword = null)
        {
            if (mode == DirectoryMode.SingleMode)
            {
                this.CurrentEditMode = DirectoryMode.SingleMode;
                DirectoryInfo dir = new DirectoryInfo(path);
                this.CurrentGamePath = path;

                var infoFile = Helper.CheckInfoFileExist(Helper.GetDirectoryPath(path));
                var dropdownItem = new DropDownItem()
                {
                    Value = dir.Name,
                    Text = dir.Parent.Name + Helper.GetInfoFileName(infoFile),
                };
                this.GameListComboBox.Items.Clear();
                this.GameListComboBox.Items.Add(dropdownItem);
                this.GameListComboBox.SelectedIndex = 0;
                this.GameListComboBox.Enabled = false;
                this.FilterTextBox.Enabled = false;
                RefreshForm(path);
            }
            else if (mode == DirectoryMode.ListMode)
            {
                this.CurrentEditMode = DirectoryMode.ListMode;
                DirectoryInfo dir = new DirectoryInfo(path);
                DirectoryInfo[] titles = dir.GetDirectories();
                this.OriginalDropDownItems = new List<DropDownItem>();
                this.GameListComboBox.Items.Clear();
                foreach (var title in titles)
                {
                    var infoFile = Helper.CheckInfoFileExist(title.FullName);                    
                    var dropdownItem = new DropDownItem()
                    {
                        Value = title.Name,
                        Text = title.Name + Helper.GetInfoFileName(infoFile),
                    };
                    OriginalDropDownItems.Add(dropdownItem);
                    if (string.IsNullOrEmpty(keyword) || dropdownItem.Text.ToUpperInvariant().Contains(keyword.ToUpper()))
                    {
                        this.GameListComboBox.Items.Add(dropdownItem);
                    }
                }

                if (this.GameListComboBox.Items.Count > 0)
                {
                    this.GameListComboBox.Enabled = true;
                    this.GameListComboBox.SelectedIndex = 0;
                    var correctedPath = Helper.GetPath(path);
                    correctedPath = Helper.GetCheatsPath(correctedPath + ((DropDownItem)this.GameListComboBox.SelectedItem).Value);
                    RefreshForm(correctedPath);
                    this.CurrentGamePath = correctedPath;
                }
                else
                {
                    InitializeForm();
                }
                
                this.FilterTextBox.Enabled = true;                
            }

        }

        /// <summary>
        /// Function to update the version mode button
        /// </summary>
        private void UpdateVersionFileModeUpdateButton()
        {
            if (IsListMode())
            {
                if (this.CurrentVersionFileMode == VersionFileMode.Create)
                {
                    ///this.VersionFileModeUpdateButton.Enabled = true;
                    this.VersionFileModeUpdateButton.Text = Resources.VersionFileModeCreateButton_Text;
                }
                else if (this.CurrentVersionFileMode == VersionFileMode.Edit)
                {
                    this.VersionFileModeUpdateButton.Enabled = true;
                    this.VersionFileModeUpdateButton.Text = Resources.VersionFileModeEditButton_Text;
                }
                else
                {
                    this.VersionFileModeUpdateButton.Text = Resources.VersionFileModeUpdateButton_Text;
                }
            }
            else
            {
                this.VersionFileModeUpdateButton.Enabled = false;
            }

        }

        /// <summary>
        /// Update the pid files into capitalization format
        /// </summary>
        public void FormatFileNamesUnderCurrentPath()
        {
            // Show confirmmessage 
            DialogResult result = MessageBox.Show(Resources.DEFAULT_CONFIRM_MESSAGE_FOR_FORMAT_FILE_NAMES,
                Resources.QUESTION_MESSAGE_TITLE_CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.Yes))
            {
                var dirPath = Helper.GetDirectoryPath(GetSelectedCheatPath());
                DirectoryInfo dir = new DirectoryInfo(dirPath);
                if (dir.Exists && !dir.Name.Equals(dir.Name.ToUpper()))
                {
                    var updatedPath = Helper.GetPath(dir.Parent.ToString()) + dir.Name.ToUpper();                        
                    dir.MoveTo(updatedPath + "_TEMP");
                    dir.MoveTo(updatedPath);
                    //this.CurrentPath = updatedPath;
                }
                var correctedPath = GetSelectedCheatPath();
                correctedPath = Helper.GetCheatsPath(correctedPath);
                RefreshSelectedForm();
                dir = new DirectoryInfo(GetSelectedCheatPath());
                int converted = 0;
                int failed = 0;
                if (dir.Exists)
                {
                    // Load files
                    FileInfo[] files = dir.GetFiles();
                    if (files.Length > 0)
                    {
                        foreach (FileInfo fi in files)
                        {
                            if (fi.Extension.Equals(Constants.TXT_FILE_SUFFIX) && fi.Name.Length == Constants.DEFAULT_CHEAT_FILE_NAME_LENGTH)
                            {
                                String originalContents = File.ReadAllText(fi.FullName);
                                var cheatFile = new CheatFile(originalContents, fi.FullName);
                                if (cheatFile.Legit)
                                {
                                    var updatedContents = cheatFile.Output();
                                    File.WriteAllText(fi.FullName, updatedContents);
                                    converted++;
                                }
                                else
                                {
                                    failed++;
                                }
                                correctedPath = Helper.GetPath(dir.FullName);
                                var formattedName = correctedPath + Helper.GetTxtFileBuildId(fi.Name).ToUpper() + Constants.TXT_FILE_SUFFIX;
                                fi.MoveTo(formattedName + "_TEMP");
                                fi.MoveTo(formattedName);
                            }
                        }
                        this.Versions = Helper.UpdateVersionMapping(this.Versions);
                        ShowInformationMessage(String.Format(Resources.DEFAULT_CONVERT_FILES_MESSAGE, converted, failed),
                            Resources.INFORMATION_MESSAGE_TITLE_RESULT);
                    }
                }
                else
                {
                    ShowErrorMessage(Resources.DEFAULT_INVALID_DIRECTORY_MESSAGE);
                }

                RefreshSelectedForm();
            }
        }

        /// <summary>
        /// Select specific cheat file at default index if exists.
        /// </summary>
        public void SelectCodeSelectorListBox()
        {
            if (this.CodeSelectorListBox != null
                && this.CodeSelectorListBox.Items.Count > 0)
            {
                this.CodeSelectorListBox.SelectedIndex = 0;
                ScrollToSpecificPosition("");
            }
        }

        /// <summary>
        /// Select specific cheat file at specific index.
        /// </summary>
        /// <param name="index">The index of the item aimimng to choose, starting from 0 instead of 1.</param>
        public void SelectCodeSelectorListBox(int index)
        {
            if (this.CodeSelectorListBox != null 
                && this.CodeSelectorListBox.Items.Count > 0
                && this.CodeSelectorListBox.Items.Count > index)
            {
                // Check if the contents have updated
                if (IsTextContentsChanged())
                {
                    ShowInformationMessage(Resources.DEFAULT_SAVE_FILE_FIRST_WARNING_MESSAGE, "", false);
                }
                else 
                {
                    this.CodeSelectorListBox.SelectedIndex = index;
                    ScrollToSpecificPosition("");
                }
            }
        }

        /// <summary>
        /// Select specific game at given index.
        /// </summary>
        /// <param name="index"></param>
        public void SelectGameListDropDown(int index)
        { 
            this.GameListComboBox.SelectedIndex = index;
        }

        /// <summary>
        /// Select specific game by given gameId.
        /// </summary>
        /// <param name="gameId"></param>
        public void SelectGameListDropDown(string gameId)
        {
            if (!string.IsNullOrEmpty(gameId) && Helper.ValidateGameId(gameId))
            { 
                DropDownItem newItem = null;
                foreach (DropDownItem item in this.GameListComboBox.Items)
                {
                    if (item.Value.Contains(gameId))
                    {
                        newItem = item;
                    }
                }
                var newIndex = this.GameListComboBox.Items.IndexOf(newItem);            
                SelectGameListDropDown(newIndex);
            }
        }

        /// <summary>
        /// Insert new cheat folder for specific game
        /// </summary>
        private void InsertNewCheatsFolder()
        {
            DialogResult res = InputBox.ShowGameIdBuildIdDialog(
                Resources.INSERT_GAME_BUILD_DIALOGUE_GAME_TITLE,
                Resources.INSERT_GAME_BUILD_DIALOGUE_GAMENAME_MESSAGE,
                Resources.INSERT_GAME_BUILD_DIALOGUE_GAMEID_MESSAGE,
                Resources.INSERT_GAME_BUILD_DIALOGUE_BUILDID_MESSAGE,
                InputBox.Buttons.OkCancel,
                Constants.DEFAULT_POPUP_DIALOGUE_TEXT_FONT);

            //Check InputBox result
            if (res == System.Windows.Forms.DialogResult.OK || res == System.Windows.Forms.DialogResult.Yes)
            {
                var returnValue = InputBox.ResultValue.Split("??");
                var gameName = returnValue[0].Trim();
                var gameId = returnValue[1].Trim().ToUpper();
                var buildId = returnValue[2].Trim().ToUpper();
                if (!Helper.ValidateGameName(gameName))
                {
                    ShowErrorMessage(Resources.DEFAULT_INSERT_NEW_CHEAT_FILE_NAME_INVALID_MESSAGE);
                }
                else if (!Helper.ValidateGameId(gameId))
                {
                    ShowErrorMessage(Resources.DEFAULT_INSERT_NEW_CHEAT_FILE_NAME_INVALID_MESSAGE);
                }
                else if (!Helper.ValidateBuildId(buildId))
                {
                    ShowErrorMessage(Resources.DEFAULT_INSERT_NEW_CHEAT_FILE_NAME_INVALID_MESSAGE);
                }
                else
                {
                    var newDirPath = Helper.GetPath(this.CurrentPath) + gameId;
                    var dir = new DirectoryInfo(newDirPath);
                    if (dir.Exists)
                    {
                        ShowErrorMessage(Resources.DEFAULT_INSERT_NEW_CHEATS_FOLDER_EXISTS_MESSAGE);
                    }
                    else
                    {
                        // Create folders
                        dir.Create();
                        var cheatsDir = new DirectoryInfo(Helper.GetCheatsPath(newDirPath));
                        cheatsDir.Create();
                        // Correct filename
                        var cFilename = Helper.GetCorrectedFilename(gameName);
                        // Insert new index file
                        var newCheatIndexFilePath = Helper.GetPath(newDirPath)
                            + Helper.GetTxtFileNameExtension(cFilename);
                        this.Versions = new Dictionary<string, string>();
                        InsertNewCheatVersionIntoInfoFile(newCheatIndexFilePath, buildId, Constants.DEFAULT_CHEAT_VERSION_NUMBER);

                        // Insert new cheat file
                        var newCheatFilePath = newDirPath + "\\cheats\\" + Helper.GetTxtFileNameExtension(buildId);
                        Action.SaveNewCheatFile(newCheatFilePath, cFilename, Constants.DEFAULT_CHEAT_VERSION_NUMBER);

                        ShowInformationMessage(String.Format(Resources.DEFAULT_INSERT_NEW_CHEATS_FOLDER_MESSAGE, cFilename, buildId, gameId), "Success", false);
                        UpdateDropdownComboBox(this.CurrentEditMode, this.CurrentPath);
                        SelectGameListDropDown(gameId);
                    }
                } //End of validation check
            }
        }

        /// <summary>
        /// Remove current cheat folder
        /// </summary>
        private void RemoveCurrentCheatFolder()
        { 
            var dirPath = GetSelectedDirectory();
            if (!Directory.Exists(dirPath))
            {
                ShowErrorMessage(Resources.DEFAULT_REMOVE_CURRENT_GAME_FOLDER_ERROR_MESSAGE);
                return;
            }

            DirectoryInfo dirInfo = new DirectoryInfo(dirPath);
            dirInfo.Delete(true);
            UpdateDropdownComboBox(this.CurrentEditMode, this.CurrentPath);
        }

        /// <summary>
        /// Insert new cheat
        /// </summary>
        private void InsertNewCheat()
        {
            DialogResult res = InputBox.ShowBuildIDVersionDialog(
                Resources.INSERT_BUILD_VERSION_DIALOGUE_VERSION_TITLE,
                Resources.EDIT_BUILD_VERSION_DIALOGUE_BUILD_MESSAGE,
                Resources.EDIT_BUILD_VERSION_DIALOGUE_VERSION_MESSAGE,
                InputBox.Icon.Question,
                InputBox.Buttons.OkCancel,
                Constants.DEFAULT_POPUP_DIALOGUE_TEXT_FONT);

            //Check InputBox result
            if (res == System.Windows.Forms.DialogResult.OK || res == System.Windows.Forms.DialogResult.Yes)
            {
                var returnValue = InputBox.ResultValue.Split("??");
                var buildId = returnValue[0].Trim().ToUpper();
                var version = returnValue[1].Trim();
                if (!Helper.ValidateBuildId(buildId))
                {
                    ShowErrorMessage(Resources.DEFAULT_INSERT_NEW_CHEAT_FILE_NAME_INVALID_MESSAGE);
                }
                else
                {
                    var selectedDir = GetSelectedDirectory();
                    var correctedPath = Helper.GetDirectoryPath(selectedDir);
                    var newCheatFilePath = Helper.GetCheatsPath(correctedPath) + Helper.GetTxtFileNameExtension(buildId);
                    var cheatFile = Helper.CheckCheatFileExist(newCheatFilePath);
                    if (cheatFile != null && cheatFile.Exists)
                    {
                        ShowErrorMessage(Resources.DEFAULT_INSERT_NEW_CHEAT_FILE_EXISTS_MESSAGE);
                    }
                    else
                    {
                        InsertNewCheatVersionIntoInfoFile(correctedPath, buildId, version);
                        var titleName = CurrentVersionFile != null ? CurrentVersionFile.Name.Substring(0, CurrentVersionFile.Name.Length - 4) : "xxxxxNewGamexxxxx";
                        Action.SaveNewCheatFile(newCheatFilePath, titleName, version);
                        ShowInformationMessage(String.Format(Resources.DEFAULT_INSERT_NEW_CHEAT_FILE_MESSAGE, buildId, version), "Success", false);
                        RefreshSelectedForm();
                    }
                } //End of validation check
            }
        }

        /// <summary>
        /// Remove this selected cheat
        /// </summary>
        public void RemoveSelectedCheat()
        {
            var path = this.CurrentOpenFilePath;
            FileInfo file = new FileInfo(path);
            if (!file.Exists)
            {
                ShowErrorMessage(Resources.DEFAULT_REMOVE_SELECTED_CHEAT_FILE_ERROR_MESSAGE);
                return;
            }

            // Show confirmmessage 
            string msg = string.Format(Resources.DEFAULT_CONFIRM_MESSAGE_TO_REMOVE_SELECTED_CHEAT, path);
            DialogResult result = MessageBox.Show(msg,
                Resources.QUESTION_MESSAGE_TITLE_CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.Yes))
            {
                var filename = file.Name;
                file.Delete();
                var selectedDir = GetSelectedDirectory();
                var correctedPath = Helper.GetDirectoryPath(selectedDir);
                RemoveCheatVersionFromInfoFile(correctedPath, Helper.GetTxtFileBuildId(filename));
                RefreshSelectedForm();
            }
        }

        /// <summary>
        /// Update cheat filename and corresponding version in the index file.
        /// </summary>
        /// <param name="buildname"></param>
        private void UpdateCheatsTitle(string buildname)
        {
            var cheatFilePath = string.IsNullOrEmpty(buildname) ? string.Empty : GetSelectedDirectory() + "\\cheats\\" + buildname;
            var cheatFile = Helper.CheckCheatFileExist(cheatFilePath);
            
            if (cheatFile == null)
            {
                ShowErrorMessage(Resources.DEFAULT_INVALID_CHEAT_FILE_MESSAGE);
            }
            else
            {
                var buildId = Helper.GetTxtFileBuildId(buildname);
                var version = this.Versions != null && this.Versions.ContainsKey(buildId) ? this.Versions[buildId] : String.Empty;

                DialogResult res = InputBox.ShowBuildIDVersionDialog(
                    Resources.EDIT_BUILD_VERSION_DIALOGUE_VERSION_TITLE,
                    Resources.EDIT_BUILD_VERSION_DIALOGUE_BUILD_MESSAGE,
                    Resources.EDIT_BUILD_VERSION_DIALOGUE_VERSION_MESSAGE,
                    InputBox.Icon.Question,
                    InputBox.Buttons.OkCancel,
                    Constants.DEFAULT_POPUP_DIALOGUE_TEXT_FONT,
                    buildId,
                    version);

                if (res == System.Windows.Forms.DialogResult.OK || res == System.Windows.Forms.DialogResult.Yes)
                {
                    var returnValue = InputBox.ResultValue.Split("??");
                    var nBuildId = returnValue[0].Trim().ToUpper();
                    var nVersion = returnValue[1].Trim();
                    // TODO : Verify build id
                    if (!Helper.ValidateBuildId(nBuildId))
                    {
                        ShowErrorMessage(Resources.DEFAULT_INSERT_NEW_CHEAT_FILE_NAME_INVALID_MESSAGE);
                    }
                    else
                    {
                        var selectedDir = GetSelectedDirectory();
                        var newCheatFilePath = selectedDir + "\\cheats\\" + nBuildId + Constants.TXT_FILE_SUFFIX;
                        InsertNewCheatVersionIntoInfoFile(selectedDir, nBuildId, nVersion, buildId, version);
                        if (nBuildId != buildId)
                        {
                            cheatFile.MoveTo(newCheatFilePath);
                            ShowInformationMessage(String.Format(Resources.DEFAULT_UPDATE_EXISTING_CHEAT_FILE_MESSAGE, buildId, nBuildId, nVersion), "Success", false);
                        }
                        RefreshSelectedForm();
                    }
                }
            }
        }

        /// <summary>
        /// Insert new cheat contents into file by given buildId - version mapping.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="nBuildId">New build id.</param>
        /// <param name="nVersion">New version.</param>
        /// <param name="oBuildId">Old build id to be replaced.</param>
        /// <param name="oVersion">Old version to be replaced.</param>
        private void InsertNewCheatVersionIntoInfoFile(string path, string nBuildId, string nVersion, string oBuildId = null, string oVersion = null)
        {
            var infoFile = Helper.CheckInfoFileExist(path);
            var contents = new StringBuilder();
            if (this.Versions == null || this.Versions.Count == 0)
            {
                // TODO
                this.Versions = new Dictionary<string, string>();
            }

            if (!String.IsNullOrEmpty(oBuildId))
            { 
                this.Versions.Remove(oBuildId);
            }

            if (!this.Versions.ContainsValue(nVersion))
            {
                this.Versions.Add(nBuildId, nVersion);
            }

            // Sort version number
            List<string> values = new List<string>();
            values.AddRange(this.Versions.Values);
            values.Sort();

            for (var i = 0; i < values.Count; i++)
            {
                string line = values[i].Equals(nVersion)
                    ? nBuildId + "\t" + nVersion
                    : this.Versions.First(kv => kv.Value.Equals(values[i])).Key + "\t" + values[i];
                contents.Append(line + "\n");
            }

            string fileName = "New Game Cheats Version File.txt";
            // Fullpath. You can direct hardcode it if you like.  
            string fullPath = infoFile != null 
                ? infoFile.FullName 
                : (path.EndsWith(Constants.TXT_FILE_SUFFIX) 
                    ? path : path + fileName);

            // Write array of strings to a file using WriteAllLines.  
            // If the file does not exists, it will create a new file.  
            // This method automatically opens the file, writes to it, and closes file  
            using (StreamWriter sw = new StreamWriter(File.Open(fullPath, FileMode.Create), Encoding.ASCII))
            {
                sw.Write(contents);
            }
        }

        /// <summary>
        /// Insert new cheat contents into file by given buildId - version mapping.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="buildId">build id</param>
        private void RemoveCheatVersionFromInfoFile(string path, string buildId)
        {
            var infoFile = Helper.CheckInfoFileExist(path);
            if (!infoFile.Exists)
            {
                return;
            }

            var contents = new StringBuilder();
            if (this.Versions == null || this.Versions.Count == 0)
            {
                this.Versions = new Dictionary<string, string>();
            }

            if (!String.IsNullOrEmpty(buildId) && this.Versions.ContainsKey(buildId))
            {
                this.Versions.Remove(buildId);
            }

            // Sort version number
            List<string> values = new List<string>();
            values.AddRange(this.Versions.Values);
            values.Sort();

            for (var i = 0; i < values.Count; i++)
            {
                string line = this.Versions.First(kv => kv.Value.Equals(values[i])).Key + "\t" + values[i];
                contents.Append(line + "\n");
            }

            using (StreamWriter sw = new StreamWriter(File.Open(infoFile.FullName, FileMode.Create), Encoding.ASCII))
            {
                sw.Write(contents);
            }
        }

        /// <summary>
        /// Insert new SubSection block into current open textfile.
        /// </summary>
        private void InsertNewSubSectionBlockIntoCurrentCheat()
        {
            DialogResult res = InputBox.InputSubSectionNameDialog(
                Resources.INSERT_SUBSECTION_DIALOGUE_TITLE,
                Resources.INSERT_SUBSECTION_DIALOGUE_LABEL,
                InputBox.Icon.Question,
                InputBox.Buttons.OkCancel,
                Constants.DEFAULT_POPUP_DIALOGUE_TEXT_FONT);

            //Check InputBox result
            if (res == System.Windows.Forms.DialogResult.OK || res == System.Windows.Forms.DialogResult.Yes)
            {
                var returnValue = InputBox.ResultValue.Trim();

                var text = this.CodeTextBox.Text;
                text += SubCheat.OutputSubSectionBlock(returnValue);
                SaveContentsIntoSelectedFile(text);
                RefreshSelectedForm();
            }
        }

        /// <summary>
        /// Highlight cheat title, subsection and other stuffs.
        /// </summary>
        private void HighlightCheatTitleSection()
        {
            var lPos = -1;
            var isSubSection = false;
            var isSubStart = false;
            var context = this.CodeTextBox.Text;
            var contextLength = this.CodeTextBox.TextLength;
            for (var index = 0; index < contextLength; index++)
            {
                if (index + 3 < contextLength && context.Substring(index, 3) == "[--")
                {
                    if (context.Substring(index, 15) == "[--SectionStart")
                    {
                        isSubStart = true;
                    }
                    else
                    {
                        isSubStart = false;
                    }
                    lPos = index;
                    isSubSection = true;
                }
                else if (context.Substring(index, 1) == "[")
                {
                    lPos = index;
                    isSubSection = false;
                }
                else if (lPos >= 0 && context.Substring(index, 1) == "]")
                {
                    this.CodeTextBox.SelectionStart = lPos;
                    this.CodeTextBox.SelectionLength = index - lPos + 1;
                    this.CodeTextBox.SelectionBackColor = 
                        isSubSection 
                            ? isSubStart 
                                ? Configs.SectionStartColor 
                                : Configs.SectionEndColor
                            : Configs.TitleColor;
                    lPos = -1;
                }
            }
        }

        /// <summary>
        /// Function to scroll to specific postition based on certain keywords.
        /// </summary>
        /// <param name="keywords"></param>
        private void ScrollToSpecificPosition(string keywords)
        {
            //CodeTextBox.AutoScrollOffset = new Point(Math.Abs(CodeTextBox.Width / 2), CodeTextBox.Height / 2);
            if (string.IsNullOrEmpty(keywords))
            {
                this.CodeTextBox.Select(0, 0);
                this.CodeTextBox.ScrollToCaret();
                this.CodeTextBox.SelectionStart = 0;
                this.CodeTextBox.SelectionLength = 0;
                return;
            }

            var index = this.CodeTextBox.Text.IndexOf(keywords);
            if (index >= 0)
            {
                this.CodeTextBox.Select(index, index + keywords.Length);
                this.CodeTextBox.ScrollToCaret();
                this.CodeTextBox.SelectionStart = index;
                this.CodeTextBox.SelectionLength = 0;
            }
        }

        /// <summary>
        /// Function to Add sub section cheats block based on the given cheat file.
        /// </summary>
        /// <param name="cheats"></param>
        private void UpdateSubCheatsSectionOnPanel(CheatFile cheats)
        {
            ResetSubCheatsSection();
            this.SubCheatsGroupBox.Visible = true;
            int index = 0;
            Panel tempPanel = new Panel();
            tempPanel.Size = new Size(760, 930);
            tempPanel.Location = new Point(5, 30);
            tempPanel.AutoScroll = true;
            foreach (var cheat in cheats.SubCheats)
            {
                GroupBox tempGroupBox = new GroupBox();
                tempGroupBox.Name = "SubCheatsGroupBox_" + index;
                //tempGroupBox.Text = "#" + index;
                tempGroupBox.Size = new Size(350, 275);
                //tempGroupBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                tempGroupBox.Location = new Point(10 + index % 2 * 360, index / 2 * 280);

                // Add subsection title
                TextBox tempTextBox = new TextBox();
                tempTextBox.ReadOnly = true;
                tempTextBox.Name = "SubCheatsTextBox_" + index;
                tempTextBox.Location = new Point(15, 30);
                tempTextBox.Text = cheat.SubTile;
                tempTextBox.TextAlign = HorizontalAlignment.Center;
                tempTextBox.BackColor = Configs.SectionStartColor;
                tempTextBox.Size = new Size(320, 25);
                tempTextBox.TabIndex = 100 + index;

                // Add subsection contents
                ListBox tempListBox = new ListBox();
                tempListBox.Name = "SubCheatsListBox_" + index;
                tempListBox.Location = new Point(15, 75);
                //tempListBox.View = View.List;
                //tempListBox.FullRowSelect = true;
                if (cheat?.Cheats?.Count > 0)
                {
                    foreach (var cb in cheat.Cheats)
                    {
                        tempListBox.Items.Add(cb.CodeTitle);
                        tempListBox.Click += new System.EventHandler(PanelSubSectionItem_Click);
                    }
                }
                
                tempListBox.Size = new Size(320, 200);
                tempGroupBox.Controls.Add(tempTextBox);
                tempGroupBox.Controls.Add(tempListBox);
                // attach event handler for Click event 
                // (assuming ButtonClickHandler is an existing method in the class)
                //myButton.Click += ButtonClickHandler;
                tempPanel.Controls.Add(tempGroupBox);


                index++;
            }

            SubCheatsGroupBox.Controls.Add(tempPanel);
        }

        /// <summary>
        /// Function to add whole cheats into listbox
        /// </summary>
        private void UpdateMainCheatsSectionOnPanel(CheatFile cheats)
        {
            ResetSubCheatsSection();
            this.SubCheatsGroupBox.Visible = true;

            Panel tempPanel = new Panel();
            tempPanel.Size = new Size(760, 880);
            tempPanel.Location = new Point(10, 30);
            //tempPanel.AutoScroll = true;
            
            // Add subsection contents
            ListBox tempListBox = new ListBox();
            tempListBox.Name = "MainCheatsListBox";
            tempListBox.Location = new Point(20, 20);
            tempListBox.Size = new Size(400, 600);
            tempListBox.BorderStyle = BorderStyle.Fixed3D;
            foreach (var cheat in cheats.Cheats)
            {
                tempListBox.Items.Add(cheat.CodeTitle);
                tempListBox.Click += new System.EventHandler(PanelSubSectionItem_Click);
            }
            
            tempPanel.Controls.Add(tempListBox);
            SubCheatsGroupBox.Controls.Add(tempPanel);
        }


        /// <summary>
        /// Open version index edit form.
        /// </summary>
        private void OpenVersionIndexEditForm()
        {
            if (IsTextContentsChanged())
            {
                ShowInformationMessage(Resources.DEFAULT_SAVE_FILE_FIRST_WARNING_MESSAGE, "Warning", false);
            }
            else
            {
                if (this.CurrentVersionFileMode == VersionFileMode.Edit)
                {
                    this.Hide();
                    EditVersionIndexForm editForm = new EditVersionIndexForm(Helper, Action, CurrentCulture);
                    editForm.FormClosed += new FormClosedEventHandler(EditVersionIndexForm_FormClosed);
                    editForm.Show();
                }
            }
        }

        /// <summary>
        /// Open options form.
        /// </summary>
        private void OpenOptionsForm()
        {
            this.Hide();
            SettingsForm settingsForm = new SettingsForm(Helper, Action, CurrentCulture);
            settingsForm.FormClosed += new FormClosedEventHandler(OptionsForm_FormClosed);
            settingsForm.Show();
        }

        /// <summary>
        /// Open about form.
        /// </summary>
        private void OpenAboutForm()
        {
            this.Hide();
            AboutForm aboutForm = new AboutForm(Helper, Action, CurrentCulture);
            aboutForm.FormClosed += new FormClosedEventHandler(AboutForm_FormClosed);
            aboutForm.Show();
        }
        #endregion

        #region ButtonClickEvents

        private void DefaultFolderOpenButton_Click(object sender, EventArgs e)
        {
            InitializeForm();
            if (String.IsNullOrEmpty(Configs.InputFolder))
            {
                ShowErrorMessage(Resources.DEFAULT_DEFAULT_INPUT_FOLDER_NOT_SET_MESSAGE);
            }
            else
            {
                var defaultPath = Configs.InputFolder;
                this.CurrentPath = defaultPath;
                this.GamesList = Action.LoadGamesDBFile(defaultPath);
                UpdateDropdownComboBox(DirectoryMode.ListMode, defaultPath);
                ResetFilterKeyword();
            }
        }
        private void MainMenuOpenButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            //dialog.Description = "Open Cheat Files Directory ...";            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var errorMesage = string.Empty;
                var mode = Helper.CheckDirectory(dialog.SelectedPath, out errorMesage);
                if (mode == DirectoryMode.ListMode)
                {
                    this.CurrentPath = dialog.SelectedPath;
                    if (string.IsNullOrEmpty(Configs.InputFolder))
                    {
                        Configs.InputFolder = dialog.SelectedPath;
                        Action.SaveDefinedPathsConfig(Configs);
                    }
                    
                    this.GamesList = Action.LoadGamesDBFile(dialog.SelectedPath);
                    UpdateDropdownComboBox(DirectoryMode.ListMode, dialog.SelectedPath);
                }
                else if (mode == DirectoryMode.SingleMode)
                {
                    this.CurrentPath = dialog.SelectedPath;
                    var correctedPath = Helper.GetCheatsPath(dialog.SelectedPath);
                    UpdateDropdownComboBox(DirectoryMode.SingleMode, correctedPath);
                }
                else
                {
                    ShowErrorMessage(string.Format(Resources.DEFAULT_FILES_NOT_LOADED_CORRECTLY_MESSAGE, errorMesage));
                }

                //ReadSelectedFile();
                //this.PathLabel.Text = Path.GetFileName(dialog.SelectedPath);
                ResetFilterKeyword();
            }

        }
        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "Text|*.txt";
            saveFileDialog.Filter = "Txt file (*.txt)|*.txt|All files (*.*)|*.*";
            //saveFileDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog.Title = Resources.SAVE_DIALOGUE_TITLE;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ShowInformationMessage(string.Format(Resources.DEFAULT_SAVE_NOTIFICATION_MESSAGE, saveFileDialog.FileName),
                    Resources.INFORMATION_MESSAGE_TITLE_SAVE, false);
                File.WriteAllText(saveFileDialog.FileName, this.CodeTextBox.Text);
            }
        }
        private void OptionsButton_Click(object sender, EventArgs e) => OpenOptionsForm();
        private void AboutButton_Click(object sender, EventArgs e) => OpenAboutForm();
        private void InsertNewCheatsButton_Click(object sender, EventArgs e) => InsertNewCheatsFolder();
        private void RemoveFolderButton_Click(object sender, EventArgs e) => RemoveCurrentCheatFolder();

        private void OpenFolderButton_Click(object sender, EventArgs e)
        {
            Action.OpenGameDirectory(this.CurrentGamePath);
        }
        private void VersionFileModeUpdateButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = this.GameListComboBox.SelectedIndex;
            if (this.CurrentVersionFileMode == VersionFileMode.Create)
            {
                if (this.GameNameTextBox.Text.Length > 5)
                {
                    DialogResult result = MessageBox.Show(
                        String.Format(Resources.DEFAULT_CONFIRM_MESSAGE_CREATE_NEW_VERSION_FILE, this.GameNameTextBox.Text),
                        Resources.DEFAULT_CONFIRM_MESSAGE_CREATE_NEW_VERSION_INDEX, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (result.Equals(DialogResult.Yes))
                    {
                        var selectedDir = GetSelectedDirectory();
                        var cFilename = Helper.GetCorrectedFilename(this.GameNameTextBox.Text.Trim());
                        var newCheatFilePath = selectedDir + Helper.GetTxtFileNameExtension(cFilename);
                        Action.SaveNewCheatIndexFile(newCheatFilePath);
                        UpdateDropdownComboBox(this.CurrentEditMode, this.CurrentPath);
                        SelectGameListDropDown(selectedIndex);
                    }
                }
            }
            else if (this.CurrentVersionFileMode == VersionFileMode.Edit)
            {
                var cFilename = Helper.GetCorrectedFilename(this.GameNameTextBox.Text.Trim());
                var inputName = Helper.GetTxtFileNameExtension(cFilename);
                if (inputName.Length > 5 && !inputName.Equals(CurrentVersionFile.Name))
                {
                    DialogResult result = MessageBox.Show(
                        String.Format(Resources.DEFAULT_CONFIRM_MESSAGE_UPDATE_EXISTING_VERSION_FILE, CurrentVersionFile.Name, inputName),
                        "Update existing version index file",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result.Equals(DialogResult.Yes))
                    {
                        CurrentVersionFile.MoveTo(Helper.GetPath(CurrentVersionFile.DirectoryName) + inputName);
                        //SaveNewCheatIndexFile(newCheatFilePath);
                        UpdateDropdownComboBox(this.CurrentEditMode, this.CurrentPath);
                        SelectGameListDropDown(selectedIndex);
                    }
                }
                else if (inputName.Length > 5)
                {
                    OpenVersionIndexEditForm();
                }
            }

        }
        private void CopyFolderButton_Click(object sender, EventArgs e)
        {
            if (!Configs.HasOutputFolder())
            {
                ShowErrorMessage(Resources.DEFAULT_DEFAULT_OUTPUT_FOLDER_NOT_SET_MESSAGE);
            }
            else
            {
                DialogResult result = MessageBox.Show(Resources.DEFAULT_CONFIRM_MESSAGE_FOR_COPY_FOLDER, 
                    Resources.QUESTION_MESSAGE_TITLE_CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result.Equals(DialogResult.Yes))
                {
                    var dirPath = Helper.GetDirectoryPath(GetSelectedCheatPath());
                    DirectoryInfo dir = new DirectoryInfo(dirPath);
                    DirectoryInfo destDir = new DirectoryInfo(Configs.OutputFolder);
                    if (dir.Exists && destDir.Exists)
                    {
                        var destPath = Configs.OutputFolder + dir.Name;
                        Action.DirectoryCopy(dir.FullName, destPath, true);
                        ShowInformationMessage(string.Format(Resources.DEFAULT_COPY_FOLDER_DESTINATION_SUCCESS, destPath),
                            Resources.INFORMATION_MESSAGE_TITLE_RESULT, false);
                    }
                    else
                    {
                        ShowErrorMessage(Resources.DEFAULT_COPY_FOLDER_DESTINATION_FAILURE);
                    }
                }
            }
        }

        private void AscendingOrderButton_Click(object sender, EventArgs e) => RefreshSelectedForm(isDescendingOrder: false);
        private void DescendingOrderButton_Click(object sender, EventArgs e) => RefreshSelectedForm(isDescendingOrder: true);
        private void InsertNewCheatButton_Click(object sender, EventArgs e) => InsertNewCheat();
        private void RemoveCheatButton_Click(object sender, EventArgs e) => RemoveSelectedCheat();
        private void FormatFilesButton_Click(object sender, EventArgs e) => FormatFileNamesUnderCurrentPath();

        private void SaveOriginalButton_Click(object sender, EventArgs e)
        {
            if (this.CodeTextBox.Enabled)
            {
                var selectedIndex = this.CodeSelectorListBox.SelectedIndex;
                SaveContentsIntoSelectedFile(this.CodeTextBox.Text);
                ShowInformationMessage(string.Format(Resources.DEFAULT_SAVE_NOTIFICATION_MESSAGE, this.CurrentOpenFilePath),
                    Resources.INFORMATION_MESSAGE_TITLE_SAVE);
                SelectCodeSelectorListBox(selectedIndex);
            }
        }
        // Copy cheat file to the directory
        private void CopyFileButton_Click(object sender, EventArgs e)
        {
            if (!Configs.HasOutputFolder())
            {
                ShowErrorMessage(Resources.DEFAULT_DEFAULT_OUTPUT_FOLDER_NOT_SET_MESSAGE);
            }
            else
            {
                DialogResult result = MessageBox.Show(Resources.DEFAULT_CONFIRM_MESSAGE_FOR_COPY_FILE, 
                    Resources.QUESTION_MESSAGE_TITLE_CONFIRM, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result.Equals(DialogResult.Yes))
                {
                    FileInfo file = new FileInfo(this.CurrentOpenFilePath);
                    DirectoryInfo destDir = new DirectoryInfo(Configs.OutputFolder);

                    if (!file.Exists)
                    {
                        ShowErrorMessage(Resources.DEFAULT_COPY_FILE_NOT_EXIST_FAILURE);
                    }
                    else if (!destDir.Exists && !destDir.Parent.Exists)
                    {
                        // IF SD card hasn't been inserted but the folder does not exist
                        ShowErrorMessage(Resources.DEFAULT_COPY_FILE_DESTINATION_FAILURE);
                    }
                    else
                    {
                        var subPath = file.FullName;
                        subPath = subPath.Substring(0, subPath.LastIndexOf('\\'));
                        subPath = subPath.Substring(0, subPath.LastIndexOf('\\'));
                        subPath = subPath.Substring(subPath.LastIndexOf('\\') + 1);
                        var destPath = Configs.OutputFolder + subPath + "\\cheats\\";
                        destDir = new DirectoryInfo(destPath);

                        if (!destDir.Exists)
                        {
                            destDir.Create();
                        }
                        File.Copy(file.FullName, destPath + file.Name, true);
                        ShowInformationMessage(String.Format(Resources.DEFAULT_COPY_FILE_DESTINATION_SUCCESS, destPath + file.Name),
                            Resources.INFORMATION_MESSAGE_TITLE_RESULT, false);
                    }
                }
            }
        }
        private void InsertNewSubSectionBlockButton_Click(object sender, EventArgs e) => InsertNewSubSectionBlockIntoCurrentCheat();

        private void UpdateCheatContentsInTextBoxButton_Click(object sender, EventArgs e)
        {
            var updatedContents = new CheatFile(this.CodeTextBox.Text, this.CurrentOpenFilePath);

            /** Hide the whole section and update **/
            /**
            this.CodeModifiedTextBox.Enabled = true;
            this.CodeModifiedTextBox.Text = updatedContents.Output();
            this.SaveFormatedButton.Enabled = true;
            */
            var selectedIndex = this.CodeSelectorListBox.SelectedIndex;
            SaveContentsIntoSelectedFile(updatedContents.Output());
            ShowInformationMessage(string.Format(Resources.DEFAULT_SAVE_NOTIFICATION_MESSAGE, this.CurrentOpenFilePath), 
                Resources.INFORMATION_MESSAGE_TITLE_SAVE);

            SelectCodeSelectorListBox(selectedIndex);
        }

        private void PanelSubSectionItem_Click(object sender, EventArgs e)
        {
            string contents = (string)((ListBox)sender).SelectedItem;
            ScrollToSpecificPosition(contents);
        }

        private void CloseApplication(object sender, EventArgs e) => Application.Exit();

        private void PreviewImage_DoubleClick(object sender, EventArgs e)
        { 
            Action.OpenGameDirectoryFromImage(this.CurrentGamePath, this.CurrentPreviewImage);
            RefreshSelectedForm();
        }

        private void OptionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Configs = (sender as SettingsForm).Configs;
            Action.SaveDefinedPathsConfig(this.Configs);
            this.Show();
            if (!String.IsNullOrEmpty(this.CurrentPath))
            {
                this.RefreshSelectedForm();
            }
            InitializeStatusBar();
        }

        private void AboutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void EditVersionIndexForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Versions = (sender as EditVersionIndexForm).Versions;
            this.Show();
            this.RefreshSelectedForm();
        }

        #endregion

        #region ItemChangedEvents

        private void GameListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshSelectedForm();
        }

        private void CodeSelectorListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (this.CodeSelectorListBox.SelectedItem != null)
            {
                var fileName = ((DropDownItem)this.CodeSelectorListBox.SelectedItem).Value;
                this.CurrentOpenFilePath = Helper.GetPath(this.CurrentGamePath) + fileName;

                var buildId = Helper.GetTxtFileBuildId(fileName);
                if (this.Versions.ContainsKey(buildId))
                {
                    this.VersionNumberTextBox.Text = this.Versions[buildId];
                }
                else
                {
                    this.VersionNumberTextBox.Text = Resources.DEFAULT_VERSION_NUMBER;
                }
                this.BuildIdTextBox.Text = buildId;
                ReadSelectedCheatFile(this.CurrentOpenFilePath);

                this.UpdateButton.Enabled = true;
                this.SaveOriginalButton.Enabled = true;
                //this.CodeModifiedTextBox.Text = string.Empty;
                //this.CodeModifiedTextBox.Enabled = false;
                EnableFileButtons();
            }
        }

        private void CodeSelectorListBox_DoubleClick(object sender, EventArgs e)
        {
            String filename = ((DropDownItem)((ListBoxEx)sender)?.SelectedItem)?.Value;
            UpdateCheatsTitle(filename);
        }

        private void GameNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.GameNameTextBox.Text.Length == 0)
            {
                this.VersionFileModeUpdateButton.Enabled = false;
            }
            else if (this.GameNameTextBox.Text.Length >= 5 && IsListMode())
            {
                if (this.CurrentVersionFileMode == VersionFileMode.Create)
                {
                    this.VersionFileModeUpdateButton.Enabled = true;
                }
                else if (this.CurrentVersionFileMode == VersionFileMode.Edit)
                {
                    this.VersionFileModeUpdateButton.Enabled = true;
                    var inputName = this.GameNameTextBox.Text + Constants.TXT_FILE_SUFFIX;
                    if (CurrentVersionFile != null)
                    {
                        if (CurrentVersionFile.Name.Equals(inputName))
                        {
                            this.VersionFileModeUpdateButton.Text = EnumMode.VersionFileModeText(VersionFileMode.Edit);
                        }
                        else
                        {
                            this.VersionFileModeUpdateButton.Text = EnumMode.VersionFileModeText(VersionFileMode.Update);
                        }
                    }
                }
            }
        }

        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateDropdownComboBox(this.CurrentEditMode, this.CurrentPath, FilterTextBox?.Text);
        }
        #endregion

        #region Helper

        /// <summary>
        /// Show Information message
        /// </summary>
        /// <param name="message">Message to show</param>
        /// <param name="title">Title of the message</param>
        /// <param name="refreshForm">If form need to be refreshed, by default yes.</param>
        private void ShowInformationMessage(string message, string title, bool refreshForm = true)
        {
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK) && refreshForm)
            {
                RefreshSelectedForm();
            }
        }

        private DialogResult ShowErrorMessage(string message)
            => MessageBox.Show(message, Resources.ERROR_MESSAGE_TITLE_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);

        private string GetSelectedCheatPath()
        {
            if (!this.CurrentPath.EndsWith("cheats"))
            {
                return Helper.GetCheatsPath(this.CurrentPath + "\\" + ((DropDownItem)this.GameListComboBox.SelectedItem).Value);

            }
            else
            {
                return this.CurrentPath;
            }
        }

        // Check if the current selected directory
        private string GetSelectedDirectory()
        {
            if (!this.CurrentPath.EndsWith("cheats"))
            {
                return Helper.GetDirectoryPath(this.CurrentPath + "\\" + ((DropDownItem)this.GameListComboBox.SelectedItem).Value);

            }
            else
            {
                return this.CurrentPath;
            }
        }

        private bool IsListMode() => this.CurrentEditMode == DirectoryMode.ListMode;
        private bool IsSingleMode() => this.CurrentEditMode == DirectoryMode.SingleMode;
        private bool IsTextContentsChanged() => String.Compare(
            this.CodeTextBox.Text.ReplaceLineEndings(),
            this.OriginalContents.ReplaceLineEndings()) != 0;

        #endregion

    }
}
