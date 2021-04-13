using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SwitchCheatCodeManager.CheatCode;
using SwitchCheatCodeManager.FormEntity;

namespace SwitchCheatCodeManager
{
    public partial class MainForm : Form
    {
        private string CurrentPath;
        private string CurrentGamePath;
        private Dictionary<string, string> Versions;
        private const int DEFAULT_CHEAT_FILE_NAME_LENGTH = 20;
        private const string DEFAULT_CODE_SELECTOR_LIST_BOX_MESSAGE = "No Available Files !!!";
        private const string DEFAULT_GAME_NAME_LABEL_TEXT = "Title not found";
        private const string DEFAULT_CODE_STATUS_LABEL_TEXT = "No code loaded";
        private const string DEFAULT_INVALID_DIRECTORY_MESSAGE = "Your selected directory is invalid";
        private const string DEFAULT_INSERT_NEW_CHEAT_FILE_MESSAGE = "Successfully inserted {0}.txt as v{1}";
        private const string DEFAULT_CONVERT_FILES_MESSAGE = "Successfully converted {0} files, failed {1} files.";
        private const string DEFAULT_CONFIRM_MESSAGE_FOR_FORMAT_FILE_NAMES = "Are you sure you wanna formulate file names?";
        private const string DEFAULT_VERSION_NUMBER = "N/A";
        private const string DEFAULT_SAVE_NOTIFICATION_Message = "Your file successfully saved to: ";

        private string OriginalContents;
        private FileInfo VersionFile;
        private string CurrentOpenFilePath;
        private CheatFile CheatFile;
        private Image PreviewImage;

        public enum DirectoryMode { SingleMode, ListMode, OtherMode };
        private DirectoryMode CurrentMode = DirectoryMode.OtherMode;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void DefaultSaveFolderOpen(object sender, EventArgs e)
        {
            string defaultPath = "D:\\Games\\NS\\CheatsDB\\MyCheats";
            this.CurrentPath = defaultPath;
            UpdateComboBox(DirectoryMode.ListMode, defaultPath);
        }

        private void MainMenuOpen(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            //dialog.Description = "Open Cheat Files Directory ...";
            //dialog.InitialDirectory = @"c:\";   //@是取消转义字符的意思
            //dialog.Filter = "All files（*.*）|*.*|All files(*.*)|*.* ";
            //dialog.ShowDialog();
            /*
             *如果值为false，那么下一次选择文件的初始目录是上一次你选择的那个目录，
             *不固定；如果值为true，每次打开这个对话框初始目录不随你的选择而改变，是固定的  
             */
            //dialog.RestoreDirectory = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                var mode = CheckDirectory(dialog.SelectedPath);
                if (mode == DirectoryMode.ListMode)
                {
                    this.CurrentPath = dialog.SelectedPath;
                    UpdateComboBox(DirectoryMode.ListMode, dialog.SelectedPath);
                }
                else if (mode == DirectoryMode.SingleMode)
                {
                    this.CurrentPath = dialog.SelectedPath;
                    var correctedPath = GetCheatsPath(dialog.SelectedPath);
                    UpdateComboBox(DirectoryMode.SingleMode, correctedPath);
                }
                else
                { 
                }                

                //ReadSelectedFile();
                //this.PathLabel.Text = Path.GetFileName(dialog.SelectedPath);
            }

        }

        private void UpdateComboBox(DirectoryMode mode, string path)
        {
            if (mode == DirectoryMode.SingleMode)
            {
                this.CurrentMode = DirectoryMode.SingleMode;
                DirectoryInfo dir = new DirectoryInfo(path);
                this.CurrentGamePath = path;

                var infoFile = CheckInfoFileExist(GetDirectoryPath(path));
                var dropdownItem = new DropDownItem()
                {
                    Value = dir.Name,
                    Text = dir.Parent.Name + (infoFile != null ? " - " + GetTxtFileName(infoFile.Name) : ""),
                };

                this.GameListComboBox.Items.Add(dropdownItem);
                this.GameListComboBox.SelectedIndex = 0;
                this.GameListComboBox.Enabled = false;
                RefreshForm(path);
            }
            else if (mode == DirectoryMode.ListMode)
            {
                this.CurrentMode = DirectoryMode.ListMode;
                DirectoryInfo dir = new DirectoryInfo(path);
                DirectoryInfo[] titles = dir.GetDirectories();
                this.GameListComboBox.Items.Clear();
                foreach (var title in titles)
                {
                    var infoFile = CheckInfoFileExist(title.FullName);
                    var dropdownItem = new DropDownItem()
                    {
                        Value = title.Name,
                        Text = title.Name + (infoFile != null ? " - " + GetTxtFileName(infoFile.Name) : ""),
                    };
                    this.GameListComboBox.Items.Add(dropdownItem);
                }
                this.GameListComboBox.Enabled = true;
                this.GameListComboBox.SelectedIndex = 0;
                var correctedPath = GetCheatsPath(path + "\\" + ((DropDownItem)this.GameListComboBox.SelectedItem).Value);

                RefreshForm(correctedPath);

                this.CurrentGamePath = correctedPath;
            }

        }

