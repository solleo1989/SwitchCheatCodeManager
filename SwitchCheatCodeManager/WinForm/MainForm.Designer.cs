using SwitchCheatCodeManager.Constant;
using SwitchCheatCodeManager.Properties;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SwitchCheatCodeManager.WinForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PathGroupBox = new System.Windows.Forms.GroupBox();
            this.PathTextBox = new SwitchCheatCodeManager.FormEntity.TextBoxEx();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.GameListComboBox = new SwitchCheatCodeManager.FormEntity.ComboBoxEx();
            this.OpenFolderButton = new System.Windows.Forms.Button();
            this.IconImageList = new System.Windows.Forms.ImageList(this.components);
            this.GameNameGroupBox = new System.Windows.Forms.GroupBox();
            this.GameNameTextBox = new SwitchCheatCodeManager.FormEntity.TextBoxEx();
            this.VersionFileModeUpdateButton = new System.Windows.Forms.Button();
            this.GameDBTidTextBox = new System.Windows.Forms.TextBox();
            this.GameDBNameTextBox = new System.Windows.Forms.TextBox();
            this.CopyFolderButton = new System.Windows.Forms.Button();
            this.CodeModifierGroupBox = new System.Windows.Forms.GroupBox();
            this.CodeSelectorGroupBox = new System.Windows.Forms.GroupBox();
            this.PreviewImage = new System.Windows.Forms.PictureBox();
            this.CodeSelectorListBox = new SwitchCheatCodeManager.FormEntity.ListBoxEx();
            this.NumOfCheatsLabel = new System.Windows.Forms.Label();
            this.AscendingOrderButton = new System.Windows.Forms.Button();
            this.DescendingOrderButton = new System.Windows.Forms.Button();
            this.InsertNewCheatButton = new System.Windows.Forms.Button();
            this.RemoveCheatButton = new System.Windows.Forms.Button();
            this.FormatFilesButton = new System.Windows.Forms.Button();
            this.CodeEditorGroupBox = new System.Windows.Forms.GroupBox();
            this.CodeStatusLabel = new System.Windows.Forms.Label();
            this.BuildIdLabel = new System.Windows.Forms.Label();
            this.BuildIdTextBox = new System.Windows.Forms.TextBox();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.VersionNumberTextBox = new System.Windows.Forms.TextBox();
            this.CodeTextBox = new SwitchCheatCodeManager.FormEntity.TextAreaEx();
            this.SaveOriginalButton = new System.Windows.Forms.Button();
            this.CopyFileButton = new System.Windows.Forms.Button();
            this.NewBlockButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SubCheatsGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveFormatedButton = new System.Windows.Forms.Button();
            this.NavigationFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DefaultFileButton = new System.Windows.Forms.Button();
            this.NavigationImageList = new System.Windows.Forms.ImageList(this.components);
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.InsertNewCheatsButton = new System.Windows.Forms.Button();
            this.RemoveFolderButton = new System.Windows.Forms.Button();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.InputFolderPathLabelToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.OutputFolderPathLabelToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PreviewImageList = new System.Windows.Forms.ImageList(this.components);
            this.MenuStrip.SuspendLayout();
            this.PathGroupBox.SuspendLayout();
            this.GameNameGroupBox.SuspendLayout();
            this.CodeSelectorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage)).BeginInit();
            this.CodeEditorGroupBox.SuspendLayout();
            this.NavigationFlowLayoutPanel.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1917, 38);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "Menu Strip";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.ToolStripSeparator,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.ToolStripSeparator1,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(62, 34);
            this.FileToolStripMenuItem.Text = global::SwitchCheatCodeManager.Properties.Resources.MenuStrip_FileText;
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Enabled = false;
            this.NewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("NewToolStripMenuItem.Image")));
            this.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(274, 40);
            this.NewToolStripMenuItem.Text = global::SwitchCheatCodeManager.Properties.Resources.MenuStrip_DefaultText;
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.DefaultFolderOpenButton_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStripMenuItem.Image")));
            this.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(274, 40);
            this.OpenToolStripMenuItem.Text = global::SwitchCheatCodeManager.Properties.Resources.MenuStrip_OpenText;
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.MainMenuOpenButton_Click);
            // 
            // ToolStripSeparator
            // 
            this.ToolStripSeparator.Name = "ToolStripSeparator";
            this.ToolStripSeparator.Size = new System.Drawing.Size(271, 6);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Enabled = false;
            this.SaveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripMenuItem.Image")));
            this.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(274, 40);
            this.SaveToolStripMenuItem.Text = global::SwitchCheatCodeManager.Properties.Resources.MenuStrip_SaveText;
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveOriginalButton_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Enabled = false;
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(274, 40);
            this.SaveAsToolStripMenuItem.Text = global::SwitchCheatCodeManager.Properties.Resources.MenuStrip_SaveAsText;
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsButton_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(271, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(274, 40);
            this.ExitToolStripMenuItem.Text = global::SwitchCheatCodeManager.Properties.Resources.MenuStrip_ExitText;
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.CloseApplication);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(74, 34);
            this.HelpToolStripMenuItem.Text = global::SwitchCheatCodeManager.Properties.Resources.MenuStrip_HelpText;
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(203, 40);
            this.AboutToolStripMenuItem.Text = global::SwitchCheatCodeManager.Properties.Resources.MenuStrip_About;
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(211, 6);
            // 
            // ToolsToolStripMenuItem
            // 
            this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsToolStripMenuItem});
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            this.ToolsToolStripMenuItem.Size = new System.Drawing.Size(89, 36);
            this.ToolsToolStripMenuItem.Text = global::SwitchCheatCodeManager.Properties.Resources.MenuStrip_Tools;
            // 
            // OptionsToolStripMenuItem
            // 
            this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
            this.OptionsToolStripMenuItem.Size = new System.Drawing.Size(204, 40);
            this.OptionsToolStripMenuItem.Text = global::SwitchCheatCodeManager.Properties.Resources.MenuStrip_Options;
            // 
            // PathGroupBox
            // 
            this.PathGroupBox.Controls.Add(this.PathTextBox);
            this.PathGroupBox.Controls.Add(this.FilterTextBox);
            this.PathGroupBox.Controls.Add(this.GameListComboBox);
            this.PathGroupBox.Controls.Add(this.OpenFolderButton);
            this.PathGroupBox.Location = new System.Drawing.Point(38, 107);
            this.PathGroupBox.Name = "PathGroupBox";
            this.PathGroupBox.Size = new System.Drawing.Size(1838, 90);
            this.PathGroupBox.TabIndex = 2;
            this.PathGroupBox.TabStop = false;
            this.PathGroupBox.Text = "Path";
            // 
            // PathTextBox
            // 
            this.PathTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PathTextBox.Location = new System.Drawing.Point(10, 33);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.ReadOnly = true;
            this.PathTextBox.Size = new System.Drawing.Size(680, 38);
            this.PathTextBox.TabIndex = 2;
            this.PathTextBox.WordWrap = false;
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Enabled = false;
            this.FilterTextBox.Location = new System.Drawing.Point(700, 33);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.PlaceholderText = global::SwitchCheatCodeManager.Properties.Resources.KeywordSearchPlaceholderText;
            this.FilterTextBox.Size = new System.Drawing.Size(140, 35);
            this.FilterTextBox.TabIndex = 4;
            this.FilterTextBox.TextChanged += new System.EventHandler(this.FilterTextBox_TextChanged);
            // 
            // GameListComboBox
            // 
            this.GameListComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GameListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GameListComboBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameListComboBox.FormattingEnabled = true;
            this.GameListComboBox.ItemHeight = 30;
            this.GameListComboBox.Location = new System.Drawing.Point(855, 35);
            this.GameListComboBox.Name = "GameListComboBox";
            this.GameListComboBox.Size = new System.Drawing.Size(810, 36);
            this.GameListComboBox.TabIndex = 3;
            this.GameListComboBox.SelectedIndexChanged += new System.EventHandler(this.GameListComboBox_SelectedIndexChanged);
            // 
            // OpenFolderButton
            // 
            this.OpenFolderButton.Enabled = false;
            this.OpenFolderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OpenFolderButton.ImageKey = "Open3.png";
            this.OpenFolderButton.ImageList = this.IconImageList;
            this.OpenFolderButton.Location = new System.Drawing.Point(1685, 31);
            this.OpenFolderButton.Name = "OpenFolderButton";
            this.OpenFolderButton.Size = new System.Drawing.Size(135, 50);
            this.OpenFolderButton.TabIndex = 3;
            this.OpenFolderButton.Text = global::SwitchCheatCodeManager.Properties.Resources.OpenFolderButton_Text;
            this.OpenFolderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ToolTip.SetToolTip(this.OpenFolderButton, global::SwitchCheatCodeManager.Properties.Resources.OpenFolderButton_Tooltip_Text);
            this.OpenFolderButton.UseVisualStyleBackColor = true;
            this.OpenFolderButton.Click += new System.EventHandler(this.OpenFolderButton_Click);
            // 
            // IconImageList
            // 
            this.IconImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.IconImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconImageList.ImageStream")));
            this.IconImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconImageList.Images.SetKeyName(0, "Add.png");
            this.IconImageList.Images.SetKeyName(1, "AddNew.png");
            this.IconImageList.Images.SetKeyName(2, "Convert.png");
            this.IconImageList.Images.SetKeyName(3, "Copy.png");
            this.IconImageList.Images.SetKeyName(4, "Down2.png");
            this.IconImageList.Images.SetKeyName(5, "Format.png");
            this.IconImageList.Images.SetKeyName(6, "Home.png");
            this.IconImageList.Images.SetKeyName(7, "Left.png");
            this.IconImageList.Images.SetKeyName(8, "Open.png");
            this.IconImageList.Images.SetKeyName(9, "Overwrite.png");
            this.IconImageList.Images.SetKeyName(10, "Right.png");
            this.IconImageList.Images.SetKeyName(11, "Save.png");
            this.IconImageList.Images.SetKeyName(12, "Settings.png");
            this.IconImageList.Images.SetKeyName(13, "Up2.png");
            this.IconImageList.Images.SetKeyName(14, "Remove.png");
            this.IconImageList.Images.SetKeyName(15, "Open3.png");
            this.IconImageList.Images.SetKeyName(16, "Save3.png");
            // 
            // GameNameGroupBox
            // 
            this.GameNameGroupBox.Controls.Add(this.GameNameTextBox);
            this.GameNameGroupBox.Controls.Add(this.VersionFileModeUpdateButton);
            this.GameNameGroupBox.Controls.Add(this.GameDBTidTextBox);
            this.GameNameGroupBox.Controls.Add(this.GameDBNameTextBox);
            this.GameNameGroupBox.Controls.Add(this.CopyFolderButton);
            this.GameNameGroupBox.Location = new System.Drawing.Point(38, 201);
            this.GameNameGroupBox.Name = "GameNameGroupBox";
            this.GameNameGroupBox.Size = new System.Drawing.Size(1838, 90);
            this.GameNameGroupBox.TabIndex = 2;
            this.GameNameGroupBox.TabStop = false;
            this.GameNameGroupBox.Text = "Name";
            // 
            // GameNameTextBox
            // 
            this.GameNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameNameTextBox.Location = new System.Drawing.Point(10, 33);
            this.GameNameTextBox.Margin = new System.Windows.Forms.Padding(33);
            this.GameNameTextBox.Name = "GameNameTextBox";
            this.GameNameTextBox.Size = new System.Drawing.Size(680, 38);
            this.GameNameTextBox.TabIndex = 2;
            this.GameNameTextBox.TextChanged += new System.EventHandler(this.GameNameTextBox_TextChanged);
            // 
            // VersionFileModeUpdateButton
            // 
            this.VersionFileModeUpdateButton.Enabled = false;
            this.VersionFileModeUpdateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VersionFileModeUpdateButton.ImageKey = "Settings.png";
            this.VersionFileModeUpdateButton.ImageList = this.IconImageList;
            this.VersionFileModeUpdateButton.Location = new System.Drawing.Point(700, 27);
            this.VersionFileModeUpdateButton.Margin = new System.Windows.Forms.Padding(4);
            this.VersionFileModeUpdateButton.Name = "VersionFileModeUpdateButton";
            this.VersionFileModeUpdateButton.Size = new System.Drawing.Size(140, 50);
            this.VersionFileModeUpdateButton.TabIndex = 2;
            this.VersionFileModeUpdateButton.Text = global::SwitchCheatCodeManager.Properties.Resources.VersionFileModeUpdateButton_Text;
            this.VersionFileModeUpdateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ToolTip.SetToolTip(this.VersionFileModeUpdateButton, global::SwitchCheatCodeManager.Properties.Resources.VersionFileModeUpdateButton_Tooltip_Text);
            this.VersionFileModeUpdateButton.UseVisualStyleBackColor = true;
            this.VersionFileModeUpdateButton.Click += new System.EventHandler(this.VersionFileModeUpdateButton_Click);
            // 
            // GameDBTidTextBox
            // 
            this.GameDBTidTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GameDBTidTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameDBTidTextBox.Location = new System.Drawing.Point(855, 33);
            this.GameDBTidTextBox.Name = "GameDBTidTextBox";
            this.GameDBTidTextBox.ReadOnly = true;
            this.GameDBTidTextBox.Size = new System.Drawing.Size(225, 35);
            this.GameDBTidTextBox.TabIndex = 6;
            // 
            // GameDBNameTextBox
            // 
            this.GameDBNameTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GameDBNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameDBNameTextBox.Location = new System.Drawing.Point(1080, 33);
            this.GameDBNameTextBox.Name = "GameDBNameTextBox";
            this.GameDBNameTextBox.ReadOnly = true;
            this.GameDBNameTextBox.Size = new System.Drawing.Size(585, 35);
            this.GameDBNameTextBox.TabIndex = 5;
            // 
            // CopyFolderButton
            // 
            this.CopyFolderButton.Enabled = false;
            this.CopyFolderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CopyFolderButton.ImageKey = "Save3.png";
            this.CopyFolderButton.ImageList = this.IconImageList;
            this.CopyFolderButton.Location = new System.Drawing.Point(1685, 27);
            this.CopyFolderButton.Name = "CopyFolderButton";
            this.CopyFolderButton.Size = new System.Drawing.Size(135, 50);
            this.CopyFolderButton.TabIndex = 4;
            this.CopyFolderButton.Text = global::SwitchCheatCodeManager.Properties.Resources.CopyFolderButton_Text;
            this.CopyFolderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ToolTip.SetToolTip(this.CopyFolderButton, global::SwitchCheatCodeManager.Properties.Resources.CopyFolderButton_Tooltip_Text);
            this.CopyFolderButton.UseVisualStyleBackColor = true;
            this.CopyFolderButton.Click += new System.EventHandler(this.CopyFolderButton_Click);
            // 
            // CodeModifierGroupBox
            // 
            this.CodeModifierGroupBox.Location = new System.Drawing.Point(1043, 84);
            this.CodeModifierGroupBox.Name = "CodeModifierGroupBox";
            this.CodeModifierGroupBox.Size = new System.Drawing.Size(675, 918);
            this.CodeModifierGroupBox.TabIndex = 4;
            this.CodeModifierGroupBox.TabStop = false;
            this.CodeModifierGroupBox.Text = global::SwitchCheatCodeManager.Properties.Resources.CodeModifierGroupBox_Text;
            // 
            // CodeSelectorGroupBox
            // 
            this.CodeSelectorGroupBox.Controls.Add(this.PreviewImage);
            this.CodeSelectorGroupBox.Controls.Add(this.CodeSelectorListBox);
            this.CodeSelectorGroupBox.Controls.Add(this.NumOfCheatsLabel);
            this.CodeSelectorGroupBox.Controls.Add(this.AscendingOrderButton);
            this.CodeSelectorGroupBox.Controls.Add(this.DescendingOrderButton);
            this.CodeSelectorGroupBox.Controls.Add(this.InsertNewCheatButton);
            this.CodeSelectorGroupBox.Controls.Add(this.RemoveCheatButton);
            this.CodeSelectorGroupBox.Controls.Add(this.FormatFilesButton);
            this.CodeSelectorGroupBox.Location = new System.Drawing.Point(38, 285);
            this.CodeSelectorGroupBox.Name = "CodeSelectorGroupBox";
            this.CodeSelectorGroupBox.Size = new System.Drawing.Size(372, 968);
            this.CodeSelectorGroupBox.TabIndex = 3;
            this.CodeSelectorGroupBox.TabStop = false;
            this.CodeSelectorGroupBox.Text = "Cheats";
            // 
            // PreviewImage
            // 
            this.PreviewImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PreviewImage.Location = new System.Drawing.Point(10, 35);
            this.PreviewImage.Margin = new System.Windows.Forms.Padding(4);
            this.PreviewImage.Name = "PreviewImage";
            this.PreviewImage.Size = new System.Drawing.Size(350, 350);
            this.PreviewImage.TabIndex = 6;
            this.PreviewImage.TabStop = false;
            this.PreviewImage.DoubleClick += new System.EventHandler(this.PreviewImage_DoubleClick);
            // 
            // CodeSelectorListBox
            // 
            this.CodeSelectorListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CodeSelectorListBox.Enabled = false;
            this.CodeSelectorListBox.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CodeSelectorListBox.FormattingEnabled = true;
            this.CodeSelectorListBox.ItemHeight = 30;
            this.CodeSelectorListBox.Location = new System.Drawing.Point(10, 404);
            this.CodeSelectorListBox.Margin = new System.Windows.Forms.Padding(24);
            this.CodeSelectorListBox.Name = "CodeSelectorListBox";
            this.CodeSelectorListBox.ScrollAlwaysVisible = true;
            this.CodeSelectorListBox.Size = new System.Drawing.Size(350, 454);
            this.CodeSelectorListBox.TabIndex = 3;
            this.CodeSelectorListBox.SelectedIndexChanged += new System.EventHandler(this.CodeSelectorListBox_SelectedIndexChanged);
            this.CodeSelectorListBox.DoubleClick += new System.EventHandler(this.CodeSelectorListBox_DoubleClick);
            // 
            // NumOfCheatsLabel
            // 
            this.NumOfCheatsLabel.AutoSize = true;
            this.NumOfCheatsLabel.Location = new System.Drawing.Point(251, 863);
            this.NumOfCheatsLabel.Name = "NumOfCheatsLabel";
            this.NumOfCheatsLabel.Size = new System.Drawing.Size(109, 30);
            this.NumOfCheatsLabel.TabIndex = 10;
            this.NumOfCheatsLabel.Text = "";
            this.NumOfCheatsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AscendingOrderButton
            // 
            this.AscendingOrderButton.Enabled = false;
            this.AscendingOrderButton.ImageKey = "Up2.png";
            this.AscendingOrderButton.ImageList = this.IconImageList;
            this.AscendingOrderButton.Location = new System.Drawing.Point(10, 900);
            this.AscendingOrderButton.Name = "AscendingOrderButton";
            this.AscendingOrderButton.Size = new System.Drawing.Size(60, 50);
            this.AscendingOrderButton.TabIndex = 8;
            this.ToolTip.SetToolTip(this.AscendingOrderButton, global::SwitchCheatCodeManager.Properties.Resources.AscendingOrderButton_Text);
            this.AscendingOrderButton.UseVisualStyleBackColor = true;
            this.AscendingOrderButton.Click += new System.EventHandler(this.AscendingOrderButton_Click);
            // 
            // DescendingOrderButton
            // 
            this.DescendingOrderButton.Enabled = false;
            this.DescendingOrderButton.ImageKey = "Down2.png";
            this.DescendingOrderButton.ImageList = this.IconImageList;
            this.DescendingOrderButton.Location = new System.Drawing.Point(80, 900);
            this.DescendingOrderButton.Name = "DescendingOrderButton";
            this.DescendingOrderButton.Size = new System.Drawing.Size(60, 50);
            this.DescendingOrderButton.TabIndex = 7;
            this.ToolTip.SetToolTip(this.DescendingOrderButton, global::SwitchCheatCodeManager.Properties.Resources.DescendingOrderButton_Text);
            this.DescendingOrderButton.UseVisualStyleBackColor = true;
            this.DescendingOrderButton.Click += new System.EventHandler(this.DescendingOrderButton_Click);
            // 
            // InsertNewCheatButton
            // 
            this.InsertNewCheatButton.Enabled = false;
            this.InsertNewCheatButton.ImageKey = "Add.png";
            this.InsertNewCheatButton.ImageList = this.IconImageList;
            this.InsertNewCheatButton.Location = new System.Drawing.Point(150, 900);
            this.InsertNewCheatButton.Margin = new System.Windows.Forms.Padding(4);
            this.InsertNewCheatButton.Name = "InsertNewCheatButton";
            this.InsertNewCheatButton.Size = new System.Drawing.Size(60, 50);
            this.InsertNewCheatButton.TabIndex = 5;
            this.ToolTip.SetToolTip(this.InsertNewCheatButton, global::SwitchCheatCodeManager.Properties.Resources.InsertNewCheatButton_Text);
            this.InsertNewCheatButton.UseVisualStyleBackColor = true;
            this.InsertNewCheatButton.Click += new System.EventHandler(this.InsertNewCheatButton_Click);
            // 
            // RemoveCheatButton
            // 
            this.RemoveCheatButton.Enabled = false;
            this.RemoveCheatButton.ImageKey = "Remove.png";
            this.RemoveCheatButton.ImageList = this.IconImageList;
            this.RemoveCheatButton.Location = new System.Drawing.Point(220, 900);
            this.RemoveCheatButton.Name = "RemoveCheatButton";
            this.RemoveCheatButton.Size = new System.Drawing.Size(60, 50);
            this.RemoveCheatButton.TabIndex = 9;
            this.ToolTip.SetToolTip(this.RemoveCheatButton, global::SwitchCheatCodeManager.Properties.Resources.RemoveCheatButton_Text);
            this.RemoveCheatButton.UseVisualStyleBackColor = true;
            this.RemoveCheatButton.Click += new System.EventHandler(this.RemoveCheatButton_Click);
            // 
            // FormatFilesButton
            // 
            this.FormatFilesButton.Enabled = false;
            this.FormatFilesButton.ImageKey = "Format.png";
            this.FormatFilesButton.ImageList = this.IconImageList;
            this.FormatFilesButton.Location = new System.Drawing.Point(290, 900);
            this.FormatFilesButton.Name = "FormatFilesButton";
            this.FormatFilesButton.Size = new System.Drawing.Size(60, 50);
            this.FormatFilesButton.TabIndex = 5;
            this.ToolTip.SetToolTip(this.FormatFilesButton, global::SwitchCheatCodeManager.Properties.Resources.FormatFilesButton_Text);
            this.FormatFilesButton.UseVisualStyleBackColor = true;
            this.FormatFilesButton.Click += new System.EventHandler(this.FormatFilesButton_Click);
            // 
            // CodeEditorGroupBox
            // 
            this.CodeEditorGroupBox.Controls.Add(this.CodeStatusLabel);
            this.CodeEditorGroupBox.Controls.Add(this.BuildIdLabel);
            this.CodeEditorGroupBox.Controls.Add(this.BuildIdTextBox);
            this.CodeEditorGroupBox.Controls.Add(this.VersionLabel);
            this.CodeEditorGroupBox.Controls.Add(this.VersionNumberTextBox);
            this.CodeEditorGroupBox.Controls.Add(this.CodeTextBox);
            this.CodeEditorGroupBox.Controls.Add(this.SaveOriginalButton);
            this.CodeEditorGroupBox.Controls.Add(this.CopyFileButton);
            this.CodeEditorGroupBox.Controls.Add(this.NewBlockButton);
            this.CodeEditorGroupBox.Controls.Add(this.UpdateButton);
            this.CodeEditorGroupBox.Location = new System.Drawing.Point(418, 285);
            this.CodeEditorGroupBox.Name = "CodeEditorGroupBox";
            this.CodeEditorGroupBox.Size = new System.Drawing.Size(675, 968);
            this.CodeEditorGroupBox.TabIndex = 4;
            this.CodeEditorGroupBox.TabStop = false;
            this.CodeEditorGroupBox.Text = "Cheats";
            // 
            // CodeStatusLabel
            // 
            this.CodeStatusLabel.AutoSize = true;
            this.CodeStatusLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CodeStatusLabel.Location = new System.Drawing.Point(9, 33);
            this.CodeStatusLabel.Name = "CodeStatusLabel";
            this.CodeStatusLabel.Size = new System.Drawing.Size(0, 24);
            this.CodeStatusLabel.TabIndex = 2;
            // 
            // BuildIdLabel
            // 
            this.BuildIdLabel.AutoSize = true;
            this.BuildIdLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BuildIdLabel.Location = new System.Drawing.Point(126, 33);
            this.BuildIdLabel.Name = "BuildIdLabel";
            this.BuildIdLabel.Size = new System.Drawing.Size(68, 24);
            this.BuildIdLabel.TabIndex = 9;
            this.BuildIdLabel.Text = "Build:";
            // 
            // BuildIdTextBox
            // 
            this.BuildIdTextBox.Location = new System.Drawing.Point(201, 28);
            this.BuildIdTextBox.Name = "BuildIdTextBox";
            this.BuildIdTextBox.ReadOnly = true;
            this.BuildIdTextBox.Size = new System.Drawing.Size(225, 35);
            this.BuildIdTextBox.TabIndex = 8;
            this.BuildIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VersionLabel.Location = new System.Drawing.Point(435, 33);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(92, 24);
            this.VersionLabel.TabIndex = 2;
            this.VersionLabel.Text = "Version:";
            // 
            // VersionNumberTextBox
            // 
            this.VersionNumberTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VersionNumberTextBox.Location = new System.Drawing.Point(538, 30);
            this.VersionNumberTextBox.Name = "VersionNumberTextBox";
            this.VersionNumberTextBox.ReadOnly = true;
            this.VersionNumberTextBox.Size = new System.Drawing.Size(115, 32);
            this.VersionNumberTextBox.TabIndex = 2;
            this.VersionNumberTextBox.Text = "N/A";
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.Enabled = false;
            this.CodeTextBox.Location = new System.Drawing.Point(10, 75);
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(630, 818);
            this.CodeTextBox.TabIndex = 4;
            this.CodeTextBox.Text = "";
            // 
            // SaveOriginalButton
            // 
            this.SaveOriginalButton.Enabled = false;
            this.SaveOriginalButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveOriginalButton.ImageKey = "Save.png";
            this.SaveOriginalButton.ImageList = this.IconImageList;
            this.SaveOriginalButton.Location = new System.Drawing.Point(10, 904);
            this.SaveOriginalButton.Name = "SaveOriginalButton";
            this.SaveOriginalButton.Size = new System.Drawing.Size(135, 50);
            this.SaveOriginalButton.TabIndex = 6;
            this.SaveOriginalButton.Text = global::SwitchCheatCodeManager.Properties.Resources.SaveOriginalButton_Text;
            this.SaveOriginalButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ToolTip.SetToolTip(this.SaveOriginalButton, global::SwitchCheatCodeManager.Properties.Resources.SaveOriginalButton_Tooltip_Text);
            this.SaveOriginalButton.UseVisualStyleBackColor = true;
            this.SaveOriginalButton.Click += new System.EventHandler(this.SaveOriginalButton_Click);
            // 
            // CopyFileButton
            // 
            this.CopyFileButton.Enabled = false;
            this.CopyFileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CopyFileButton.ImageKey = "Overwrite.png";
            this.CopyFileButton.ImageList = this.IconImageList;
            this.CopyFileButton.Location = new System.Drawing.Point(160, 904);
            this.CopyFileButton.Name = "CopyFileButton";
            this.CopyFileButton.Size = new System.Drawing.Size(155, 50);
            this.CopyFileButton.TabIndex = 7;
            this.CopyFileButton.Text = global::SwitchCheatCodeManager.Properties.Resources.CopyFileButton_Text;
            this.CopyFileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ToolTip.SetToolTip(this.CopyFileButton, global::SwitchCheatCodeManager.Properties.Resources.CopyFileButton_ToolTip_Text);
            this.CopyFileButton.UseVisualStyleBackColor = true;
            this.CopyFileButton.Click += new System.EventHandler(this.CopyFileButton_Click);
            // 
            // NewBlockButton
            // 
            this.NewBlockButton.Enabled = false;
            this.NewBlockButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NewBlockButton.ImageKey = "AddNew.png";
            this.NewBlockButton.ImageList = this.IconImageList;
            this.NewBlockButton.Location = new System.Drawing.Point(330, 904);
            this.NewBlockButton.Name = "NewBlockButton";
            this.NewBlockButton.Size = new System.Drawing.Size(150, 50);
            this.NewBlockButton.TabIndex = 7;
            this.NewBlockButton.Text = global::SwitchCheatCodeManager.Properties.Resources.NewBlockButton_Text;
            this.NewBlockButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ToolTip.SetToolTip(this.NewBlockButton, global::SwitchCheatCodeManager.Properties.Resources.NewBlockButton_Tooltip_Text);
            this.NewBlockButton.UseVisualStyleBackColor = true;
            this.NewBlockButton.Click += new System.EventHandler(this.InsertNewSubSectionBlockButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Enabled = false;
            this.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateButton.ImageKey = "Convert.png";
            this.UpdateButton.ImageList = this.IconImageList;
            this.UpdateButton.Location = new System.Drawing.Point(495, 904);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(145, 50);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = global::SwitchCheatCodeManager.Properties.Resources.UpdateButton_Text;
            this.UpdateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ToolTip.SetToolTip(this.UpdateButton, global::SwitchCheatCodeManager.Properties.Resources.UpdateButton_Tooltip_Text);
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateCheatContentsInTextBoxButton_Click);
            // 
            // SubCheatsGroupBox
            // 
            this.SubCheatsGroupBox.Location = new System.Drawing.Point(1103, 285);
            this.SubCheatsGroupBox.Name = "SubCheatsGroupBox";
            this.SubCheatsGroupBox.Size = new System.Drawing.Size(775, 968);
            this.SubCheatsGroupBox.TabIndex = 4;
            this.SubCheatsGroupBox.TabStop = false;
            this.SubCheatsGroupBox.Text = "Cheat Sections";
            // 
            // SaveFormatedButton
            // 
            this.SaveFormatedButton.Enabled = false;
            this.SaveFormatedButton.Location = new System.Drawing.Point(9, 854);
            this.SaveFormatedButton.Name = "SaveFormatedButton";
            this.SaveFormatedButton.Size = new System.Drawing.Size(138, 46);
            this.SaveFormatedButton.TabIndex = 7;
            this.SaveFormatedButton.Text = global::SwitchCheatCodeManager.Properties.Resources.SaveFormatedButton_Text;
            this.SaveFormatedButton.UseVisualStyleBackColor = true;
            // 
            // NavigationFlowLayoutPanel
            // 
            this.NavigationFlowLayoutPanel.Controls.Add(this.DefaultFileButton);
            this.NavigationFlowLayoutPanel.Controls.Add(this.OpenFileButton);
            this.NavigationFlowLayoutPanel.Controls.Add(this.InsertNewCheatsButton);
            this.NavigationFlowLayoutPanel.Controls.Add(this.RemoveFolderButton);
            this.NavigationFlowLayoutPanel.Location = new System.Drawing.Point(40, 41);
            this.NavigationFlowLayoutPanel.Name = "NavigationFlowLayoutPanel";
            this.NavigationFlowLayoutPanel.Size = new System.Drawing.Size(1838, 66);
            this.NavigationFlowLayoutPanel.TabIndex = 4;
            // 
            // DefaultFileButton
            // 
            this.DefaultFileButton.Enabled = false;
            this.DefaultFileButton.ImageKey = "Home.png";
            this.DefaultFileButton.ImageList = this.NavigationImageList;
            this.DefaultFileButton.Location = new System.Drawing.Point(3, 3);
            this.DefaultFileButton.Name = "DefaultFileButton";
            this.DefaultFileButton.Size = new System.Drawing.Size(60, 60);
            this.DefaultFileButton.TabIndex = 0;
            this.ToolTip.SetToolTip(this.DefaultFileButton, global::SwitchCheatCodeManager.Properties.Resources.DefaultFileButton_Tooltip_Text);
            this.DefaultFileButton.UseVisualStyleBackColor = true;
            this.DefaultFileButton.Click += new System.EventHandler(this.DefaultFolderOpenButton_Click);
            // 
            // NavigationImageList
            // 
            this.NavigationImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.NavigationImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("NavigationImageList.ImageStream")));
            this.NavigationImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.NavigationImageList.Images.SetKeyName(0, "Home.png");
            this.NavigationImageList.Images.SetKeyName(1, "Open.png");
            this.NavigationImageList.Images.SetKeyName(2, "Open2.png");
            this.NavigationImageList.Images.SetKeyName(3, "Remove2.png");
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.ImageKey = "Open.png";
            this.OpenFileButton.ImageList = this.NavigationImageList;
            this.OpenFileButton.Location = new System.Drawing.Point(69, 3);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(60, 60);
            this.OpenFileButton.TabIndex = 1;
            this.ToolTip.SetToolTip(this.OpenFileButton, global::SwitchCheatCodeManager.Properties.Resources.OpenFileButton_Tooltip_Text);
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.MainMenuOpenButton_Click);
            // 
            // InsertNewCheatsButton
            // 
            this.InsertNewCheatsButton.Enabled = false;
            this.InsertNewCheatsButton.ImageKey = "Open2.png";
            this.InsertNewCheatsButton.ImageList = this.NavigationImageList;
            this.InsertNewCheatsButton.Location = new System.Drawing.Point(135, 3);
            this.InsertNewCheatsButton.Name = "InsertNewCheatsButton";
            this.InsertNewCheatsButton.Size = new System.Drawing.Size(60, 60);
            this.InsertNewCheatsButton.TabIndex = 2;
            this.ToolTip.SetToolTip(this.InsertNewCheatsButton, global::SwitchCheatCodeManager.Properties.Resources.InsertNewCheatsButton_Tooltip_Text);
            this.InsertNewCheatsButton.UseVisualStyleBackColor = true;
            this.InsertNewCheatsButton.Click += new System.EventHandler(this.InsertNewCheatsButton_Click);
            // 
            // RemoveFolderButton
            // 
            this.RemoveFolderButton.Enabled = false;
            this.RemoveFolderButton.ImageKey = "Remove2.png";
            this.RemoveFolderButton.ImageList = this.NavigationImageList;
            this.RemoveFolderButton.Location = new System.Drawing.Point(201, 3);
            this.RemoveFolderButton.Name = "RemoveFolderButton";
            this.RemoveFolderButton.Size = new System.Drawing.Size(60, 60);
            this.RemoveFolderButton.TabIndex = 3;
            this.ToolTip.SetToolTip(this.RemoveFolderButton, global::SwitchCheatCodeManager.Properties.Resources.RemoveFolderButton_Text);
            this.RemoveFolderButton.UseVisualStyleBackColor = true;
            this.RemoveFolderButton.Click += new System.EventHandler(this.RemoveFolderButton_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InputFolderPathLabelToolStripStatusLabel,
            this.OutputFolderPathLabelToolStripStatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 1279);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(1917, 43);
            this.StatusStrip.TabIndex = 5;
            this.StatusStrip.Text = "Status Strip";
            // 
            // InputFolderPathLabelToolStripStatusLabel
            // 
            this.InputFolderPathLabelToolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.InputFolderPathLabelToolStripStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.InputFolderPathLabelToolStripStatusLabel.Name = "InputFolderPathLabelToolStripStatusLabel";
            this.InputFolderPathLabelToolStripStatusLabel.Size = new System.Drawing.Size(951, 34);
            this.InputFolderPathLabelToolStripStatusLabel.Spring = true;
            this.InputFolderPathLabelToolStripStatusLabel.Text = global::SwitchCheatCodeManager.Properties.Resources.InputFolderPathLabelToolStripStatusLabel_Text;
            this.InputFolderPathLabelToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OutputFolderPathLabelToolStripStatusLabel
            // 
            this.OutputFolderPathLabelToolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.OutputFolderPathLabelToolStripStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OutputFolderPathLabelToolStripStatusLabel.Name = "OutputFolderPathLabelToolStripStatusLabel";
            this.OutputFolderPathLabelToolStripStatusLabel.Size = new System.Drawing.Size(951, 34);
            this.OutputFolderPathLabelToolStripStatusLabel.Spring = true;
            this.OutputFolderPathLabelToolStripStatusLabel.Text = global::SwitchCheatCodeManager.Properties.Resources.OutputFolderPathLabelToolStripStatusLabel_Text;
            this.OutputFolderPathLabelToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PreviewImageList
            // 
            this.PreviewImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.PreviewImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("PreviewImageList.ImageStream")));
            this.PreviewImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.PreviewImageList.Images.SetKeyName(0, "NoImage.jpg");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1917, 1322);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.NavigationFlowLayoutPanel);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.PathGroupBox);
            this.Controls.Add(this.GameNameGroupBox);
            this.Controls.Add(this.CodeSelectorGroupBox);
            this.Controls.Add(this.CodeEditorGroupBox);
            this.Controls.Add(this.SubCheatsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nintendo Switch Cheat Code Manager";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.PathGroupBox.ResumeLayout(false);
            this.PathGroupBox.PerformLayout();
            this.GameNameGroupBox.ResumeLayout(false);
            this.GameNameGroupBox.PerformLayout();
            this.CodeSelectorGroupBox.ResumeLayout(false);
            this.CodeSelectorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewImage)).EndInit();
            this.CodeEditorGroupBox.ResumeLayout(false);
            this.CodeEditorGroupBox.PerformLayout();
            this.NavigationFlowLayoutPanel.ResumeLayout(false);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip MenuStrip;
        private ToolStripMenuItem FileToolStripMenuItem;
        private ToolStripMenuItem NewToolStripMenuItem;
        private ToolStripMenuItem OpenToolStripMenuItem;
        private ToolStripSeparator ToolStripSeparator;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private ToolStripMenuItem SaveAsToolStripMenuItem;
        private ToolStripSeparator ToolStripSeparator1;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem ToolsToolStripMenuItem;
        private ToolStripMenuItem OptionsToolStripMenuItem;
        private ToolStripMenuItem HelpToolStripMenuItem;
        private ToolStripSeparator ToolStripSeparator2;
        private ToolStripMenuItem AboutToolStripMenuItem;
        private ImageList IconImageList;
        private ImageList NavigationImageList;
        private ImageList PreviewImageList;
        private ToolTip ToolTip;

        // NavigationFlowLayoutPanel
        private FlowLayoutPanel NavigationFlowLayoutPanel;
        private Button DefaultFileButton;
        private Button OpenFileButton;
        private Button InsertNewCheatsButton;
        private Button RemoveFolderButton;

        // PathGroupBox
        private GroupBox PathGroupBox;
        private FormEntity.TextBoxEx PathTextBox;
        private TextBox FilterTextBox;
        private FormEntity.ComboBoxEx GameListComboBox;
        private Button OpenFolderButton;

        // GameNameGroupBox
        private GroupBox GameNameGroupBox;
        private FormEntity.TextBoxEx GameNameTextBox;
        private Button VersionFileModeUpdateButton;
        private TextBox GameDBTidTextBox;
        private TextBox GameDBNameTextBox;
        private Button CopyFolderButton;

        // CodeSelectorGroupBox
        private GroupBox CodeSelectorGroupBox;
        private PictureBox PreviewImage;
        private FormEntity.ListBoxEx CodeSelectorListBox;
        private Label NumOfCheatsLabel;
        private Button AscendingOrderButton;
        private Button DescendingOrderButton;
        private Button InsertNewCheatButton;
        private Button RemoveCheatButton;
        private Button FormatFilesButton;

        // CodeEditorGroupBox
        private GroupBox CodeEditorGroupBox;
        private Label CodeStatusLabel;
        private Label BuildIdLabel;
        private TextBox BuildIdTextBox;
        private Label VersionLabel;
        private TextBox VersionNumberTextBox;
        private FormEntity.TextAreaEx CodeTextBox;
        private Button SaveOriginalButton;
        private Button CopyFileButton;
        private Button NewBlockButton;
        private Button UpdateButton;

        // -Removed
        private GroupBox CodeModifierGroupBox;
        private FormEntity.TextAreaEx CodeModifiedTextBox;
        private Button SaveFormatedButton;

        // SubCheatsGroupBox
        private GroupBox SubCheatsGroupBox;

        // SwitchCheatCodeManager
        private StatusStrip StatusStrip;
        private ToolStripStatusLabel InputFolderPathLabelToolStripStatusLabel;
        private ToolStripStatusLabel OutputFolderPathLabelToolStripStatusLabel;
    }
}

