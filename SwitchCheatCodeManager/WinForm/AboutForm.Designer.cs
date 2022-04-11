using SwitchCheatCodeManager.Constant;
using SwitchCheatCodeManager.Properties;

namespace SwitchCheatCodeManager.WinForm
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.ReleaseLinkLabel = new System.Windows.Forms.LinkLabel();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MessageLabel
            // 
            resources.ApplyResources(this.MessageLabel, "MessageLabel");
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Text = global::SwitchCheatCodeManager.Properties.Resources.ABOUT_FORM_MESSAGE_TEXT;
            // 
            // ReleaseLinkLabel
            // 
            resources.ApplyResources(this.ReleaseLinkLabel, "ReleaseLinkLabel");
            this.ReleaseLinkLabel.Name = "ReleaseLinkLabel";
            this.ReleaseLinkLabel.TabStop = true;
            this.ReleaseLinkLabel.Text = global::SwitchCheatCodeManager.Properties.Resources.ABOUT_FORM_LINK_TEXT;
            this.ReleaseLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ReleaseLinkLabel_LinkClicked);
            // 
            // OkButton
            // 
            resources.ApplyResources(this.OkButton, "OkButton");
            this.OkButton.Name = "OkButton";
            this.OkButton.Text = global::SwitchCheatCodeManager.Properties.Resources.DIALOGUE_BUTTON_TEXT_OK;
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // TitleLabel
            // 
            resources.ApplyResources(this.TitleLabel, "TitleLabel");
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Text = global::SwitchCheatCodeManager.Properties.Resources.ABOUT_FORM_TITLE_TEXT;
            // 
            // AboutForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.ReleaseLinkLabel);
            this.Controls.Add(this.OkButton);
            this.Name = "AboutForm";
            this.Text = global::SwitchCheatCodeManager.Properties.Resources.ABOUT_FORM_TITLE;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.LinkLabel ReleaseLinkLabel;
        private System.Windows.Forms.Button OkButton;
    }
}