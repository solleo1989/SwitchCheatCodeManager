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
            DirectoryGroupBox = new GroupBox();
            InputPathLabel = new Label();
            InputPathTextBox = new TextBox();
            InputPathButton = new Button();
            OutputPathLabel = new Label();
            OutputPathTextBox = new TextBox();
            OutputPathButton = new Button();
            BackgroundColorGroupBox = new GroupBox();
            ColorTitleButton = new Button();
            ColorTitleLabel = new Label();
            ColorTitleEnabledLabel = new Label();
            ColorTitleEnabledButton = new Button();
            ColorSectionStartLabel = new Label();
            ColorSectionStartButton = new Button();
            ColorSectionEndLabel = new Label();
            ColorSectionEndButton = new Button();
            LanguageGroupBox = new GroupBox();
            LanguageLabel = new Label();
            LanguageComboBox = new ComboBox();
            PreferredImageLabel = new Label();
            ImageCheckedListBox = new CheckedListBox();
            DirectoryGroupBox.SuspendLayout();
            BackgroundColorGroupBox.SuspendLayout();
            LanguageGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // DirectoryGroupBox
            // 
            resources.ApplyResources(DirectoryGroupBox, "DirectoryGroupBox");
            DirectoryGroupBox.Controls.Add(InputPathLabel);
            DirectoryGroupBox.Controls.Add(InputPathTextBox);
            DirectoryGroupBox.Controls.Add(InputPathButton);
            DirectoryGroupBox.Controls.Add(OutputPathLabel);
            DirectoryGroupBox.Controls.Add(OutputPathTextBox);
            DirectoryGroupBox.Controls.Add(OutputPathButton);
            DirectoryGroupBox.Name = "DirectoryGroupBox";
            DirectoryGroupBox.TabStop = false;
            // 
            // InputPathLabel
            // 
            resources.ApplyResources(InputPathLabel, "InputPathLabel");
            InputPathLabel.Name = "InputPathLabel";
            // 
            // InputPathTextBox
            // 
            resources.ApplyResources(InputPathTextBox, "InputPathTextBox");
            InputPathTextBox.Name = "InputPathTextBox";
            InputPathTextBox.ReadOnly = true;
            // 
            // InputPathButton
            // 
            resources.ApplyResources(InputPathButton, "InputPathButton");
            InputPathButton.Name = "InputPathButton";
            InputPathButton.Text = Resources.SettingsForm_InputPathButton_Text;
            InputPathButton.UseVisualStyleBackColor = true;
            InputPathButton.Click += InputPathButton_Click;
            // 
            // OutputPathLabel
            // 
            resources.ApplyResources(OutputPathLabel, "OutputPathLabel");
            OutputPathLabel.Name = "OutputPathLabel";
            // 
            // OutputPathTextBox
            // 
            resources.ApplyResources(OutputPathTextBox, "OutputPathTextBox");
            OutputPathTextBox.Name = "OutputPathTextBox";
            OutputPathTextBox.ReadOnly = true;
            // 
            // OutputPathButton
            // 
            resources.ApplyResources(OutputPathButton, "OutputPathButton");
            OutputPathButton.Name = "OutputPathButton";
            OutputPathButton.Text = Resources.SettingsForm_OutputPathButton_Text;
            OutputPathButton.UseVisualStyleBackColor = true;
            OutputPathButton.Click += OutputPathButton_Click;
            // 
            // BackgroundColorGroupBox
            // 
            resources.ApplyResources(BackgroundColorGroupBox, "BackgroundColorGroupBox");
            BackgroundColorGroupBox.Controls.Add(ColorTitleButton);
            BackgroundColorGroupBox.Controls.Add(ColorTitleLabel);
            BackgroundColorGroupBox.Controls.Add(ColorTitleEnabledLabel);
            BackgroundColorGroupBox.Controls.Add(ColorTitleEnabledButton);
            BackgroundColorGroupBox.Controls.Add(ColorSectionStartLabel);
            BackgroundColorGroupBox.Controls.Add(ColorSectionStartButton);
            BackgroundColorGroupBox.Controls.Add(ColorSectionEndLabel);
            BackgroundColorGroupBox.Controls.Add(ColorSectionEndButton);
            BackgroundColorGroupBox.Name = "BackgroundColorGroupBox";
            BackgroundColorGroupBox.TabStop = false;
            // 
            // ColorTitleButton
            // 
            resources.ApplyResources(ColorTitleButton, "ColorTitleButton");
            ColorTitleButton.Name = "ColorTitleButton";
            ColorTitleButton.UseVisualStyleBackColor = true;
            ColorTitleButton.Click += ColorTitleButton_Click;
            // 
            // ColorTitleLabel
            // 
            resources.ApplyResources(ColorTitleLabel, "ColorTitleLabel");
            ColorTitleLabel.BorderStyle = BorderStyle.FixedSingle;
            ColorTitleLabel.Name = "ColorTitleLabel";
            // 
            // ColorTitleEnabledLabel
            // 
            resources.ApplyResources(ColorTitleEnabledLabel, "ColorTitleEnabledLabel");
            ColorTitleEnabledLabel.BorderStyle = BorderStyle.FixedSingle;
            ColorTitleEnabledLabel.Name = "ColorTitleEnabledLabel";
            // 
            // ColorTitleEnabledButton
            // 
            resources.ApplyResources(ColorTitleEnabledButton, "ColorTitleEnabledButton");
            ColorTitleEnabledButton.Name = "ColorTitleEnabledButton";
            ColorTitleEnabledButton.UseVisualStyleBackColor = true;
            ColorTitleEnabledButton.Click += ColorTitleEnabledButton_Click;
            // 
            // ColorSectionStartLabel
            // 
            resources.ApplyResources(ColorSectionStartLabel, "ColorSectionStartLabel");
            ColorSectionStartLabel.BorderStyle = BorderStyle.FixedSingle;
            ColorSectionStartLabel.Name = "ColorSectionStartLabel";
            // 
            // ColorSectionStartButton
            // 
            resources.ApplyResources(ColorSectionStartButton, "ColorSectionStartButton");
            ColorSectionStartButton.Name = "ColorSectionStartButton";
            ColorSectionStartButton.UseVisualStyleBackColor = true;
            ColorSectionStartButton.Click += ColorSectionStartButton_Click;
            // 
            // ColorSectionEndLabel
            // 
            resources.ApplyResources(ColorSectionEndLabel, "ColorSectionEndLabel");
            ColorSectionEndLabel.BorderStyle = BorderStyle.FixedSingle;
            ColorSectionEndLabel.Name = "ColorSectionEndLabel";
            // 
            // ColorSectionEndButton
            // 
            resources.ApplyResources(ColorSectionEndButton, "ColorSectionEndButton");
            ColorSectionEndButton.Name = "ColorSectionEndButton";
            ColorSectionEndButton.UseVisualStyleBackColor = true;
            ColorSectionEndButton.Click += ColorSectionEndButton_Click;
            // 
            // LanguageGroupBox
            // 
            resources.ApplyResources(LanguageGroupBox, "LanguageGroupBox");
            LanguageGroupBox.Controls.Add(LanguageLabel);
            LanguageGroupBox.Controls.Add(LanguageComboBox);
            LanguageGroupBox.Controls.Add(PreferredImageLabel);
            LanguageGroupBox.Controls.Add(ImageCheckedListBox);
            LanguageGroupBox.Name = "LanguageGroupBox";
            LanguageGroupBox.TabStop = false;
            // 
            // LanguageLabel
            // 
            resources.ApplyResources(LanguageLabel, "LanguageLabel");
            LanguageLabel.Name = "LanguageLabel";
            // 
            // LanguageComboBox
            // 
            resources.ApplyResources(LanguageComboBox, "LanguageComboBox");
            LanguageComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            LanguageComboBox.FormattingEnabled = true;
            LanguageComboBox.Items.AddRange(new object[] { resources.GetString("LanguageComboBox.Items"), resources.GetString("LanguageComboBox.Items1") });
            LanguageComboBox.Name = "LanguageComboBox";
            LanguageComboBox.SelectedIndexChanged += FromLanguageComboBox_Changed;
            // 
            // PreferredImageLabel
            // 
            resources.ApplyResources(PreferredImageLabel, "PreferredImageLabel");
            PreferredImageLabel.Name = "PreferredImageLabel";
            // 
            // ImageCheckedListBox
            // 
            resources.ApplyResources(ImageCheckedListBox, "ImageCheckedListBox");
            ImageCheckedListBox.FormattingEnabled = true;
            ImageCheckedListBox.Items.AddRange(new object[] { resources.GetString("ImageCheckedListBox.Items"), resources.GetString("ImageCheckedListBox.Items1"), resources.GetString("ImageCheckedListBox.Items2") });
            ImageCheckedListBox.Name = "ImageCheckedListBox";
            ImageCheckedListBox.ItemCheck += ImageCheckedListBox_Click;
            // 
            // SettingsForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LanguageGroupBox);
            Controls.Add(BackgroundColorGroupBox);
            Controls.Add(DirectoryGroupBox);
            Name = "SettingsForm";
            DirectoryGroupBox.ResumeLayout(false);
            DirectoryGroupBox.PerformLayout();
            BackgroundColorGroupBox.ResumeLayout(false);
            BackgroundColorGroupBox.PerformLayout();
            LanguageGroupBox.ResumeLayout(false);
            LanguageGroupBox.PerformLayout();
            ResumeLayout(false);
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
        private System.Windows.Forms.Label ColorTitleEnabledLabel;
        private System.Windows.Forms.Label ColorTitleLabel;
        private System.Windows.Forms.GroupBox LanguageGroupBox;
        private System.Windows.Forms.CheckedListBox ImageCheckedListBox;
        private System.Windows.Forms.ComboBox LanguageComboBox;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.Label PreferredImageLabel;
        private System.Windows.Forms.Button ColorSectionEndButton;
        private System.Windows.Forms.Button ColorSectionStartButton;
        private System.Windows.Forms.Button ColorTitleEnabledButton;
        private System.Windows.Forms.Button ColorTitleButton;
    }
}