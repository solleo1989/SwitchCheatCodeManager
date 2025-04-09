namespace SwitchCheatCodeManager.SubView
{
    partial class ConditionalForm
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
            ConditionalGroupBox = new System.Windows.Forms.GroupBox();
            ValueCompareTextBox = new System.Windows.Forms.TextBox();
            ValueCompareLabel = new System.Windows.Forms.Label();
            RelevantAddressTextBox = new System.Windows.Forms.TextBox();
            RelevantAddressLabel = new System.Windows.Forms.Label();
            ComparisonGroupBox = new System.Windows.Forms.GroupBox();
            LessThanOrEqualToRadioButton = new System.Windows.Forms.RadioButton();
            LessThanRadioButton = new System.Windows.Forms.RadioButton();
            NotEqualRadioButton = new System.Windows.Forms.RadioButton();
            GreaterThanOrEqualToRadioButton = new System.Windows.Forms.RadioButton();
            GreaterThanRadioButton = new System.Windows.Forms.RadioButton();
            EqualRadioButton = new System.Windows.Forms.RadioButton();
            AddressSizeGroupBox = new System.Windows.Forms.GroupBox();
            SixtyFourBitRadioButton = new System.Windows.Forms.RadioButton();
            ThirtyTwoBitRadioButton = new System.Windows.Forms.RadioButton();
            SixteenBitRadioButton = new System.Windows.Forms.RadioButton();
            EightBitRadioButton = new System.Windows.Forms.RadioButton();
            CompareHeapRadioButton = new System.Windows.Forms.RadioButton();
            CompareNsoRadioButton = new System.Windows.Forms.RadioButton();
            MemoryRegionGroupBox = new System.Windows.Forms.GroupBox();
            CompareAslrRadioButton = new System.Windows.Forms.RadioButton();
            CompareAliasRadioButton = new System.Windows.Forms.RadioButton();
            ExampleLabel = new System.Windows.Forms.Label();
            TemplateLabel = new System.Windows.Forms.Label();
            ConditionalGroupBox.SuspendLayout();
            ComparisonGroupBox.SuspendLayout();
            AddressSizeGroupBox.SuspendLayout();
            MemoryRegionGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ConditionalGroupBox
            // 
            ConditionalGroupBox.Controls.Add(ValueCompareTextBox);
            ConditionalGroupBox.Controls.Add(ValueCompareLabel);
            ConditionalGroupBox.Controls.Add(RelevantAddressTextBox);
            ConditionalGroupBox.Controls.Add(RelevantAddressLabel);
            ConditionalGroupBox.Location = new System.Drawing.Point(20, 457);
            ConditionalGroupBox.Name = "ConditionalGroupBox";
            ConditionalGroupBox.Size = new System.Drawing.Size(520, 201);
            ConditionalGroupBox.TabIndex = 0;
            ConditionalGroupBox.TabStop = false;
            ConditionalGroupBox.Text = "Memory Offset";
            // 
            // ValueCompareTextBox
            // 
            ValueCompareTextBox.Location = new System.Drawing.Point(20, 135);
            ValueCompareTextBox.Name = "ValueCompareTextBox";
            ValueCompareTextBox.Size = new System.Drawing.Size(450, 35);
            ValueCompareTextBox.TabIndex = 5;
            ValueCompareTextBox.TextChanged += ValueTextBox_TextChanged;
            // 
            // ValueCompareLabel
            // 
            ValueCompareLabel.AutoSize = true;
            ValueCompareLabel.Location = new System.Drawing.Point(20, 102);
            ValueCompareLabel.Name = "ValueCompareLabel";
            ValueCompareLabel.Size = new System.Drawing.Size(284, 30);
            ValueCompareLabel.TabIndex = 4;
            ValueCompareLabel.Text = "Value to compare against (V):";
            // 
            // RelevantAddressTextBox
            // 
            RelevantAddressTextBox.Location = new System.Drawing.Point(20, 64);
            RelevantAddressTextBox.MaxLength = 10;
            RelevantAddressTextBox.Name = "RelevantAddressTextBox";
            RelevantAddressTextBox.PlaceholderText = " e.g. ABCDEF0123 (0~10 hex-numbers)";
            RelevantAddressTextBox.Size = new System.Drawing.Size(450, 35);
            RelevantAddressTextBox.TabIndex = 3;
            RelevantAddressTextBox.TextChanged += RelevantAddressTextBox_TextChanged;
            // 
            // RelevantAddressLabel
            // 
            RelevantAddressLabel.AutoSize = true;
            RelevantAddressLabel.Location = new System.Drawing.Point(20, 31);
            RelevantAddressLabel.Name = "RelevantAddressLabel";
            RelevantAddressLabel.Size = new System.Drawing.Size(278, 30);
            RelevantAddressLabel.TabIndex = 2;
            RelevantAddressLabel.Text = "Address relevant to NSO (A):";
            // 
            // ComparisonGroupBox
            // 
            ComparisonGroupBox.Controls.Add(LessThanOrEqualToRadioButton);
            ComparisonGroupBox.Controls.Add(LessThanRadioButton);
            ComparisonGroupBox.Controls.Add(NotEqualRadioButton);
            ComparisonGroupBox.Controls.Add(GreaterThanOrEqualToRadioButton);
            ComparisonGroupBox.Controls.Add(GreaterThanRadioButton);
            ComparisonGroupBox.Controls.Add(EqualRadioButton);
            ComparisonGroupBox.Location = new System.Drawing.Point(21, 252);
            ComparisonGroupBox.Name = "ComparisonGroupBox";
            ComparisonGroupBox.Size = new System.Drawing.Size(519, 199);
            ComparisonGroupBox.TabIndex = 7;
            ComparisonGroupBox.TabStop = false;
            ComparisonGroupBox.Text = "Compare Comparison (C):";
            // 
            // LessThanOrEqualToRadioButton
            // 
            LessThanOrEqualToRadioButton.AutoSize = true;
            LessThanOrEqualToRadioButton.Location = new System.Drawing.Point(260, 120);
            LessThanOrEqualToRadioButton.Name = "LessThanOrEqualToRadioButton";
            LessThanOrEqualToRadioButton.Size = new System.Drawing.Size(177, 64);
            LessThanOrEqualToRadioButton.TabIndex = 8;
            LessThanOrEqualToRadioButton.TabStop = true;
            LessThanOrEqualToRadioButton.Text = "(<=) Less than \r\nor Equal to";
            LessThanOrEqualToRadioButton.UseVisualStyleBackColor = true;
            // 
            // LessThanRadioButton
            // 
            LessThanRadioButton.AutoSize = true;
            LessThanRadioButton.Location = new System.Drawing.Point(260, 80);
            LessThanRadioButton.Name = "LessThanRadioButton";
            LessThanRadioButton.Size = new System.Drawing.Size(157, 34);
            LessThanRadioButton.TabIndex = 4;
            LessThanRadioButton.TabStop = true;
            LessThanRadioButton.Text = "(<) Less than";
            LessThanRadioButton.UseVisualStyleBackColor = true;
            // 
            // NotEqualRadioButton
            // 
            NotEqualRadioButton.AutoSize = true;
            NotEqualRadioButton.Location = new System.Drawing.Point(260, 40);
            NotEqualRadioButton.Name = "NotEqualRadioButton";
            NotEqualRadioButton.Size = new System.Drawing.Size(168, 34);
            NotEqualRadioButton.TabIndex = 3;
            NotEqualRadioButton.TabStop = true;
            NotEqualRadioButton.Text = "(!=) Not equal";
            NotEqualRadioButton.UseVisualStyleBackColor = true;
            // 
            // GreaterThanOrEqualToRadioButton
            // 
            GreaterThanOrEqualToRadioButton.AutoSize = true;
            GreaterThanOrEqualToRadioButton.Location = new System.Drawing.Point(20, 120);
            GreaterThanOrEqualToRadioButton.Name = "GreaterThanOrEqualToRadioButton";
            GreaterThanOrEqualToRadioButton.Size = new System.Drawing.Size(206, 64);
            GreaterThanOrEqualToRadioButton.TabIndex = 2;
            GreaterThanOrEqualToRadioButton.TabStop = true;
            GreaterThanOrEqualToRadioButton.Text = "(>=) Greater than \r\nor Equal to";
            GreaterThanOrEqualToRadioButton.UseVisualStyleBackColor = true;
            // 
            // GreaterThanRadioButton
            // 
            GreaterThanRadioButton.AutoSize = true;
            GreaterThanRadioButton.Location = new System.Drawing.Point(20, 80);
            GreaterThanRadioButton.Name = "GreaterThanRadioButton";
            GreaterThanRadioButton.Size = new System.Drawing.Size(186, 34);
            GreaterThanRadioButton.TabIndex = 1;
            GreaterThanRadioButton.TabStop = true;
            GreaterThanRadioButton.Text = "(>) Greater than";
            GreaterThanRadioButton.UseVisualStyleBackColor = true;
            // 
            // EqualRadioButton
            // 
            EqualRadioButton.AutoSize = true;
            EqualRadioButton.Location = new System.Drawing.Point(20, 40);
            EqualRadioButton.Name = "EqualRadioButton";
            EqualRadioButton.Size = new System.Drawing.Size(135, 34);
            EqualRadioButton.TabIndex = 0;
            EqualRadioButton.TabStop = true;
            EqualRadioButton.Text = "(==) Equal";
            EqualRadioButton.UseVisualStyleBackColor = true;
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
            AddressSizeGroupBox.TabIndex = 6;
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
            // CompareHeapRadioButton
            // 
            CompareHeapRadioButton.AutoSize = true;
            CompareHeapRadioButton.Location = new System.Drawing.Point(260, 40);
            CompareHeapRadioButton.Name = "CompareHeapRadioButton";
            CompareHeapRadioButton.Size = new System.Drawing.Size(168, 34);
            CompareHeapRadioButton.TabIndex = 1;
            CompareHeapRadioButton.TabStop = true;
            CompareHeapRadioButton.Text = "Write to Heap";
            CompareHeapRadioButton.UseVisualStyleBackColor = true;
            CompareHeapRadioButton.CheckedChanged += AddressTypeRadioButton_CheckedChanged;
            // 
            // CompareNsoRadioButton
            // 
            CompareNsoRadioButton.AutoSize = true;
            CompareNsoRadioButton.Location = new System.Drawing.Point(20, 40);
            CompareNsoRadioButton.Name = "CompareNsoRadioButton";
            CompareNsoRadioButton.Size = new System.Drawing.Size(215, 34);
            CompareNsoRadioButton.TabIndex = 0;
            CompareNsoRadioButton.TabStop = true;
            CompareNsoRadioButton.Text = "Write to Main NSO";
            CompareNsoRadioButton.UseVisualStyleBackColor = true;
            CompareNsoRadioButton.CheckedChanged += AddressTypeRadioButton_CheckedChanged;
            // 
            // MemoryRegionGroupBox
            // 
            MemoryRegionGroupBox.Controls.Add(CompareAslrRadioButton);
            MemoryRegionGroupBox.Controls.Add(CompareAliasRadioButton);
            MemoryRegionGroupBox.Controls.Add(CompareNsoRadioButton);
            MemoryRegionGroupBox.Controls.Add(CompareHeapRadioButton);
            MemoryRegionGroupBox.Location = new System.Drawing.Point(20, 116);
            MemoryRegionGroupBox.Name = "MemoryRegionGroupBox";
            MemoryRegionGroupBox.Size = new System.Drawing.Size(520, 130);
            MemoryRegionGroupBox.TabIndex = 1;
            MemoryRegionGroupBox.TabStop = false;
            MemoryRegionGroupBox.Text = "Memory Region (M):";
            // 
            // CompareAslrRadioButton
            // 
            CompareAslrRadioButton.AutoSize = true;
            CompareAslrRadioButton.Location = new System.Drawing.Point(260, 80);
            CompareAslrRadioButton.Name = "CompareAslrRadioButton";
            CompareAslrRadioButton.Size = new System.Drawing.Size(154, 34);
            CompareAslrRadioButton.TabIndex = 3;
            CompareAslrRadioButton.TabStop = true;
            CompareAslrRadioButton.Text = "Write to Aslr";
            CompareAslrRadioButton.UseVisualStyleBackColor = true;
            CompareAslrRadioButton.CheckedChanged += AddressTypeRadioButton_CheckedChanged;
            // 
            // CompareAliasRadioButton
            // 
            CompareAliasRadioButton.AutoSize = true;
            CompareAliasRadioButton.Location = new System.Drawing.Point(20, 80);
            CompareAliasRadioButton.Name = "CompareAliasRadioButton";
            CompareAliasRadioButton.Size = new System.Drawing.Size(163, 34);
            CompareAliasRadioButton.TabIndex = 2;
            CompareAliasRadioButton.TabStop = true;
            CompareAliasRadioButton.Text = "Write to Alias";
            CompareAliasRadioButton.UseVisualStyleBackColor = true;
            // 
            // ExampleLabel
            // 
            ExampleLabel.AutoSize = true;
            ExampleLabel.Location = new System.Drawing.Point(20, 661);
            ExampleLabel.Name = "ExampleLabel";
            ExampleLabel.Size = new System.Drawing.Size(96, 30);
            ExampleLabel.TabIndex = 8;
            ExampleLabel.Text = "Example:";
            // 
            // TemplateLabel
            // 
            TemplateLabel.AutoSize = true;
            TemplateLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TemplateLabel.Location = new System.Drawing.Point(40, 691);
            TemplateLabel.Name = "TemplateLabel";
            TemplateLabel.Size = new System.Drawing.Size(166, 24);
            TemplateLabel.TabIndex = 9;
            TemplateLabel.Text = "TemplateLabel";
            // 
            // ConditionalForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(576, 755);
            Controls.Add(TemplateLabel);
            Controls.Add(ExampleLabel);
            Controls.Add(ComparisonGroupBox);
            Controls.Add(MemoryRegionGroupBox);
            Controls.Add(AddressSizeGroupBox);
            Controls.Add(ConditionalGroupBox);
            Name = "ConditionalForm";
            Text = "ConditionalForm";
            ConditionalGroupBox.ResumeLayout(false);
            ConditionalGroupBox.PerformLayout();
            ComparisonGroupBox.ResumeLayout(false);
            ComparisonGroupBox.PerformLayout();
            AddressSizeGroupBox.ResumeLayout(false);
            AddressSizeGroupBox.PerformLayout();
            MemoryRegionGroupBox.ResumeLayout(false);
            MemoryRegionGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox AddressSizeGroupBox;
        private System.Windows.Forms.RadioButton EightBitRadioButton;
        private System.Windows.Forms.RadioButton SixteenBitRadioButton;
        private System.Windows.Forms.RadioButton ThirtyTwoBitRadioButton;
        private System.Windows.Forms.RadioButton SixtyFourBitRadioButton;

        private System.Windows.Forms.GroupBox MemoryRegionGroupBox;
        private System.Windows.Forms.RadioButton CompareNsoRadioButton;
        private System.Windows.Forms.RadioButton CompareHeapRadioButton;
        private System.Windows.Forms.RadioButton CompareAliasRadioButton;
        private System.Windows.Forms.RadioButton CompareAslrRadioButton;

        private System.Windows.Forms.GroupBox ComparisonGroupBox;
        private System.Windows.Forms.RadioButton GreaterThanRadioButton;
        private System.Windows.Forms.RadioButton GreaterThanOrEqualToRadioButton;
        private System.Windows.Forms.RadioButton LessThanRadioButton;
        private System.Windows.Forms.RadioButton LessThanOrEqualToRadioButton;
        private System.Windows.Forms.RadioButton EqualRadioButton;
        private System.Windows.Forms.RadioButton NotEqualRadioButton;


        private System.Windows.Forms.GroupBox ConditionalGroupBox;
        private System.Windows.Forms.Label RelevantAddressLabel;
        private System.Windows.Forms.TextBox RelevantAddressTextBox;
        private System.Windows.Forms.Label ValueCompareLabel;
        private System.Windows.Forms.TextBox ValueCompareTextBox;

        private System.Windows.Forms.Label ExampleLabel;
        private System.Windows.Forms.Label TemplateLabel;
    }
}