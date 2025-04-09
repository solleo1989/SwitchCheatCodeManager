namespace SwitchCheatCodeManager.SubView
{
    partial class TerminatorForm
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
            ExampleLabel = new System.Windows.Forms.Label();
            TemplateLabel = new System.Windows.Forms.Label();
            TerminatorGroupBox = new System.Windows.Forms.GroupBox();
            ConditionElseRadioButton = new System.Windows.Forms.RadioButton();
            ConditionEndRadioButton = new System.Windows.Forms.RadioButton();
            TerminatorGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ExampleLabel
            // 
            ExampleLabel.AutoSize = true;
            ExampleLabel.Location = new System.Drawing.Point(20, 113);
            ExampleLabel.Name = "ExampleLabel";
            ExampleLabel.Size = new System.Drawing.Size(96, 30);
            ExampleLabel.TabIndex = 0;
            ExampleLabel.Text = "Example:";
            // 
            // TemplateLabel
            // 
            TemplateLabel.AutoSize = true;
            TemplateLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TemplateLabel.Location = new System.Drawing.Point(40, 143);
            TemplateLabel.Name = "TemplateLabel";
            TemplateLabel.Size = new System.Drawing.Size(106, 24);
            TemplateLabel.TabIndex = 1;
            TemplateLabel.Text = "2X000000";
            // 
            // TerminatorGroupBox
            // 
            TerminatorGroupBox.Controls.Add(ConditionElseRadioButton);
            TerminatorGroupBox.Controls.Add(ConditionEndRadioButton);
            TerminatorGroupBox.Location = new System.Drawing.Point(20, 12);
            TerminatorGroupBox.Name = "TerminatorGroupBox";
            TerminatorGroupBox.Size = new System.Drawing.Size(520, 98);
            TerminatorGroupBox.TabIndex = 2;
            TerminatorGroupBox.TabStop = false;
            TerminatorGroupBox.Text = "End Type (X):";
            // 
            // ConditionElseRadioButton
            // 
            ConditionElseRadioButton.AutoSize = true;
            ConditionElseRadioButton.Location = new System.Drawing.Point(260, 40);
            ConditionElseRadioButton.Name = "ConditionElseRadioButton";
            ConditionElseRadioButton.Size = new System.Drawing.Size(199, 34);
            ConditionElseRadioButton.TabIndex = 1;
            ConditionElseRadioButton.TabStop = true;
            ConditionElseRadioButton.Text = "Else Condition (1)";
            ConditionElseRadioButton.UseVisualStyleBackColor = true;
            ConditionElseRadioButton.CheckedChanged += ConditionRadioButton_CheckedChanged;
            // 
            // ConditionEndRadioButton
            // 
            ConditionEndRadioButton.AutoSize = true;
            ConditionEndRadioButton.Location = new System.Drawing.Point(20, 40);
            ConditionEndRadioButton.Name = "ConditionEndRadioButton";
            ConditionEndRadioButton.Size = new System.Drawing.Size(198, 34);
            ConditionEndRadioButton.TabIndex = 0;
            ConditionEndRadioButton.TabStop = true;
            ConditionEndRadioButton.Text = "End Condition (0)";
            ConditionEndRadioButton.UseVisualStyleBackColor = true;
            ConditionEndRadioButton.CheckedChanged += ConditionRadioButton_CheckedChanged;
            // 
            // TerminatorForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(576, 536);
            Controls.Add(ExampleLabel);
            Controls.Add(TemplateLabel);
            Controls.Add(TerminatorGroupBox);
            Name = "TerminatorForm";
            Text = "TerminatorForm";
            TerminatorGroupBox.ResumeLayout(false);
            TerminatorGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox TerminatorGroupBox;
        private System.Windows.Forms.RadioButton ConditionEndRadioButton;
        private System.Windows.Forms.RadioButton ConditionElseRadioButton;
        private System.Windows.Forms.Label ExampleLabel;
        private System.Windows.Forms.Label TemplateLabel;
    }
}