        private DirectoryMode CheckDirectory(string selectedPath)
        {
            DirectoryInfo dir = new DirectoryInfo(selectedPath);
            if (dir.Name.Equals("cheats"))
            {
                return DirectoryMode.SingleMode;
            }

            DirectoryInfo[] titles = dir.GetDirectories();
            bool isListMode = true;
            bool isSingleMode = false;
            foreach (var title in titles)
            {
                if (title.Name.StartsWith("010") || title.Name.ToUpper().StartsWith("05C") || title.Name.ToUpper().StartsWith("35F"))
                {
                    // DO STH
                }
                else if (title.Name.Equals("cheats"))
                {
                    isSingleMode = true;
                }
                else
                {
                    isListMode = false;
                }
            }

            return isSingleMode ? DirectoryMode.SingleMode : isListMode ? DirectoryMode.ListMode : DirectoryMode.OtherMode;
        }

        private FileInfo CheckInfoFileExist(string path)
        {
            DirectoryInfo cheatFileDir = new DirectoryInfo(path);

            if (cheatFileDir.Exists)
            {
                FileInfo[] titles = cheatFileDir.GetFiles();
                var file = titles?.FirstOrDefault(t => t.Extension.Equals(".txt"));
                if (file?.Name?.Length > 4)
                {
                    return file;
                }
            }
            return null;
        }

        private FileInfo CheckCheatFileExist(string path)
        {
            FileInfo file = new FileInfo(path);
            if (file.Exists)
            {
                return file;
            }

            return null;
        }

        private FileInfo CheckImageExist(string path)
        {
            DirectoryInfo cheatFileDir = new DirectoryInfo(path);

            if (cheatFileDir.Exists)
            {
                FileInfo[] titles = cheatFileDir.GetFiles();
                var image = titles?.FirstOrDefault(t => t.Extension.Equals(".jpg") || t.Extension.Equals(".png"));
                if (image?.Name?.Length > 4)
                {
                    return image;
                }
            }
            return null;
        }

        private void RefreshForm(string correctedPath)
        {
            InitializeForm();
            this.PathTextBox.Text = this.CurrentPath;
            DirectoryInfo dir = new DirectoryInfo(correctedPath);
            if (dir.Exists)
            {
                // Check the game title
                var cheatFileDirPath = correctedPath.Substring(0, correctedPath.Length - 8);
                var cheatFileDir = new DirectoryInfo(cheatFileDirPath);
                
                if (cheatFileDir.Exists)
                {
                    var file = CheckInfoFileExist(cheatFileDirPath);
                    var image = CheckImageExist(cheatFileDirPath);
                    var title = file?.Name;
                    GameNameTextBox.Text = file != null ? GetTxtFileName(title) : DEFAULT_GAME_NAME_LABEL_TEXT;
                    if (file != null)
                    {
                        this.VersionFile = file;
                        this.Versions = LoadVersionFile(file.FullName);
                    }
                    if (image != null)
                    {
                        Image prevImg = Image.FromFile(image.FullName);
                        this.previewImage.Image = prevImg;
                        this.PreviewImage = prevImg;
                    }
                }
                else
                {
                    GameNameTextBox.Text = DEFAULT_GAME_NAME_LABEL_TEXT;
                }

                // Load files
                FileInfo[] files = dir.GetFiles();
                List<String> filenames = new List<string>();
                if (files.Length > 0)
                {
                    foreach (FileInfo fi in files)
                    {
                        if (fi.Extension.Equals(".txt") && fi.Name.Length == DEFAULT_CHEAT_FILE_NAME_LENGTH)
                        {
                            filenames.Add(fi.Name);
                        }
                    }
                }

                if (filenames.Count > 0)
                {
                    this.CodeSelectorListBox.Enabled = true;
                    this.FormatFilesButton.Enabled = true;
                    this.InsertNewCheatButton.Enabled = true;

                    var sortedFileNames = new List<string>();
                    List<string> values = new List<string>();
                    values.AddRange(this.Versions.Values);
                    values.Sort();

                    for (var i = 0; i < values.Count; i++)
                    {
                        var key = this.Versions.First(kv => kv.Value.Equals(values[i])).Key + ".txt";
                        if (filenames.Contains(key))
                        {
                            filenames.Remove(key);
                            sortedFileNames.Add(key);
                        }
                    }
                    sortedFileNames.AddRange(filenames);

                    foreach (var filename in sortedFileNames)
                    {
                        var displayName = filename.Substring(0, DEFAULT_CHEAT_FILE_NAME_LENGTH - 4);
                        this.CodeSelectorListBox.Items.Add(displayName);
                    }
                }
                else
                {
                    this.CodeSelectorListBox.Items.Add(DEFAULT_CODE_SELECTOR_LIST_BOX_MESSAGE);
                }
            }
            else
            {
                ShowErrorMessage();
            }
        }

