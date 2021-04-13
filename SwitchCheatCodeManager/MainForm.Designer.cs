using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SwitchCheatCodeManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PathGroupBox = new System.Windows.Forms.GroupBox();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.GameListComboBox = new System.Windows.Forms.ComboBox();
            this.GameNameGroupBox = new System.Windows.Forms.GroupBox();
            this.GameNameTextBox = new System.Windows.Forms.TextBox();
            this.CodeSelectorGroupBox = new System.Windows.Forms.GroupBox();
            this.InsertNewCheatButton = new System.Windows.Forms.Button();
            this.previewImage = new System.Windows.Forms.PictureBox();
            this.CodeSelectorListBox = new System.Windows.Forms.ListBox();
            this.FormatFilesButton = new System.Windows.Forms.Button();
            this.CodeEditorGroupBox = new System.Windows.Forms.GroupBox();
            this.CodeStatusLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.VersionNumberTextBox = new System.Windows.Forms.TextBox();
            this.CodeTextBox = new System.Windows.Forms.TextBox();
            this.SaveOriginalButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CodeModifierGroupBox = new System.Windows.Forms.GroupBox();
            this.CodeModifiedTextBox = new System.Windows.Forms.TextBox();
            this.SaveFormatedButton = new System.Windows.Forms.Button();
            this.MenuStrip.SuspendLayout();
            this.PathGroupBox.SuspendLayout();
            this.GameNameGroupBox.SuspendLayout();
            this.CodeSelectorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewImage)).BeginInit();
            this.CodeEditorGroupBox.SuspendLayout();
            this.CodeModifierGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.MenuStrip.Size = new System.Drawing.Size(1198, 26);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.OpenMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.newToolStripMenuItem.Text = "&Default";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.DefaultSaveFolderOpen);
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenMenuItem.Image")));
            this.OpenMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenMenuItem.Size = new System.Drawing.Size(194, 26);
            this.OpenMenuItem.Text = "&Open";
            this.OpenMenuItem.Click += new System.EventHandler(this.MainMenuOpen);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(191, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(191, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(147, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(160, 38);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(160, 38);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(74, 36);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(176, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(176, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(89, 36);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // PathGroupBox
            // 
            this.PathGroupBox.Controls.Add(this.PathTextBox);
            this.PathGroupBox.Controls.Add(this.GameListComboBox);
            this.PathGroupBox.Location = new System.Drawing.Point(25, 38);
            this.PathGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.PathGroupBox.Name = "PathGroupBox";
            this.PathGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.PathGroupBox.Size = new System.Drawing.Size(1145, 50);
            this.PathGroupBox.TabIndex = 2;
            this.PathGroupBox.TabStop = false;
            this.PathGroupBox.Text = "Path";
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(6, 22);
            this.PathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.ReadOnly = true;
            this.PathTextBox.Size = new System.Drawing.Size(505, 27);
            this.PathTextBox.TabIndex = 2;
            this.PathTextBox.WordWrap = false;
            // 
            // GameListComboBox
            // 
            this.GameListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GameListComboBox.Font = new System.Drawing.Font("Ubuntu Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameListComboBox.FormattingEnabled = true;
            this.GameListComboBox.Location = new System.Drawing.Point(553, 21);
            this.GameListComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.GameListComboBox.Name = "GameListComboBox";
            this.GameListComboBox.Size = new System.Drawing.Size(541, 25);
            this.GameListComboBox.TabIndex = 3;
            this.GameListComboBox.SelectedIndexChanged += new System.EventHandler(this.GameListComboBox_SelectedIndexChanged);
            // 
            // GameNameGroupBox
            // 
            this.GameNameGroupBox.Controls.Add(this.GameNameTextBox);
            this.GameNameGroupBox.Location = new System.Drawing.Point(25, 94);
            this.GameNameGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.GameNameGroupBox.Name = "GameNameGroupBox";
            this.GameNameGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.GameNameGroupBox.Size = new System.Drawing.Size(1145, 50);
            this.GameNameGroupBox.TabIndex = 2;
            this.GameNameGroupBox.TabStop = false;
            this.GameNameGroupBox.Text = "Name";
            // 
            // GameNameTextBox
            // 
            this.GameNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameNameTextBox.Location = new System.Drawing.Point(6, 22);
            this.GameNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.GameNameTextBox.Name = "GameNameTextBox";
            this.GameNameTextBox.Size = new System.Drawing.Size(555, 27);
            this.GameNameTextBox.TabIndex = 2;
            // 
            // CodeSelectorGroupBox
            // 
            this.CodeSelectorGroupBox.Controls.Add(this.InsertNewCheatButton);
            this.CodeSelectorGroupBox.Controls.Add(this.previewImage);
            this.CodeSelectorGroupBox.Controls.Add(this.CodeSelectorListBox);
            this.CodeSelectorGroupBox.Controls.Add(this.FormatFilesButton);
            this.CodeSelectorGroupBox.Location = new System.Drawing.Point(25, 150);
            this.CodeSelectorGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.CodeSelectorGroupBox.Name = "CodeSelectorGroupBox";
            this.CodeSelectorGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.CodeSelectorGroupBox.Size = new System.Drawing.Size(235, 612);
            this.CodeSelectorGroupBox.TabIndex = 3;
            this.CodeSelectorGroupBox.TabStop = false;
            this.CodeSelectorGroupBox.Text = "Version ID";
            this.CodeSelectorGroupBox.Enter += new System.EventHandler(this.CodeSelectorGroupBox_Enter);
            // 
            // InsertNewCheatButton
            // 
            this.InsertNewCheatButton.Enabled = false;
            this.InsertNewCheatButton.Location = new System.Drawing.Point(110, 569);
            this.InsertNewCheatButton.Name = "InsertNewCheatButton";
            this.InsertNewCheatButton.Size = new System.Drawing.Size(74, 31);
            this.InsertNewCheatButton.TabIndex = 5;
            this.InsertNewCheatButton.Text = "Insert";
            this.InsertNewCheatButton.UseVisualStyleBackColor = true;
            this.InsertNewCheatButton.Click += new System.EventHandler(this.InsertNewCheatButton_Click);
            // 
            // previewImage
            // 
            this.previewImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewImage.Location = new System.Drawing.Point(6, 34);
            this.previewImage.Name = "previewImage";
            this.previewImage.Size = new System.Drawing.Size(220, 220);
            this.previewImage.TabIndex = 6;
            this.previewImage.TabStop = false;
            this.previewImage.DoubleClick += new System.EventHandler(this.previewImage_DoubleClick);
            // 
            // CodeSelectorListBox
            // 
            this.CodeSelectorListBox.Enabled = false;
            this.CodeSelectorListBox.Font = new System.Drawing.Font("Ubuntu Mono", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CodeSelectorListBox.FormattingEnabled = true;
            this.CodeSelectorListBox.ItemHeight = 19;
            this.CodeSelectorListBox.Location = new System.Drawing.Point(6, 269);
            this.CodeSelectorListBox.Margin = new System.Windows.Forms.Padding(6);
            this.CodeSelectorListBox.Name = "CodeSelectorListBox";
            this.CodeSelectorListBox.Size = new System.Drawing.Size(219, 289);
            this.CodeSelectorListBox.TabIndex = 3;
            this.CodeSelectorListBox.SelectedIndexChanged += new System.EventHandler(this.CodeSelectorListBox_SelectedIndexChanged);
            // 
            // FormatFilesButton
            // 
            this.FormatFilesButton.Enabled = false;
            this.FormatFilesButton.Location = new System.Drawing.Point(6, 569);
            this.FormatFilesButton.Margin = new System.Windows.Forms.Padding(2);
            this.FormatFilesButton.Name = "FormatFilesButton";
            this.FormatFilesButton.Size = new System.Drawing.Size(74, 31);
            this.FormatFilesButton.TabIndex = 5;
            this.FormatFilesButton.Text = "Format";
            this.FormatFilesButton.UseVisualStyleBackColor = true;
            this.FormatFilesButton.Click += new System.EventHandler(this.FormatFilesButton_Click);
            // 
            // CodeEditorGroupBox
            // 
            this.CodeEditorGroupBox.Controls.Add(this.CodeStatusLabel);
            this.CodeEditorGroupBox.Controls.Add(this.VersionLabel);
            this.CodeEditorGroupBox.Controls.Add(this.VersionNumberTextBox);
            this.CodeEditorGroupBox.Controls.Add(this.CodeTextBox);
            this.CodeEditorGroupBox.Controls.Add(this.SaveOriginalButton);
            this.CodeEditorGroupBox.Controls.Add(this.UpdateButton);
            this.CodeEditorGroupBox.Location = new System.Drawing.Point(265, 150);
            this.CodeEditorGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.CodeEditorGroupBox.Name = "CodeEditorGroupBox";
            this.CodeEditorGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.CodeEditorGroupBox.Size = new System.Drawing.Size(450, 612);
            this.CodeEditorGroupBox.TabIndex = 4;
            this.CodeEditorGroupBox.TabStop = false;
            this.CodeEditorGroupBox.Text = "Cheats";
            // 
            // CodeStatusLabel
            // 
            this.CodeStatusLabel.AutoSize = true;
            this.CodeStatusLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CodeStatusLabel.Location = new System.Drawing.Point(6, 22);
            this.CodeStatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CodeStatusLabel.Name = "CodeStatusLabel";
            this.CodeStatusLabel.Size = new System.Drawing.Size(0, 18);
            this.CodeStatusLabel.TabIndex = 2;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VersionLabel.Location = new System.Drawing.Point(215, 22);
            this.VersionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(69, 18);
            this.VersionLabel.TabIndex = 2;
            this.VersionLabel.Text = "Version: ";
            // 
            // VersionNumberTextBox
            // 
            this.VersionNumberTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VersionNumberTextBox.Location = new System.Drawing.Point(289, 22);
            this.VersionNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.VersionNumberTextBox.Name = "VersionNumberTextBox";
            this.VersionNumberTextBox.Size = new System.Drawing.Size(78, 25);
            this.VersionNumberTextBox.TabIndex = 2;
            this.VersionNumberTextBox.Text = "N/A";
            this.VersionNumberTextBox.TextChanged += new System.EventHandler(this.VersionNumberTextBox_TextChanged);
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.Enabled = false;
            this.CodeTextBox.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CodeTextBox.Location = new System.Drawing.Point(6, 50);
            this.CodeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CodeTextBox.Multiline = true;
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CodeTextBox.Size = new System.Drawing.Size(421, 513);
            this.CodeTextBox.TabIndex = 4;
            // 
            // SaveOriginalButton
            // 
            this.SaveOriginalButton.Enabled = false;
            this.SaveOriginalButton.Location = new System.Drawing.Point(6, 569);
            this.SaveOriginalButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveOriginalButton.Name = "SaveOriginalButton";
            this.SaveOriginalButton.Size = new System.Drawing.Size(92, 31);
            this.SaveOriginalButton.TabIndex = 6;
            this.SaveOriginalButton.Text = "Save";
            this.SaveOriginalButton.UseVisualStyleBackColor = true;
            this.SaveOriginalButton.Click += new System.EventHandler(this.SaveOriginalButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Enabled = false;
            this.UpdateButton.Location = new System.Drawing.Point(286, 569);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(89, 31);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Convert >>";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // CodeModifierGroupBox
            // 
            this.CodeModifierGroupBox.Controls.Add(this.CodeModifiedTextBox);
            this.CodeModifierGroupBox.Controls.Add(this.SaveFormatedButton);
            this.CodeModifierGroupBox.Location = new System.Drawing.Point(722, 150);
            this.CodeModifierGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.CodeModifierGroupBox.Name = "CodeModifierGroupBox";
            this.CodeModifierGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.CodeModifierGroupBox.Size = new System.Drawing.Size(450, 612);
            this.CodeModifierGroupBox.TabIndex = 4;
            this.CodeModifierGroupBox.TabStop = false;
            this.CodeModifierGroupBox.Text = "Updated Cheats";
            // 
            // CodeModifiedTextBox
            // 
            this.CodeModifiedTextBox.Enabled = false;
            this.CodeModifiedTextBox.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CodeModifiedTextBox.Location = new System.Drawing.Point(6, 50);
            this.CodeModifiedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CodeModifiedTextBox.Multiline = true;
            this.CodeModifiedTextBox.Name = "CodeModifiedTextBox";
            this.CodeModifiedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CodeModifiedTextBox.Size = new System.Drawing.Size(421, 513);
            this.CodeModifiedTextBox.TabIndex = 4;
            // 
            // SaveFormatedButton
            // 
            this.SaveFormatedButton.Enabled = false;
            this.SaveFormatedButton.Location = new System.Drawing.Point(6, 569);
            this.SaveFormatedButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveFormatedButton.Name = "SaveFormatedButton";
            this.SaveFormatedButton.Size = new System.Drawing.Size(92, 31);
            this.SaveFormatedButton.TabIndex = 7;
            this.SaveFormatedButton.Text = "Save";
            this.SaveFormatedButton.UseVisualStyleBackColor = true;
            this.SaveFormatedButton.Click += new System.EventHandler(this.SaveFormatedButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 808);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.PathGroupBox);
            this.Controls.Add(this.GameNameGroupBox);
            this.Controls.Add(this.CodeSelectorGroupBox);
            this.Controls.Add(this.CodeEditorGroupBox);
            this.Controls.Add(this.CodeModifierGroupBox);
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Nintendo Switch Cheat Code Manager";
            this.Load += new System.EventHandler(this.Form_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.PathGroupBox.ResumeLayout(false);
            this.PathGroupBox.PerformLayout();
            this.GameNameGroupBox.ResumeLayout(false);
            this.GameNameGroupBox.PerformLayout();
            this.CodeSelectorGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.previewImage)).EndInit();
            this.CodeEditorGroupBox.ResumeLayout(false);
            this.CodeEditorGroupBox.PerformLayout();
            this.CodeModifierGroupBox.ResumeLayout(false);
            this.CodeModifierGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CodeTextBox;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        
        private System.Windows.Forms.ListBox CodeSelectorListBox;
        private System.Windows.Forms.TextBox GameNameTextBox;
        private System.Windows.Forms.Label CodeStatusLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.TextBox VersionNumberTextBox;
        private System.Windows.Forms.Button FormatFilesButton;
        private System.Windows.Forms.TextBox CodeModifiedTextBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button SaveOriginalButton;
        private System.Windows.Forms.Button SaveFormatedButton;
        private System.Windows.Forms.GroupBox PathGroupBox;
        private System.Windows.Forms.GroupBox CodeSelectorGroupBox;
        private System.Windows.Forms.GroupBox CodeEditorGroupBox;
        private System.Windows.Forms.GroupBox CodeModifierGroupBox;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.GroupBox GameNameGroupBox;
        private System.Windows.Forms.ComboBox GameListComboBox;
        private System.Windows.Forms.PictureBox previewImage;
        private Button InsertNewCheatButton;
    }
}

