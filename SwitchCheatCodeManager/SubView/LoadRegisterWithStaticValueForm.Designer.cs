using System.Windows.Forms;

namespace SwitchCheatCodeManager.SubView
{
    partial class LoadRegisterWithStaticValueForm
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
            TemplateLabel = new Label();
            ExampleLabel = new Label();
            LoadRegisterWithValueGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // LoadRegisterWithValueGroupBox
            // 
            LoadRegisterWithValueGroupBox.Controls.Add(RegisterListComboBox);
            LoadRegisterWithValueGroupBox.Controls.Add(AddressValueTextBox);
            LoadRegisterWithValueGroupBox.Controls.Add(AddressValueLabel);
            LoadRegisterWithValueGroupBox.Controls.Add(RegisterLabel);
            LoadRegisterWithValueGroupBox.Location = new System.Drawing.Point(20, 12);
            LoadRegisterWithValueGroupBox.Name = "LoadRegisterWithValueGroupBox";
            LoadRegisterWithValueGroupBox.Size = new System.Drawing.Size(520, 180);
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
            AddressValueTextBox.MaxLength = 16;
            AddressValueTextBox.Name = "AddressValueTextBox";
            AddressValueTextBox.PlaceholderText = "e.g. VVVVVVVVVVVVVVVV (0~16 hex-numbers)";
            AddressValueTextBox.Size = new System.Drawing.Size(450, 35);
            AddressValueTextBox.TabIndex = 5;
            AddressValueTextBox.TextChanged += AddressValueTextBox_TextChanged;
            // 
            // AddressValueLabel
            // 
            AddressValueLabel.AutoSize = true;
            AddressValueLabel.Location = new System.Drawing.Point(20, 90);
            AddressValueLabel.Name = "AddressValueLabel";
            AddressValueLabel.Size = new System.Drawing.Size(382, 30);
            AddressValueLabel.TabIndex = 4;
            AddressValueLabel.Text = "Value to load (V): (Max 16 hex numbers)";
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
            // TemplateLabel
            // 
            TemplateLabel.AutoSize = true;
            TemplateLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TemplateLabel.Location = new System.Drawing.Point(40, 225);
            TemplateLabel.Name = "TemplateLabel";
            TemplateLabel.Size = new System.Drawing.Size(322, 24);
            TemplateLabel.TabIndex = 8;
            TemplateLabel.Text = "400R0000 VVVVVVVV VVVVVVVV";
            // 
            // ExampleLabel
            // 
            ExampleLabel.AutoSize = true;
            ExampleLabel.Location = new System.Drawing.Point(20, 195);
            ExampleLabel.Name = "ExampleLabel";
            ExampleLabel.Size = new System.Drawing.Size(96, 30);
            ExampleLabel.TabIndex = 7;
            ExampleLabel.Text = "Example:";
            // 
            // LoadRegisterWithStaticValueForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(576, 704);
            Controls.Add(LoadRegisterWithValueGroupBox);
            Controls.Add(TemplateLabel);
            Controls.Add(ExampleLabel);
            Name = "LoadRegisterWithStaticValueForm";
            Text = "LoadRegisterWithValueForm";
            LoadRegisterWithValueGroupBox.ResumeLayout(false);
            LoadRegisterWithValueGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox LoadRegisterWithValueGroupBox;
        private System.Windows.Forms.TextBox AddressValueTextBox;
        private System.Windows.Forms.Label AddressValueLabel;
        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.Label TemplateLabel;
        private System.Windows.Forms.Label ExampleLabel;
        private System.Windows.Forms.ComboBox RegisterListComboBox;
    }
}