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
            this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
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
            this.ToolsToolStripMenuItem,
            this.HelpToolStripMenuItem});
            resources.ApplyResources(this.MenuStrip, "MenuStrip");
            this.MenuStrip.Name = global::SwitchCheatCodeManager.Properties.Resources.MenuStrip;
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
            resources.ApplyResources(this.FileToolStripMenuItem, "FileToolStripMenuItem");
            this.FileToolStripMenuItem.Text = global::SwitchCheatCodeManager.Properties.Resources.MenuStrip_FileText;
            // 
            // NewToolStripMenuItem
            // 
            resources.ApplyResources(this.NewToolStripMenuItem, "NewToolStripMenuItem");
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Text = global::SwitchCheatCodeManager.Properties.Resources.MenuStrip_DefaultText;
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.DefaultFolderOpenButton_Click);
            // 
            // OpenToolStripMenuItem
            // 
            resources.ApplyResources(this.OpenToolStripMenuItem, "OpenToolStripMenuItem");
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Text = global::SwitchCheatCodeManager.Properties.Resources.MenuStrip_OpenText;
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.MainMenuOpenButton_Click);
            // 
            // ToolStripSeparator
            // 
            this.ToolStripSeparator.Name = "ToolStripSeparator";
            resources.ApplyResources(this.ToolStripSeparator, "ToolStripSeparator");
            // 
            // SaveToolStripMenuItem
            // 
            resources.ApplyResources(this.SaveToolStripMenuItem, "SaveToolStripMenuItem");
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Text = global::SwitchCheatCodeManager.Properties.Resources.MenuStrip_SaveText;
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveOriginalButton_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            resources.ApplyResources(this.SaveAsToolStripMenuItem, "SaveAsToolStripMenuItem");
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Text = global::SwitchCheatCodeManager.Properties.Resources.MenuStrip_SaveAsText;
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsButton_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            resources.ApplyResources(this.ToolStripSeparator1, "ToolStripSeparator1");
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            resources.ApplyResources(this.ExitToolStripMenuItem, "ExitToolStripMenuItem");
            this.ExitToolStripMenuItem.Text = global::SwitchCheatCodeManager.Properties.Resources.MenuStrip_ExitText;
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.CloseApplication);
            // 
            // ToolsToolStripMenuItem
            // 
            this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsToolStripMenuItem});
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            resources.ApplyResources(this.ToolsToolStripMenuItem, "ToolsToolStripMenuItem");
            this.ToolsToolStripMenuItem.Text = global::SwitchCheatCodeManager.Properties.Resources.MenuStrip_Tools;
            // 
            // OptionsToolStripMenuItem
            // 
            this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
            resources.ApplyResources(this.OptionsToolStripMenuItem, "OptionsToolStripMenuItem");
            this.OptionsToolStripMenuItem.Text = global::SwitchCheatCodeManager.Properties.Resources.MenuStrip_Options;
            this.OptionsToolStripMenuItem.Click += new System.EventHandler(this.OptionsButton_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            resources.ApplyResources(this.HelpToolStripMenuItem, "HelpToolStripMenuItem");
            this.HelpToolStripMenuItem.Text = global::SwitchCheatCodeManager.Properties.Resources.MenuStrip_HelpText;
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            resources.ApplyResources(this.AboutToolStripMenuItem, "AboutToolStripMenuItem");
            this.AboutToolStripMenuItem.Text = global::SwitchCheatCodeManager.Properties.Resources.MenuStrip_About;
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            resources.ApplyResources(this.ToolStripSeparator2, "ToolStripSeparator2");
            // 
            // PathGroupBox
            // 
            this.PathGroupBox.Controls.Add(this.PathTextBox);
            this.PathGroupBox.Controls.Add(this.FilterTextBox);
            this.PathGroupBox.Controls.Add(this.GameListComboBox);
            this.PathGroupBox.Controls.Add(this.OpenFolderButton);
            resources.ApplyResources(this.PathGroupBox, "PathGroupBox");
            this.PathGroupBox.Name = "PathGroupBox";
            this.PathGroupBox.TabStop = false;
            this.PathGroupBox.Text = global::SwitchCheatCodeManager.Properties.Resources.PathGroupBox_Text;
            // 
            // PathTextBox
            // 
            this.PathTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            resources.ApplyResources(this.PathTextBox, "PathTextBox");
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.ReadOnly = true;
            // 
            // FilterTextBox
            // 
            resources.ApplyResources(this.FilterTextBox, "FilterTextBox");
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.PlaceholderText = global::SwitchCheatCodeManager.Properties.Resources.KeywordSearchPlaceholderText;
            this.FilterTextBox.TextChanged += new System.EventHandler(this.FilterTextBox_TextChanged);
            // 
            // GameListComboBox
            // 
            this.GameListComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GameListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.GameListComboBox, "GameListComboBox");
            this.GameListComboBox.FormattingEnabled = true;
            this.GameListComboBox.Name = "GameListComboBox";
            this.GameListComboBox.SelectedIndexChanged += new System.EventHandler(this.GameListComboBox_SelectedIndexChanged);
            // 
            // OpenFolderButton
            // 
            resources.ApplyResources(this.OpenFolderButton, "OpenFolderButton");
            this.OpenFolderButton.ImageList = this.IconImageList;
            this.OpenFolderButton.Name = "OpenFolderButton";
            this.OpenFolderButton.Text = global::SwitchCheatCodeManager.Properties.Resources.OpenFolderButton_Text;
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
            resources.ApplyResources(this.GameNameGroupBox, "GameNameGroupBox");
            this.GameNameGroupBox.Name = "GameNameGroupBox";
            this.GameNameGroupBox.Text = global::SwitchCheatCodeManager.Properties.Resources.GameNameGroupBoxText;
            this.GameNameGroupBox.TabStop = false;
            // 
            // GameNameTextBox
            // 
            resources.ApplyResources(this.GameNameTextBox, "GameNameTextBox");
            this.GameNameTextBox.Name = "GameNameTextBox";
            this.GameNameTextBox.TextChanged += new System.EventHandler(this.GameNameTextBox_TextChanged);
            // 
            // VersionFileModeUpdateButton
            // 
            resources.ApplyResources(this.VersionFileModeUpdateButton, "VersionFileModeUpdateButton");
            this.VersionFileModeUpdateButton.ImageList = this.IconImageList;
            this.VersionFileModeUpdateButton.Name = "VersionFileModeUpdateButton";
            this.VersionFileModeUpdateButton.Text = global::SwitchCheatCodeManager.Properties.Resources.VersionFileModeUpdateButton_Text;
            this.ToolTip.SetToolTip(this.VersionFileModeUpdateButton, global::SwitchCheatCodeManager.Properties.Resources.VersionFileModeUpdateButton_Tooltip_Text);
            this.VersionFileModeUpdateButton.UseVisualStyleBackColor = true;
            this.VersionFileModeUpdateButton.Click += new System.EventHandler(this.VersionFileModeUpdateButton_Click);
            // 
            // GameDBTidTextBox
            // 
            this.GameDBTidTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.GameDBTidTextBox, "GameDBTidTextBox");
            this.GameDBTidTextBox.Name = "GameDBTidTextBox";
            this.GameDBTidTextBox.ReadOnly = true;
            // 
            // GameDBNameTextBox
            // 
            this.GameDBNameTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.GameDBNameTextBox, "GameDBNameTextBox");
            this.GameDBNameTextBox.Name = "GameDBNameTextBox";
            this.GameDBNameTextBox.ReadOnly = true;
            // 
            // CopyFolderButton
            // 
            resources.ApplyResources(this.CopyFolderButton, "CopyFolderButton");
            this.CopyFolderButton.ImageList = this.IconImageList;
            this.CopyFolderButton.Name = "CopyFolderButton";
            this.CopyFolderButton.Text = global::SwitchCheatCodeManager.Properties.Resources.CopyFolderButton_Text;
            this.ToolTip.SetToolTip(this.CopyFolderButton, global::SwitchCheatCodeManager.Properties.Resources.CopyFolderButton_Tooltip_Text);
            this.CopyFolderButton.UseVisualStyleBackColor = true;
            this.CopyFolderButton.Click += new System.EventHandler(this.CopyFolderButton_Click);
            // 
            // CodeModifierGroupBox
            // 
            resources.ApplyResources(this.CodeModifierGroupBox, "CodeModifierGroupBox");
            this.CodeModifierGroupBox.Name = "CodeModifierGroupBox";
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
            resources.ApplyResources(this.CodeSelectorGroupBox, "CodeSelectorGroupBox");
            this.CodeSelectorGroupBox.Name = "CodeSelectorGroupBox";
            this.CodeSelectorGroupBox.TabStop = false;
            this.CodeSelectorGroupBox.Text = global::SwitchCheatCodeManager.Properties.Resources.CodeSelectorGroupBox_Text;
            // 
            // PreviewImage
            // 
            this.PreviewImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PreviewImage, "PreviewImage");
            this.PreviewImage.Name = "PreviewImage";
            this.PreviewImage.TabStop = false;
            this.PreviewImage.DoubleClick += new System.EventHandler(this.PreviewImage_DoubleClick);
            // 
            // CodeSelectorListBox
            // 
            this.CodeSelectorListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            resources.ApplyResources(this.CodeSelectorListBox, "CodeSelectorListBox");
            this.CodeSelectorListBox.FormattingEnabled = true;
            this.CodeSelectorListBox.Name = "CodeSelectorListBox";
            this.CodeSelectorListBox.SelectedIndexChanged += new System.EventHandler(this.CodeSelectorListBox_SelectedIndexChanged);
            this.CodeSelectorListBox.DoubleClick += new System.EventHandler(this.CodeSelectorListBox_DoubleClick);
            // 
            // NumOfCheatsLabel
            // 
            resources.ApplyResources(this.NumOfCheatsLabel, "NumOfCheatsLabel");
            this.NumOfCheatsLabel.Name = "NumOfCheatsLabel";
            // 
            // AscendingOrderButton
            // 
            resources.ApplyResources(this.AscendingOrderButton, "AscendingOrderButton");
            this.AscendingOrderButton.ImageList = this.IconImageList;
            this.AscendingOrderButton.Name = "AscendingOrderButton";
            this.ToolTip.SetToolTip(this.AscendingOrderButton, global::SwitchCheatCodeManager.Properties.Resources.AscendingOrderButton_Text);
            this.AscendingOrderButton.UseVisualStyleBackColor = true;
            this.AscendingOrderButton.Click += new System.EventHandler(this.AscendingOrderButton_Click);
            // 
            // DescendingOrderButton
            // 
            resources.ApplyResources(this.DescendingOrderButton, "DescendingOrderButton");
            this.DescendingOrderButton.ImageList = this.IconImageList;
            this.DescendingOrderButton.Name = "DescendingOrderButton";
            this.ToolTip.SetToolTip(this.DescendingOrderButton, global::SwitchCheatCodeManager.Properties.Resources.DescendingOrderButton_Text);
            this.DescendingOrderButton.UseVisualStyleBackColor = true;
            this.DescendingOrderButton.Click += new System.EventHandler(this.DescendingOrderButton_Click);
            // 
            // InsertNewCheatButton
            // 
            resources.ApplyResources(this.InsertNewCheatButton, "InsertNewCheatButton");
            this.InsertNewCheatButton.ImageList = this.IconImageList;
            this.InsertNewCheatButton.Name = "InsertNewCheatButton";
            this.ToolTip.SetToolTip(this.InsertNewCheatButton, global::SwitchCheatCodeManager.Properties.Resources.InsertNewCheatButton_Text);
            this.InsertNewCheatButton.UseVisualStyleBackColor = true;
            this.InsertNewCheatButton.Click += new System.EventHandler(this.InsertNewCheatButton_Click);
            // 
            // RemoveCheatButton
            // 
            resources.ApplyResources(this.RemoveCheatButton, "RemoveCheatButton");
            this.RemoveCheatButton.ImageList = this.IconImageList;
            this.RemoveCheatButton.Name = "RemoveCheatButton";
            this.ToolTip.SetToolTip(this.RemoveCheatButton, global::SwitchCheatCodeManager.Properties.Resources.RemoveCheatButton_Text);
            this.RemoveCheatButton.UseVisualStyleBackColor = true;
            this.RemoveCheatButton.Click += new System.EventHandler(this.RemoveCheatButton_Click);
            // 
            // FormatFilesButton
            // 
            resources.ApplyResources(this.FormatFilesButton, "FormatFilesButton");
            this.FormatFilesButton.ImageList = this.IconImageList;
            this.FormatFilesButton.Name = "FormatFilesButton";
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
            resources.ApplyResources(this.CodeEditorGroupBox, "CodeEditorGroupBox");
            this.CodeEditorGroupBox.Name = "CodeEditorGroupBox";
            this.CodeEditorGroupBox.TabStop = false;
            this.CodeEditorGroupBox.Text = global::SwitchCheatCodeManager.Properties.Resources.CodeEditorGroupBox_Text;
            // 
            // CodeStatusLabel
            // 
            resources.ApplyResources(this.CodeStatusLabel, "CodeStatusLabel");
            this.CodeStatusLabel.Name = "CodeStatusLabel";
            // 
            // BuildIdLabel
            // 
            resources.ApplyResources(this.BuildIdLabel, "BuildIdLabel");
            this.BuildIdLabel.Name = "BuildIdLabel";
            this.BuildIdLabel.Text = global::SwitchCheatCodeManager.Properties.Resources.BuildIdLabel_Text;
            // 
            // BuildIdTextBox
            // 
            resources.ApplyResources(this.BuildIdTextBox, "BuildIdTextBox");
            this.BuildIdTextBox.Name = "BuildIdTextBox";
            this.BuildIdTextBox.ReadOnly = true;
            // 
            // VersionLabel
            // 
            resources.ApplyResources(this.VersionLabel, "VersionLabel");
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Text = global::SwitchCheatCodeManager.Properties.Resources.VersionLabel_Text;
            // 
            // VersionNumberTextBox
            // 
            resources.ApplyResources(this.VersionNumberTextBox, "VersionNumberTextBox");
            this.VersionNumberTextBox.Name = "VersionNumberTextBox";
            this.VersionNumberTextBox.ReadOnly = true;
            // 
            // CodeTextBox
            // 
            resources.ApplyResources(this.CodeTextBox, "CodeTextBox");
            this.CodeTextBox.Name = "CodeTextBox";
            // 
            // SaveOriginalButton
            // 
            resources.ApplyResources(this.SaveOriginalButton, "SaveOriginalButton");
            this.SaveOriginalButton.ImageList = this.IconImageList;
            this.SaveOriginalButton.Name = "SaveOriginalButton";
            this.SaveOriginalButton.Text = global::SwitchCheatCodeManager.Properties.Resources.SaveOriginalButton_Text;
            this.ToolTip.SetToolTip(this.SaveOriginalButton, global::SwitchCheatCodeManager.Properties.Resources.SaveOriginalButton_Tooltip_Text);
            this.SaveOriginalButton.UseVisualStyleBackColor = true;
            this.SaveOriginalButton.Click += new System.EventHandler(this.SaveOriginalButton_Click);
            // 
            // CopyFileButton
            // 
            resources.ApplyResources(this.CopyFileButton, "CopyFileButton");
            this.CopyFileButton.ImageList = this.IconImageList;
            this.CopyFileButton.Name = "CopyFileButton";
            this.CopyFileButton.Text = global::SwitchCheatCodeManager.Properties.Resources.CopyFileButton_Text;
            this.ToolTip.SetToolTip(this.CopyFileButton, global::SwitchCheatCodeManager.Properties.Resources.CopyFileButton_ToolTip_Text);
            this.CopyFileButton.UseVisualStyleBackColor = true;
            this.CopyFileButton.Click += new System.EventHandler(this.CopyFileButton_Click);
            // 
            // NewBlockButton
            // 
            resources.ApplyResources(this.NewBlockButton, "NewBlockButton");
            this.NewBlockButton.ImageList = this.IconImageList;
            this.NewBlockButton.Name = "NewBlockButton";
            this.NewBlockButton.Text = global::SwitchCheatCodeManager.Properties.Resources.NewBlockButton_Text;
            this.ToolTip.SetToolTip(this.NewBlockButton, global::SwitchCheatCodeManager.Properties.Resources.NewBlockButton_Tooltip_Text);
            this.NewBlockButton.UseVisualStyleBackColor = true;
            this.NewBlockButton.Click += new System.EventHandler(this.InsertNewSubSectionBlockButton_Click);
            // 
            // UpdateButton
            // 
            resources.ApplyResources(this.UpdateButton, "UpdateButton");
            this.UpdateButton.ImageList = this.IconImageList;
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Text = global::SwitchCheatCodeManager.Properties.Resources.UpdateButton_Text;
            this.ToolTip.SetToolTip(this.UpdateButton, global::SwitchCheatCodeManager.Properties.Resources.UpdateButton_Tooltip_Text);
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateCheatContentsInTextBoxButton_Click);
            // 
            // SubCheatsGroupBox
            // 
            resources.ApplyResources(this.SubCheatsGroupBox, "SubCheatsGroupBox");
            this.SubCheatsGroupBox.Name = "SubCheatsGroupBox";
            this.SubCheatsGroupBox.TabStop = false;
            this.SubCheatsGroupBox.Text = global::SwitchCheatCodeManager.Properties.Resources.SubCheatsGroupBox_Text;
            // 
            // SaveFormatedButton
            // 
            resources.ApplyResources(this.SaveFormatedButton, "SaveFormatedButton");
            this.SaveFormatedButton.Name = "SaveFormatedButton";
            this.SaveFormatedButton.Text = global::SwitchCheatCodeManager.Properties.Resources.SaveFormatedButton_Text;
            this.SaveFormatedButton.UseVisualStyleBackColor = true;
            // 
            // NavigationFlowLayoutPanel
            // 
            this.NavigationFlowLayoutPanel.Controls.Add(this.DefaultFileButton);
            this.NavigationFlowLayoutPanel.Controls.Add(this.OpenFileButton);
            this.NavigationFlowLayoutPanel.Controls.Add(this.InsertNewCheatsButton);
            this.NavigationFlowLayoutPanel.Controls.Add(this.RemoveFolderButton);
            resources.ApplyResources(this.NavigationFlowLayoutPanel, "NavigationFlowLayoutPanel");
            this.NavigationFlowLayoutPanel.Name = "NavigationFlowLayoutPanel";
            // 
            // DefaultFileButton
            // 
            resources.ApplyResources(this.DefaultFileButton, "DefaultFileButton");
            this.DefaultFileButton.ImageList = this.NavigationImageList;
            this.DefaultFileButton.Name = "DefaultFileButton";
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
            resources.ApplyResources(this.OpenFileButton, "OpenFileButton");
            this.OpenFileButton.ImageList = this.NavigationImageList;
            this.OpenFileButton.Name = "OpenFileButton";
            this.ToolTip.SetToolTip(this.OpenFileButton, global::SwitchCheatCodeManager.Properties.Resources.OpenFileButton_Tooltip_Text);
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.MainMenuOpenButton_Click);
            // 
            // InsertNewCheatsButton
            // 
            resources.ApplyResources(this.InsertNewCheatsButton, "InsertNewCheatsButton");
            this.InsertNewCheatsButton.ImageList = this.NavigationImageList;
            this.InsertNewCheatsButton.Name = "InsertNewCheatsButton";
            this.ToolTip.SetToolTip(this.InsertNewCheatsButton, global::SwitchCheatCodeManager.Properties.Resources.InsertNewCheatsButton_Tooltip_Text);
            this.InsertNewCheatsButton.UseVisualStyleBackColor = true;
            this.InsertNewCheatsButton.Click += new System.EventHandler(this.InsertNewCheatsButton_Click);
            // 
            // RemoveFolderButton
            // 
            resources.ApplyResources(this.RemoveFolderButton, "RemoveFolderButton");
            this.RemoveFolderButton.ImageList = this.NavigationImageList;
            this.RemoveFolderButton.Name = "RemoveFolderButton";
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
            resources.ApplyResources(this.StatusStrip, "StatusStrip");
            this.StatusStrip.Name = "StatusStrip";
            // 
            // InputFolderPathLabelToolStripStatusLabel
            // 
            this.InputFolderPathLabelToolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.InputFolderPathLabelToolStripStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.InputFolderPathLabelToolStripStatusLabel.Name = "InputFolderPathLabelToolStripStatusLabel";
            resources.ApplyResources(this.InputFolderPathLabelToolStripStatusLabel, "InputFolderPathLabelToolStripStatusLabel");
            this.InputFolderPathLabelToolStripStatusLabel.Spring = true;
            this.InputFolderPathLabelToolStripStatusLabel.Text = global::SwitchCheatCodeManager.Properties.Resources.InputFolderPathLabelToolStripStatusLabel_Text;
            // 
            // OutputFolderPathLabelToolStripStatusLabel
            // 
            this.OutputFolderPathLabelToolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.OutputFolderPathLabelToolStripStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OutputFolderPathLabelToolStripStatusLabel.Name = "OutputFolderPathLabelToolStripStatusLabel";
            resources.ApplyResources(this.OutputFolderPathLabelToolStripStatusLabel, "OutputFolderPathLabelToolStripStatusLabel");
            this.OutputFolderPathLabelToolStripStatusLabel.Spring = true;
            this.OutputFolderPathLabelToolStripStatusLabel.Text = global::SwitchCheatCodeManager.Properties.Resources.OutputFolderPathLabelToolStripStatusLabel_Text;
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
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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

