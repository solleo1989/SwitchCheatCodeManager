namespace SwitchCheatCodeManager.SubView
{
    partial class ApplyArithmeticOperationForm
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
            ArithmeticOperationTypesGroupBox = new System.Windows.Forms.GroupBox();
            ValueArithmeticButton = new System.Windows.Forms.RadioButton();
            RegisterArithmeticButton = new System.Windows.Forms.RadioButton();
            ArithmeticRegisterGroupBox = new System.Windows.Forms.GroupBox();
            ArithmeticRegisterLabel = new System.Windows.Forms.Label();
            ArithmeticRegisterComboBox = new System.Windows.Forms.ComboBox();
            ArithmeticOperationWidthGroupBox = new System.Windows.Forms.GroupBox();
            EightBitRadioButton = new System.Windows.Forms.RadioButton();
            SixtyFourBitRadioButton = new System.Windows.Forms.RadioButton();
            SixteenBitRadioButton = new System.Windows.Forms.RadioButton();
            ThirtyTwoBitRadioButton = new System.Windows.Forms.RadioButton();
            ArithmeticTypesGroupBox = new System.Windows.Forms.GroupBox();
            OperationNoneMoveRadioButton = new System.Windows.Forms.RadioButton();
            OperationLogicalXorRadioButton = new System.Windows.Forms.RadioButton();
            OperationLogicalNotRadioButton = new System.Windows.Forms.RadioButton();
            OperationLogicalOrRadioButton = new System.Windows.Forms.RadioButton();
            OperationLogicalAndRadioButton = new System.Windows.Forms.RadioButton();
            OperationAdditionRadioButton = new System.Windows.Forms.RadioButton();
            OperationSubtractionRadioButton = new System.Windows.Forms.RadioButton();
            OperationMultiplicationRadioButton = new System.Windows.Forms.RadioButton();
            OperationLeftShiftRadioButton = new System.Windows.Forms.RadioButton();
            OperationrRightShiftRadioButton = new System.Windows.Forms.RadioButton();
            LeftHandOperandRegisterGroupBox = new System.Windows.Forms.GroupBox();
            LeftHandOperandRegisterLabel = new System.Windows.Forms.Label();
            LeftHandOperandRegisterComboBox = new System.Windows.Forms.ComboBox();
            RightHandOperandRegisterGroupBox = new System.Windows.Forms.GroupBox();
            RightHandOperandRegisterLabel = new System.Windows.Forms.Label();
            RightHandOperandRegisterComboBox = new System.Windows.Forms.ComboBox();
            RightHandOperandValueGroupBox = new System.Windows.Forms.GroupBox();
            ValueTextBox = new FormEntity.TextBoxEx();
            ValueLabel = new System.Windows.Forms.Label();
            ExampleLabel = new System.Windows.Forms.Label();
            TemplateLabel = new System.Windows.Forms.Label();
            ArithmeticOperationTypesGroupBox.SuspendLayout();
            ArithmeticRegisterGroupBox.SuspendLayout();
            ArithmeticOperationWidthGroupBox.SuspendLayout();
            ArithmeticTypesGroupBox.SuspendLayout();
            LeftHandOperandRegisterGroupBox.SuspendLayout();
            RightHandOperandRegisterGroupBox.SuspendLayout();
            RightHandOperandValueGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ArithmeticOperationTypesGroupBox
            // 
            ArithmeticOperationTypesGroupBox.Controls.Add(ValueArithmeticButton);
            ArithmeticOperationTypesGroupBox.Controls.Add(RegisterArithmeticButton);
            ArithmeticOperationTypesGroupBox.Location = new System.Drawing.Point(15, 15);
            ArithmeticOperationTypesGroupBox.Name = "ArithmeticOperationTypesGroupBox";
            ArithmeticOperationTypesGroupBox.Size = new System.Drawing.Size(549, 85);
            ArithmeticOperationTypesGroupBox.TabIndex = 0;
            ArithmeticOperationTypesGroupBox.TabStop = false;
            ArithmeticOperationTypesGroupBox.Text = "Arithmetic Types:";
            // 
            // ValueArithmeticButton
            // 
            ValueArithmeticButton.AutoSize = true;
            ValueArithmeticButton.Location = new System.Drawing.Point(260, 40);
            ValueArithmeticButton.Name = "ValueArithmeticButton";
            ValueArithmeticButton.Size = new System.Drawing.Size(222, 34);
            ValueArithmeticButton.TabIndex = 13;
            ValueArithmeticButton.TabStop = true;
            ValueArithmeticButton.Text = "Immediate Value (1)";
            ValueArithmeticButton.UseVisualStyleBackColor = true;
            ValueArithmeticButton.CheckedChanged += ValueArithmeticButton_CheckedChanged;
            // 
            // RegisterArithmeticButton
            // 
            RegisterArithmeticButton.AutoSize = true;
            RegisterArithmeticButton.Location = new System.Drawing.Point(20, 40);
            RegisterArithmeticButton.Name = "RegisterArithmeticButton";
            RegisterArithmeticButton.Size = new System.Drawing.Size(175, 34);
            RegisterArithmeticButton.TabIndex = 11;
            RegisterArithmeticButton.TabStop = true;
            RegisterArithmeticButton.Text = "On Register (0)";
            RegisterArithmeticButton.UseVisualStyleBackColor = true;
            RegisterArithmeticButton.CheckedChanged += RegisterArithmeticButton_CheckedChanged;
            // 
            // ArithmeticRegisterGroupBox
            // 
            ArithmeticRegisterGroupBox.Controls.Add(ArithmeticRegisterLabel);
            ArithmeticRegisterGroupBox.Controls.Add(ArithmeticRegisterComboBox);
            ArithmeticRegisterGroupBox.Location = new System.Drawing.Point(15, 443);
            ArithmeticRegisterGroupBox.Name = "ArithmeticRegisterGroupBox";
            ArithmeticRegisterGroupBox.Size = new System.Drawing.Size(549, 85);
            ArithmeticRegisterGroupBox.TabIndex = 17;
            ArithmeticRegisterGroupBox.TabStop = false;
            ArithmeticRegisterGroupBox.Text = "Register to store result in";
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
            // ArithmeticOperationWidthGroupBox
            // 
            ArithmeticOperationWidthGroupBox.Controls.Add(EightBitRadioButton);
            ArithmeticOperationWidthGroupBox.Controls.Add(SixtyFourBitRadioButton);
            ArithmeticOperationWidthGroupBox.Controls.Add(SixteenBitRadioButton);
            ArithmeticOperationWidthGroupBox.Controls.Add(ThirtyTwoBitRadioButton);
            ArithmeticOperationWidthGroupBox.Location = new System.Drawing.Point(15, 106);
            ArithmeticOperationWidthGroupBox.Name = "ArithmeticOperationWidthGroupBox";
            ArithmeticOperationWidthGroupBox.Size = new System.Drawing.Size(549, 85);
            ArithmeticOperationWidthGroupBox.TabIndex = 18;
            ArithmeticOperationWidthGroupBox.TabStop = false;
            ArithmeticOperationWidthGroupBox.Text = "Arithmetic Operation Width (T):";
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
            EightBitRadioButton.CheckedChanged += EightBitRadioButton_CheckedChanged;
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
            SixtyFourBitRadioButton.CheckedChanged += SixtyFourBitRadioButton_CheckedChanged;
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
            SixteenBitRadioButton.CheckedChanged += SixteenBitRadioButton_CheckedChanged;
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
            ThirtyTwoBitRadioButton.CheckedChanged += ThirtyTwoBitRadioButton_CheckedChanged;
            // 
            // ArithmeticTypesGroupBox
            // 
            ArithmeticTypesGroupBox.Controls.Add(OperationNoneMoveRadioButton);
            ArithmeticTypesGroupBox.Controls.Add(OperationLogicalXorRadioButton);
            ArithmeticTypesGroupBox.Controls.Add(OperationLogicalNotRadioButton);
            ArithmeticTypesGroupBox.Controls.Add(OperationLogicalOrRadioButton);
            ArithmeticTypesGroupBox.Controls.Add(OperationLogicalAndRadioButton);
            ArithmeticTypesGroupBox.Controls.Add(OperationAdditionRadioButton);
            ArithmeticTypesGroupBox.Controls.Add(OperationSubtractionRadioButton);
            ArithmeticTypesGroupBox.Controls.Add(OperationMultiplicationRadioButton);
            ArithmeticTypesGroupBox.Controls.Add(OperationLeftShiftRadioButton);
            ArithmeticTypesGroupBox.Controls.Add(OperationrRightShiftRadioButton);
            ArithmeticTypesGroupBox.Location = new System.Drawing.Point(15, 197);
            ArithmeticTypesGroupBox.Name = "ArithmeticTypesGroupBox";
            ArithmeticTypesGroupBox.Size = new System.Drawing.Size(549, 240);
            ArithmeticTypesGroupBox.TabIndex = 19;
            ArithmeticTypesGroupBox.TabStop = false;
            ArithmeticTypesGroupBox.Text = "Arithmetic operation to apply (C):";
            // 
            // OperationNoneMoveRadioButton
            // 
            OperationNoneMoveRadioButton.AutoSize = true;
            OperationNoneMoveRadioButton.Location = new System.Drawing.Point(260, 200);
            OperationNoneMoveRadioButton.Name = "OperationNoneMoveRadioButton";
            OperationNoneMoveRadioButton.Size = new System.Drawing.Size(178, 34);
            OperationNoneMoveRadioButton.TabIndex = 19;
            OperationNoneMoveRadioButton.TabStop = true;
            OperationNoneMoveRadioButton.Text = "None/Move (9)";
            OperationNoneMoveRadioButton.UseVisualStyleBackColor = true;
            // 
            // OperationLogicalXorRadioButton
            // 
            OperationLogicalXorRadioButton.AutoSize = true;
            OperationLogicalXorRadioButton.Location = new System.Drawing.Point(260, 160);
            OperationLogicalXorRadioButton.Name = "OperationLogicalXorRadioButton";
            OperationLogicalXorRadioButton.Size = new System.Drawing.Size(169, 34);
            OperationLogicalXorRadioButton.TabIndex = 18;
            OperationLogicalXorRadioButton.TabStop = true;
            OperationLogicalXorRadioButton.Text = "Logical Xor (8)";
            OperationLogicalXorRadioButton.UseVisualStyleBackColor = true;
            // 
            // OperationLogicalNotRadioButton
            // 
            OperationLogicalNotRadioButton.AutoSize = true;
            OperationLogicalNotRadioButton.Location = new System.Drawing.Point(260, 120);
            OperationLogicalNotRadioButton.Name = "OperationLogicalNotRadioButton";
            OperationLogicalNotRadioButton.Size = new System.Drawing.Size(173, 34);
            OperationLogicalNotRadioButton.TabIndex = 17;
            OperationLogicalNotRadioButton.TabStop = true;
            OperationLogicalNotRadioButton.Text = "Logical Not (7)";
            OperationLogicalNotRadioButton.UseVisualStyleBackColor = true;
            // 
            // OperationLogicalOrRadioButton
            // 
            OperationLogicalOrRadioButton.AutoSize = true;
            OperationLogicalOrRadioButton.Location = new System.Drawing.Point(260, 80);
            OperationLogicalOrRadioButton.Name = "OperationLogicalOrRadioButton";
            OperationLogicalOrRadioButton.Size = new System.Drawing.Size(161, 34);
            OperationLogicalOrRadioButton.TabIndex = 16;
            OperationLogicalOrRadioButton.TabStop = true;
            OperationLogicalOrRadioButton.Text = "Logical Or (6)";
            OperationLogicalOrRadioButton.UseVisualStyleBackColor = true;
            // 
            // OperationLogicalAndRadioButton
            // 
            OperationLogicalAndRadioButton.AutoSize = true;
            OperationLogicalAndRadioButton.Location = new System.Drawing.Point(260, 40);
            OperationLogicalAndRadioButton.Name = "OperationLogicalAndRadioButton";
            OperationLogicalAndRadioButton.Size = new System.Drawing.Size(176, 34);
            OperationLogicalAndRadioButton.TabIndex = 15;
            OperationLogicalAndRadioButton.TabStop = true;
            OperationLogicalAndRadioButton.Text = "Logical And (5)";
            OperationLogicalAndRadioButton.UseVisualStyleBackColor = true;
            // 
            // OperationAdditionRadioButton
            // 
            OperationAdditionRadioButton.AutoSize = true;
            OperationAdditionRadioButton.Location = new System.Drawing.Point(20, 40);
            OperationAdditionRadioButton.Name = "OperationAdditionRadioButton";
            OperationAdditionRadioButton.Size = new System.Drawing.Size(146, 34);
            OperationAdditionRadioButton.TabIndex = 10;
            OperationAdditionRadioButton.TabStop = true;
            OperationAdditionRadioButton.Text = "Addition (0)";
            OperationAdditionRadioButton.UseVisualStyleBackColor = true;
            // 
            // OperationSubtractionRadioButton
            // 
            OperationSubtractionRadioButton.AutoSize = true;
            OperationSubtractionRadioButton.Location = new System.Drawing.Point(20, 80);
            OperationSubtractionRadioButton.Name = "OperationSubtractionRadioButton";
            OperationSubtractionRadioButton.Size = new System.Drawing.Size(173, 34);
            OperationSubtractionRadioButton.TabIndex = 11;
            OperationSubtractionRadioButton.TabStop = true;
            OperationSubtractionRadioButton.Text = "Subtraction (1)";
            OperationSubtractionRadioButton.UseVisualStyleBackColor = true;
            // 
            // OperationMultiplicationRadioButton
            // 
            OperationMultiplicationRadioButton.AutoSize = true;
            OperationMultiplicationRadioButton.Location = new System.Drawing.Point(20, 120);
            OperationMultiplicationRadioButton.Name = "OperationMultiplicationRadioButton";
            OperationMultiplicationRadioButton.Size = new System.Drawing.Size(194, 34);
            OperationMultiplicationRadioButton.TabIndex = 12;
            OperationMultiplicationRadioButton.TabStop = true;
            OperationMultiplicationRadioButton.Text = "Multiplication (2)";
            OperationMultiplicationRadioButton.UseVisualStyleBackColor = true;
            // 
            // OperationLeftShiftRadioButton
            // 
            OperationLeftShiftRadioButton.AutoSize = true;
            OperationLeftShiftRadioButton.Checked = true;
            OperationLeftShiftRadioButton.Location = new System.Drawing.Point(20, 160);
            OperationLeftShiftRadioButton.Name = "OperationLeftShiftRadioButton";
            OperationLeftShiftRadioButton.Size = new System.Drawing.Size(150, 34);
            OperationLeftShiftRadioButton.TabIndex = 13;
            OperationLeftShiftRadioButton.TabStop = true;
            OperationLeftShiftRadioButton.Text = "Left Shift (3)";
            OperationLeftShiftRadioButton.UseVisualStyleBackColor = true;
            // 
            // OperationrRightShiftRadioButton
            // 
            OperationrRightShiftRadioButton.AutoSize = true;
            OperationrRightShiftRadioButton.Location = new System.Drawing.Point(20, 200);
            OperationrRightShiftRadioButton.Name = "OperationrRightShiftRadioButton";
            OperationrRightShiftRadioButton.Size = new System.Drawing.Size(164, 34);
            OperationrRightShiftRadioButton.TabIndex = 14;
            OperationrRightShiftRadioButton.TabStop = true;
            OperationrRightShiftRadioButton.Text = "Right Shift (4)";
            OperationrRightShiftRadioButton.UseVisualStyleBackColor = true;
            // 
            // LeftHandOperandRegisterGroupBox
            // 
            LeftHandOperandRegisterGroupBox.Controls.Add(LeftHandOperandRegisterLabel);
            LeftHandOperandRegisterGroupBox.Controls.Add(LeftHandOperandRegisterComboBox);
            LeftHandOperandRegisterGroupBox.Location = new System.Drawing.Point(15, 534);
            LeftHandOperandRegisterGroupBox.Name = "LeftHandOperandRegisterGroupBox";
            LeftHandOperandRegisterGroupBox.Size = new System.Drawing.Size(549, 85);
            LeftHandOperandRegisterGroupBox.TabIndex = 18;
            LeftHandOperandRegisterGroupBox.TabStop = false;
            LeftHandOperandRegisterGroupBox.Text = "Register to use as left-hand operand";
            // 
            // LeftHandOperandRegisterLabel
            // 
            LeftHandOperandRegisterLabel.AutoSize = true;
            LeftHandOperandRegisterLabel.Location = new System.Drawing.Point(20, 40);
            LeftHandOperandRegisterLabel.Name = "LeftHandOperandRegisterLabel";
            LeftHandOperandRegisterLabel.Size = new System.Drawing.Size(121, 30);
            LeftHandOperandRegisterLabel.TabIndex = 1;
            LeftHandOperandRegisterLabel.Text = "Register (S):";
            // 
            // LeftHandOperandRegisterComboBox
            // 
            LeftHandOperandRegisterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            LeftHandOperandRegisterComboBox.FormattingEnabled = true;
            LeftHandOperandRegisterComboBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" });
            LeftHandOperandRegisterComboBox.Location = new System.Drawing.Point(160, 40);
            LeftHandOperandRegisterComboBox.Name = "LeftHandOperandRegisterComboBox";
            LeftHandOperandRegisterComboBox.Size = new System.Drawing.Size(80, 38);
            LeftHandOperandRegisterComboBox.TabIndex = 2;
            // 
            // RightHandOperandRegisterGroupBox
            // 
            RightHandOperandRegisterGroupBox.Controls.Add(RightHandOperandRegisterLabel);
            RightHandOperandRegisterGroupBox.Controls.Add(RightHandOperandRegisterComboBox);
            RightHandOperandRegisterGroupBox.Location = new System.Drawing.Point(15, 625);
            RightHandOperandRegisterGroupBox.Name = "RightHandOperandRegisterGroupBox";
            RightHandOperandRegisterGroupBox.Size = new System.Drawing.Size(549, 85);
            RightHandOperandRegisterGroupBox.TabIndex = 19;
            RightHandOperandRegisterGroupBox.TabStop = false;
            RightHandOperandRegisterGroupBox.Text = "Register to use as right-hand operand";
            // 
            // RightHandOperandRegisterLabel
            // 
            RightHandOperandRegisterLabel.AutoSize = true;
            RightHandOperandRegisterLabel.Location = new System.Drawing.Point(20, 40);
            RightHandOperandRegisterLabel.Name = "RightHandOperandRegisterLabel";
            RightHandOperandRegisterLabel.Size = new System.Drawing.Size(119, 30);
            RightHandOperandRegisterLabel.TabIndex = 1;
            RightHandOperandRegisterLabel.Text = "Register (s):";
            // 
            // RightHandOperandRegisterComboBox
            // 
            RightHandOperandRegisterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            RightHandOperandRegisterComboBox.FormattingEnabled = true;
            RightHandOperandRegisterComboBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" });
            RightHandOperandRegisterComboBox.Location = new System.Drawing.Point(160, 40);
            RightHandOperandRegisterComboBox.Name = "RightHandOperandRegisterComboBox";
            RightHandOperandRegisterComboBox.Size = new System.Drawing.Size(80, 38);
            RightHandOperandRegisterComboBox.TabIndex = 2;
            // 
            // RightHandOperandValueGroupBox
            // 
            RightHandOperandValueGroupBox.Controls.Add(ValueTextBox);
            RightHandOperandValueGroupBox.Controls.Add(ValueLabel);
            RightHandOperandValueGroupBox.Location = new System.Drawing.Point(15, 716);
            RightHandOperandValueGroupBox.Name = "RightHandOperandValueGroupBox";
            RightHandOperandValueGroupBox.Size = new System.Drawing.Size(549, 120);
            RightHandOperandValueGroupBox.TabIndex = 20;
            RightHandOperandValueGroupBox.TabStop = false;
            RightHandOperandValueGroupBox.Text = "Value to use as right-hand operand";
            // 
            // ValueTextBox
            // 
            ValueTextBox.Location = new System.Drawing.Point(20, 73);
            ValueTextBox.MaxLength = 16;
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
            ExampleLabel.Location = new System.Drawing.Point(20, 839);
            ExampleLabel.Name = "ExampleLabel";
            ExampleLabel.Size = new System.Drawing.Size(140, 30);
            ExampleLabel.TabIndex = 21;
            ExampleLabel.Text = "ExampleLabel";
            // 
            // TemplateLabel
            // 
            TemplateLabel.AutoSize = true;
            TemplateLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TemplateLabel.Location = new System.Drawing.Point(40, 869);
            TemplateLabel.Name = "TemplateLabel";
            TemplateLabel.Size = new System.Drawing.Size(166, 24);
            TemplateLabel.TabIndex = 22;
            TemplateLabel.Text = "TemplateLabel";
            // 
            // ApplyArithmeticOperationForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(576, 924);
            Controls.Add(TemplateLabel);
            Controls.Add(ExampleLabel);
            Controls.Add(RightHandOperandValueGroupBox);
            Controls.Add(RightHandOperandRegisterGroupBox);
            Controls.Add(LeftHandOperandRegisterGroupBox);
            Controls.Add(ArithmeticTypesGroupBox);
            Controls.Add(ArithmeticOperationWidthGroupBox);
            Controls.Add(ArithmeticRegisterGroupBox);
            Controls.Add(ArithmeticOperationTypesGroupBox);
            Name = "ApplyArithmeticOperationForm";
            Text = "ApplyArithmeticOperationForm";
            ArithmeticOperationTypesGroupBox.ResumeLayout(false);
            ArithmeticOperationTypesGroupBox.PerformLayout();
            ArithmeticRegisterGroupBox.ResumeLayout(false);
            ArithmeticRegisterGroupBox.PerformLayout();
            ArithmeticOperationWidthGroupBox.ResumeLayout(false);
            ArithmeticOperationWidthGroupBox.PerformLayout();
            ArithmeticTypesGroupBox.ResumeLayout(false);
            ArithmeticTypesGroupBox.PerformLayout();
            LeftHandOperandRegisterGroupBox.ResumeLayout(false);
            LeftHandOperandRegisterGroupBox.PerformLayout();
            RightHandOperandRegisterGroupBox.ResumeLayout(false);
            RightHandOperandRegisterGroupBox.PerformLayout();
            RightHandOperandValueGroupBox.ResumeLayout(false);
            RightHandOperandValueGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox ArithmeticOperationTypesGroupBox;
        private System.Windows.Forms.GroupBox ArithmeticRegisterGroupBox;
        private System.Windows.Forms.Label ArithmeticRegisterLabel;
        private System.Windows.Forms.ComboBox ArithmeticRegisterComboBox;
        private System.Windows.Forms.GroupBox ArithmeticOperationWidthGroupBox;
        private System.Windows.Forms.RadioButton EightBitRadioButton;
        private System.Windows.Forms.RadioButton SixtyFourBitRadioButton;
        private System.Windows.Forms.RadioButton SixteenBitRadioButton;
        private System.Windows.Forms.RadioButton ThirtyTwoBitRadioButton;
        private System.Windows.Forms.RadioButton ValueArithmeticButton;
        private System.Windows.Forms.RadioButton RegisterArithmeticButton;
        private System.Windows.Forms.GroupBox ArithmeticTypesGroupBox;

        private System.Windows.Forms.RadioButton OperationAdditionRadioButton;
        private System.Windows.Forms.RadioButton OperationSubtractionRadioButton;
        private System.Windows.Forms.RadioButton OperationMultiplicationRadioButton;
        private System.Windows.Forms.RadioButton OperationLeftShiftRadioButton;
        private System.Windows.Forms.RadioButton OperationrRightShiftRadioButton;
        private System.Windows.Forms.RadioButton OperationLogicalAndRadioButton;
        private System.Windows.Forms.RadioButton OperationLogicalOrRadioButton;
        private System.Windows.Forms.RadioButton OperationNoneMoveRadioButton;
        private System.Windows.Forms.RadioButton OperationLogicalXorRadioButton;
        private System.Windows.Forms.RadioButton OperationLogicalNotRadioButton;
        private System.Windows.Forms.GroupBox LeftHandOperandRegisterGroupBox;
        private System.Windows.Forms.Label LeftHandOperandRegisterLabel;
        private System.Windows.Forms.ComboBox LeftHandOperandRegisterComboBox;
        private System.Windows.Forms.GroupBox RightHandOperandRegisterGroupBox;
        private System.Windows.Forms.Label RightHandOperandRegisterLabel;
        private System.Windows.Forms.ComboBox RightHandOperandRegisterComboBox;
        private System.Windows.Forms.GroupBox RightHandOperandValueGroupBox;
        private FormEntity.TextBoxEx ValueTextBox;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label ExampleLabel;
        private System.Windows.Forms.Label TemplateLabel;
    }
}