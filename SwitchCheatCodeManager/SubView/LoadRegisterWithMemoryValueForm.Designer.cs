using System.Windows.Forms;

namespace SwitchCheatCodeManager.SubView
{
    partial class LoadRegisterWithMemoryValueForm
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
            LoadRegisterWithValueGroupBox = new GroupBox();
            RegisterListComboBox = new ComboBox();
            AddressValueTextBox = new TextBox();
            AddressValueLabel = new Label();
            RegisterLabel = new Label();
            RelativeToGroupBox = new GroupBox();
            ToAslrRadioButton = new RadioButton();
            ToAliasRadioButton = new RadioButton();
            ToHeapRadioButton = new RadioButton();
            ToNsoRadioButton = new RadioButton();
            TemplateLabel = new Label();
            ExampleLabel = new Label();
            AddressSizeGroupBox = new GroupBox();
            SixtyFourBitRadioButton = new RadioButton();
            ThirtyTwoBitRadioButton = new RadioButton();
            SixteenBitRadioButton = new RadioButton();
            EightBitRadioButton = new RadioButton();
            LoadFromGroupBox = new GroupBox();
            RegisterAddressEncodingRadioButton = new RadioButton();
            FixedAddressEncodingRadioButton = new RadioButton();
            LoadRegisterWithValueGroupBox.SuspendLayout();
            RelativeToGroupBox.SuspendLayout();
            AddressSizeGroupBox.SuspendLayout();
            LoadFromGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // LoadRegisterWithValueGroupBox
            // 
            LoadRegisterWithValueGroupBox.Controls.Add(RegisterListComboBox);
            LoadRegisterWithValueGroupBox.Controls.Add(AddressValueTextBox);
            LoadRegisterWithValueGroupBox.Controls.Add(AddressValueLabel);
            LoadRegisterWithValueGroupBox.Controls.Add(RegisterLabel);
            LoadRegisterWithValueGroupBox.Location = new System.Drawing.Point(20, 381);
            LoadRegisterWithValueGroupBox.Name = "LoadRegisterWithValueGroupBox";
            LoadRegisterWithValueGroupBox.Size = new System.Drawing.Size(520, 185);
            LoadRegisterWithValueGroupBox.TabIndex = 0;
            LoadRegisterWithValueGroupBox.TabStop = false;
            LoadRegisterWithValueGroupBox.Text = "Memory Offset";
            // 
            // RegisterListComboBox
            // 
            RegisterListComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            RegisterListComboBox.FormattingEnabled = true;
            RegisterListComboBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" });
            RegisterListComboBox.Location = new System.Drawing.Point(160, 40);
            RegisterListComboBox.Name = "RegisterListComboBox";
            RegisterListComboBox.Size = new System.Drawing.Size(80, 38);
            RegisterListComboBox.TabIndex = 9;
            // 
            // AddressValueTextBox
            // 
            AddressValueTextBox.Location = new System.Drawing.Point(20, 123);
            AddressValueTextBox.MaxLength = 10;
            AddressValueTextBox.Name = "AddressValueTextBox";
            AddressValueTextBox.PlaceholderText = "e.g. AAAAAAAAAA (0~10 hex-numbers)";
            AddressValueTextBox.Size = new System.Drawing.Size(450, 35);
            AddressValueTextBox.TabIndex = 5;
            AddressValueTextBox.TextChanged += AddressValueTextBox_TextChanged;
            // 
            // AddressValueLabel
            // 
            AddressValueLabel.AutoSize = true;
            AddressValueLabel.Location = new System.Drawing.Point(20, 90);
            AddressValueLabel.Name = "AddressValueLabel";
            AddressValueLabel.Size = new System.Drawing.Size(490, 30);
            AddressValueLabel.TabIndex = 4;
            AddressValueLabel.Text = "Address relevant to NSO (A): (Max 10 hex numbers)";
            // 
            // RegisterLabel
            // 
            RegisterLabel.AutoSize = true;
            RegisterLabel.Location = new System.Drawing.Point(20, 40);
            RegisterLabel.Name = "RegisterLabel";
            RegisterLabel.Size = new System.Drawing.Size(123, 30);
            RegisterLabel.TabIndex = 2;
            RegisterLabel.Text = "Register (R):";
            // 
            // RelativeToGroupBox
            // 
            RelativeToGroupBox.Controls.Add(ToAslrRadioButton);
            RelativeToGroupBox.Controls.Add(ToAliasRadioButton);
            RelativeToGroupBox.Controls.Add(ToHeapRadioButton);
            RelativeToGroupBox.Controls.Add(ToNsoRadioButton);
            RelativeToGroupBox.Location = new System.Drawing.Point(20, 245);
            RelativeToGroupBox.Name = "RelativeToGroupBox";
            RelativeToGroupBox.Size = new System.Drawing.Size(520, 130);
            RelativeToGroupBox.TabIndex = 10;
            RelativeToGroupBox.TabStop = false;
            RelativeToGroupBox.Text = "Memory Region (M):";
            // 
            // ToAslrRadioButton
            // 
            ToAslrRadioButton.AutoSize = true;
            ToAslrRadioButton.Location = new System.Drawing.Point(260, 80);
            ToAslrRadioButton.Name = "ToAslrRadioButton";
            ToAslrRadioButton.Size = new System.Drawing.Size(154, 34);
            ToAslrRadioButton.TabIndex = 3;
            ToAslrRadioButton.TabStop = true;
            ToAslrRadioButton.Text = "Write to Aslr";
            ToAslrRadioButton.UseVisualStyleBackColor = true;
            // 
            // ToAliasRadioButton
            // 
            ToAliasRadioButton.AutoSize = true;
            ToAliasRadioButton.Location = new System.Drawing.Point(20, 80);
            ToAliasRadioButton.Name = "ToAliasRadioButton";
            ToAliasRadioButton.Size = new System.Drawing.Size(163, 34);
            ToAliasRadioButton.TabIndex = 2;
            ToAliasRadioButton.TabStop = true;
            ToAliasRadioButton.Text = "Write to Alias";
            ToAliasRadioButton.UseVisualStyleBackColor = true;
            // 
            // ToHeapRadioButton
            // 
            ToHeapRadioButton.AutoSize = true;
            ToHeapRadioButton.Location = new System.Drawing.Point(260, 40);
            ToHeapRadioButton.Name = "ToHeapRadioButton";
            ToHeapRadioButton.Size = new System.Drawing.Size(168, 34);
            ToHeapRadioButton.TabIndex = 1;
            ToHeapRadioButton.TabStop = true;
            ToHeapRadioButton.Text = "Write to Heap";
            ToHeapRadioButton.UseVisualStyleBackColor = true;
            ToHeapRadioButton.CheckedChanged += BitRadioButton_CheckedChanged;
            // 
            // ToNsoRadioButton
            // 
            ToNsoRadioButton.AutoSize = true;
            ToNsoRadioButton.Location = new System.Drawing.Point(20, 40);
            ToNsoRadioButton.Name = "ToNsoRadioButton";
            ToNsoRadioButton.Size = new System.Drawing.Size(215, 34);
            ToNsoRadioButton.TabIndex = 0;
            ToNsoRadioButton.TabStop = true;
            ToNsoRadioButton.Text = "Write to Main NSO";
            ToNsoRadioButton.UseVisualStyleBackColor = true;
            ToNsoRadioButton.CheckedChanged += BitRadioButton_CheckedChanged;
            // 
            // TemplateLabel
            // 
            TemplateLabel.AutoSize = true;
            TemplateLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TemplateLabel.Location = new System.Drawing.Point(40, 599);
            TemplateLabel.Name = "TemplateLabel";
            TemplateLabel.Size = new System.Drawing.Size(166, 24);
            TemplateLabel.TabIndex = 8;
            TemplateLabel.Text = "TemplateLabel";
            // 
            // ExampleLabel
            // 
            ExampleLabel.AutoSize = true;
            ExampleLabel.Location = new System.Drawing.Point(20, 569);
            ExampleLabel.Name = "ExampleLabel";
            ExampleLabel.Size = new System.Drawing.Size(96, 30);
            ExampleLabel.TabIndex = 7;
            ExampleLabel.Text = "Example:";
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
            // LoadFromGroupBox
            // 
            LoadFromGroupBox.Controls.Add(RegisterAddressEncodingRadioButton);
            LoadFromGroupBox.Controls.Add(FixedAddressEncodingRadioButton);
            LoadFromGroupBox.Location = new System.Drawing.Point(20, 116);
            LoadFromGroupBox.Name = "LoadFromGroupBox";
            LoadFromGroupBox.Size = new System.Drawing.Size(520, 123);
            LoadFromGroupBox.TabIndex = 11;
            LoadFromGroupBox.TabStop = false;
            LoadFromGroupBox.Text = "Load From (M):";
            // 
            // RegisterAddressEncodingRadioButton
            // 
            RegisterAddressEncodingRadioButton.AutoSize = true;
            RegisterAddressEncodingRadioButton.Location = new System.Drawing.Point(260, 40);
            RegisterAddressEncodingRadioButton.Name = "RegisterAddressEncodingRadioButton";
            RegisterAddressEncodingRadioButton.Size = new System.Drawing.Size(198, 64);
            RegisterAddressEncodingRadioButton.TabIndex = 1;
            RegisterAddressEncodingRadioButton.TabStop = true;
            RegisterAddressEncodingRadioButton.Text = "Register Address \r\nEncoding(0)";
            RegisterAddressEncodingRadioButton.UseVisualStyleBackColor = true;
            RegisterAddressEncodingRadioButton.CheckedChanged += AddressEncodingRadioButton_CheckedChanged;
            // 
            // FixedAddressEncodingRadioButton
            // 
            FixedAddressEncodingRadioButton.AutoSize = true;
            FixedAddressEncodingRadioButton.Location = new System.Drawing.Point(20, 40);
            FixedAddressEncodingRadioButton.Name = "FixedAddressEncodingRadioButton";
            FixedAddressEncodingRadioButton.Size = new System.Drawing.Size(172, 64);
            FixedAddressEncodingRadioButton.TabIndex = 0;
            FixedAddressEncodingRadioButton.TabStop = true;
            FixedAddressEncodingRadioButton.Text = "Fixed Address \r\nEncoding(M)";
            FixedAddressEncodingRadioButton.UseVisualStyleBackColor = true;
            FixedAddressEncodingRadioButton.CheckedChanged += AddressEncodingRadioButton_CheckedChanged;
            // 
            // LoadRegisterWithMemoryValueForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(576, 665);
            Controls.Add(LoadFromGroupBox);
            Controls.Add(RelativeToGroupBox);
            Controls.Add(TemplateLabel);
            Controls.Add(LoadRegisterWithValueGroupBox);
            Controls.Add(ExampleLabel);
            Controls.Add(AddressSizeGroupBox);
            Name = "LoadRegisterWithMemoryValueForm";
            Text = "LoadRegisterWithMemoryValueForm";
            LoadRegisterWithValueGroupBox.ResumeLayout(false);
            LoadRegisterWithValueGroupBox.PerformLayout();
            RelativeToGroupBox.ResumeLayout(false);
            RelativeToGroupBox.PerformLayout();
            AddressSizeGroupBox.ResumeLayout(false);
            AddressSizeGroupBox.PerformLayout();
            LoadFromGroupBox.ResumeLayout(false);
            LoadFromGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox AddressSizeGroupBox;
        private System.Windows.Forms.RadioButton EightBitRadioButton;
        private System.Windows.Forms.RadioButton SixteenBitRadioButton;
        private System.Windows.Forms.RadioButton ThirtyTwoBitRadioButton;
        private System.Windows.Forms.RadioButton SixtyFourBitRadioButton;

        private GroupBox LoadFromGroupBox;
        private RadioButton FixedAddressEncodingRadioButton;
        private RadioButton RegisterAddressEncodingRadioButton;

        private GroupBox RelativeToGroupBox;
        private RadioButton ToNsoRadioButton;
        private RadioButton ToHeapRadioButton;
        private RadioButton ToAliasRadioButton;
        private RadioButton ToAslrRadioButton;

        private System.Windows.Forms.GroupBox LoadRegisterWithValueGroupBox;
        private System.Windows.Forms.TextBox AddressValueTextBox;
        private System.Windows.Forms.Label AddressValueLabel;
        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.Label TemplateLabel;
        private System.Windows.Forms.Label ExampleLabel;
        private System.Windows.Forms.ComboBox RegisterListComboBox;
    }
}