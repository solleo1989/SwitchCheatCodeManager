using System.Windows.Forms;

namespace SwitchCheatCodeManager.SubView
{
    partial class MemoryWriteForm
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
            NsoRadioButton = new RadioButton();
            HeapRadioButton = new RadioButton();
            RelevantAddressLabel = new Label();
            RelevantAddressTextBox = new FormEntity.TextBoxEx();
            ValueLabel = new Label();
            ValueTextBox = new FormEntity.TextBoxEx();
            AddressSizeGroupBox = new GroupBox();
            EightBitRadioButton = new RadioButton();
            SixtyFourBitRadioButton = new RadioButton();
            SixteenBitRadioButton = new RadioButton();
            ThirtyTwoBitRadioButton = new RadioButton();
            TemplateLabel = new Label();
            MemoryRegionGroupBox = new GroupBox();
            AslrRadioButton = new RadioButton();
            AliasRadioButton = new RadioButton();
            RegisterOffsetLabel = new Label();
            OffsetRegisterComboBox = new ComboBox();
            MemoryOffsetGroupBox = new GroupBox();
            ExampleLabel = new Label();
            AddressSizeGroupBox.SuspendLayout();
            MemoryRegionGroupBox.SuspendLayout();
            MemoryOffsetGroupBox.SuspendLayout();
            SuspendLayout();
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
            NsoRadioButton.CheckedChanged += AddressTypeRadioButton_CheckedChanged;
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
            HeapRadioButton.CheckedChanged += AddressTypeRadioButton_CheckedChanged;
            // 
            // RelevantAddressLabel
            // 
            RelevantAddressLabel.AutoSize = true;
            RelevantAddressLabel.Location = new System.Drawing.Point(20, 90);
            RelevantAddressLabel.Name = "RelevantAddressLabel";
            RelevantAddressLabel.Size = new System.Drawing.Size(490, 30);
            RelevantAddressLabel.TabIndex = 4;
            RelevantAddressLabel.Text = "Address relevant to NSO (A): (Max 10 hex numbers)";
            // 
            // RelevantAddressTextBox
            // 
            RelevantAddressTextBox.Location = new System.Drawing.Point(20, 123);
            RelevantAddressTextBox.MaxLength = 10;
            RelevantAddressTextBox.Name = "RelevantAddressTextBox";
            RelevantAddressTextBox.PlaceholderText = " e.g. ABCDEF0123 (0~10 hex-numbers)";
            RelevantAddressTextBox.Size = new System.Drawing.Size(480, 35);
            RelevantAddressTextBox.TabIndex = 3;
            RelevantAddressTextBox.TextChanged += RelevantAddressTextBox_TextChanged;
            // 
            // ValueLabel
            // 
            ValueLabel.AutoSize = true;
            ValueLabel.Location = new System.Drawing.Point(20, 172);
            ValueLabel.Name = "ValueLabel";
            ValueLabel.Size = new System.Drawing.Size(200, 30);
            ValueLabel.TabIndex = 6;
            ValueLabel.Text = "Value to write to (V):";
            // 
            // ValueTextBox
            // 
            ValueTextBox.Location = new System.Drawing.Point(20, 205);
            ValueTextBox.Name = "ValueTextBox";
            ValueTextBox.Size = new System.Drawing.Size(480, 35);
            ValueTextBox.TabIndex = 5;
            ValueTextBox.TextChanged += ValueTextBox_TextChanged;
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
            AddressSizeGroupBox.TabIndex = 14;
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
            // TemplateLabel
            // 
            TemplateLabel.AutoSize = true;
            TemplateLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TemplateLabel.Location = new System.Drawing.Point(40, 555);
            TemplateLabel.Name = "TemplateLabel";
            TemplateLabel.Size = new System.Drawing.Size(322, 24);
            TemplateLabel.TabIndex = 16;
            TemplateLabel.Text = "1TMC00AA AAAAAAAA VVVVVVVV";
            // 
            // MemoryRegionGroupBox
            // 
            MemoryRegionGroupBox.Controls.Add(AslrRadioButton);
            MemoryRegionGroupBox.Controls.Add(AliasRadioButton);
            MemoryRegionGroupBox.Controls.Add(NsoRadioButton);
            MemoryRegionGroupBox.Controls.Add(HeapRadioButton);
            MemoryRegionGroupBox.Location = new System.Drawing.Point(20, 116);
            MemoryRegionGroupBox.Name = "MemoryRegionGroupBox";
            MemoryRegionGroupBox.Size = new System.Drawing.Size(520, 130);
            MemoryRegionGroupBox.TabIndex = 1;
            MemoryRegionGroupBox.TabStop = false;
            MemoryRegionGroupBox.Text = "Memory Region (M):";
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
            AslrRadioButton.CheckedChanged += AddressTypeRadioButton_CheckedChanged;
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
            AliasRadioButton.CheckedChanged += AddressTypeRadioButton_CheckedChanged;
            // 
            // RegisterOffsetLabel
            // 
            RegisterOffsetLabel.AutoSize = true;
            RegisterOffsetLabel.Location = new System.Drawing.Point(20, 40);
            RegisterOffsetLabel.Name = "RegisterOffsetLabel";
            RegisterOffsetLabel.Size = new System.Drawing.Size(123, 30);
            RegisterOffsetLabel.TabIndex = 17;
            RegisterOffsetLabel.Text = "Register (R):";
            // 
            // OffsetRegisterComboBox
            // 
            OffsetRegisterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            OffsetRegisterComboBox.FormattingEnabled = true;
            OffsetRegisterComboBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" });
            OffsetRegisterComboBox.Location = new System.Drawing.Point(160, 40);
            OffsetRegisterComboBox.Name = "OffsetRegisterComboBox";
            OffsetRegisterComboBox.Size = new System.Drawing.Size(80, 38);
            OffsetRegisterComboBox.TabIndex = 18;
            // 
            // MemoryOffsetGroupBox
            // 
            MemoryOffsetGroupBox.Controls.Add(RegisterOffsetLabel);
            MemoryOffsetGroupBox.Controls.Add(OffsetRegisterComboBox);
            MemoryOffsetGroupBox.Controls.Add(RelevantAddressLabel);
            MemoryOffsetGroupBox.Controls.Add(RelevantAddressTextBox);
            MemoryOffsetGroupBox.Controls.Add(ValueLabel);
            MemoryOffsetGroupBox.Controls.Add(ValueTextBox);
            MemoryOffsetGroupBox.Location = new System.Drawing.Point(20, 252);
            MemoryOffsetGroupBox.Name = "MemoryOffsetGroupBox";
            MemoryOffsetGroupBox.Size = new System.Drawing.Size(520, 270);
            MemoryOffsetGroupBox.TabIndex = 19;
            MemoryOffsetGroupBox.TabStop = false;
            MemoryOffsetGroupBox.Text = "Memory Offset";
            // 
            // ExampleLabel
            // 
            ExampleLabel.AutoSize = true;
            ExampleLabel.Location = new System.Drawing.Point(20, 525);
            ExampleLabel.Name = "ExampleLabel";
            ExampleLabel.Size = new System.Drawing.Size(96, 30);
            ExampleLabel.TabIndex = 15;
            ExampleLabel.Text = "Example:";
            // 
            // MemoryWriteForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(576, 596);
            Controls.Add(MemoryOffsetGroupBox);
            Controls.Add(TemplateLabel);
            Controls.Add(MemoryRegionGroupBox);
            Controls.Add(ExampleLabel);
            Controls.Add(AddressSizeGroupBox);
            Name = "MemoryWriteForm";
            Text = "Momory Write";
            AddressSizeGroupBox.ResumeLayout(false);
            AddressSizeGroupBox.PerformLayout();
            MemoryRegionGroupBox.ResumeLayout(false);
            MemoryRegionGroupBox.PerformLayout();
            MemoryOffsetGroupBox.ResumeLayout(false);
            MemoryOffsetGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox AddressSizeGroupBox;
        private RadioButton EightBitRadioButton;
        private RadioButton SixteenBitRadioButton;
        private RadioButton ThirtyTwoBitRadioButton;
        private RadioButton SixtyFourBitRadioButton;

        private GroupBox MemoryRegionGroupBox;
        private RadioButton NsoRadioButton;
        private RadioButton HeapRadioButton;
        private RadioButton AliasRadioButton;
        private RadioButton AslrRadioButton;

        private GroupBox MemoryOffsetGroupBox;
        private Label RegisterOffsetLabel;
        private ComboBox OffsetRegisterComboBox;
        private Label RelevantAddressLabel;
        private FormEntity.TextBoxEx RelevantAddressTextBox;
        private Label ValueLabel;
        private FormEntity.TextBoxEx ValueTextBox;

        private Label ExampleLabel;
        private Label TemplateLabel;
    }
}