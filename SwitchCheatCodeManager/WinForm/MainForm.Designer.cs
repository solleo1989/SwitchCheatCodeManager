using SwitchCheatCodeManager.Constant;
using SwitchCheatCodeManager.FormEntity;
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
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
            MenuStrip = new MenuStrip();
            FileToolStripMenuItem = new ToolStripMenuItem();
            NewToolStripMenuItem = new ToolStripMenuItem();
            OpenToolStripMenuItem = new ToolStripMenuItem();
            ToolStripSeparator = new ToolStripSeparator();
            SaveToolStripMenuItem = new ToolStripMenuItem();
            SaveAsToolStripMenuItem = new ToolStripMenuItem();
            ToolStripSeparator1 = new ToolStripSeparator();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            ToolsToolStripMenuItem = new ToolStripMenuItem();
            OptionsToolStripMenuItem = new ToolStripMenuItem();
            HelpToolStripMenuItem = new ToolStripMenuItem();
            AboutToolStripMenuItem = new ToolStripMenuItem();
            ToolStripSeparator2 = new ToolStripSeparator();
            PathGroupBox = new GroupBox();
            PathTextBox = new FormEntity.TextBoxEx();
            FilterTextBox = new SearchTextBox();
            GameListComboBox = new FormEntity.ComboBoxEx();
            OpenFolderButton = new Button();
            IconImageList = new ImageList(components);
            GameNameGroupBox = new GroupBox();
            GameNameTextBox = new FormEntity.TextBoxEx();
            VersionFileModeUpdateButton = new Button();
            GameDBTidTextBox = new TextBox();
            GameDBNameTextBox = new TextBox();
            CopyFolderButton = new Button();
            CodeModifierGroupBox = new GroupBox();
            CodeSelectorGroupBox = new GroupBox();
            PreviewImage = new PictureBox();
            CodeSelectorListBox = new FormEntity.ListBoxEx();
            NumOfCheatsLabel = new Label();
            AscendingOrderButton = new Button();
            DescendingOrderButton = new Button();
            InsertNewCheatButton = new Button();
            RemoveCheatButton = new Button();
            FormatFilesButton = new Button();
            CodeEditorGroupBox = new GroupBox();
            CodeStatusLabel = new Label();
            BuildIdLabel = new Label();
            BuildIdTextBox = new TextBox();
            VersionLabel = new Label();
            VersionNumberTextBox = new TextBox();
            CodeTextBox = new FormEntity.TextAreaEx();
            SaveOriginalButton = new Button();
            CopyFileButton = new Button();
            CodeBuilderButton = new Button();
            NewBlockButton = new Button();
            UpdateButton = new Button();
            SubCheatsGroupBox = new GroupBox();
            SaveFormatedButton = new Button();
            NavigationFlowLayoutPanel = new FlowLayoutPanel();
            DefaultFileButton = new Button();
            NavigationImageList = new ImageList(components);
            OpenFileButton = new Button();
            InsertNewCheatsButton = new Button();
            RemoveFolderButton = new Button();
            CompareButton = new Button();
            StatusStrip = new StatusStrip();
            InputFolderPathLabelToolStripStatusLabel = new ToolStripStatusLabel();
            OutputFolderPathLabelToolStripStatusLabel = new ToolStripStatusLabel();
            ToolTip = new ToolTip(components);
            PreviewImageList = new ImageList(components);
            MenuStrip.SuspendLayout();
            PathGroupBox.SuspendLayout();
            GameNameGroupBox.SuspendLayout();
            CodeSelectorGroupBox.SuspendLayout();
            ((ISupportInitialize)PreviewImage).BeginInit();
            CodeEditorGroupBox.SuspendLayout();
            NavigationFlowLayoutPanel.SuspendLayout();
            StatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            resources.ApplyResources(MenuStrip, "MenuStrip");
            MenuStrip.ImageScalingSize = new Size(32, 32);
            MenuStrip.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem, ToolsToolStripMenuItem, HelpToolStripMenuItem });
            MenuStrip.Name = "MenuStrip";
            ToolTip.SetToolTip(MenuStrip, resources.GetString("MenuStrip.ToolTip"));
            // 
            // FileToolStripMenuItem
            // 
            resources.ApplyResources(FileToolStripMenuItem, "FileToolStripMenuItem");
            FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewToolStripMenuItem, OpenToolStripMenuItem, ToolStripSeparator, SaveToolStripMenuItem, SaveAsToolStripMenuItem, ToolStripSeparator1, ExitToolStripMenuItem });
            FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            FileToolStripMenuItem.Text = Resources.MenuStrip_FileText;
            // 
            // NewToolStripMenuItem
            // 
            resources.ApplyResources(NewToolStripMenuItem, "NewToolStripMenuItem");
            NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            NewToolStripMenuItem.Text = Resources.MenuStrip_DefaultText;
            NewToolStripMenuItem.Click += DefaultFolderOpenButton_Click;
            // 
            // OpenToolStripMenuItem
            // 
            resources.ApplyResources(OpenToolStripMenuItem, "OpenToolStripMenuItem");
            OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            OpenToolStripMenuItem.Text = Resources.MenuStrip_OpenText;
            OpenToolStripMenuItem.Click += MainMenuOpenButton_Click;
            // 
            // ToolStripSeparator
            // 
            resources.ApplyResources(ToolStripSeparator, "ToolStripSeparator");
            ToolStripSeparator.Name = "ToolStripSeparator";
            // 
            // SaveToolStripMenuItem
            // 
            resources.ApplyResources(SaveToolStripMenuItem, "SaveToolStripMenuItem");
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.Text = Resources.MenuStrip_SaveText;
            SaveToolStripMenuItem.Click += SaveOriginalButton_Click;
            // 
            // SaveAsToolStripMenuItem
            // 
            resources.ApplyResources(SaveAsToolStripMenuItem, "SaveAsToolStripMenuItem");
            SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            SaveAsToolStripMenuItem.Text = Resources.MenuStrip_SaveAsText;
            SaveAsToolStripMenuItem.Click += SaveAsButton_Click;
            // 
            // ToolStripSeparator1
            // 
            resources.ApplyResources(ToolStripSeparator1, "ToolStripSeparator1");
            ToolStripSeparator1.Name = "ToolStripSeparator1";
            // 
            // ExitToolStripMenuItem
            // 
            resources.ApplyResources(ExitToolStripMenuItem, "ExitToolStripMenuItem");
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Text = Resources.MenuStrip_ExitText;
            ExitToolStripMenuItem.Click += CloseApplication;
            // 
            // ToolsToolStripMenuItem
            // 
            resources.ApplyResources(ToolsToolStripMenuItem, "ToolsToolStripMenuItem");
            ToolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OptionsToolStripMenuItem });
            ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            ToolsToolStripMenuItem.Text = Resources.MenuStrip_Tools;
            // 
            // OptionsToolStripMenuItem
            // 
            resources.ApplyResources(OptionsToolStripMenuItem, "OptionsToolStripMenuItem");
            OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
            OptionsToolStripMenuItem.Text = Resources.MenuStrip_Options;
            OptionsToolStripMenuItem.Click += OptionsButton_Click;
            // 
            // HelpToolStripMenuItem
            // 
            resources.ApplyResources(HelpToolStripMenuItem, "HelpToolStripMenuItem");
            HelpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutToolStripMenuItem });
            HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            HelpToolStripMenuItem.Text = Resources.MenuStrip_HelpText;
            // 
            // AboutToolStripMenuItem
            // 
            resources.ApplyResources(AboutToolStripMenuItem, "AboutToolStripMenuItem");
            AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            AboutToolStripMenuItem.Text = Resources.MenuStrip_About;
            AboutToolStripMenuItem.Click += AboutButton_Click;
            // 
            // ToolStripSeparator2
            // 
            resources.ApplyResources(ToolStripSeparator2, "ToolStripSeparator2");
            ToolStripSeparator2.Name = "ToolStripSeparator2";
            // 
            // PathGroupBox
            // 
            resources.ApplyResources(PathGroupBox, "PathGroupBox");
            PathGroupBox.Controls.Add(PathTextBox);
            PathGroupBox.Controls.Add(FilterTextBox);
            PathGroupBox.Controls.Add(GameListComboBox);
            PathGroupBox.Controls.Add(OpenFolderButton);
            PathGroupBox.Name = "PathGroupBox";
            PathGroupBox.TabStop = false;
            ToolTip.SetToolTip(PathGroupBox, resources.GetString("PathGroupBox.ToolTip"));
            // 
            // PathTextBox
            // 
            resources.ApplyResources(PathTextBox, "PathTextBox");
            PathTextBox.BackColor = SystemColors.InactiveBorder;
            PathTextBox.Name = "PathTextBox";
            PathTextBox.ReadOnly = true;
            ToolTip.SetToolTip(PathTextBox, resources.GetString("PathTextBox.ToolTip"));
            // 
            // FilterTextBox
            // 
            resources.ApplyResources(FilterTextBox, "FilterTextBox");
            FilterTextBox.Name = "FilterTextBox";
            FilterTextBox.PlaceholderText = Resources.KeywordSearchPlaceholderText;
            ToolTip.SetToolTip(FilterTextBox, resources.GetString("FilterTextBox.ToolTip"));
            FilterTextBox.DelayedTextChanged += FilterTextBox_TextChanged;
            // 
            // GameListComboBox
            // 
            resources.ApplyResources(GameListComboBox, "GameListComboBox");
            GameListComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            GameListComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GameListComboBox.FormattingEnabled = true;
            GameListComboBox.DropDownHeight = 50 * 20;
            GameListComboBox.Name = "GameListComboBox";
            ToolTip.SetToolTip(GameListComboBox, resources.GetString("GameListComboBox.ToolTip"));
            GameListComboBox.SelectedIndexChanged += GameListComboBox_SelectedIndexChanged;
            // 
            // OpenFolderButton
            // 
            resources.ApplyResources(OpenFolderButton, "OpenFolderButton");
            OpenFolderButton.ImageList = IconImageList;
            OpenFolderButton.Name = "OpenFolderButton";
            OpenFolderButton.Text = Resources.OpenFolderButton_Text;
            ToolTip.SetToolTip(OpenFolderButton, Resources.OpenFolderButton_Tooltip_Text);
            OpenFolderButton.UseVisualStyleBackColor = true;
            OpenFolderButton.Click += OpenFolderButton_Click;
            // 
            // IconImageList
            // 
            IconImageList.ColorDepth = ColorDepth.Depth32Bit;
            IconImageList.ImageStream = (ImageListStreamer)resources.GetObject("IconImageList.ImageStream");
            IconImageList.TransparentColor = Color.Transparent;
            IconImageList.Images.SetKeyName(0, "Add.png");
            IconImageList.Images.SetKeyName(1, "AddNew.png");
            IconImageList.Images.SetKeyName(2, "Convert.png");
            IconImageList.Images.SetKeyName(3, "Copy.png");
            IconImageList.Images.SetKeyName(4, "Down2.png");
            IconImageList.Images.SetKeyName(5, "Format.png");
            IconImageList.Images.SetKeyName(6, "Home.png");
            IconImageList.Images.SetKeyName(7, "Left.png");
            IconImageList.Images.SetKeyName(8, "Open.png");
            IconImageList.Images.SetKeyName(9, "Overwrite.png");
            IconImageList.Images.SetKeyName(10, "Right.png");
            IconImageList.Images.SetKeyName(11, "Save.png");
            IconImageList.Images.SetKeyName(12, "Settings.png");
            IconImageList.Images.SetKeyName(13, "Up2.png");
            IconImageList.Images.SetKeyName(14, "Remove.png");
            IconImageList.Images.SetKeyName(15, "Open3.png");
            IconImageList.Images.SetKeyName(16, "Save3.png");
            IconImageList.Images.SetKeyName(17, "");
            // 
            // GameNameGroupBox
            // 
            resources.ApplyResources(GameNameGroupBox, "GameNameGroupBox");
            GameNameGroupBox.Controls.Add(GameNameTextBox);
            GameNameGroupBox.Controls.Add(VersionFileModeUpdateButton);
            GameNameGroupBox.Controls.Add(GameDBTidTextBox);
            GameNameGroupBox.Controls.Add(GameDBNameTextBox);
            GameNameGroupBox.Controls.Add(CopyFolderButton);
            GameNameGroupBox.Name = "GameNameGroupBox";
            GameNameGroupBox.TabStop = false;
            ToolTip.SetToolTip(GameNameGroupBox, resources.GetString("GameNameGroupBox.ToolTip"));
            // 
            // GameNameTextBox
            // 
            resources.ApplyResources(GameNameTextBox, "GameNameTextBox");
            GameNameTextBox.Name = "GameNameTextBox";
            ToolTip.SetToolTip(GameNameTextBox, resources.GetString("GameNameTextBox.ToolTip"));
            GameNameTextBox.TextChanged += GameNameTextBox_TextChanged;
            // 
            // VersionFileModeUpdateButton
            // 
            resources.ApplyResources(VersionFileModeUpdateButton, "VersionFileModeUpdateButton");
            VersionFileModeUpdateButton.ImageList = IconImageList;
            VersionFileModeUpdateButton.Name = "VersionFileModeUpdateButton";
            VersionFileModeUpdateButton.Text = Resources.VersionFileModeUpdateButton_Text;
            ToolTip.SetToolTip(VersionFileModeUpdateButton, Resources.VersionFileModeUpdateButton_Tooltip_Text);
            VersionFileModeUpdateButton.UseVisualStyleBackColor = true;
            VersionFileModeUpdateButton.Click += VersionFileModeUpdateButton_Click;
            // 
            // GameDBTidTextBox
            // 
            resources.ApplyResources(GameDBTidTextBox, "GameDBTidTextBox");
            GameDBTidTextBox.BackColor = SystemColors.ControlLight;
            GameDBTidTextBox.Name = "GameDBTidTextBox";
            GameDBTidTextBox.ReadOnly = true;
            ToolTip.SetToolTip(GameDBTidTextBox, resources.GetString("GameDBTidTextBox.ToolTip"));
            // 
            // GameDBNameTextBox
            // 
            resources.ApplyResources(GameDBNameTextBox, "GameDBNameTextBox");
            GameDBNameTextBox.BackColor = SystemColors.ControlLight;
            GameDBNameTextBox.Name = "GameDBNameTextBox";
            GameDBNameTextBox.ReadOnly = true;
            ToolTip.SetToolTip(GameDBNameTextBox, resources.GetString("GameDBNameTextBox.ToolTip"));
            // 
            // CopyFolderButton
            // 
            resources.ApplyResources(CopyFolderButton, "CopyFolderButton");
            CopyFolderButton.ImageList = IconImageList;
            CopyFolderButton.Name = "CopyFolderButton";
            CopyFolderButton.Text = Resources.CopyFolderButton_Text;
            ToolTip.SetToolTip(CopyFolderButton, Resources.CopyFolderButton_Tooltip_Text);
            CopyFolderButton.UseVisualStyleBackColor = true;
            CopyFolderButton.Click += CopyFolderButton_Click;
            // 
            // CodeModifierGroupBox
            // 
            resources.ApplyResources(CodeModifierGroupBox, "CodeModifierGroupBox");
            CodeModifierGroupBox.Name = "CodeModifierGroupBox";
            CodeModifierGroupBox.TabStop = false;
            CodeModifierGroupBox.Text = Resources.CodeModifierGroupBox_Text;
            ToolTip.SetToolTip(CodeModifierGroupBox, resources.GetString("CodeModifierGroupBox.ToolTip"));
            // 
            // CodeSelectorGroupBox
            // 
            resources.ApplyResources(CodeSelectorGroupBox, "CodeSelectorGroupBox");
            CodeSelectorGroupBox.Controls.Add(PreviewImage);
            CodeSelectorGroupBox.Controls.Add(CodeSelectorListBox);
            CodeSelectorGroupBox.Controls.Add(NumOfCheatsLabel);
            CodeSelectorGroupBox.Controls.Add(AscendingOrderButton);
            CodeSelectorGroupBox.Controls.Add(DescendingOrderButton);
            CodeSelectorGroupBox.Controls.Add(InsertNewCheatButton);
            CodeSelectorGroupBox.Controls.Add(RemoveCheatButton);
            CodeSelectorGroupBox.Controls.Add(FormatFilesButton);
            CodeSelectorGroupBox.Name = "CodeSelectorGroupBox";
            CodeSelectorGroupBox.TabStop = false;
            ToolTip.SetToolTip(CodeSelectorGroupBox, resources.GetString("CodeSelectorGroupBox.ToolTip"));
            // 
            // PreviewImage
            // 
            resources.ApplyResources(PreviewImage, "PreviewImage");
            PreviewImage.BorderStyle = BorderStyle.FixedSingle;
            PreviewImage.Name = "PreviewImage";
            PreviewImage.TabStop = false;
            ToolTip.SetToolTip(PreviewImage, resources.GetString("PreviewImage.ToolTip"));
            PreviewImage.DoubleClick += PreviewImage_DoubleClick;
            // 
            // CodeSelectorListBox
            // 
            resources.ApplyResources(CodeSelectorListBox, "CodeSelectorListBox");
            CodeSelectorListBox.DrawMode = DrawMode.OwnerDrawFixed;
            CodeSelectorListBox.FormattingEnabled = true;
            CodeSelectorListBox.Name = "CodeSelectorListBox";
            ToolTip.SetToolTip(CodeSelectorListBox, resources.GetString("CodeSelectorListBox.ToolTip"));
            CodeSelectorListBox.SelectedIndexChanged += CodeSelectorListBox_SelectedIndexChanged;
            CodeSelectorListBox.DoubleClick += CodeSelectorListBox_DoubleClick;
            // 
            // NumOfCheatsLabel
            // 
            resources.ApplyResources(NumOfCheatsLabel, "NumOfCheatsLabel");
            NumOfCheatsLabel.Name = "NumOfCheatsLabel";
            ToolTip.SetToolTip(NumOfCheatsLabel, resources.GetString("NumOfCheatsLabel.ToolTip"));
            // 
            // AscendingOrderButton
            // 
            resources.ApplyResources(AscendingOrderButton, "AscendingOrderButton");
            AscendingOrderButton.ImageList = IconImageList;
            AscendingOrderButton.Name = "AscendingOrderButton";
            ToolTip.SetToolTip(AscendingOrderButton, Resources.AscendingOrderButton_Text);
            AscendingOrderButton.UseVisualStyleBackColor = true;
            AscendingOrderButton.Click += AscendingOrderButton_Click;
            // 
            // DescendingOrderButton
            // 
            resources.ApplyResources(DescendingOrderButton, "DescendingOrderButton");
            DescendingOrderButton.ImageList = IconImageList;
            DescendingOrderButton.Name = "DescendingOrderButton";
            ToolTip.SetToolTip(DescendingOrderButton, Resources.DescendingOrderButton_Text);
            DescendingOrderButton.UseVisualStyleBackColor = true;
            DescendingOrderButton.Click += DescendingOrderButton_Click;
            // 
            // InsertNewCheatButton
            // 
            resources.ApplyResources(InsertNewCheatButton, "InsertNewCheatButton");
            InsertNewCheatButton.ImageList = IconImageList;
            InsertNewCheatButton.Name = "InsertNewCheatButton";
            ToolTip.SetToolTip(InsertNewCheatButton, Resources.InsertNewCheatButton_Text);
            InsertNewCheatButton.UseVisualStyleBackColor = true;
            InsertNewCheatButton.Click += InsertNewCheatButton_Click;
            // 
            // RemoveCheatButton
            // 
            resources.ApplyResources(RemoveCheatButton, "RemoveCheatButton");
            RemoveCheatButton.ImageList = IconImageList;
            RemoveCheatButton.Name = "RemoveCheatButton";
            ToolTip.SetToolTip(RemoveCheatButton, Resources.RemoveCheatButton_Text);
            RemoveCheatButton.UseVisualStyleBackColor = true;
            RemoveCheatButton.Click += RemoveCheatButton_Click;
            // 
            // FormatFilesButton
            // 
            resources.ApplyResources(FormatFilesButton, "FormatFilesButton");
            FormatFilesButton.ImageList = IconImageList;
            FormatFilesButton.Name = "FormatFilesButton";
            ToolTip.SetToolTip(FormatFilesButton, Resources.FormatFilesButton_Text);
            FormatFilesButton.UseVisualStyleBackColor = true;
            FormatFilesButton.Click += FormatFilesButton_Click;
            // 
            // CodeEditorGroupBox
            // 
            resources.ApplyResources(CodeEditorGroupBox, "CodeEditorGroupBox");
            CodeEditorGroupBox.Controls.Add(CodeStatusLabel);
            CodeEditorGroupBox.Controls.Add(BuildIdLabel);
            CodeEditorGroupBox.Controls.Add(BuildIdTextBox);
            CodeEditorGroupBox.Controls.Add(VersionLabel);
            CodeEditorGroupBox.Controls.Add(VersionNumberTextBox);
            CodeEditorGroupBox.Controls.Add(CodeTextBox);
            CodeEditorGroupBox.Controls.Add(SaveOriginalButton);
            CodeEditorGroupBox.Controls.Add(CopyFileButton);
            CodeEditorGroupBox.Controls.Add(CodeBuilderButton);
            CodeEditorGroupBox.Controls.Add(NewBlockButton);
            CodeEditorGroupBox.Controls.Add(UpdateButton);
            CodeEditorGroupBox.Name = "CodeEditorGroupBox";
            CodeEditorGroupBox.TabStop = false;
            ToolTip.SetToolTip(CodeEditorGroupBox, resources.GetString("CodeEditorGroupBox.ToolTip"));
            // 
            // CodeStatusLabel
            // 
            resources.ApplyResources(CodeStatusLabel, "CodeStatusLabel");
            CodeStatusLabel.Name = "CodeStatusLabel";
            ToolTip.SetToolTip(CodeStatusLabel, resources.GetString("CodeStatusLabel.ToolTip"));
            // 
            // BuildIdLabel
            // 
            resources.ApplyResources(BuildIdLabel, "BuildIdLabel");
            BuildIdLabel.Name = "BuildIdLabel";
            ToolTip.SetToolTip(BuildIdLabel, resources.GetString("BuildIdLabel.ToolTip"));
            // 
            // BuildIdTextBox
            // 
            resources.ApplyResources(BuildIdTextBox, "BuildIdTextBox");
            BuildIdTextBox.Name = "BuildIdTextBox";
            BuildIdTextBox.ReadOnly = true;
            ToolTip.SetToolTip(BuildIdTextBox, resources.GetString("BuildIdTextBox.ToolTip"));
            // 
            // VersionLabel
            // 
            resources.ApplyResources(VersionLabel, "VersionLabel");
            VersionLabel.Name = "VersionLabel";
            ToolTip.SetToolTip(VersionLabel, resources.GetString("VersionLabel.ToolTip"));
            // 
            // VersionNumberTextBox
            // 
            resources.ApplyResources(VersionNumberTextBox, "VersionNumberTextBox");
            VersionNumberTextBox.Name = "VersionNumberTextBox";
            VersionNumberTextBox.ReadOnly = true;
            ToolTip.SetToolTip(VersionNumberTextBox, resources.GetString("VersionNumberTextBox.ToolTip"));
            // 
            // CodeTextBox
            // 
            resources.ApplyResources(CodeTextBox, "CodeTextBox");
            CodeTextBox.Name = "CodeTextBox";
            //CodeTextBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CodeTextBox_MouseMove);
            CodeTextBox.MouseHover += new System.EventHandler(this.CodeTextBox_MouseHover);
            // 
            // SaveOriginalButton
            // 
            resources.ApplyResources(SaveOriginalButton, "SaveOriginalButton");
            SaveOriginalButton.ImageList = IconImageList;
            SaveOriginalButton.Name = "SaveOriginalButton";
            SaveOriginalButton.Text = Resources.SaveOriginalButton_Text;
            ToolTip.SetToolTip(SaveOriginalButton, Resources.SaveOriginalButton_Tooltip_Text);
            SaveOriginalButton.UseVisualStyleBackColor = true;
            SaveOriginalButton.Click += SaveOriginalButton_Click;
            // 
            // CopyFileButton
            // 
            resources.ApplyResources(CopyFileButton, "CopyFileButton");
            CopyFileButton.ImageList = IconImageList;
            CopyFileButton.Name = "CopyFileButton";
            CopyFileButton.Text = Resources.CopyFileButton_Text;
            ToolTip.SetToolTip(CopyFileButton, Resources.CopyFileButton_Tooltip_Text);
            CopyFileButton.UseVisualStyleBackColor = true;
            CopyFileButton.Click += CopyFileButton_Click;
            // 
            // CodeBuilderButton
            // 
            resources.ApplyResources(CodeBuilderButton, "CodeBuilderButton");
            CodeBuilderButton.ImageList = IconImageList;
            CodeBuilderButton.Name = "CodeBuilderButton";
            CodeBuilderButton.Text = Resources.CodeBuilderButton_Text;
            ToolTip.SetToolTip(CodeBuilderButton, Resources.CodeBuilderButton_Tooltip_Text);
            CodeBuilderButton.UseVisualStyleBackColor = true;
            CodeBuilderButton.Click += CodeBuilderButton_Click;
            // 
            // NewBlockButton
            // 
            resources.ApplyResources(NewBlockButton, "NewBlockButton");
            NewBlockButton.ImageList = IconImageList;
            NewBlockButton.Name = "NewBlockButton";
            NewBlockButton.Text = Resources.NewBlockButton_Text;
            ToolTip.SetToolTip(NewBlockButton, Resources.NewBlockButton_Tooltip_Text);
            NewBlockButton.UseVisualStyleBackColor = true;
            NewBlockButton.Click += InsertNewSubSectionBlockButton_Click;
            // 
            // UpdateButton
            // 
            resources.ApplyResources(UpdateButton, "UpdateButton");
            UpdateButton.ImageList = IconImageList;
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Text = Resources.UpdateButton_Text;
            ToolTip.SetToolTip(UpdateButton, Resources.UpdateButton_Tooltip_Text);
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateCheatContentsInTextBoxButton_Click;
            // 
            // SubCheatsGroupBox
            // 
            resources.ApplyResources(SubCheatsGroupBox, "SubCheatsGroupBox");
            SubCheatsGroupBox.Name = "SubCheatsGroupBox";
            SubCheatsGroupBox.TabStop = false;
            ToolTip.SetToolTip(SubCheatsGroupBox, resources.GetString("SubCheatsGroupBox.ToolTip"));
            // 
            // SaveFormatedButton
            // 
            resources.ApplyResources(SaveFormatedButton, "SaveFormatedButton");
            SaveFormatedButton.Name = "SaveFormatedButton";
            SaveFormatedButton.Text = Resources.SaveFormatedButton_Text;
            ToolTip.SetToolTip(SaveFormatedButton, resources.GetString("SaveFormatedButton.ToolTip"));
            SaveFormatedButton.UseVisualStyleBackColor = true;
            // 
            // NavigationFlowLayoutPanel
            // 
            resources.ApplyResources(NavigationFlowLayoutPanel, "NavigationFlowLayoutPanel");
            NavigationFlowLayoutPanel.Controls.Add(DefaultFileButton);
            NavigationFlowLayoutPanel.Controls.Add(OpenFileButton);
            NavigationFlowLayoutPanel.Controls.Add(InsertNewCheatsButton);
            NavigationFlowLayoutPanel.Controls.Add(RemoveFolderButton);
            NavigationFlowLayoutPanel.Controls.Add(CompareButton);
            NavigationFlowLayoutPanel.Name = "NavigationFlowLayoutPanel";
            ToolTip.SetToolTip(NavigationFlowLayoutPanel, resources.GetString("NavigationFlowLayoutPanel.ToolTip"));
            // 
            // DefaultFileButton
            // 
            resources.ApplyResources(DefaultFileButton, "DefaultFileButton");
            DefaultFileButton.ImageList = NavigationImageList;
            DefaultFileButton.Name = "DefaultFileButton";
            ToolTip.SetToolTip(DefaultFileButton, Resources.DefaultFileButton_Tooltip_Text);
            DefaultFileButton.UseVisualStyleBackColor = true;
            DefaultFileButton.Click += DefaultFolderOpenButton_Click;
            // 
            // NavigationImageList
            // 
            NavigationImageList.ColorDepth = ColorDepth.Depth32Bit;
            NavigationImageList.ImageStream = (ImageListStreamer)resources.GetObject("NavigationImageList.ImageStream");
            NavigationImageList.TransparentColor = Color.Transparent;
            NavigationImageList.Images.SetKeyName(0, "Home.png");
            NavigationImageList.Images.SetKeyName(1, "Open.png");
            NavigationImageList.Images.SetKeyName(2, "Open2.png");
            NavigationImageList.Images.SetKeyName(3, "Remove2.png");
            NavigationImageList.Images.SetKeyName(4, "Compare.png");
            // 
            // OpenFileButton
            // 
            resources.ApplyResources(OpenFileButton, "OpenFileButton");
            OpenFileButton.ImageList = NavigationImageList;
            OpenFileButton.Name = "OpenFileButton";
            ToolTip.SetToolTip(OpenFileButton, Resources.OpenFileButton_Tooltip_Text);
            OpenFileButton.UseVisualStyleBackColor = true;
            OpenFileButton.Click += MainMenuOpenButton_Click;
            // 
            // InsertNewCheatsButton
            // 
            resources.ApplyResources(InsertNewCheatsButton, "InsertNewCheatsButton");
            InsertNewCheatsButton.ImageList = NavigationImageList;
            InsertNewCheatsButton.Name = "InsertNewCheatsButton";
            ToolTip.SetToolTip(InsertNewCheatsButton, Resources.InsertNewCheatsButton_Tooltip_Text);
            InsertNewCheatsButton.UseVisualStyleBackColor = true;
            InsertNewCheatsButton.Click += InsertNewCheatsButton_Click;
            // 
            // RemoveFolderButton
            // 
            resources.ApplyResources(RemoveFolderButton, "RemoveFolderButton");
            RemoveFolderButton.ImageList = NavigationImageList;
            RemoveFolderButton.Name = "RemoveFolderButton";
            ToolTip.SetToolTip(RemoveFolderButton, Resources.RemoveFolderButton_Text);
            RemoveFolderButton.UseVisualStyleBackColor = true;
            RemoveFolderButton.Click += RemoveFolderButton_Click;
            // 
            // CompareButton
            // 
            resources.ApplyResources(CompareButton, "CompareButton");
            CompareButton.ImageList = NavigationImageList;
            CompareButton.Name = "CompareButton";
            ToolTip.SetToolTip(CompareButton, Resources.CompareCheatsButton_Text);
            CompareButton.UseVisualStyleBackColor = true;
            CompareButton.Click += CompareCheatsButton_Click;
            // 
            // StatusStrip
            // 
            resources.ApplyResources(StatusStrip, "StatusStrip");
            StatusStrip.ImageScalingSize = new Size(28, 28);
            StatusStrip.Items.AddRange(new ToolStripItem[] { InputFolderPathLabelToolStripStatusLabel, OutputFolderPathLabelToolStripStatusLabel });
            StatusStrip.Name = "StatusStrip";
            ToolTip.SetToolTip(StatusStrip, resources.GetString("StatusStrip.ToolTip"));
            // 
            // InputFolderPathLabelToolStripStatusLabel
            // 
            resources.ApplyResources(InputFolderPathLabelToolStripStatusLabel, "InputFolderPathLabelToolStripStatusLabel");
            InputFolderPathLabelToolStripStatusLabel.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            InputFolderPathLabelToolStripStatusLabel.DisplayStyle = ToolStripItemDisplayStyle.Text;
            InputFolderPathLabelToolStripStatusLabel.Name = "InputFolderPathLabelToolStripStatusLabel";
            InputFolderPathLabelToolStripStatusLabel.Spring = true;
            InputFolderPathLabelToolStripStatusLabel.Text = Resources.InputFolderPathLabelToolStripStatusLabel_Text;
            // 
            // OutputFolderPathLabelToolStripStatusLabel
            // 
            resources.ApplyResources(OutputFolderPathLabelToolStripStatusLabel, "OutputFolderPathLabelToolStripStatusLabel");
            OutputFolderPathLabelToolStripStatusLabel.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            OutputFolderPathLabelToolStripStatusLabel.DisplayStyle = ToolStripItemDisplayStyle.Text;
            OutputFolderPathLabelToolStripStatusLabel.Name = "OutputFolderPathLabelToolStripStatusLabel";
            OutputFolderPathLabelToolStripStatusLabel.Spring = true;
            OutputFolderPathLabelToolStripStatusLabel.Text = Resources.OutputFolderPathLabelToolStripStatusLabel_Text;
            // 
            // PreviewImageList
            // 
            PreviewImageList.ColorDepth = ColorDepth.Depth32Bit;
            PreviewImageList.ImageStream = (ImageListStreamer)resources.GetObject("PreviewImageList.ImageStream");
            PreviewImageList.TransparentColor = Color.Transparent;
            PreviewImageList.Images.SetKeyName(0, "NoImage.jpg");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(StatusStrip);
            Controls.Add(NavigationFlowLayoutPanel);
            Controls.Add(MenuStrip);
            Controls.Add(PathGroupBox);
            Controls.Add(GameNameGroupBox);
            Controls.Add(CodeSelectorGroupBox);
            Controls.Add(CodeEditorGroupBox);
            Controls.Add(SubCheatsGroupBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = MenuStrip;
            Name = "MainForm";
            ToolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            PathGroupBox.ResumeLayout(false);
            PathGroupBox.PerformLayout();
            GameNameGroupBox.ResumeLayout(false);
            GameNameGroupBox.PerformLayout();
            CodeSelectorGroupBox.ResumeLayout(false);
            CodeSelectorGroupBox.PerformLayout();
            ((ISupportInitialize)PreviewImage).EndInit();
            CodeEditorGroupBox.ResumeLayout(false);
            CodeEditorGroupBox.PerformLayout();
            NavigationFlowLayoutPanel.ResumeLayout(false);
            StatusStrip.ResumeLayout(false);
            StatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private SearchTextBox FilterTextBox;
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
        private Button CodeBuilderButton;
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
        private Button CompareButton;
    }
}

