namespace SwitchCheatCodeManager.SubView
{
    partial class ApplyLegacyArithmeticOperationForm
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
            AddressSizeGroupBox = new System.Windows.Forms.GroupBox();
            EightBitRadioButton = new System.Windows.Forms.RadioButton();
            SixtyFourBitRadioButton = new System.Windows.Forms.RadioButton();
            SixteenBitRadioButton = new System.Windows.Forms.RadioButton();
            ThirtyTwoBitRadioButton = new System.Windows.Forms.RadioButton();
            ArithmeticRegisterGroupBox = new System.Windows.Forms.GroupBox();
            ArithmeticRegisterLabel = new System.Windows.Forms.Label();
            ArithmeticRegisterComboBox = new System.Windows.Forms.ComboBox();
            ArithmeticOperationGroupBox = new System.Windows.Forms.GroupBox();
            RightShiftRadioButton = new System.Windows.Forms.RadioButton();
            LeftShiftRadioButton = new System.Windows.Forms.RadioButton();
            MultiplicationRadioButton = new System.Windows.Forms.RadioButton();
            SubtractionRadioButton = new System.Windows.Forms.RadioButton();
            AdditionRadioButton = new System.Windows.Forms.RadioButton();
            ArithmeticOperationValueGroupBox = new System.Windows.Forms.GroupBox();
            ValueTextBox = new FormEntity.TextBoxEx();
            ValueLabel = new System.Windows.Forms.Label();
            ExampleLabel = new System.Windows.Forms.Label();
            TemplateLabel = new System.Windows.Forms.Label();
            AddressSizeGroupBox.SuspendLayout();
            ArithmeticRegisterGroupBox.SuspendLayout();
            ArithmeticOperationGroupBox.SuspendLayout();
            ArithmeticOperationValueGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // AddressSizeGroupBox
            // 
            AddressSizeGroupBox.Controls.Add(EightBitRadioButton);
            AddressSizeGroupBox.Controls.Add(SixtyFourBitRadioButton);
            AddressSizeGroupBox.Controls.Add(SixteenBitRadioButton);
            AddressSizeGroupBox.Controls.Add(ThirtyTwoBitRadioButton);
            AddressSizeGroupBox.Location = new System.Drawing.Point(20, 12);
            AddressSizeGroupBox.Name = "AddressSizeGroupBox";
            AddressSizeGroupBox.Size = new System.Drawing.Size(520, 98);
            AddressSizeGroupBox.TabIndex = 15;
            AddressSizeGroupBox.TabStop = false;
            AddressSizeGroupBox.Text = "Memory Width (T):";
            // 
            // EightBitRadioButton
            // 
            EightBitRadioButton.AutoSize = true;
            EightBitRadioButton.Location = new System.Drawing.Point(20, 40);
            EightBitRadioButton.Name = "EightBitRadioButton";
            EightBitRadioButton.Size = new System.Drawing.Size(108, 34);
            EightBitRadioButton.TabIndex = 10;
            EightBitRadioButton.TabStop = true;
            EightBitRadioButton.Text = "8 bit (1)";
            EightBitRadioButton.UseVisualStyleBackColor = true;
            EightBitRadioButton.CheckedChanged += BitRadioButton_CheckedChanged;
            // 
            // SixtyFourBitRadioButton
            // 
            SixtyFourBitRadioButton.AutoSize = true;
            SixtyFourBitRadioButton.Checked = true;
            SixtyFourBitRadioButton.Location = new System.Drawing.Point(380, 40);
            SixtyFourBitRadioButton.Name = "SixtyFourBitRadioButton";
            SixtyFourBitRadioButton.Size = new System.Drawing.Size(119, 34);
            SixtyFourBitRadioButton.TabIndex = 13;
            SixtyFourBitRadioButton.TabStop = true;
            SixtyFourBitRadioButton.Text = "64 bit (8)";
            SixtyFourBitRadioButton.UseVisualStyleBackColor = true;
            SixtyFourBitRadioButton.CheckedChanged += BitRadioButton_CheckedChanged;
            // 
            // SixteenBitRadioButton
            // 
            SixteenBitRadioButton.AutoSize = true;
            SixteenBitRadioButton.Location = new System.Drawing.Point(140, 40);
            SixteenBitRadioButton.Name = "SixteenBitRadioButton";
            SixteenBitRadioButton.Size = new System.Drawing.Size(119, 34);
            SixteenBitRadioButton.TabIndex = 11;
            SixteenBitRadioButton.TabStop = true;
            SixteenBitRadioButton.Text = "16 bit (2)";
            SixteenBitRadioButton.UseVisualStyleBackColor = true;
            SixteenBitRadioButton.CheckedChanged += BitRadioButton_CheckedChanged;
            // 
            // ThirtyTwoBitRadioButton
            // 
            ThirtyTwoBitRadioButton.AutoSize = true;
            ThirtyTwoBitRadioButton.Location = new System.Drawing.Point(260, 40);
            ThirtyTwoBitRadioButton.Name = "ThirtyTwoBitRadioButton";
            ThirtyTwoBitRadioButton.Size = new System.Drawing.Size(119, 34);
            ThirtyTwoBitRadioButton.TabIndex = 12;
            ThirtyTwoBitRadioButton.TabStop = true;
            ThirtyTwoBitRadioButton.Text = "32 bit (4)";
            ThirtyTwoBitRadioButton.UseVisualStyleBackColor = true;
            ThirtyTwoBitRadioButton.CheckedChanged += BitRadioButton_CheckedChanged;
            // 
            // ArithmeticRegisterGroupBox
            // 
            ArithmeticRegisterGroupBox.Controls.Add(ArithmeticRegisterLabel);
            ArithmeticRegisterGroupBox.Controls.Add(ArithmeticRegisterComboBox);
            ArithmeticRegisterGroupBox.Location = new System.Drawing.Point(20, 116);
            ArithmeticRegisterGroupBox.Name = "ArithmeticRegisterGroupBox";
            ArithmeticRegisterGroupBox.Size = new System.Drawing.Size(520, 98);
            ArithmeticRegisterGroupBox.TabIndex = 16;
            ArithmeticRegisterGroupBox.TabStop = false;
            ArithmeticRegisterGroupBox.Text = "Register to apply arithmetic to";
            // 
            // ArithmeticRegisterLabel
            // 
            ArithmeticRegisterLabel.AutoSize = true;
            ArithmeticRegisterLabel.Location = new System.Drawing.Point(20, 40);
            ArithmeticRegisterLabel.Name = "ArithmeticRegisterLabel";
            ArithmeticRegisterLabel.Size = new System.Drawing.Size(123, 30);
            ArithmeticRegisterLabel.TabIndex = 1;
            ArithmeticRegisterLabel.Text = "Register (R):";
            // 
            // ArithmeticRegisterComboBox
            // 
            ArithmeticRegisterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ArithmeticRegisterComboBox.FormattingEnabled = true;
            ArithmeticRegisterComboBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" });
            ArithmeticRegisterComboBox.Location = new System.Drawing.Point(160, 40);
            ArithmeticRegisterComboBox.Name = "ArithmeticRegisterComboBox";
            ArithmeticRegisterComboBox.Size = new System.Drawing.Size(80, 38);
            ArithmeticRegisterComboBox.TabIndex = 2;
            // 
            // ArithmeticOperationGroupBox
            // 
            ArithmeticOperationGroupBox.Controls.Add(RightShiftRadioButton);
            ArithmeticOperationGroupBox.Controls.Add(LeftShiftRadioButton);
            ArithmeticOperationGroupBox.Controls.Add(MultiplicationRadioButton);
            ArithmeticOperationGroupBox.Controls.Add(SubtractionRadioButton);
            ArithmeticOperationGroupBox.Controls.Add(AdditionRadioButton);
            ArithmeticOperationGroupBox.Location = new System.Drawing.Point(20, 220);
            ArithmeticOperationGroupBox.Name = "ArithmeticOperationGroupBox";
            ArithmeticOperationGroupBox.Size = new System.Drawing.Size(520, 168);
            ArithmeticOperationGroupBox.TabIndex = 17;
            ArithmeticOperationGroupBox.TabStop = false;
            ArithmeticOperationGroupBox.Text = "Arithmetic operation (C):";
            // 
            // RightShiftRadioButton
            // 
            RightShiftRadioButton.AutoSize = true;
            RightShiftRadioButton.Location = new System.Drawing.Point(260, 80);
            RightShiftRadioButton.Name = "RightShiftRadioButton";
            RightShiftRadioButton.Size = new System.Drawing.Size(164, 34);
            RightShiftRadioButton.TabIndex = 4;
            RightShiftRadioButton.TabStop = true;
            RightShiftRadioButton.Text = "Right Shift (4)";
            RightShiftRadioButton.UseVisualStyleBackColor = true;
            // 
            // LeftShiftRadioButton
            // 
            LeftShiftRadioButton.AutoSize = true;
            LeftShiftRadioButton.Location = new System.Drawing.Point(260, 40);
            LeftShiftRadioButton.Name = "LeftShiftRadioButton";
            LeftShiftRadioButton.Size = new System.Drawing.Size(150, 34);
            LeftShiftRadioButton.TabIndex = 3;
            LeftShiftRadioButton.TabStop = true;
            LeftShiftRadioButton.Text = "Left Shift (3)";
            LeftShiftRadioButton.UseVisualStyleBackColor = true;
            // 
            // MultiplicationRadioButton
            // 
            MultiplicationRadioButton.AutoSize = true;
            MultiplicationRadioButton.Location = new System.Drawing.Point(20, 120);
            MultiplicationRadioButton.Name = "MultiplicationRadioButton";
            MultiplicationRadioButton.Size = new System.Drawing.Size(194, 34);
            MultiplicationRadioButton.TabIndex = 2;
            MultiplicationRadioButton.TabStop = true;
            MultiplicationRadioButton.Text = "Multiplication (2)";
            MultiplicationRadioButton.UseVisualStyleBackColor = true;
            // 
            // SubtractionRadioButton
            // 
            SubtractionRadioButton.AutoSize = true;
            SubtractionRadioButton.Location = new System.Drawing.Point(20, 80);
            SubtractionRadioButton.Name = "SubtractionRadioButton";
            SubtractionRadioButton.Size = new System.Drawing.Size(173, 34);
            SubtractionRadioButton.TabIndex = 1;
            SubtractionRadioButton.TabStop = true;
            SubtractionRadioButton.Text = "Subtraction (1)";
            SubtractionRadioButton.UseVisualStyleBackColor = true;
            // 
            // AdditionRadioButton
            // 
            AdditionRadioButton.AutoSize = true;
            AdditionRadioButton.Location = new System.Drawing.Point(20, 40);
            AdditionRadioButton.Name = "AdditionRadioButton";
            AdditionRadioButton.Size = new System.Drawing.Size(146, 34);
            AdditionRadioButton.TabIndex = 0;
            AdditionRadioButton.TabStop = true;
            AdditionRadioButton.Text = "Addition (0)";
            AdditionRadioButton.UseVisualStyleBackColor = true;
            // 
            // ArithmeticOperationValueGroupBox
            // 
            ArithmeticOperationValueGroupBox.Controls.Add(ValueTextBox);
            ArithmeticOperationValueGroupBox.Controls.Add(ValueLabel);
            ArithmeticOperationValueGroupBox.Location = new System.Drawing.Point(20, 394);
            ArithmeticOperationValueGroupBox.Name = "ArithmeticOperationValueGroupBox";
            ArithmeticOperationValueGroupBox.Size = new System.Drawing.Size(520, 130);
            ArithmeticOperationValueGroupBox.TabIndex = 18;
            ArithmeticOperationValueGroupBox.TabStop = false;
            ArithmeticOperationValueGroupBox.Text = "Value to use for arithmetic operation";
            // 
            // ValueTextBox
            // 
            ValueTextBox.Location = new System.Drawing.Point(20, 73);
            ValueTextBox.MaxLength = 8;
            ValueTextBox.Name = "ValueTextBox";
            ValueTextBox.Size = new System.Drawing.Size(480, 35);
            ValueTextBox.TabIndex = 8;
            ValueTextBox.TextChanged += ValueTextBox_TextChanged;
            // 
            // ValueLabel
            // 
            ValueLabel.AutoSize = true;
            ValueLabel.Location = new System.Drawing.Point(20, 40);
            ValueLabel.Name = "ValueLabel";
            ValueLabel.Size = new System.Drawing.Size(99, 30);
            ValueLabel.TabIndex = 7;
            ValueLabel.Text = "Value (V):";
            // 
            // ExampleLabel
            // 
            ExampleLabel.AutoSize = true;
            ExampleLabel.Location = new System.Drawing.Point(20, 527);
            ExampleLabel.Name = "ExampleLabel";
            ExampleLabel.Size = new System.Drawing.Size(140, 30);
            ExampleLabel.TabIndex = 19;
            ExampleLabel.Text = "ExampleLabel";
            // 
            // TemplateLabel
            // 
            TemplateLabel.AutoSize = true;
            TemplateLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TemplateLabel.Location = new System.Drawing.Point(40, 557);
            TemplateLabel.Name = "TemplateLabel";
            TemplateLabel.Size = new System.Drawing.Size(166, 24);
            TemplateLabel.TabIndex = 20;
            TemplateLabel.Text = "TemplateLabel";
            // 
            // ApplyLegacyArithmeticOperationForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(576, 618);
            Controls.Add(TemplateLabel);
            Controls.Add(ExampleLabel);
            Controls.Add(ArithmeticOperationValueGroupBox);
            Controls.Add(ArithmeticOperationGroupBox);
            Controls.Add(ArithmeticRegisterGroupBox);
            Controls.Add(AddressSizeGroupBox);
            Name = "ApplyLegacyArithmeticOperationForm";
            Text = "ApplyLegacyArithmeticOperationForm";
            AddressSizeGroupBox.ResumeLayout(false);
            AddressSizeGroupBox.PerformLayout();
            ArithmeticRegisterGroupBox.ResumeLayout(false);
            ArithmeticRegisterGroupBox.PerformLayout();
            ArithmeticOperationGroupBox.ResumeLayout(false);
            ArithmeticOperationGroupBox.PerformLayout();
            ArithmeticOperationValueGroupBox.ResumeLayout(false);
            ArithmeticOperationValueGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox AddressSizeGroupBox;
        private System.Windows.Forms.RadioButton EightBitRadioButton;
        private System.Windows.Forms.RadioButton SixtyFourBitRadioButton;
        private System.Windows.Forms.RadioButton SixteenBitRadioButton;
        private System.Windows.Forms.RadioButton ThirtyTwoBitRadioButton;
        private System.Windows.Forms.GroupBox ArithmeticRegisterGroupBox;
        private System.Windows.Forms.Label ArithmeticRegisterLabel;
        private System.Windows.Forms.ComboBox ArithmeticRegisterComboBox;
        private System.Windows.Forms.GroupBox ArithmeticOperationGroupBox;
        private System.Windows.Forms.RadioButton RightShiftRadioButton;
        private System.Windows.Forms.RadioButton LeftShiftRadioButton;
        private System.Windows.Forms.RadioButton MultiplicationRadioButton;
        private System.Windows.Forms.RadioButton SubtractionRadioButton;
        private System.Windows.Forms.RadioButton AdditionRadioButton;
        private System.Windows.Forms.GroupBox ArithmeticOperationValueGroupBox;
        private System.Windows.Forms.Label ValueLabel;
        private FormEntity.TextBoxEx ValueTextBox;
        private System.Windows.Forms.Label ExampleLabel;
        private System.Windows.Forms.Label TemplateLabel;
    }
}