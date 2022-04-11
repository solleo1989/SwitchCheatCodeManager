using System.Drawing;
using System.Windows.Forms;
using Resources = SwitchCheatCodeManager.Properties.Resources;
using Constants = SwitchCheatCodeManager.Constant.Constants;

namespace SwitchCheatCodeManager.WinForm
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.DirectoryGroupBox = new System.Windows.Forms.GroupBox();
            this.InputPathLabel = new System.Windows.Forms.Label();
            this.InputPathTextBox = new System.Windows.Forms.TextBox();
            this.InputPathButton = new System.Windows.Forms.Button();
            this.OutputPathLabel = new System.Windows.Forms.Label();
            this.OutputPathTextBox = new System.Windows.Forms.TextBox();
            this.OutputPathButton = new System.Windows.Forms.Button();
            this.BackgroundColorGroupBox = new System.Windows.Forms.GroupBox();
            this.ColorTitleLabel = new System.Windows.Forms.Label();
            this.ColorTitleButton = new System.Windows.Forms.Button();
            this.ColorSectionStartLabel = new System.Windows.Forms.Label();
            this.ColorSectionStartButton = new System.Windows.Forms.Button();
            this.ColorSectionEndLabel = new System.Windows.Forms.Label();
            this.ColorSectionEndButton = new System.Windows.Forms.Button();
            this.LanguageGroupBox = new System.Windows.Forms.GroupBox();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.LanguageComboBox = new System.Windows.Forms.ComboBox();
            this.PreferredImageLabel = new System.Windows.Forms.Label();
            this.ImageCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.DirectoryGroupBox.SuspendLayout();
            this.BackgroundColorGroupBox.SuspendLayout();
            this.LanguageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DirectoryGroupBox
            // 
            this.DirectoryGroupBox.Controls.Add(this.InputPathLabel);
            this.DirectoryGroupBox.Controls.Add(this.InputPathTextBox);
            this.DirectoryGroupBox.Controls.Add(this.InputPathButton);
            this.DirectoryGroupBox.Controls.Add(this.OutputPathLabel);
            this.DirectoryGroupBox.Controls.Add(this.OutputPathTextBox);
            this.DirectoryGroupBox.Controls.Add(this.OutputPathButton);
            resources.ApplyResources(this.DirectoryGroupBox, "DirectoryGroupBox");
            this.DirectoryGroupBox.Name = "DirectoryGroupBox";
            this.DirectoryGroupBox.TabStop = false;
            this.DirectoryGroupBox.Text = global::SwitchCheatCodeManager.Properties.Resources.SettingsForm_DirectoryGroupBox_Text;
            // 
            // InputPathLabel
            // 
            resources.ApplyResources(this.InputPathLabel, "InputPathLabel");
            this.InputPathLabel.Name = "InputPathLabel";
            this.InputPathLabel.Text = global::SwitchCheatCodeManager.Properties.Resources.SettingsForm_InputPathLabel_Text;
            // 
            // InputPathTextBox
            // 
            resources.ApplyResources(this.InputPathTextBox, "InputPathTextBox");
            this.InputPathTextBox.Name = "InputPathTextBox";
            this.InputPathTextBox.ReadOnly = true;
            // 
            // InputPathButton
            // 
            resources.ApplyResources(this.InputPathButton, "InputPathButton");
            this.InputPathButton.Name = "InputPathButton";
            this.InputPathButton.Text = global::SwitchCheatCodeManager.Properties.Resources.SettingsForm_InputPathButton_Text;
            this.InputPathButton.UseVisualStyleBackColor = true;
            this.InputPathButton.Click += new System.EventHandler(this.InputPathButton_Click);
            // 
            // OutputPathLabel
            // 
            resources.ApplyResources(this.OutputPathLabel, "OutputPathLabel");
            this.OutputPathLabel.Name = "OutputPathLabel";
            this.OutputPathLabel.Text = global::SwitchCheatCodeManager.Properties.Resources.SettingsForm_OutputPathLabel_Text;
            // 
            // OutputPathTextBox
            // 
            resources.ApplyResources(this.OutputPathTextBox, "OutputPathTextBox");
            this.OutputPathTextBox.Name = "OutputPathTextBox";
            this.OutputPathTextBox.ReadOnly = true;
            // 
            // OutputPathButton
            // 
            resources.ApplyResources(this.OutputPathButton, "OutputPathButton");
            this.OutputPathButton.Name = "OutputPathButton";
            this.OutputPathButton.Text = global::SwitchCheatCodeManager.Properties.Resources.SettingsForm_OutputPathButton_Text;
            this.OutputPathButton.UseVisualStyleBackColor = true;
            this.OutputPathButton.Click += new System.EventHandler(this.OutputPathButton_Click);
            // 
            // BackgroundColorGroupBox
            // 
            this.BackgroundColorGroupBox.Controls.Add(this.ColorTitleLabel);
            this.BackgroundColorGroupBox.Controls.Add(this.ColorTitleButton);
            this.BackgroundColorGroupBox.Controls.Add(this.ColorSectionStartLabel);
            this.BackgroundColorGroupBox.Controls.Add(this.ColorSectionStartButton);
            this.BackgroundColorGroupBox.Controls.Add(this.ColorSectionEndLabel);
            this.BackgroundColorGroupBox.Controls.Add(this.ColorSectionEndButton);
            resources.ApplyResources(this.BackgroundColorGroupBox, "BackgroundColorGroupBox");
            this.BackgroundColorGroupBox.Name = "BackgroundColorGroupBox";
            this.BackgroundColorGroupBox.TabStop = false;
            this.BackgroundColorGroupBox.Text = global::SwitchCheatCodeManager.Properties.Resources.SettingsForm_BackgroundColorGroupBox_Text;
            // 
            // ColorTitleLabel
            // 
            resources.ApplyResources(this.ColorTitleLabel, "ColorTitleLabel");
            this.ColorTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorTitleLabel.Name = "ColorTitleLabel";
            this.ColorTitleLabel.Text = global::SwitchCheatCodeManager.Properties.Resources.SettingsForm_ColorTitleLabel_Text;
            // 
            // ColorTitleButton
            // 
            resources.ApplyResources(this.ColorTitleButton, "ColorTitleButton");
            this.ColorTitleButton.Name = "ColorTitleButton";
            this.ColorTitleButton.UseVisualStyleBackColor = true;
            this.ColorTitleButton.Click += new System.EventHandler(this.ColorTitleButton_Click);
            // 
            // ColorSectionStartLabel
            // 
            resources.ApplyResources(this.ColorSectionStartLabel, "ColorSectionStartLabel");
            this.ColorSectionStartLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorSectionStartLabel.Name = "ColorSectionStartLabel";
            this.ColorSectionStartLabel.Text = global::SwitchCheatCodeManager.Properties.Resources.SettingsForm_ColorSectionStartLabel_Text;
            // 
            // ColorSectionStartButton
            // 
            resources.ApplyResources(this.ColorSectionStartButton, "ColorSectionStartButton");
            this.ColorSectionStartButton.Name = "ColorSectionStartButton";
            this.ColorSectionStartButton.UseVisualStyleBackColor = true;
            this.ColorSectionStartButton.Click += new System.EventHandler(this.ColorSectionStartButton_Click);
            // 
            // ColorSectionEndLabel
            // 
            resources.ApplyResources(this.ColorSectionEndLabel, "ColorSectionEndLabel");
            this.ColorSectionEndLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorSectionEndLabel.Name = "ColorSectionEndLabel";
            this.ColorSectionEndLabel.Text = global::SwitchCheatCodeManager.Properties.Resources.SettingsForm_ColorSectionEndLabel_Text;
            // 
            // ColorSectionEndButton
            // 
            resources.ApplyResources(this.ColorSectionEndButton, "ColorSectionEndButton");
            this.ColorSectionEndButton.Name = "ColorSectionEndButton";
            this.ColorSectionEndButton.UseVisualStyleBackColor = true;
            this.ColorSectionEndButton.Click += new System.EventHandler(this.ColorSectionEndButton_Click);
            // 
            // LanguageGroupBox
            // 
            this.LanguageGroupBox.Controls.Add(this.LanguageLabel);
            this.LanguageGroupBox.Controls.Add(this.LanguageComboBox);
            this.LanguageGroupBox.Controls.Add(this.PreferredImageLabel);
            this.LanguageGroupBox.Controls.Add(this.ImageCheckedListBox);
            resources.ApplyResources(this.LanguageGroupBox, "LanguageGroupBox");
            this.LanguageGroupBox.Name = "LanguageGroupBox";
            this.LanguageGroupBox.TabStop = false;
            this.LanguageGroupBox.Text = global::SwitchCheatCodeManager.Properties.Resources.SettingsForm_LanguageGroupBox_Text;
            // 
            // LanguageLabel
            // 
            resources.ApplyResources(this.LanguageLabel, "LanguageLabel");
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Text = global::SwitchCheatCodeManager.Properties.Resources.SettingsForm_LanguageLabel_Text;
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.Items.AddRange(new object[] {
            resources.GetString("LanguageComboBox.Items"),
            resources.GetString("LanguageComboBox.Items1")});
            resources.ApplyResources(this.LanguageComboBox, "LanguageComboBox");
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.SelectedIndexChanged += new System.EventHandler(this.FromLanguageComboBox_Changed);
            // 
            // PreferredImageLabel
            // 
            resources.ApplyResources(this.PreferredImageLabel, "PreferredImageLabel");
            this.PreferredImageLabel.Name = "PreferredImageLabel";
            this.PreferredImageLabel.Text = global::SwitchCheatCodeManager.Properties.Resources.SettingsForm_PreferredImageLabel_Text;
            // 
            // ImageCheckedListBox
            // 
            this.ImageCheckedListBox.FormattingEnabled = true;
            this.ImageCheckedListBox.Items.AddRange(new object[] {
            resources.GetString("ImageCheckedListBox.Items"),
            resources.GetString("ImageCheckedListBox.Items1"),
            resources.GetString("ImageCheckedListBox.Items2")});
            resources.ApplyResources(this.ImageCheckedListBox, "ImageCheckedListBox");
            this.ImageCheckedListBox.Name = "ImageCheckedListBox";
            this.ImageCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ImageCheckedListBox_Click);
            // 
            // SettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LanguageGroupBox);
            this.Controls.Add(this.BackgroundColorGroupBox);
            this.Controls.Add(this.DirectoryGroupBox);
            this.Name = "SettingsForm";
            this.Text = global::SwitchCheatCodeManager.Properties.Resources.SettingsForm_Title;
            this.DirectoryGroupBox.ResumeLayout(false);
            this.DirectoryGroupBox.PerformLayout();
            this.BackgroundColorGroupBox.ResumeLayout(false);
            this.BackgroundColorGroupBox.PerformLayout();
            this.LanguageGroupBox.ResumeLayout(false);
            this.LanguageGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DirectoryGroupBox;
        private System.Windows.Forms.Button OutputPathButton;
        private System.Windows.Forms.Button InputPathButton;
        private System.Windows.Forms.TextBox OutputPathTextBox;
        private System.Windows.Forms.TextBox InputPathTextBox;
        private System.Windows.Forms.Label OutputPathLabel;
        private System.Windows.Forms.Label InputPathLabel;
        private System.Windows.Forms.GroupBox BackgroundColorGroupBox;
        private System.Windows.Forms.Label ColorSectionEndLabel;
        private System.Windows.Forms.Label ColorSectionStartLabel;
        private System.Windows.Forms.Label ColorTitleLabel;
        private System.Windows.Forms.GroupBox LanguageGroupBox;
        private System.Windows.Forms.CheckedListBox ImageCheckedListBox;
        private System.Windows.Forms.ComboBox LanguageComboBox;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.Label PreferredImageLabel;
        private System.Windows.Forms.Button ColorSectionEndButton;
        private System.Windows.Forms.Button ColorSectionStartButton;
        private System.Windows.Forms.Button ColorTitleButton;
    }
}