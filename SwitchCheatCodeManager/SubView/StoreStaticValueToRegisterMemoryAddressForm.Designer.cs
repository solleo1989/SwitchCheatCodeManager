using System.Windows.Forms;

namespace SwitchCheatCodeManager.SubView
{
    partial class StoreStaticValueToRegisterMemoryAddressForm
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
            AddressSizeGroupBox = new GroupBox();
            SixtyFourBitRadioButton = new RadioButton();
            ThirtyTwoBitRadioButton = new RadioButton();
            SixteenBitRadioButton = new RadioButton();
            EightBitRadioButton = new RadioButton();
            BaseMemoryRegisterLabel = new Label();
            BaseMemoryRegisterComboBox = new ComboBox();
            BaseMemoryRegisterGroupBox = new GroupBox();
            IncrementalRadioButton = new RadioButton();
            NotIncrementalRadioButton = new RadioButton();
            OffsetRegisterEnableFlagGroupBox = new GroupBox();
            AddToAddressRadioButton = new RadioButton();
            NotAddToAddressRadioButton = new RadioButton();
            OffsetRegisterComboBox = new ComboBox();
            OffsetRegisterLabel = new Label();
            MemoryOffsetGroupBox = new GroupBox();
            ValueWriteToMemoryTextBox = new TextBox();
            ValueWriteToMemoryLabel = new Label();
            IncrementalRegisterFlagGroupBox = new GroupBox();
            OffsetRegisterGroupBox = new GroupBox();
            ExampleLabel = new Label();
            TemplateLabel = new Label();
            AddressSizeGroupBox.SuspendLayout();
            BaseMemoryRegisterGroupBox.SuspendLayout();
            OffsetRegisterEnableFlagGroupBox.SuspendLayout();
            MemoryOffsetGroupBox.SuspendLayout();
            IncrementalRegisterFlagGroupBox.SuspendLayout();
            OffsetRegisterGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // AddressSizeGroupBox
            // 
            AddressSizeGroupBox.Controls.Add(SixtyFourBitRadioButton);
            AddressSizeGroupBox.Controls.Add(ThirtyTwoBitRadioButton);
            AddressSizeGroupBox.Controls.Add(SixteenBitRadioButton);
            AddressSizeGroupBox.Controls.Add(EightBitRadioButton);
            AddressSizeGroupBox.Location = new System.Drawing.Point(20, 12);
            AddressSizeGroupBox.Name = "AddressSizeGroupBox";
            AddressSizeGroupBox.Size = new System.Drawing.Size(520, 98);
            AddressSizeGroupBox.TabIndex = 0;
            AddressSizeGroupBox.TabStop = false;
            AddressSizeGroupBox.Text = "Memory Width (T):";
            // 
            // SixtyFourBitRadioButton
            // 
            SixtyFourBitRadioButton.AutoSize = true;
            SixtyFourBitRadioButton.Location = new System.Drawing.Point(380, 40);
            SixtyFourBitRadioButton.Name = "SixtyFourBitRadioButton";
            SixtyFourBitRadioButton.Size = new System.Drawing.Size(119, 34);
            SixtyFourBitRadioButton.TabIndex = 3;
            SixtyFourBitRadioButton.TabStop = true;
            SixtyFourBitRadioButton.Text = "64 bit (8)";
            SixtyFourBitRadioButton.UseVisualStyleBackColor = true;
            SixtyFourBitRadioButton.CheckedChanged += BitRadioButton_CheckedChanged;
            // 
            // ThirtyTwoBitRadioButton
            // 
            ThirtyTwoBitRadioButton.AutoSize = true;
            ThirtyTwoBitRadioButton.Location = new System.Drawing.Point(260, 40);
            ThirtyTwoBitRadioButton.Name = "ThirtyTwoBitRadioButton";
            ThirtyTwoBitRadioButton.Size = new System.Drawing.Size(119, 34);
            ThirtyTwoBitRadioButton.TabIndex = 2;
            ThirtyTwoBitRadioButton.TabStop = true;
            ThirtyTwoBitRadioButton.Text = "32 bit (4)";
            ThirtyTwoBitRadioButton.UseVisualStyleBackColor = true;
            ThirtyTwoBitRadioButton.CheckedChanged += BitRadioButton_CheckedChanged;
            // 
            // SixteenBitRadioButton
            // 
            SixteenBitRadioButton.AutoSize = true;
            SixteenBitRadioButton.Location = new System.Drawing.Point(140, 40);
            SixteenBitRadioButton.Name = "SixteenBitRadioButton";
            SixteenBitRadioButton.Size = new System.Drawing.Size(119, 34);
            SixteenBitRadioButton.TabIndex = 1;
            SixteenBitRadioButton.TabStop = true;
            SixteenBitRadioButton.Text = "16 bit (2)";
            SixteenBitRadioButton.UseVisualStyleBackColor = true;
            SixteenBitRadioButton.CheckedChanged += BitRadioButton_CheckedChanged;
            // 
            // EightBitRadioButton
            // 
            EightBitRadioButton.AutoSize = true;
            EightBitRadioButton.Location = new System.Drawing.Point(20, 40);
            EightBitRadioButton.Name = "EightBitRadioButton";
            EightBitRadioButton.Size = new System.Drawing.Size(108, 34);
            EightBitRadioButton.TabIndex = 0;
            EightBitRadioButton.TabStop = true;
            EightBitRadioButton.Text = "8 bit (1)";
            EightBitRadioButton.UseVisualStyleBackColor = true;
            EightBitRadioButton.CheckedChanged += BitRadioButton_CheckedChanged;
            // 
            // ArithmeticRegisterLabel
            // 
            BaseMemoryRegisterLabel.AutoSize = true;
            BaseMemoryRegisterLabel.Location = new System.Drawing.Point(20, 40);
            BaseMemoryRegisterLabel.Name = "ArithmeticRegisterLabel";
            BaseMemoryRegisterLabel.Size = new System.Drawing.Size(123, 30);
            BaseMemoryRegisterLabel.TabIndex = 1;
            BaseMemoryRegisterLabel.Text = "Register (R):";
            // 
            // ArithmeticRegisterComboBox
            // 
            BaseMemoryRegisterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            BaseMemoryRegisterComboBox.FormattingEnabled = true;
            BaseMemoryRegisterComboBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" });
            BaseMemoryRegisterComboBox.Location = new System.Drawing.Point(160, 40);
            BaseMemoryRegisterComboBox.Name = "ArithmeticRegisterComboBox";
            BaseMemoryRegisterComboBox.Size = new System.Drawing.Size(80, 38);
            BaseMemoryRegisterComboBox.TabIndex = 2;
            // 
            // ArithmeticRegisterGroupBox
            // 
            BaseMemoryRegisterGroupBox.Controls.Add(BaseMemoryRegisterLabel);
            BaseMemoryRegisterGroupBox.Controls.Add(BaseMemoryRegisterComboBox);
            BaseMemoryRegisterGroupBox.Location = new System.Drawing.Point(20, 116);
            BaseMemoryRegisterGroupBox.Name = "ArithmeticRegisterGroupBox";
            BaseMemoryRegisterGroupBox.Size = new System.Drawing.Size(520, 98);
            BaseMemoryRegisterGroupBox.TabIndex = 3;
            BaseMemoryRegisterGroupBox.TabStop = false;
            BaseMemoryRegisterGroupBox.Text = "Base Memory Register";
            // 
            // IncrementalRadioButton
            // 
            IncrementalRadioButton.AutoSize = true;
            IncrementalRadioButton.Location = new System.Drawing.Point(260, 40);
            IncrementalRadioButton.Name = "IncrementalRadioButton";
            IncrementalRadioButton.Size = new System.Drawing.Size(225, 34);
            IncrementalRadioButton.TabIndex = 1;
            IncrementalRadioButton.TabStop = true;
            IncrementalRadioButton.Text = "Increment R by T (1)";
            IncrementalRadioButton.UseVisualStyleBackColor = true;
            IncrementalRadioButton.CheckedChanged += IncrementalRegisterRadioButton_CheckedChanged;
            // 
            // NotIncrementalRadioButton
            // 
            NotIncrementalRadioButton.AutoSize = true;
            NotIncrementalRadioButton.Location = new System.Drawing.Point(20, 40);
            NotIncrementalRadioButton.Name = "NotIncrementalRadioButton";
            NotIncrementalRadioButton.Size = new System.Drawing.Size(220, 34);
            NotIncrementalRadioButton.TabIndex = 0;
            NotIncrementalRadioButton.TabStop = true;
            NotIncrementalRadioButton.Text = "Not increment R (0)";
            NotIncrementalRadioButton.UseVisualStyleBackColor = true;
            NotIncrementalRadioButton.CheckedChanged += IncrementalRegisterRadioButton_CheckedChanged;
            // 
            // OffsetRegisterEnableFlagGroupBox
            // 
            OffsetRegisterEnableFlagGroupBox.Controls.Add(AddToAddressRadioButton);
            OffsetRegisterEnableFlagGroupBox.Controls.Add(NotAddToAddressRadioButton);
            OffsetRegisterEnableFlagGroupBox.Location = new System.Drawing.Point(20, 324);
            OffsetRegisterEnableFlagGroupBox.Name = "OffsetRegisterEnableFlagGroupBox";
            OffsetRegisterEnableFlagGroupBox.Size = new System.Drawing.Size(520, 98);
            OffsetRegisterEnableFlagGroupBox.TabIndex = 4;
            OffsetRegisterEnableFlagGroupBox.TabStop = false;
            OffsetRegisterEnableFlagGroupBox.Text = "Offset Register Enable Flag (o):";
            // 
            // AddToAddressRadioButton
            // 
            AddToAddressRadioButton.AutoSize = true;
            AddToAddressRadioButton.Location = new System.Drawing.Point(260, 40);
            AddToAddressRadioButton.Name = "AddToAddressRadioButton";
            AddToAddressRadioButton.Size = new System.Drawing.Size(220, 34);
            AddToAddressRadioButton.TabIndex = 1;
            AddToAddressRadioButton.TabStop = true;
            AddToAddressRadioButton.Text = "Add r to address (1)";
            AddToAddressRadioButton.UseVisualStyleBackColor = true;
            AddToAddressRadioButton.CheckedChanged += OffsetRegisterAddToAddressRadioButton_CheckedChanged;
            // 
            // NotAddToAddressRadioButton
            // 
            NotAddToAddressRadioButton.AutoSize = true;
            NotAddToAddressRadioButton.Location = new System.Drawing.Point(20, 40);
            NotAddToAddressRadioButton.Name = "NotAddToAddressRadioButton";
            NotAddToAddressRadioButton.Size = new System.Drawing.Size(245, 34);
            NotAddToAddressRadioButton.TabIndex = 0;
            NotAddToAddressRadioButton.TabStop = true;
            NotAddToAddressRadioButton.Text = "Not add to address (0)";
            NotAddToAddressRadioButton.UseVisualStyleBackColor = true;
            NotAddToAddressRadioButton.CheckedChanged += OffsetRegisterAddToAddressRadioButton_CheckedChanged;
            // 
            // OffsetRegisterComboBox
            // 
            OffsetRegisterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            OffsetRegisterComboBox.FormattingEnabled = true;
            OffsetRegisterComboBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" });
            OffsetRegisterComboBox.Location = new System.Drawing.Point(160, 40);
            OffsetRegisterComboBox.Name = "OffsetRegisterComboBox";
            OffsetRegisterComboBox.Size = new System.Drawing.Size(80, 38);
            OffsetRegisterComboBox.TabIndex = 3;
            // 
            // OffsetRegisterLabel
            // 
            OffsetRegisterLabel.AutoSize = true;
            OffsetRegisterLabel.Location = new System.Drawing.Point(20, 40);
            OffsetRegisterLabel.Name = "OffsetRegisterLabel";
            OffsetRegisterLabel.Size = new System.Drawing.Size(117, 30);
            OffsetRegisterLabel.TabIndex = 2;
            OffsetRegisterLabel.Text = "Register (r):";
            // 
            // MemoryOffsetGroupBox
            // 
            MemoryOffsetGroupBox.Controls.Add(ValueWriteToMemoryTextBox);
            MemoryOffsetGroupBox.Controls.Add(ValueWriteToMemoryLabel);
            MemoryOffsetGroupBox.Location = new System.Drawing.Point(20, 532);
            MemoryOffsetGroupBox.Name = "MemoryOffsetGroupBox";
            MemoryOffsetGroupBox.Size = new System.Drawing.Size(520, 147);
            MemoryOffsetGroupBox.TabIndex = 5;
            MemoryOffsetGroupBox.TabStop = false;
            MemoryOffsetGroupBox.Text = "Memory Offset";
            // 
            // ValueWriteToMemoryTextBox
            // 
            ValueWriteToMemoryTextBox.Location = new System.Drawing.Point(20, 73);
            ValueWriteToMemoryTextBox.MaxLength = 16;
            ValueWriteToMemoryTextBox.Name = "ValueWriteToMemoryTextBox";
            ValueWriteToMemoryTextBox.PlaceholderText = " e.g. VVVVVVVVVVVVVVVV (0~16 hex-numbers)";
            ValueWriteToMemoryTextBox.Size = new System.Drawing.Size(480, 35);
            ValueWriteToMemoryTextBox.TabIndex = 1;
            ValueWriteToMemoryTextBox.TextChanged += ValueWriteToMemoryTextBox_TextChanged;
            // 
            // ValueWriteToMemoryLabel
            // 
            ValueWriteToMemoryLabel.AutoSize = true;
            ValueWriteToMemoryLabel.Location = new System.Drawing.Point(20, 40);
            ValueWriteToMemoryLabel.Name = "ValueWriteToMemoryLabel";
            ValueWriteToMemoryLabel.Size = new System.Drawing.Size(200, 30);
            ValueWriteToMemoryLabel.TabIndex = 0;
            ValueWriteToMemoryLabel.Text = "Value to write to (V):";
            // 
            // IncrementalRegisterFlagGroupBox
            // 
            IncrementalRegisterFlagGroupBox.Controls.Add(NotIncrementalRadioButton);
            IncrementalRegisterFlagGroupBox.Controls.Add(IncrementalRadioButton);
            IncrementalRegisterFlagGroupBox.Location = new System.Drawing.Point(20, 220);
            IncrementalRegisterFlagGroupBox.Name = "IncrementalRegisterFlagGroupBox";
            IncrementalRegisterFlagGroupBox.Size = new System.Drawing.Size(520, 98);
            IncrementalRegisterFlagGroupBox.TabIndex = 6;
            IncrementalRegisterFlagGroupBox.TabStop = false;
            IncrementalRegisterFlagGroupBox.Text = "Increment Register Flag (I):";
            // 
            // OffsetRegisterGroupBox
            // 
            OffsetRegisterGroupBox.Controls.Add(OffsetRegisterLabel);
            OffsetRegisterGroupBox.Controls.Add(OffsetRegisterComboBox);
            OffsetRegisterGroupBox.Location = new System.Drawing.Point(20, 428);
            OffsetRegisterGroupBox.Name = "OffsetRegisterGroupBox";
            OffsetRegisterGroupBox.Size = new System.Drawing.Size(520, 98);
            OffsetRegisterGroupBox.TabIndex = 7;
            OffsetRegisterGroupBox.TabStop = false;
            OffsetRegisterGroupBox.Text = "Offset Register (o is 1)";
            // 
            // ExampleLabel
            // 
            ExampleLabel.AutoSize = true;
            ExampleLabel.Location = new System.Drawing.Point(20, 682);
            ExampleLabel.Name = "ExampleLabel";
            ExampleLabel.Size = new System.Drawing.Size(96, 30);
            ExampleLabel.TabIndex = 8;
            ExampleLabel.Text = "Example:";
            // 
            // TemplateLabel
            // 
            TemplateLabel.AutoSize = true;
            TemplateLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TemplateLabel.Location = new System.Drawing.Point(40, 712);
            TemplateLabel.Name = "TemplateLabel";
            TemplateLabel.Size = new System.Drawing.Size(106, 24);
            TemplateLabel.TabIndex = 9;
            TemplateLabel.Text = "Template";
            // 
            // StoreStaticValueToRegisterMemoryAddressForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(576, 755);
            Controls.Add(TemplateLabel);
            Controls.Add(ExampleLabel);
            Controls.Add(OffsetRegisterGroupBox);
            Controls.Add(IncrementalRegisterFlagGroupBox);
            Controls.Add(MemoryOffsetGroupBox);
            Controls.Add(OffsetRegisterEnableFlagGroupBox);
            Controls.Add(BaseMemoryRegisterGroupBox);
            Controls.Add(AddressSizeGroupBox);
            Name = "StoreStaticValueToRegisterMemoryAddressForm";
            Text = "StoreStaticValueToRegisterMemoryAddressForm";
            AddressSizeGroupBox.ResumeLayout(false);
            AddressSizeGroupBox.PerformLayout();
            BaseMemoryRegisterGroupBox.ResumeLayout(false);
            BaseMemoryRegisterGroupBox.PerformLayout();
            OffsetRegisterEnableFlagGroupBox.ResumeLayout(false);
            OffsetRegisterEnableFlagGroupBox.PerformLayout();
            MemoryOffsetGroupBox.ResumeLayout(false);
            MemoryOffsetGroupBox.PerformLayout();
            IncrementalRegisterFlagGroupBox.ResumeLayout(false);
            IncrementalRegisterFlagGroupBox.PerformLayout();
            OffsetRegisterGroupBox.ResumeLayout(false);
            OffsetRegisterGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox AddressSizeGroupBox;
        private System.Windows.Forms.RadioButton EightBitRadioButton;
        private System.Windows.Forms.RadioButton SixteenBitRadioButton;
        private System.Windows.Forms.RadioButton ThirtyTwoBitRadioButton;
        private System.Windows.Forms.RadioButton SixtyFourBitRadioButton;

