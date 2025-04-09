namespace SwitchCheatCodeManager.WinForm
{
    partial class CodeCompareForm
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
            CheatPathTextBox = new System.Windows.Forms.TextBox();
            LeftTextAreaEx = new FormEntity.TextAreaEx();
            RightTextAreaEx = new FormEntity.TextAreaEx();
            LeftComboBoxEx = new FormEntity.ComboBoxEx();
            RightComboBoxEx = new FormEntity.ComboBoxEx();
            PathLabel = new System.Windows.Forms.Label();
            NameLabel = new System.Windows.Forms.Label();
            TitleLabel = new System.Windows.Forms.Label();
            LeftBuildLabel = new System.Windows.Forms.Label();
            LeftVersionLabel = new System.Windows.Forms.Label();
            GameNameTextBox = new System.Windows.Forms.TextBox();
            GameTitleTextBox = new System.Windows.Forms.TextBox();
            LeftBuildTextBox = new System.Windows.Forms.TextBox();
            LeftVersionTextBox = new System.Windows.Forms.TextBox();
            RightBuildLabel = new System.Windows.Forms.Label();
            RightVersionLabel = new System.Windows.Forms.Label();
            RightBuildTextBox = new System.Windows.Forms.TextBox();
            RightVersionTextBox = new System.Windows.Forms.TextBox();
            SaveButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // CheatPathTextBox
            // 
            CheatPathTextBox.Location = new System.Drawing.Point(125, 30);
            CheatPathTextBox.Name = "CheatPathTextBox";
            CheatPathTextBox.ReadOnly = true;
            CheatPathTextBox.Size = new System.Drawing.Size(1050, 35);
            CheatPathTextBox.TabIndex = 2;
            // 
            // LeftTextAreaEx
            // 
            LeftTextAreaEx.Location = new System.Drawing.Point(50, 220);
            LeftTextAreaEx.Name = "LeftTextAreaEx";
            LeftTextAreaEx.Size = new System.Drawing.Size(700, 900);
            LeftTextAreaEx.TabIndex = 3;
            LeftTextAreaEx.Text = "";
            // 
            // RightTextAreaEx
            // 
            RightTextAreaEx.Location = new System.Drawing.Point(800, 220);
            RightTextAreaEx.Name = "RightTextAreaEx";
            RightTextAreaEx.Size = new System.Drawing.Size(700, 900);
            RightTextAreaEx.TabIndex = 4;
            RightTextAreaEx.Text = "";
            // 
            // LeftComboBoxEx
            // 
            LeftComboBoxEx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            LeftComboBoxEx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            LeftComboBoxEx.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LeftComboBoxEx.FormattingEnabled = true;
            LeftComboBoxEx.Location = new System.Drawing.Point(50, 130);
            LeftComboBoxEx.Name = "LeftComboBoxEx";
            LeftComboBoxEx.Size = new System.Drawing.Size(700, 33);
            LeftComboBoxEx.TabIndex = 5;
            LeftComboBoxEx.SelectedIndexChanged += LeftComboBoxEx_SelectedIndexChanged;
            // 
            // RightComboBoxEx
            // 
            RightComboBoxEx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            RightComboBoxEx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            RightComboBoxEx.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RightComboBoxEx.FormattingEnabled = true;
            RightComboBoxEx.Location = new System.Drawing.Point(800, 130);
            RightComboBoxEx.Name = "RightComboBoxEx";
            RightComboBoxEx.Size = new System.Drawing.Size(700, 33);
            RightComboBoxEx.TabIndex = 6;
            RightComboBoxEx.SelectedIndexChanged += RightComboBoxEx_SelectedIndexChanged;
            // 
            // CodeTypeLabel
            // 
            PathLabel.AutoSize = true;
            PathLabel.Location = new System.Drawing.Point(50, 30);
            PathLabel.Name = "CodeTypeLabel";
            PathLabel.Size = new System.Drawing.Size(54, 30);
            PathLabel.TabIndex = 7;
            PathLabel.Text = "Path";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new System.Drawing.Point(50, 80);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new System.Drawing.Size(69, 30);
            NameLabel.TabIndex = 8;
            NameLabel.Text = "Name";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new System.Drawing.Point(800, 80);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new System.Drawing.Size(52, 30);
            TitleLabel.TabIndex = 9;
            TitleLabel.Text = "Title";
            // 
            // LeftBuildLabel
            // 
            LeftBuildLabel.AutoSize = true;
            LeftBuildLabel.Location = new System.Drawing.Point(50, 180);
            LeftBuildLabel.Name = "LeftBuildLabel";
            LeftBuildLabel.Size = new System.Drawing.Size(59, 30);
            LeftBuildLabel.TabIndex = 10;
            LeftBuildLabel.Text = "Build";
            // 
            // LeftVersionLabel
            // 
            LeftVersionLabel.AutoSize = true;
            LeftVersionLabel.Location = new System.Drawing.Point(380, 180);
            LeftVersionLabel.Name = "LeftVersionLabel";
            LeftVersionLabel.Size = new System.Drawing.Size(81, 30);
            LeftVersionLabel.TabIndex = 11;
            LeftVersionLabel.Text = "Version";
            // 
            // GameNameTextBox
            // 
            GameNameTextBox.Location = new System.Drawing.Point(125, 80);
            GameNameTextBox.Name = "GameNameTextBox";
            GameNameTextBox.ReadOnly = true;
            GameNameTextBox.Size = new System.Drawing.Size(669, 35);
            GameNameTextBox.TabIndex = 12;
            // 
            // GameTitleTextBox
            // 
            GameTitleTextBox.Location = new System.Drawing.Point(858, 80);
            GameTitleTextBox.Name = "GameTitleTextBox";
            GameTitleTextBox.ReadOnly = true;
            GameTitleTextBox.Size = new System.Drawing.Size(317, 35);
            GameTitleTextBox.TabIndex = 13;
            // 
            // LeftBuildTextBox
            // 
            LeftBuildTextBox.Location = new System.Drawing.Point(110, 180);
            LeftBuildTextBox.Name = "LeftBuildTextBox";
            LeftBuildTextBox.Size = new System.Drawing.Size(250, 35);
            LeftBuildTextBox.TabIndex = 14;
            LeftBuildTextBox.ReadOnly = true;
            // 
            // LeftVersionTextBox
            // 
            LeftVersionTextBox.Location = new System.Drawing.Point(470, 180);
            LeftVersionTextBox.Name = "LeftVersionTextBox";
            LeftVersionTextBox.Size = new System.Drawing.Size(190, 35);
            LeftVersionTextBox.TabIndex = 15;
            LeftVersionTextBox.ReadOnly = true;
            // 
            // RightBuildLabel
            // 
            RightBuildLabel.AutoSize = true;
            RightBuildLabel.Location = new System.Drawing.Point(800, 180);
            RightBuildLabel.Name = "RightBuildLabel";
            RightBuildLabel.Size = new System.Drawing.Size(59, 30);
            RightBuildLabel.TabIndex = 16;
            RightBuildLabel.Text = "Build";
            // 
            // RightVersionLabel
            // 
            RightVersionLabel.AutoSize = true;
            RightVersionLabel.Location = new System.Drawing.Point(1130, 180);
            RightVersionLabel.Name = "RightVersionLabel";
            RightVersionLabel.Size = new System.Drawing.Size(81, 30);
            RightVersionLabel.TabIndex = 17;
            RightVersionLabel.Text = "Version";
            // 
            // RightBuildTextBox
            // 
            RightBuildTextBox.Location = new System.Drawing.Point(860, 180);
            RightBuildTextBox.Name = "RightBuildTextBox";
            RightBuildTextBox.Size = new System.Drawing.Size(250, 35);
            RightBuildTextBox.TabIndex = 18;
            RightBuildTextBox.ReadOnly = true;
            // 
            // RightVersionTextBox
            // 
            RightVersionTextBox.Location = new System.Drawing.Point(1220, 180);
            RightVersionTextBox.Name = "RightVersionTextBox";
            RightVersionTextBox.Size = new System.Drawing.Size(190, 35);
            RightVersionTextBox.TabIndex = 19;
            RightVersionTextBox.ReadOnly = true;
            // 
            // SaveButton
            // 
            SaveButton.Location = new System.Drawing.Point(50, 1143);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new System.Drawing.Size(167, 55);
            SaveButton.TabIndex = 20;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // CodeCompareForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1576, 1210);
            Controls.Add(SaveButton);
            Controls.Add(RightVersionTextBox);
            Controls.Add(RightBuildTextBox);
            Controls.Add(RightVersionLabel);
            Controls.Add(RightBuildLabel);
            Controls.Add(LeftVersionTextBox);
            Controls.Add(LeftBuildTextBox);
            Controls.Add(GameTitleTextBox);
            Controls.Add(GameNameTextBox);
            Controls.Add(LeftVersionLabel);
            Controls.Add(LeftBuildLabel);
            Controls.Add(TitleLabel);
            Controls.Add(NameLabel);
            Controls.Add(PathLabel);
            Controls.Add(RightComboBoxEx);
            Controls.Add(LeftComboBoxEx);
            Controls.Add(RightTextAreaEx);
            Controls.Add(LeftTextAreaEx);
            Controls.Add(CheatPathTextBox);
            Name = "CodeCompareForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "CodeCompareForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.TextBox CheatPathTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox GameNameTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox GameTitleTextBox;

        private System.Windows.Forms.Label LeftBuildLabel;
        private System.Windows.Forms.TextBox LeftBuildTextBox;
        private System.Windows.Forms.Label LeftVersionLabel;
        private System.Windows.Forms.TextBox LeftVersionTextBox;
        private FormEntity.ComboBoxEx LeftComboBoxEx;
        private FormEntity.TextAreaEx LeftTextAreaEx;

        private System.Windows.Forms.Label RightBuildLabel;
        private System.Windows.Forms.TextBox RightBuildTextBox;
        private System.Windows.Forms.Label RightVersionLabel;
        private System.Windows.Forms.TextBox RightVersionTextBox;
        private FormEntity.ComboBoxEx RightComboBoxEx;
        private FormEntity.TextAreaEx RightTextAreaEx;

        private System.Windows.Forms.Button SaveButton;
    }
}