        private void InitializeForm()
        {
            this.CheatFile = new CheatFile();
            this.OriginalContents = string.Empty;
            this.VersionFile = null;

            this.CodeTextBox.Text = String.Empty;
            this.CodeTextBox.Enabled = false;
            this.CodeSelectorListBox.Items.Clear();
            this.CodeSelectorListBox.Enabled = false;

            this.CodeModifiedTextBox.Text = String.Empty;
            this.CodeModifiedTextBox.Enabled = false;

            InitializeButtons();

            //this.PathTextBox.Focus();
            this.GameNameTextBox.Text = DEFAULT_GAME_NAME_LABEL_TEXT;
            this.CodeStatusLabel.Text = DEFAULT_CODE_STATUS_LABEL_TEXT;
            this.CodeStatusLabel.BackColor = System.Drawing.Color.Empty;

            this.Versions = new Dictionary<string, string>();
            this.VersionNumberTextBox.Text = DEFAULT_VERSION_NUMBER;
        }

        private void InitializeButtons()
        {
            this.UpdateButton.Enabled = false;
            this.FormatFilesButton.Enabled = false;
            this.InsertNewCheatButton.Enabled = false;
            this.SaveOriginalButton.Enabled = false;
            this.SaveFormatedButton.Enabled = false;
        }

