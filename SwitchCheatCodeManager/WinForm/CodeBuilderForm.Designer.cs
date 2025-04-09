using System.Windows.Forms;
using System.Drawing;

namespace SwitchCheatCodeManager.WinForm
{
    partial class CodeBuilderForm
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
            HexDecGroupBox = new GroupBox();
            EqualButton = new Button();
            ResultTextBox = new TextBox();
            RightFactorTextBox = new TextBox();
            SymbolComboBox = new ComboBox();
            LeftFactorTextBox = new TextBox();
            HexResultTextBox = new TextBox();
            Dec2HexTextBox = new TextBox();
            Dec2HexLabel = new Label();
            DecResultTextBox = new TextBox();
            Hex2DecTextBox = new TextBox();
            Hex2DecLabel = new Label();
            ToolGroupBox = new GroupBox();
            AddCodeButton = new Button();
            MemoryWritePanel = new Panel();
            MethodsComboBox = new ComboBox();
            CodeGroupBox = new GroupBox();
            CopyToClipboardButton = new Button();
            ResetButton = new Button();
            OutputTextBox = new TextBox();
            HexDecGroupBox.SuspendLayout();
            ToolGroupBox.SuspendLayout();
            CodeGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // HexDecGroupBox
            // 
            HexDecGroupBox.Controls.Add(EqualButton);
            HexDecGroupBox.Controls.Add(ResultTextBox);
            HexDecGroupBox.Controls.Add(RightFactorTextBox);
            HexDecGroupBox.Controls.Add(SymbolComboBox);
            HexDecGroupBox.Controls.Add(LeftFactorTextBox);
            HexDecGroupBox.Controls.Add(HexResultTextBox);
            HexDecGroupBox.Controls.Add(Dec2HexTextBox);
            HexDecGroupBox.Controls.Add(Dec2HexLabel);
            HexDecGroupBox.Controls.Add(DecResultTextBox);
            HexDecGroupBox.Controls.Add(Hex2DecTextBox);
            HexDecGroupBox.Controls.Add(Hex2DecLabel);
            HexDecGroupBox.Location = new Point(50, 30);
            HexDecGroupBox.Name = "HexDecGroupBox";
            HexDecGroupBox.Size = new Size(1300, 200);
            HexDecGroupBox.TabIndex = 2;
            HexDecGroupBox.TabStop = false;
            HexDecGroupBox.Text = "Hex-Dec";
            // 
            // EqualButton
            // 
            EqualButton.Location = new Point(604, 117);
            EqualButton.Name = "EqualButton";
            EqualButton.Size = new Size(95, 40);
            EqualButton.TabIndex = 10;
            EqualButton.Text = "=";
            EqualButton.UseVisualStyleBackColor = true;
            EqualButton.Click += EqualButton_Click;
            // 
            // ResultTextBox
            // 
            ResultTextBox.Location = new Point(705, 117);
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.PlaceholderText = "0x1234";
            ResultTextBox.Size = new Size(180, 35);
            ResultTextBox.TabIndex = 9;
            // 
            // RightFactorTextBox
            // 
            RightFactorTextBox.Location = new Point(418, 117);
            RightFactorTextBox.Name = "RightFactorTextBox";
            RightFactorTextBox.PlaceholderText = "0x1234";
            RightFactorTextBox.Size = new Size(180, 35);
            RightFactorTextBox.TabIndex = 8;
            // 
            // SymbolComboBox
            // 
            SymbolComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SymbolComboBox.FormattingEnabled = true;
            SymbolComboBox.Location = new Point(223, 117);
            SymbolComboBox.Name = "SymbolComboBox";
            SymbolComboBox.Size = new Size(180, 38);
            SymbolComboBox.TabIndex = 7;
            // 
            // LeftFactorTextBox
            // 
            LeftFactorTextBox.Location = new Point(30, 120);
            LeftFactorTextBox.Name = "LeftFactorTextBox";
            LeftFactorTextBox.PlaceholderText = "0x1234";
            LeftFactorTextBox.Size = new Size(180, 35);
            LeftFactorTextBox.TabIndex = 6;
            // 
            // HexResultTextBox
            // 
            HexResultTextBox.Location = new Point(1081, 50);
            HexResultTextBox.Name = "HexResultTextBox";
            HexResultTextBox.ReadOnly = true;
            HexResultTextBox.Size = new Size(180, 35);
            HexResultTextBox.TabIndex = 5;
            // 
            // Dec2HexTextBox
            // 
            Dec2HexTextBox.Location = new Point(705, 50);
            Dec2HexTextBox.MaxLength = 14;
            Dec2HexTextBox.Name = "Dec2HexTextBox";
            Dec2HexTextBox.Size = new Size(180, 35);
            Dec2HexTextBox.TabIndex = 4;
            Dec2HexTextBox.TextChanged += Dec2HexTextBox_TextChanged;
            // 
            // Dec2HexLabel
            // 
            Dec2HexLabel.AutoSize = true;
            Dec2HexLabel.Location = new Point(891, 50);
            Dec2HexLabel.Name = "Dec2HexLabel";
            Dec2HexLabel.Size = new Size(187, 30);
            Dec2HexLabel.TabIndex = 3;
            Dec2HexLabel.Text = "(10)Dec-to-Hex(0x)";
            // 
            // DecResultTextBox
            // 
            DecResultTextBox.Location = new Point(418, 50);
            DecResultTextBox.Name = "DecResultTextBox";
            DecResultTextBox.ReadOnly = true;
            DecResultTextBox.Size = new Size(180, 35);
            DecResultTextBox.TabIndex = 2;
            // 
            // Hex2DecTextBox
            // 
            Hex2DecTextBox.Location = new Point(30, 50);
            Hex2DecTextBox.MaxLength = 12;
            Hex2DecTextBox.Name = "Hex2DecTextBox";
            Hex2DecTextBox.Size = new Size(180, 35);
            Hex2DecTextBox.TabIndex = 1;
            Hex2DecTextBox.TextChanged += Hex2DecTextBox_TextChanged;
            // 
            // Hex2DecLabel
            // 
            Hex2DecLabel.AutoSize = true;
            Hex2DecLabel.Location = new Point(216, 50);
            Hex2DecLabel.Name = "Hex2DecLabel";
            Hex2DecLabel.Size = new Size(187, 30);
            Hex2DecLabel.TabIndex = 0;
            Hex2DecLabel.Text = "(0x)Hex-to-Dec(10)";
            // 
            // ToolGroupBox
            // 
            ToolGroupBox.Controls.Add(AddCodeButton);
            ToolGroupBox.Controls.Add(MemoryWritePanel);
            ToolGroupBox.Controls.Add(MethodsComboBox);
            ToolGroupBox.Location = new Point(50, 250);
            ToolGroupBox.Name = "ToolGroupBox";
            ToolGroupBox.Size = new Size(630, 1109);
            ToolGroupBox.TabIndex = 0;
            ToolGroupBox.TabStop = false;
            ToolGroupBox.Text = "Tool";
            // 
            // AddCodeButton
            // 
            AddCodeButton.Location = new Point(318, 1034);
            AddCodeButton.Name = "AddCodeButton";
            AddCodeButton.Size = new Size(280, 69);
            AddCodeButton.TabIndex = 3;
            AddCodeButton.Text = "Add Code -->";
            AddCodeButton.UseVisualStyleBackColor = true;
            AddCodeButton.Click += AddCodeButton_Click;
            // 
            // MemoryWritePanel
            // 
            MemoryWritePanel.Location = new Point(30, 78);
            MemoryWritePanel.Name = "MemoryWritePanel";
            MemoryWritePanel.Size = new Size(568, 950);
            MemoryWritePanel.TabIndex = 2;
            // 
            // MethodsComboBox
            // 
            MethodsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MethodsComboBox.FormattingEnabled = true;
            MethodsComboBox.Items.AddRange(new object[] { "0x0: Store Static Value to Memory", "0x1: Begin Conditional Block", "0x2: End Conditional Block", "0x3: Start/End Loop", "0x4: Load Register with Static Value", "0x5: Load Register with Memory Value", "0x6: Store Static Value to Register Memory Address", "0x7: Apply Legacy Arithmetic Operation To Register (Deprecated)", "0x8: Begin Keypress Conditional Block", "0x9: Apply Arithmetic Operation To Register", "0xA: Store Register to Memory Address", "0xB: Reserved" });
            MethodsComboBox.Location = new Point(40, 34);
            MethodsComboBox.Name = "MethodsComboBox";
            MethodsComboBox.Size = new Size(539, 38);
            MethodsComboBox.TabIndex = 0;
            MethodsComboBox.SelectedIndexChanged += MethodsComboBox_SelectedIndexChanged;
            // 
            // CodeGroupBox
            // 
            CodeGroupBox.Controls.Add(CopyToClipboardButton);
            CodeGroupBox.Controls.Add(ResetButton);
            CodeGroupBox.Controls.Add(OutputTextBox);
            CodeGroupBox.Location = new Point(720, 250);
            CodeGroupBox.Name = "CodeGroupBox";
            CodeGroupBox.Size = new Size(630, 1109);
            CodeGroupBox.TabIndex = 1;
            CodeGroupBox.TabStop = false;
            CodeGroupBox.Text = "Code";
            // 
            // CopyToClipboardButton
            // 
            CopyToClipboardButton.Location = new Point(341, 1034);
            CopyToClipboardButton.Name = "CopyToClipboardButton";
            CopyToClipboardButton.Size = new Size(250, 66);
            CopyToClipboardButton.TabIndex = 2;
            CopyToClipboardButton.Text = "Copy to Clipboard";
            CopyToClipboardButton.UseVisualStyleBackColor = true;
            CopyToClipboardButton.Click += CopyToClipboardButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(35, 1034);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(250, 66);
            ResetButton.TabIndex = 1;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // OutputTextBox
            // 
            OutputTextBox.Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point);
            OutputTextBox.Location = new Point(35, 54);
            OutputTextBox.Multiline = true;
            OutputTextBox.Name = "OutputTextBox";
            OutputTextBox.Size = new Size(556, 974);
            OutputTextBox.TabIndex = 0;
            // 
            // CodeBuilderForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 1371);
            Controls.Add(HexDecGroupBox);
            Controls.Add(CodeGroupBox);
            Controls.Add(ToolGroupBox);
            Name = "CodeBuilderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CodeBuilder";
            HexDecGroupBox.ResumeLayout(false);
            HexDecGroupBox.PerformLayout();
            ToolGroupBox.ResumeLayout(false);
            CodeGroupBox.ResumeLayout(false);
            CodeGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox HexDecGroupBox;
        private Label Hex2DecLabel;

        private TextBox Hex2DecTextBox;
        private TextBox DecResultTextBox;
        private Label Dec2HexLabel;
        private TextBox Dec2HexTextBox;
        private TextBox HexResultTextBox;

        private GroupBox CodeGroupBox;
        private GroupBox ToolGroupBox;
        private ComboBox MethodsComboBox;
        private TextBox OutputTextBox;
        private Panel MemoryWritePanel;
        private Button AddCodeButton;
        private Button CopyToClipboardButton;
        private Button ResetButton;
        private TextBox RightFactorTextBox;
        private ComboBox SymbolComboBox;
        private TextBox LeftFactorTextBox;
        private TextBox ResultTextBox;
        private Button EqualButton;
    }
}