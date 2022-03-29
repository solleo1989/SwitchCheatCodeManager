using SwitchCheatCodeManager.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SwitchCheatCodeManager.WinForm
{
    partial class EditVersionIndexForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            DataGridViewCellStyle titleDataGridViewCellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle buildIdDataGridViewCellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle versionDataGridViewCellStyle = new DataGridViewCellStyle();
            this.VersionBuildIdDataGridView = new DataGridView();
            this.BuildIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.VersionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.AddRowButton = new Button();
            this.DeleteRowButton = new Button();
            this.SaveButton = new Button();

            ((ISupportInitialize)this.VersionBuildIdDataGridView).BeginInit();
            this.SuspendLayout();
            // 
            // VersionBuildIdDataGridView
            // 
            this.VersionBuildIdDataGridView.AllowUserToResizeColumns = false;
            this.VersionBuildIdDataGridView.AllowUserToResizeRows = false;
            this.VersionBuildIdDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            titleDataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            titleDataGridViewCellStyle.BackColor = Color.Black;
            titleDataGridViewCellStyle.Font = new Font("Ubuntu Mono", 11F, FontStyle.Bold, GraphicsUnit.Point);
            titleDataGridViewCellStyle.ForeColor = Color.White;
            titleDataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
            titleDataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
            titleDataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
            this.VersionBuildIdDataGridView.ColumnHeadersDefaultCellStyle = titleDataGridViewCellStyle;
            this.VersionBuildIdDataGridView.ColumnHeadersHeight = 50;
            this.VersionBuildIdDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.VersionBuildIdDataGridView.Columns.AddRange(new DataGridViewColumn[] {
            this.BuildIdDataGridViewTextBoxColumn,
            this.VersionDataGridViewTextBoxColumn});
            this.VersionBuildIdDataGridView.GridColor = Color.Black;
            this.VersionBuildIdDataGridView.Location = new Point(30, 30);
            this.VersionBuildIdDataGridView.Margin = new Padding(4);
            this.VersionBuildIdDataGridView.Name = "VersionBuildIdDataGridView";
            this.VersionBuildIdDataGridView.RowHeadersVisible = false;
            this.VersionBuildIdDataGridView.RowHeadersWidth = 50;
            this.VersionBuildIdDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.VersionBuildIdDataGridView.Size = new Size(480, 825);
            this.VersionBuildIdDataGridView.TabIndex = 0;
            // 
            // BuildIdDataGridViewTextBoxColumn
            // 
            buildIdDataGridViewCellStyle.Padding = new Padding(10, 0, 0, 0);
            buildIdDataGridViewCellStyle.Font = new Font("Ubuntu Mono", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.BuildIdDataGridViewTextBoxColumn.DefaultCellStyle = buildIdDataGridViewCellStyle;
            this.BuildIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.BuildIdDataGridViewTextBoxColumn.Name = "BuildIdDataGridViewTextBoxColumn";
            this.BuildIdDataGridViewTextBoxColumn.Width = 280;
            // 
            // VersionDataGridViewTextBoxColumn
            // 
            versionDataGridViewCellStyle.Padding = new Padding(10, 0, 0, 0);
            versionDataGridViewCellStyle.Font = new Font("Ubuntu Mono", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.VersionDataGridViewTextBoxColumn.DefaultCellStyle = versionDataGridViewCellStyle;
            this.VersionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.VersionDataGridViewTextBoxColumn.Name = "VersionDataGridViewTextBoxColumn";
            this.VersionDataGridViewTextBoxColumn.Width = 140;
            // 
            // AddRowButton
            // 
            this.AddRowButton.Location = new Point(550, 150);
            this.AddRowButton.Margin = new Padding(4);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new Size(150, 45);
            this.AddRowButton.TabIndex = 1;
            this.AddRowButton.Text = Resources.VersionDataGridViewTextBoxColumn_AddRowButton_Text;
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new EventHandler(this.AddRowButton_Click);
            // 
            // DeleteRowButton
            // 
            this.DeleteRowButton.Location = new Point(550, 223);
            this.DeleteRowButton.Margin = new Padding(4);
            this.DeleteRowButton.Name = "DeleteRowButton";
            this.DeleteRowButton.Size = new Size(150, 45);
            this.DeleteRowButton.TabIndex = 2;
            this.DeleteRowButton.Text = Resources.VersionDataGridViewTextBoxColumn_DeleteRowButton_Text;
            this.DeleteRowButton.UseVisualStyleBackColor = true;
            this.DeleteRowButton.Click += new EventHandler(this.DeleteRowButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new Point(550, 30);
            this.SaveButton.Margin = new Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new Size(150, 90);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = Resources.VersionDataGridViewTextBoxColumn_SaveButton_Text;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new EventHandler(this.SaveButton_Click);
            // 
            // EditVersionIndexForm
            // 
            this.AutoScaleDimensions = new SizeF(12F, 30F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(750, 900);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteRowButton);
            this.Controls.Add(this.AddRowButton);
            this.Controls.Add(this.VersionBuildIdDataGridView);
            this.Margin = new Padding(4);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Name = "EditVersionIndexForm";
            this.Text = "Edit Version Index Form";
            ((System.ComponentModel.ISupportInitialize)this.VersionBuildIdDataGridView).EndInit();

            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView VersionBuildIdDataGridView;
        private Button AddRowButton;
        private Button DeleteRowButton;
        private DataGridViewTextBoxColumn BuildIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn VersionDataGridViewTextBoxColumn;
        private Button SaveButton;
    }
}