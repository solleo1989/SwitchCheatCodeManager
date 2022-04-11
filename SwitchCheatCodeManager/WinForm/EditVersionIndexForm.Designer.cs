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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditVersionIndexForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.VersionBuildIdDataGridView = new System.Windows.Forms.DataGridView();
            this.BuildIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VersionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddRowButton = new System.Windows.Forms.Button();
            this.DeleteRowButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VersionBuildIdDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // VersionBuildIdDataGridView
            // 
            this.VersionBuildIdDataGridView.AllowUserToResizeColumns = false;
            this.VersionBuildIdDataGridView.AllowUserToResizeRows = false;
            this.VersionBuildIdDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ubuntu Mono", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VersionBuildIdDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.VersionBuildIdDataGridView, "VersionBuildIdDataGridView");
            this.VersionBuildIdDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.VersionBuildIdDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BuildIdDataGridViewTextBoxColumn,
            this.VersionDataGridViewTextBoxColumn});
            this.VersionBuildIdDataGridView.GridColor = System.Drawing.Color.Black;
            this.VersionBuildIdDataGridView.Name = "VersionBuildIdDataGridView";
            this.VersionBuildIdDataGridView.RowHeadersVisible = false;
            this.VersionBuildIdDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            // 
            // BuildIdDataGridViewTextBoxColumn
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Ubuntu Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BuildIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.BuildIdDataGridViewTextBoxColumn, "BuildIdDataGridViewTextBoxColumn");
            this.BuildIdDataGridViewTextBoxColumn.Name = "BuildIdDataGridViewTextBoxColumn";
            // 
            // VersionDataGridViewTextBoxColumn
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Ubuntu Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.VersionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.VersionDataGridViewTextBoxColumn, "VersionDataGridViewTextBoxColumn");
            this.VersionDataGridViewTextBoxColumn.Name = "VersionDataGridViewTextBoxColumn";
            // 
            // AddRowButton
            // 
            resources.ApplyResources(this.AddRowButton, "AddRowButton");
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Text = global::SwitchCheatCodeManager.Properties.Resources.VersionDataGridViewTextBoxColumn_AddRowButton_Text;
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // DeleteRowButton
            // 
            resources.ApplyResources(this.DeleteRowButton, "DeleteRowButton");
            this.DeleteRowButton.Name = "DeleteRowButton";
            this.DeleteRowButton.Text = global::SwitchCheatCodeManager.Properties.Resources.VersionDataGridViewTextBoxColumn_DeleteRowButton_Text;
            this.DeleteRowButton.UseVisualStyleBackColor = true;
            this.DeleteRowButton.Click += new System.EventHandler(this.DeleteRowButton_Click);
            // 
            // SaveButton
            // 
            resources.ApplyResources(this.SaveButton, "SaveButton");
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Text = global::SwitchCheatCodeManager.Properties.Resources.VersionDataGridViewTextBoxColumn_SaveButton_Text;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EditVersionIndexForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteRowButton);
            this.Controls.Add(this.AddRowButton);
            this.Controls.Add(this.VersionBuildIdDataGridView);
            this.Name = "EditVersionIndexForm";
            this.Text = global::SwitchCheatCodeManager.Properties.Resources.VERSION_FORM_TITLE;
            ((System.ComponentModel.ISupportInitialize)(this.VersionBuildIdDataGridView)).EndInit();
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