        private void FormatFileNames()
        {
            // Show confirmmessage 
            DialogResult result = MessageBox.Show(DEFAULT_CONFIRM_MESSAGE_FOR_FORMAT_FILE_NAMES, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.Yes))
            {
                var dirPath = GetDirectoryPath(GetSelectedCheatPath());
                DirectoryInfo dir = new DirectoryInfo(dirPath);
                if (dir.Exists && !dir.Name.Equals(dir.Name.ToUpper()))
                {
                    var updatedPath = GetPath(dir.Parent.ToString()) + dir.Name.ToUpper();
                    dir.MoveTo(updatedPath + "_TEMP");
                    dir.MoveTo(updatedPath);
                    //this.CurrentPath = updatedPath;
                }

                var correctedPath = GetCheatsPath(GetSelectedCheatPath());
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
                            if (fi.Extension.Equals(".txt") && fi.Name.Length == DEFAULT_CHEAT_FILE_NAME_LENGTH)
                            {
                                String originalContents = File.ReadAllText(fi.FullName);
                                var cheatFile = new CheatFile(originalContents);
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

                                var formattedName = dir.FullName + GetTxtFileName(fi.Name).ToUpper() + ".txt";
                                fi.MoveTo(formattedName + "_TEMP");
                                fi.MoveTo(formattedName);
                            }
                        }
                        ShowConvertMesssage(converted, failed);
                    }
                }
                else
                {
                    ShowErrorMessage();
                }

                RefreshSelectedForm();
            }           
        }

        private void InsertNewCheat()
        {
            //Set buttons language Czech/English/German/Slovakian/Spanish (default English)
            InputBox.SetLanguage(InputBox.Language.English);

            //Save the DialogResult as res
            DialogResult res = InputBox.ShowDialog(
                "Build ID (e.g. 3AB632DEE82D5944)", 
                "Version (Default 1.0.0)",
                "New Cheat",   //Text message (mandatory), Title (optional)
                InputBox.Icon.Question, //Set icon type (default info)
                InputBox.Buttons.OkCancel, //Set buttons (default ok)
                InputBox.Type.TextBox, //Set type (default nothing)
                null,///new string[] { "Item1", "Item2", "Item3" }, //String field as ComboBox items (default null)
                true, //Set visible in taskbar (default false)
                new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular)); //Set font (default by system)

            //Check InputBox result
            if (res == System.Windows.Forms.DialogResult.OK || res == System.Windows.Forms.DialogResult.Yes)
            {
                var returnValue = InputBox.ResultValue.Split("+");
                var buildId = returnValue[0];
                var version = returnValue[1];
                ///listView1.Items.Add(); //Get returned value
                var selectedDir = GetSelectedDirectory();
                var newCheatFilePath = selectedDir + "\\cheats\\" + buildId + ".txt";
                var infoFile = CheckCheatFileExist(newCheatFilePath);
                if (infoFile != null && infoFile.Exists)
                {
                    MessageBox.Show("New cheat already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(String.Format(DEFAULT_INSERT_NEW_CHEAT_FILE_MESSAGE, buildId, version), "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InsertNewCheatIntoFile(selectedDir, buildId, version);
                    SaveNewCheatFile(newCheatFilePath);
                    RefreshSelectedForm();
                }
            }
                
        }

        public void InsertNewCheatIntoFile(string path, string buildId, string version)
        {
            var infoFile = CheckInfoFileExist(path);
            var contents = new StringBuilder();
            if (this.Versions == null || this.Versions.Count == 0)
            {
                // TODO
                this.Versions = new Dictionary<string, string>();
            }

            if (!this.Versions.ContainsValue("v" + version))
            {
                this.Versions.Add(buildId, "v" + version);
            }            

            // Sort version number
            List<string> values = new List<string>();
            values.AddRange(this.Versions.Values);
            values.Sort();

            for (var i = 0; i < values.Count; i++)
            {
                string line = values[i].Equals("v" + version)
                    ? buildId + "\tv" + version
                    : this.Versions.First(kv => kv.Value.Equals(values[i])).Key + "\t" + values[i];
                contents.Append(line + "\n");
            }

            string fileName = "New Game Cheats Version File.txt";
            // Fullpath. You can direct hardcode it if you like.  
            string fullPath = infoFile != null ? infoFile.FullName : path + fileName;

            // Write array of strings to a file using WriteAllLines.  
            // If the file does not exists, it will create a new file.  
            // This method automatically opens the file, writes to it, and closes file  
            using (StreamWriter sw = new StreamWriter(File.Open(fullPath, FileMode.Create), Encoding.ASCII))
            {
                sw.Write(contents);
            }
        }

        private void SaveNewCheatFile(string path)
        {
            using (StreamWriter sw = new StreamWriter(File.Open(path, FileMode.Create), Encoding.ASCII))
            {
                sw.WriteLine();
            }
        }

        private Dictionary<string, string> LoadVersionFile(string path)
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                var items = line.Split("\t");
                if (items.Length == 2)
                {
                    map.Add(items[0], items[1]);
                }
            }
            return map;
        }

        private void ReadSelectedFile(string path)
        {
            this.CodeTextBox.Enabled = true;
            String contents = File.ReadAllText(path);
            this.CodeTextBox.Text = contents;
            CheatCode.CheatFile cheats = new CheatCode.CheatFile(contents);
            
            if (cheats.Legit)
            {
                this.CodeStatusLabel.Text = "-- Valid --";
                this.CodeStatusLabel.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                MessageBox.Show("Error: " + cheats.ErrorLine, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.CodeStatusLabel.Text = "!! Invalid !!";
                this.CodeStatusLabel.BackColor = System.Drawing.Color.Red;
            }
        }

        private void SaveSelectedFile(string contents)
        {
            File.WriteAllText(this.CurrentOpenFilePath, contents);
        }

        private String GetPath(string path) => path.EndsWith("\\") ? path : path + "\\";

        private String GetDirectoryPath(string path) => GetPath(path.EndsWith("\\cheats\\") ? path.Substring(0, path.Length - 7) : path);

        private String GetCheatsPath(String path) => GetPath(path.EndsWith("\\cheats") ? path : (path + "\\cheats"));

        private void CodeSelectorListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CodeSelectorListBox.SelectedItem != null)
            {
                var fileName = this.CodeSelectorListBox.SelectedItem.ToString();
                this.CurrentOpenFilePath = this.CurrentGamePath + fileName + ".txt";

                if (this.Versions.ContainsKey(fileName))
                {
                    this.VersionNumberTextBox.Text = this.Versions[fileName];
                }
                else
                {
                    this.VersionNumberTextBox.Text = DEFAULT_VERSION_NUMBER;
                }
                ReadSelectedFile(this.CurrentOpenFilePath);
                
                this.UpdateButton.Enabled = true;
                this.SaveOriginalButton.Enabled = true;
                this.CodeModifiedTextBox.Text = string.Empty;
                this.CodeModifiedTextBox.Enabled = false;
            }
        }

        private void ShowConvertMesssage(int s, int f)
        {
            DialogResult result = MessageBox.Show(String.Format(DEFAULT_CONVERT_FILES_MESSAGE, s, f), "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                RefreshSelectedForm();
            }
        }

        private DialogResult ShowErrorMessage()
        {
            return MessageBox.Show(DEFAULT_INVALID_DIRECTORY_MESSAGE, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FormatFilesButton_Click(object sender, EventArgs e)
        {
            FormatFileNames();
        }
        private void InsertNewCheatButton_Click(object sender, EventArgs e)
        {
            InsertNewCheat();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var updatedContents = new CheatFile(this.CodeTextBox.Text);
            this.CodeModifiedTextBox.Enabled = true;
            this.CodeModifiedTextBox.Text = updatedContents.Output();
            this.SaveFormatedButton.Enabled = true;
        }

        private void SaveFormatedButton_Click(object sender, EventArgs e)
        {
            SaveSelectedFile(this.CodeModifiedTextBox.Text);
            DialogResult result = MessageBox.Show($"{DEFAULT_SAVE_NOTIFICATION_Message}{this.CurrentOpenFilePath}", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (result.Equals(DialogResult.OK))
            {
                RefreshSelectedForm();
            }
        }

        private void SaveOriginalButton_Click(object sender, EventArgs e)
        {
            SaveSelectedFile(this.CodeTextBox.Text);
            DialogResult result = MessageBox.Show($"{DEFAULT_SAVE_NOTIFICATION_Message}{this.CurrentOpenFilePath}", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                RefreshSelectedForm();
            }
        }

        private void GameListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshSelectedForm();
        }

        private string GetSelectedCheatPath()
        {
            if (!this.CurrentPath.EndsWith("cheats"))
            {
                return GetCheatsPath(this.CurrentPath + "\\" + ((DropDownItem)this.GameListComboBox.SelectedItem).Value);
                
            }
            else
            {
                return this.CurrentPath;
            }
        }

        private string GetSelectedDirectory()
        {
            if (!this.CurrentPath.EndsWith("cheats"))
            {
                return GetDirectoryPath(this.CurrentPath + "\\" + ((DropDownItem)this.GameListComboBox.SelectedItem).Value);

            }
            else
            {
                return this.CurrentPath;
            }
        }

        private void RefreshSelectedForm()
        {
            if (!this.CurrentPath.EndsWith("cheats"))
            {
                var correctedPath = GetCheatsPath(this.CurrentPath + "\\" + ((DropDownItem)this.GameListComboBox.SelectedItem).Value);
                this.CurrentGamePath = correctedPath;
                RefreshForm(correctedPath);
            }
            else
            {
                RefreshForm(this.CurrentPath);
            }
        }

        private void previewImage_DoubleClick(object sender, EventArgs e)
        {
            if (this.PreviewImage != null & !String.IsNullOrEmpty(this.CurrentGamePath))
            {
                Process.Start("explorer.exe", this.CurrentGamePath);
            }
        }

        private string GetTxtFileName(string filename) => filename.Length >= 4 ? filename.Substring(0, filename.Length - 4) : filename;


        private void CodeSelectorGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void VersionNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