        private System.Windows.Forms.GroupBox BaseMemoryRegisterGroupBox;
        private System.Windows.Forms.Label BaseMemoryRegisterLabel;
        private System.Windows.Forms.ComboBox BaseMemoryRegisterComboBox;

        private System.Windows.Forms.GroupBox IncrementalRegisterFlagGroupBox;
        private System.Windows.Forms.RadioButton IncrementalRadioButton;
        private System.Windows.Forms.RadioButton NotIncrementalRadioButton;

        private System.Windows.Forms.GroupBox OffsetRegisterEnableFlagGroupBox;
        private System.Windows.Forms.RadioButton AddToAddressRadioButton;
        private System.Windows.Forms.RadioButton NotAddToAddressRadioButton;

        private System.Windows.Forms.GroupBox OffsetRegisterGroupBox;
        private System.Windows.Forms.ComboBox OffsetRegisterComboBox;
        private System.Windows.Forms.Label OffsetRegisterLabel;

        private System.Windows.Forms.GroupBox MemoryOffsetGroupBox;
        private System.Windows.Forms.Label ValueWriteToMemoryLabel;
        private System.Windows.Forms.TextBox ValueWriteToMemoryTextBox;
        private System.Windows.Forms.Label ExampleLabel;
        private System.Windows.Forms.Label TemplateLabel;
    }
}