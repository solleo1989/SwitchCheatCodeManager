using System.Windows.Forms;

namespace SwitchCheatCodeManager.SubView
{
    partial class LoopStartEndForm
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
            MemoryOffsetGroupBox = new GroupBox();
            CurrentValueLabel = new Label();
            ExampleLabel = new Label();
            CountRegisterComboBox = new ComboBox();
            NumOfLoopsTextBox = new TextBox();
            NumOfLoopsLabel = new Label();
            CountRegisterLabel = new Label();
            LoopStartEndGroupBox = new GroupBox();
            EndRadioButton = new RadioButton();
            StartRadioButton = new RadioButton();
            MemoryOffsetGroupBox.SuspendLayout();
            LoopStartEndGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // MemoryOffsetGroupBox
            // 
            MemoryOffsetGroupBox.Controls.Add(CountRegisterComboBox);
            MemoryOffsetGroupBox.Controls.Add(NumOfLoopsTextBox);
            MemoryOffsetGroupBox.Controls.Add(NumOfLoopsLabel);
            MemoryOffsetGroupBox.Controls.Add(CountRegisterLabel);
            MemoryOffsetGroupBox.Location = new System.Drawing.Point(15, 120);
            MemoryOffsetGroupBox.Name = "MemoryOffsetGroupBox";
            MemoryOffsetGroupBox.Size = new System.Drawing.Size(549, 210);
            MemoryOffsetGroupBox.TabIndex = 0;
            MemoryOffsetGroupBox.TabStop = false;
            MemoryOffsetGroupBox.Text = "Memory Offset";
            // 
            // CurrentValueLabel
            // 
            CurrentValueLabel.AutoSize = true;
            CurrentValueLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            CurrentValueLabel.Location = new System.Drawing.Point(40, 363);
            CurrentValueLabel.Name = "CurrentValueLabel";
            CurrentValueLabel.Size = new System.Drawing.Size(214, 24);
            CurrentValueLabel.TabIndex = 6;
            CurrentValueLabel.Text = "300R0000 VVVVVVVV";
            // 
            // ExampleLabel
            // 
            ExampleLabel.AutoSize = true;
            ExampleLabel.Location = new System.Drawing.Point(20, 333);
            ExampleLabel.Name = "ExampleLabel";
            ExampleLabel.Size = new System.Drawing.Size(96, 30);
            ExampleLabel.TabIndex = 5;
            ExampleLabel.Text = "Example:";
            // 
            // CountRegisterComboBox
            // 
            CountRegisterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CountRegisterComboBox.FormattingEnabled = true;
            CountRegisterComboBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" });
            CountRegisterComboBox.Location = new System.Drawing.Point(25, 73);
            CountRegisterComboBox.Name = "CountRegisterComboBox";
            CountRegisterComboBox.Size = new System.Drawing.Size(80, 38);
            CountRegisterComboBox.TabIndex = 4;
            CountRegisterComboBox.SelectedIndexChanged += CountRegisterComboBox_SelectedIndexChanged;
            // 
            // NumOfLoopsTextBox
            // 
            NumOfLoopsTextBox.Location = new System.Drawing.Point(20, 160);
            NumOfLoopsTextBox.MaxLength = 8;
            NumOfLoopsTextBox.Name = "NumOfLoopsTextBox";
            NumOfLoopsTextBox.PlaceholderText = "e.g. VVVVVVVV";
            NumOfLoopsTextBox.Size = new System.Drawing.Size(401, 35);
            NumOfLoopsTextBox.TabIndex = 3;
            NumOfLoopsTextBox.TextChanged += NumOfLoopsTextBox_TextChanged;
            // 
            // NumOfLoopsLabel
            // 
            NumOfLoopsLabel.AutoSize = true;
            NumOfLoopsLabel.Location = new System.Drawing.Point(20, 120);
            NumOfLoopsLabel.Name = "NumOfLoopsLabel";
            NumOfLoopsLabel.Size = new System.Drawing.Size(439, 30);
            NumOfLoopsLabel.TabIndex = 2;
            NumOfLoopsLabel.Text = "Number of times to loop (V): (in hex numbers)";
            // 
            // CountRegisterLabel
            // 
            CountRegisterLabel.AutoSize = true;
            CountRegisterLabel.Location = new System.Drawing.Point(20, 40);
            CountRegisterLabel.Name = "CountRegisterLabel";
            CountRegisterLabel.Size = new System.Drawing.Size(361, 30);
            CountRegisterLabel.TabIndex = 0;
            CountRegisterLabel.Text = "Count register (R): (Select from 0 to F)";
            // 
            // LoopStartEndGroupBox
            // 
            LoopStartEndGroupBox.Controls.Add(EndRadioButton);
            LoopStartEndGroupBox.Controls.Add(StartRadioButton);
            LoopStartEndGroupBox.Location = new System.Drawing.Point(20, 12);
            LoopStartEndGroupBox.Name = "LoopStartEndGroupBox";
            LoopStartEndGroupBox.Size = new System.Drawing.Size(520, 98);
            LoopStartEndGroupBox.TabIndex = 1;
            LoopStartEndGroupBox.TabStop = false;
            LoopStartEndGroupBox.Text = "Loop Start/End (X):";
            // 
            // EndRadioButton
            // 
            EndRadioButton.AutoSize = true;
            EndRadioButton.Location = new System.Drawing.Point(260, 40);
            EndRadioButton.Name = "EndRadioButton";
            EndRadioButton.Size = new System.Drawing.Size(154, 34);
            EndRadioButton.TabIndex = 1;
            EndRadioButton.TabStop = true;
            EndRadioButton.Text = "Loop End (1)";
            EndRadioButton.UseVisualStyleBackColor = true;
            // 
            // StartRadioButton
            // 
            StartRadioButton.AutoSize = true;
            StartRadioButton.Location = new System.Drawing.Point(20, 40);
            StartRadioButton.Name = "StartRadioButton";
            StartRadioButton.Size = new System.Drawing.Size(161, 34);
            StartRadioButton.TabIndex = 0;
            StartRadioButton.TabStop = true;
            StartRadioButton.Text = "Loop Start (0)";
            StartRadioButton.UseVisualStyleBackColor = true;
            StartRadioButton.CheckedChanged += StartRadioButton_CheckedChanged;
            // 
            // LoopStartEndForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(576, 536);
            Controls.Add(ExampleLabel);
            Controls.Add(CurrentValueLabel);
            Controls.Add(LoopStartEndGroupBox);
            Controls.Add(MemoryOffsetGroupBox);
            Name = "LoopStartEndForm";
            Text = "LoopStartForm";
            MemoryOffsetGroupBox.ResumeLayout(false);
            MemoryOffsetGroupBox.PerformLayout();
            LoopStartEndGroupBox.ResumeLayout(false);
            LoopStartEndGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private GroupBox LoopStartEndGroupBox;
        private RadioButton StartRadioButton;
        private RadioButton EndRadioButton;

        private GroupBox MemoryOffsetGroupBox;

        private TextBox NumOfLoopsTextBox;
        private Label NumOfLoopsLabel;
        private Label CountRegisterLabel;
        private ComboBox CountRegisterComboBox;
        private Label CurrentValueLabel;
        private Label ExampleLabel;
    }
}