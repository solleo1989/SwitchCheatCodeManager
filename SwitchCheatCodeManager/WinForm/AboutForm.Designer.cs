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
            this.MessageLabel = new System.Windows.Forms.Label();
            this.ReleaseLinkLabel = new System.Windows.Forms.LinkLabel();
            this.OkButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = Constants.DEFAULT_POPUP_DIALOGUE_TITLE_FONT;
            this.TitleLabel.Location = new System.Drawing.Point(190, 30);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(120, 40);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLabel.Text = Resources.ABOUT_FORM_TITLE;
            // 
            // MessageLabel
            // 
            this.MessageLabel.Font = Constants.DEFAULT_POPUP_DIALOGUE_TEXT_FONT;
            this.MessageLabel.Location = new System.Drawing.Point(40, 80);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(420, 80);
            this.MessageLabel.TabIndex = 1;
            this.MessageLabel.Text = Resources.ABOUT_FORM_MESSAGE_TEXT;
            // 
            // ReleaseLinkLabel
            // 
            this.ReleaseLinkLabel.Location = new System.Drawing.Point(150, 160);
            this.ReleaseLinkLabel.Name = "releaseLinkLabel";
            this.ReleaseLinkLabel.Size = new System.Drawing.Size(200, 40);
            this.ReleaseLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReleaseLinkLabel.TabIndex = 2;
            this.ReleaseLinkLabel.TabStop = true;
            this.ReleaseLinkLabel.Links[0].LinkData = Constants.DEFAULT_VERSION_RELEASE_URL;
            this.ReleaseLinkLabel.Text = Resources.ABOUT_FORM_LINK_TEXT;
            this.ReleaseLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(ReleaseLinkLabel_LinkClicked);
            // 
            // OkButton
            // 
            this.OkButton.Font = Constants.DEFAULT_POPUP_DIALOGUE_TEXT_FONT;
            this.OkButton.Location = new System.Drawing.Point(190, 220);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(120, 60);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = Resources.DIALOGUE_BUTTON_TEXT_OK;
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);

            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.ReleaseLinkLabel);
            this.Controls.Add(this.OkButton);
            this.Name = "AboutForm";
            this.Text = Resources.ABOUT_FORM_TITLE;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.LinkLabel ReleaseLinkLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label TitleLabel;
    }
}