namespace SwitchCheatCodeManager.SubView
{
    partial class LoopEndForm
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
            LoopEndGroupBox = new System.Windows.Forms.GroupBox();
            CurrentValueLabel = new System.Windows.Forms.Label();
            ExampleLabel = new System.Windows.Forms.Label();
            LoopEndGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // LoopEndGroupBox
            // 
            LoopEndGroupBox.Controls.Add(CurrentValueLabel);
            LoopEndGroupBox.Controls.Add(ExampleLabel);
            LoopEndGroupBox.Location = new System.Drawing.Point(15, 15);
            LoopEndGroupBox.Name = "LoopEndGroupBox";
            LoopEndGroupBox.Size = new System.Drawing.Size(549, 509);
            LoopEndGroupBox.TabIndex = 0;
            LoopEndGroupBox.TabStop = false;
            LoopEndGroupBox.Text = "Loop End";
            // 
            // CurrentValueLabel
            // 
            CurrentValueLabel.AutoSize = true;
            CurrentValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            CurrentValueLabel.Location = new System.Drawing.Point(140, 100);
            CurrentValueLabel.Name = "CurrentValueLabel";
            CurrentValueLabel.Size = new System.Drawing.Size(0, 30);
            CurrentValueLabel.TabIndex = 1;
            // 
            // ExampleLabel
            // 
            ExampleLabel.AutoSize = true;
            ExampleLabel.Location = new System.Drawing.Point(30, 100);
            ExampleLabel.Name = "ExampleLabel";
            ExampleLabel.Size = new System.Drawing.Size(96, 30);
            ExampleLabel.TabIndex = 0;
            ExampleLabel.Text = "Example:";
            // 
            // LoopEndForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(576, 536);
            Controls.Add(LoopEndGroupBox);
            Name = "LoopEndForm";
            Text = "LoopEndForm";
            LoopEndGroupBox.ResumeLayout(false);
            LoopEndGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox LoopEndGroupBox;
        private System.Windows.Forms.Label CurrentValueLabel;
        private System.Windows.Forms.Label ExampleLabel;
    }
}