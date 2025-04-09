namespace SwitchCheatCodeManager.SubView
{
    partial class StoreRegisterToMemoryAddressForm
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
            OffsetTypesGroupBox = new System.Windows.Forms.GroupBox();
            MemoryRegionRelativeAddressOffsetRegisteradioButton = new System.Windows.Forms.RadioButton();
            MemoryRegionRelativeAddressRadioButton = new System.Windows.Forms.RadioButton();
            MemoryRegionBaseRegisterRadioButton = new System.Windows.Forms.RadioButton();
            FixedOffsetRadioButton = new System.Windows.Forms.RadioButton();
            OffsetRegisterRadioButton = new System.Windows.Forms.RadioButton();
            NoOffsetRadioButton = new System.Windows.Forms.RadioButton();
            AddressSizeGroupBox = new System.Windows.Forms.GroupBox();
            EightBitRadioButton = new System.Windows.Forms.RadioButton();
            SixtyFourBitRadioButton = new System.Windows.Forms.RadioButton();
            SixteenBitRadioButton = new System.Windows.Forms.RadioButton();
            ThirtyTwoBitRadioButton = new System.Windows.Forms.RadioButton();
            BaseMemoryRegisterGroupBox = new System.Windows.Forms.GroupBox();
            BaseMemoryRegisterComboBox = new System.Windows.Forms.ComboBox();
            WriteToRegisterGroupBox = new System.Windows.Forms.GroupBox();
            WriteToRegisterComboBox = new System.Windows.Forms.ComboBox();
            IncrementalRegisterFlagGroupBox = new System.Windows.Forms.GroupBox();
            NotIncrementalRadioButton = new System.Windows.Forms.RadioButton();
            IncrementalRadioButton = new System.Windows.Forms.RadioButton();
            MemoryRegionGroupBox = new System.Windows.Forms.GroupBox();
            AslrRadioButton = new System.Windows.Forms.RadioButton();
            AliasRadioButton = new System.Windows.Forms.RadioButton();
            NsoRadioButton = new System.Windows.Forms.RadioButton();
            HeapRadioButton = new System.Windows.Forms.RadioButton();
            OffsetRegisterGroupBox = new System.Windows.Forms.GroupBox();
            OffsetRegisterComboBox = new System.Windows.Forms.ComboBox();
            OffsetValueGroupBox = new System.Windows.Forms.GroupBox();
            OffsetValueTextBox = new System.Windows.Forms.TextBox();
            ExampleLabel = new System.Windows.Forms.Label();
            TemplateLabel = new System.Windows.Forms.Label();
            OffsetTypesGroupBox.SuspendLayout();
            AddressSizeGroupBox.SuspendLayout();
            BaseMemoryRegisterGroupBox.SuspendLayout();
            WriteToRegisterGroupBox.SuspendLayout();
            IncrementalRegisterFlagGroupBox.SuspendLayout();
            MemoryRegionGroupBox.SuspendLayout();
            OffsetRegisterGroupBox.SuspendLayout();
            OffsetValueGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // OffsetTypesGroupBox
            // 
            OffsetTypesGroupBox.Controls.Add(MemoryRegionRelativeAddressOffsetRegisteradioButton);
            OffsetTypesGroupBox.Controls.Add(MemoryRegionRelativeAddressRadioButton);
            OffsetTypesGroupBox.Controls.Add(MemoryRegionBaseRegisterRadioButton);
            OffsetTypesGroupBox.Controls.Add(FixedOffsetRadioButton);
            OffsetTypesGroupBox.Controls.Add(OffsetRegisterRadioButton);
            OffsetTypesGroupBox.Controls.Add(NoOffsetRadioButton);
            OffsetTypesGroupBox.Location = new System.Drawing.Point(20, 311);
            OffsetTypesGroupBox.Name = "OffsetTypesGroupBox";
            OffsetTypesGroupBox.Size = new System.Drawing.Size(520, 300);
            OffsetTypesGroupBox.TabIndex = 0;
            OffsetTypesGroupBox.TabStop = false;
            OffsetTypesGroupBox.Text = "Offset Types:";
            // 
            // MemoryRegionRelativeAddressOffsetRegisteradioButton
            // 
            MemoryRegionRelativeAddressOffsetRegisteradioButton.AutoSize = true;
            MemoryRegionRelativeAddressOffsetRegisteradioButton.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            MemoryRegionRelativeAddressOffsetRegisteradioButton.Location = new System.Drawing.Point(20, 226);
            MemoryRegionRelativeAddressOffsetRegisteradioButton.Name = "MemoryRegionRelativeAddressOffsetRegisteradioButton";
            MemoryRegionRelativeAddressOffsetRegisteradioButton.Size = new System.Drawing.Size(349, 60);
            MemoryRegionRelativeAddressOffsetRegisteradioButton.TabIndex = 5;
            MemoryRegionRelativeAddressOffsetRegisteradioButton.TabStop = true;
            MemoryRegionRelativeAddressOffsetRegisteradioButton.Text = "Memory Region + Relative Address \r\n+ Offset Register (5)";
            MemoryRegionRelativeAddressOffsetRegisteradioButton.UseVisualStyleBackColor = true;
            MemoryRegionRelativeAddressOffsetRegisteradioButton.CheckedChanged += OffsetTypesRadioButton_CheckedChanged;
            // 
            // MemoryRegionRelativeAddressRadioButton
            // 
            MemoryRegionRelativeAddressRadioButton.AutoSize = true;
            MemoryRegionRelativeAddressRadioButton.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            MemoryRegionRelativeAddressRadioButton.Location = new System.Drawing.Point(20, 160);
            MemoryRegionRelativeAddressRadioButton.Name = "MemoryRegionRelativeAddressRadioButton";
            MemoryRegionRelativeAddressRadioButton.Size = new System.Drawing.Size(349, 60);
            MemoryRegionRelativeAddressRadioButton.TabIndex = 4;
            MemoryRegionRelativeAddressRadioButton.TabStop = true;
            MemoryRegionRelativeAddressRadioButton.Text = "Memory Region + Relative Address \r\n(ignore address register) (4)";
            MemoryRegionRelativeAddressRadioButton.UseVisualStyleBackColor = true;
            MemoryRegionRelativeAddressRadioButton.CheckedChanged += OffsetTypesRadioButton_CheckedChanged;
            // 
            // MemoryRegionBaseRegisterRadioButton
            // 
            MemoryRegionBaseRegisterRadioButton.AutoSize = true;
            MemoryRegionBaseRegisterRadioButton.Location = new System.Drawing.Point(20, 120);
            MemoryRegionBaseRegisterRadioButton.Name = "MemoryRegionBaseRegisterRadioButton";
            MemoryRegionBaseRegisterRadioButton.Size = new System.Drawing.Size(363, 34);
            MemoryRegionBaseRegisterRadioButton.TabIndex = 3;
            MemoryRegionBaseRegisterRadioButton.TabStop = true;
            MemoryRegionBaseRegisterRadioButton.Text = "Memory Region + Base Register (3)";
            MemoryRegionBaseRegisterRadioButton.UseVisualStyleBackColor = true;
            MemoryRegionBaseRegisterRadioButton.CheckedChanged += OffsetTypesRadioButton_CheckedChanged;
            // 
            // FixedOffsetRadioButton
            // 
            FixedOffsetRadioButton.AutoSize = true;
            FixedOffsetRadioButton.Location = new System.Drawing.Point(20, 80);
            FixedOffsetRadioButton.Name = "FixedOffsetRadioButton";
            FixedOffsetRadioButton.Size = new System.Drawing.Size(218, 34);
            FixedOffsetRadioButton.TabIndex = 2;
            FixedOffsetRadioButton.TabStop = true;
            FixedOffsetRadioButton.Text = "Use Fixed Offset (2)";
            FixedOffsetRadioButton.UseVisualStyleBackColor = true;
            FixedOffsetRadioButton.CheckedChanged += OffsetTypesRadioButton_CheckedChanged;
            // 
            // OffsetRegisterRadioButton
            // 
            OffsetRegisterRadioButton.AutoSize = true;
            OffsetRegisterRadioButton.Location = new System.Drawing.Point(260, 40);
            OffsetRegisterRadioButton.Name = "OffsetRegisterRadioButton";
            OffsetRegisterRadioButton.Size = new System.Drawing.Size(244, 34);
            OffsetRegisterRadioButton.TabIndex = 1;
            OffsetRegisterRadioButton.TabStop = true;
            OffsetRegisterRadioButton.Text = "Use Offset Register (1)";
            OffsetRegisterRadioButton.UseVisualStyleBackColor = true;
            OffsetRegisterRadioButton.CheckedChanged += OffsetTypesRadioButton_CheckedChanged;
            // 
            // NoOffsetRadioButton
            // 
            NoOffsetRadioButton.AutoSize = true;
            NoOffsetRadioButton.Location = new System.Drawing.Point(20, 40);
            NoOffsetRadioButton.Name = "NoOffsetRadioButton";
            NoOffsetRadioButton.Size = new System.Drawing.Size(158, 34);
            NoOffsetRadioButton.TabIndex = 0;
            NoOffsetRadioButton.TabStop = true;
            NoOffsetRadioButton.Text = "No Offset (0)";
            NoOffsetRadioButton.UseVisualStyleBackColor = true;
            NoOffsetRadioButton.CheckedChanged += OffsetTypesRadioButton_CheckedChanged;
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
            // 
            // ArithmeticRegisterGroupBox
            // 
            BaseMemoryRegisterGroupBox.Controls.Add(BaseMemoryRegisterComboBox);
            BaseMemoryRegisterGroupBox.Location = new System.Drawing.Point(281, 116);
            BaseMemoryRegisterGroupBox.Name = "ArithmeticRegisterGroupBox";
            BaseMemoryRegisterGroupBox.Size = new System.Drawing.Size(259, 85);
            BaseMemoryRegisterGroupBox.TabIndex = 16;
            BaseMemoryRegisterGroupBox.TabStop = false;
            BaseMemoryRegisterGroupBox.Text = "Register to use as base address (R):";
            // 
            // ArithmeticRegisterComboBox
            // 
            BaseMemoryRegisterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            BaseMemoryRegisterComboBox.FormattingEnabled = true;
            BaseMemoryRegisterComboBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" });
            BaseMemoryRegisterComboBox.Location = new System.Drawing.Point(158, 34);
            BaseMemoryRegisterComboBox.Name = "ArithmeticRegisterComboBox";
            BaseMemoryRegisterComboBox.Size = new System.Drawing.Size(80, 38);
            BaseMemoryRegisterComboBox.TabIndex = 2;
            // 
            // WriteToRegisterGroupBox
            // 
            WriteToRegisterGroupBox.Controls.Add(WriteToRegisterComboBox);
            WriteToRegisterGroupBox.Location = new System.Drawing.Point(20, 116);
            WriteToRegisterGroupBox.Name = "WriteToRegisterGroupBox";
            WriteToRegisterGroupBox.Size = new System.Drawing.Size(259, 85);
            WriteToRegisterGroupBox.TabIndex = 17;
            WriteToRegisterGroupBox.TabStop = false;
            WriteToRegisterGroupBox.Text = "Register to write to memory (S):";
            // 
            // WriteToRegisterComboBox
            // 
            WriteToRegisterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            WriteToRegisterComboBox.FormattingEnabled = true;
            WriteToRegisterComboBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" });
            WriteToRegisterComboBox.Location = new System.Drawing.Point(158, 34);
            WriteToRegisterComboBox.Name = "WriteToRegisterComboBox";
            WriteToRegisterComboBox.Size = new System.Drawing.Size(80, 38);
            WriteToRegisterComboBox.TabIndex = 1;
            // 
            // IncrementalRegisterFlagGroupBox
            // 
            IncrementalRegisterFlagGroupBox.Controls.Add(NotIncrementalRadioButton);
            IncrementalRegisterFlagGroupBox.Controls.Add(IncrementalRadioButton);
            IncrementalRegisterFlagGroupBox.Location = new System.Drawing.Point(20, 207);
            IncrementalRegisterFlagGroupBox.Name = "IncrementalRegisterFlagGroupBox";
            IncrementalRegisterFlagGroupBox.Size = new System.Drawing.Size(520, 98);
            IncrementalRegisterFlagGroupBox.TabIndex = 18;
            IncrementalRegisterFlagGroupBox.TabStop = false;
            IncrementalRegisterFlagGroupBox.Text = "Increment Register Flag (I):";
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
            // 
            // MemoryRegionGroupBox
            // 
            MemoryRegionGroupBox.Controls.Add(AslrRadioButton);
            MemoryRegionGroupBox.Controls.Add(AliasRadioButton);
            MemoryRegionGroupBox.Controls.Add(NsoRadioButton);
            MemoryRegionGroupBox.Controls.Add(HeapRadioButton);
            MemoryRegionGroupBox.Location = new System.Drawing.Point(20, 617);
            MemoryRegionGroupBox.Name = "MemoryRegionGroupBox";
            MemoryRegionGroupBox.Size = new System.Drawing.Size(520, 130);
            MemoryRegionGroupBox.TabIndex = 19;
            MemoryRegionGroupBox.TabStop = false;
            MemoryRegionGroupBox.Text = "Memory Region (x):";
            // 
            // AslrRadioButton
            // 
            AslrRadioButton.AutoSize = true;
            AslrRadioButton.Location = new System.Drawing.Point(260, 80);
            AslrRadioButton.Name = "AslrRadioButton";
            AslrRadioButton.Size = new System.Drawing.Size(154, 34);
            AslrRadioButton.TabIndex = 11;
            AslrRadioButton.TabStop = true;
            AslrRadioButton.Text = "Write to Aslr";
            AslrRadioButton.UseVisualStyleBackColor = true;
            // 
            // AliasRadioButton
            // 
            AliasRadioButton.AutoSize = true;
            AliasRadioButton.Location = new System.Drawing.Point(20, 80);
            AliasRadioButton.Name = "AliasRadioButton";
            AliasRadioButton.Size = new System.Drawing.Size(163, 34);
            AliasRadioButton.TabIndex = 10;
            AliasRadioButton.TabStop = true;
            AliasRadioButton.Text = "Write to Alias";
            AliasRadioButton.UseVisualStyleBackColor = true;
            // 
            // NsoRadioButton
            // 
            NsoRadioButton.AutoSize = true;
            NsoRadioButton.Checked = true;
            NsoRadioButton.Location = new System.Drawing.Point(20, 40);
            NsoRadioButton.Name = "NsoRadioButton";
            NsoRadioButton.Size = new System.Drawing.Size(215, 34);
            NsoRadioButton.TabIndex = 8;
            NsoRadioButton.TabStop = true;
            NsoRadioButton.Text = "Write to Main NSO";
            NsoRadioButton.UseVisualStyleBackColor = true;
            // 
            // HeapRadioButton
            // 
            HeapRadioButton.AutoSize = true;
            HeapRadioButton.Location = new System.Drawing.Point(260, 40);
            HeapRadioButton.Name = "HeapRadioButton";
            HeapRadioButton.Size = new System.Drawing.Size(168, 34);
            HeapRadioButton.TabIndex = 9;
            HeapRadioButton.TabStop = true;
            HeapRadioButton.Text = "Write to Heap";
            HeapRadioButton.UseVisualStyleBackColor = true;
            // 
            // OffsetRegisterGroupBox
            // 
            OffsetRegisterGroupBox.Controls.Add(OffsetRegisterComboBox);
            OffsetRegisterGroupBox.Location = new System.Drawing.Point(20, 753);
            OffsetRegisterGroupBox.Name = "OffsetRegisterGroupBox";
            OffsetRegisterGroupBox.Size = new System.Drawing.Size(193, 85);
            OffsetRegisterGroupBox.TabIndex = 20;
            OffsetRegisterGroupBox.TabStop = false;
            OffsetRegisterGroupBox.Text = "Offset Register (x):";
            // 
            // OffsetRegisterComboBox
            // 
            OffsetRegisterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            OffsetRegisterComboBox.FormattingEnabled = true;
            OffsetRegisterComboBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" });
            OffsetRegisterComboBox.Location = new System.Drawing.Point(100, 40);
            OffsetRegisterComboBox.Name = "OffsetRegisterComboBox";
            OffsetRegisterComboBox.Size = new System.Drawing.Size(80, 38);
            OffsetRegisterComboBox.TabIndex = 0;
            // 
            // OffsetValueGroupBox
            // 
            OffsetValueGroupBox.Controls.Add(OffsetValueTextBox);
            OffsetValueGroupBox.Location = new System.Drawing.Point(219, 753);
            OffsetValueGroupBox.Name = "OffsetValueGroupBox";
            OffsetValueGroupBox.Size = new System.Drawing.Size(321, 85);
            OffsetValueGroupBox.TabIndex = 21;
            OffsetValueGroupBox.TabStop = false;
            OffsetValueGroupBox.Text = "Relative Address Offset Value (a):";
            // 
            // OffsetValueTextBox
            // 
            OffsetValueTextBox.Location = new System.Drawing.Point(63, 34);
            OffsetValueTextBox.MaxLength = 9;
            OffsetValueTextBox.Name = "OffsetValueTextBox";
            OffsetValueTextBox.PlaceholderText = " e.g. aaaaaaaaa (0~9 hex-numbers)";
            OffsetValueTextBox.Size = new System.Drawing.Size(237, 35);
            OffsetValueTextBox.TabIndex = 0;
            OffsetValueTextBox.TextChanged += OffsetValueTextBox_TextChanged;
            // 
            // ExampleLabel
            // 
            ExampleLabel.AutoSize = true;
            ExampleLabel.Location = new System.Drawing.Point(20, 841);
            ExampleLabel.Name = "ExampleLabel";
            ExampleLabel.Size = new System.Drawing.Size(96, 30);
            ExampleLabel.TabIndex = 22;
            ExampleLabel.Text = "Example:";
            // 
            // TemplateLabel
            // 
            TemplateLabel.AutoSize = true;
            TemplateLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TemplateLabel.Location = new System.Drawing.Point(40, 871);
            TemplateLabel.Name = "TemplateLabel";
            TemplateLabel.Size = new System.Drawing.Size(166, 24);
            TemplateLabel.TabIndex = 23;
            TemplateLabel.Text = "TemplateLabel";
            // 
            // StoreRegisterToMemoryAddressForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(576, 994);
            Controls.Add(TemplateLabel);
            Controls.Add(ExampleLabel);
            Controls.Add(OffsetValueGroupBox);
            Controls.Add(OffsetRegisterGroupBox);
            Controls.Add(MemoryRegionGroupBox);
            Controls.Add(IncrementalRegisterFlagGroupBox);
            Controls.Add(WriteToRegisterGroupBox);
            Controls.Add(BaseMemoryRegisterGroupBox);
            Controls.Add(AddressSizeGroupBox);
            Controls.Add(OffsetTypesGroupBox);
            Name = "StoreRegisterToMemoryAddressForm";
            Text = "StoreRegisterValueForm";
            OffsetTypesGroupBox.ResumeLayout(false);
            OffsetTypesGroupBox.PerformLayout();
            AddressSizeGroupBox.ResumeLayout(false);
            AddressSizeGroupBox.PerformLayout();
            BaseMemoryRegisterGroupBox.ResumeLayout(false);
            WriteToRegisterGroupBox.ResumeLayout(false);
            IncrementalRegisterFlagGroupBox.ResumeLayout(false);
            IncrementalRegisterFlagGroupBox.PerformLayout();
            MemoryRegionGroupBox.ResumeLayout(false);
            MemoryRegionGroupBox.PerformLayout();
            OffsetRegisterGroupBox.ResumeLayout(false);
            OffsetValueGroupBox.ResumeLayout(false);
            OffsetValueGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private System.Windows.Forms.GroupBox AddressSizeGroupBox;
        private System.Windows.Forms.RadioButton EightBitRadioButton;
        private System.Windows.Forms.RadioButton SixteenBitRadioButton;
        private System.Windows.Forms.RadioButton ThirtyTwoBitRadioButton;
        private System.Windows.Forms.RadioButton SixtyFourBitRadioButton;

        private System.Windows.Forms.GroupBox WriteToRegisterGroupBox;
        private System.Windows.Forms.ComboBox WriteToRegisterComboBox;

        private System.Windows.Forms.GroupBox BaseMemoryRegisterGroupBox;
        private System.Windows.Forms.ComboBox BaseMemoryRegisterComboBox;

        private System.Windows.Forms.GroupBox IncrementalRegisterFlagGroupBox;
        private System.Windows.Forms.RadioButton NotIncrementalRadioButton;
        private System.Windows.Forms.RadioButton IncrementalRadioButton;

        private System.Windows.Forms.GroupBox OffsetTypesGroupBox;
        private System.Windows.Forms.RadioButton NoOffsetRadioButton;
        private System.Windows.Forms.RadioButton OffsetRegisterRadioButton;
        private System.Windows.Forms.RadioButton FixedOffsetRadioButton;
        private System.Windows.Forms.RadioButton MemoryRegionBaseRegisterRadioButton;
        private System.Windows.Forms.RadioButton MemoryRegionRelativeAddressRadioButton;
        private System.Windows.Forms.RadioButton MemoryRegionRelativeAddressOffsetRegisteradioButton;
        private System.Windows.Forms.GroupBox MemoryRegionGroupBox;
        private System.Windows.Forms.RadioButton AslrRadioButton;
        private System.Windows.Forms.RadioButton AliasRadioButton;
        private System.Windows.Forms.RadioButton NsoRadioButton;
        private System.Windows.Forms.RadioButton HeapRadioButton;

        private System.Windows.Forms.GroupBox OffsetRegisterGroupBox;

        private System.Windows.Forms.GroupBox OffsetValueGroupBox;
        private System.Windows.Forms.ComboBox OffsetRegisterComboBox;
        private System.Windows.Forms.TextBox OffsetValueTextBox;
        private System.Windows.Forms.Label ExampleLabel;
        private System.Windows.Forms.Label TemplateLabel;
    }
}