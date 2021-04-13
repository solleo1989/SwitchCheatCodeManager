using System;

using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SwitchCheatCodeManager
{
    class InputBox
    {
        private static System.Windows.Forms.Form frm = new System.Windows.Forms.Form();
        public static string ResultValue;
        private static DialogResult DialogRes;
        private static string[] buttonTextArray = new string[4];

        public static Control BuildTextbox;
        public static Control VersionTextbox;

        public enum Icon
        {
            Error,
            Exclamation,
            Information,
            Question,
            Nothing
        }
        public enum Type
        {
            ComboBox,
            TextBox,
            Nothing
        }
        public enum Buttons
        {
            Ok,
            OkCancel,
            YesNo,
            YesNoCancel
        }
        public enum Language
        {
            Czech,
            English,
            German,
            Slovakian,
            Spanish
        }

        public class InputBoxResult
        {
            public string BuildID;
            public string VersionNumber;

            public InputBoxResult() 
            { 
            }

            public InputBoxResult(string buildId, string version)
            {
                this.BuildID = buildId;
                this.VersionNumber = version;
            }

        }

        /// <summary>
        /// This form is like a MessageBox, but you can select type of controls on it. 
        /// This form returning a DialogResult value.
        /// </summary>
        /// <param name="Message">Message in dialog(as System.String)</param>
        /// <param name="Title">Title of dialog (as System.String)</param>
        /// <param name="icon">Select icon (as InputBox.Icon)</param>
        /// <param name="buttons">Select icon (as InputBox.Buttons)</param>
        /// <param name="type">Type of control in Input box (as InputBox.Type)</param>
        /// <param name="ListItems">Array of ComboBox items (as System.String[])</param>
        /// <param name="FormFont">Font in form (as System.Drawing.Font)</param>
        /// <returns></returns>
        /// 
        public static DialogResult ShowDialog(string Message, string Message2, string Title = "",
        Icon icon = Icon.Information, Buttons buttons = Buttons.Ok, Type type = Type.Nothing,
        string[] ListItems = null, bool ShowInTaskBar = false, Font FormFont = null)
        {
            frm.Controls.Clear();
            ResultValue = "";
            //Form definition
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            frm.Size = new System.Drawing.Size(350, 270);
            frm.Text = Title;
            frm.ShowIcon = false;
            frm.ShowInTaskbar = ShowInTaskBar;
            frm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(frm_FormClosing);
            frm.StartPosition = FormStartPosition.CenterParent;
            //Panel definition
            Panel panel = new Panel();
            panel.Location = new Point(0, 0);
            panel.Size = new Size(340, 167);
            panel.BackColor = Color.White;
            frm.Controls.Add(panel);
            //TODO: Add icon in to panel
            ///panel.Controls.Add(Picture(icon));
            //Label definition (message)
            Label buildLabel = new Label();
            buildLabel.Text = Message;
            buildLabel.Size = new Size(325, 40);
            buildLabel.Location = new Point(30, 10);
            buildLabel.TextAlign = ContentAlignment.MiddleLeft;
            panel.Controls.Add(buildLabel);

            Label txtLabel = new Label();
            txtLabel.Text = ".txt";
            txtLabel.Size = new Size(60, 40);
            txtLabel.Location = new Point(210, 45);
            txtLabel.TextAlign = ContentAlignment.MiddleLeft;
            panel.Controls.Add(txtLabel);

            Label versionLabel = new Label();
            versionLabel.Text = Message2;
            versionLabel.Size = new Size(325, 40);
            versionLabel.Location = new Point(30, 80);
            versionLabel.TextAlign = ContentAlignment.MiddleLeft;
            panel.Controls.Add(versionLabel);

            //Add ComboBox or TextBox to the form
            BuildTextbox = Cntrl(type, ListItems, new Size(180, 22), new Point(30, 50));
            panel.Controls.Add(BuildTextbox);

            VersionTextbox = Cntrl(type, ListItems, new Size(100, 22), new Point(30, 120));
            panel.Controls.Add(VersionTextbox);
            //Get automatically cursor to the TextBox
            if (BuildTextbox.Name == "textBox")
            {
                frm.ActiveControl = BuildTextbox;
            }
                
            //Set label font
            if (FormFont != null)
            {
                buildLabel.Font = FormFont;
                versionLabel.Font = FormFont;
            }

            //Add buttons to the form
            foreach (Button btn in Btns(buttons))
            {
                frm.Controls.Add(btn);
            }   

            frm.ShowDialog();
            //Return text value
            switch (type)
            {
                case Type.Nothing:
                    break;
                default:
                    if (DialogRes == DialogResult.OK || DialogRes == DialogResult.Yes)
                    { 
                        ResultValue = BuildTextbox.Text + "+" + VersionTextbox.Text;
                    }
                    else ResultValue = "";
                    break;
            }
            return DialogRes;
        }
        private static void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Name)
            {
                case "Yes":
                    DialogRes = DialogResult.Yes;
                    break;
                case "No":
                    DialogRes = DialogResult.No;
                    break;
                case "Cancel":
                    DialogRes = DialogResult.Cancel;
                    break;
                default:
                    DialogRes = DialogResult.OK;
                    break;
            }
            frm.Close();
        }

        private static void buttonVerify_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Name)
            {
                case "OK":
                    bool hasError = false;
                    if (!Regex.Match(BuildTextbox.Text, "^[a-zA-Z0-9]{16}$").Success)
                    {
                        MessageBox.Show("Invalid build id format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        hasError = true;
                    }
                    if (!Regex.Match(VersionTextbox.Text, @"\d{1}\.\d{1}\.\d{1}").Success)
                    {
                        MessageBox.Show("Invalid version number format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        hasError = true;
                    }
                    
                    if(!hasError)
                    {
                        DialogRes = DialogResult.Yes;
                    }
                    
                    break;
                default:
                    DialogRes = DialogResult.OK;
                    break;
            }
            frm.Close();
        }

        private static void textBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogRes = DialogResult.OK;
                frm.Close();
            }
        }
        private static void frm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (DialogRes != null) { 
                // Closing doing nothing
            }
            else DialogRes = DialogResult.None;
        }
        private static PictureBox Picture(Icon icon)
        {
            System.Windows.Forms.PictureBox picture = new System.Windows.Forms.PictureBox();
            var assembly = Assembly.GetExecutingAssembly();     //Get integrated sources
            System.IO.Stream stream = null;
            //Set icon
            switch (icon)
            {
                case Icon.Error:
                    stream = assembly.GetManifestResourceStream(@"MsgBox.error.png");
                    break;
                case Icon.Exclamation:
                    stream = assembly.GetManifestResourceStream(@"MsgBox.exclamation.png");
                    break;
                case Icon.Information:
                    stream = assembly.GetManifestResourceStream(@"MsgBox.information.png");
                    break;
                case Icon.Question:
                    stream = assembly.GetManifestResourceStream(@"MsgBox.question.png");
                    break;
                case Icon.Nothing:
                    stream = assembly.GetManifestResourceStream(@"MsgBox.nic80x80.png");
                    break;
            }
            picture.Image = System.Drawing.Image.FromStream(stream);
            picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picture.Size = new System.Drawing.Size(60, 60);
            picture.Location = new System.Drawing.Point(10, 10);
            return picture;
        }
        private static Button[] Btns(Buttons button, Language lang = Language.English)
        {
            //Buttons field for return
            System.Windows.Forms.Button[] returnButtons = new Button[3];
            //Buttons instances
            System.Windows.Forms.Button OkButton = new System.Windows.Forms.Button();            
            System.Windows.Forms.Button StornoButton = new System.Windows.Forms.Button();
            System.Windows.Forms.Button AnoButton = new System.Windows.Forms.Button();
            System.Windows.Forms.Button NeButton = new System.Windows.Forms.Button();
            //Set buttons names and text
            OkButton.Text = buttonTextArray[0];
            OkButton.Name = "OK";
            AnoButton.Text = buttonTextArray[1];
            AnoButton.Name = "Yes";
            NeButton.Text = buttonTextArray[2];
            NeButton.Name = "No";
            StornoButton.Text = buttonTextArray[3];
            StornoButton.Name = "Cancel";
            //Set buttons position
            switch (button)
            {
                case Buttons.Ok:
                    OkButton.Location = new System.Drawing.Point(250, 191);
                    OkButton.Size = new System.Drawing.Size(74, 31);
                    returnButtons[0] = OkButton;
                    break;
                case Buttons.OkCancel:
                    OkButton.Location = new System.Drawing.Point(160, 181);
                    OkButton.Size = new System.Drawing.Size(174, 51);
                    returnButtons[0] = OkButton;
                    StornoButton.Location = new System.Drawing.Point(250, 181);
                    StornoButton.Size = new System.Drawing.Size(74, 51);
                    returnButtons[1] = StornoButton;
                    break;
                case Buttons.YesNo:
                    AnoButton.Location = new System.Drawing.Point(160, 191);
                    AnoButton.Size = new System.Drawing.Size(74, 31);
                    returnButtons[0] = AnoButton;
                    NeButton.Location = new System.Drawing.Point(250, 191);
                    NeButton.Size = new System.Drawing.Size(74, 31);
                    returnButtons[1] = NeButton;
                    break;
                case Buttons.YesNoCancel:
                    AnoButton.Location = new System.Drawing.Point(70, 191);
                    AnoButton.Size = new System.Drawing.Size(74, 31);
                    returnButtons[0] = AnoButton;
                    NeButton.Location = new System.Drawing.Point(160, 191);
                    NeButton.Size = new System.Drawing.Size(74, 31);
                    returnButtons[1] = NeButton;
                    StornoButton.Location = new System.Drawing.Point(250, 191);
                    StornoButton.Size = new System.Drawing.Size(74, 31);
                    returnButtons[2] = StornoButton;
                    break;
            }
            //Set size and event for all used buttons
            foreach (Button btn in returnButtons)
            {
                
                if (btn != null)
                {
                    if (button == Buttons.OkCancel  && btn.Name == "OK")
                    {
                        btn.Size = new System.Drawing.Size(75, 31);
                        btn.Click += new System.EventHandler(buttonVerify_Click);
                        
                    }
                    else
                    {
                        btn.Size = new System.Drawing.Size(75, 31);
                        btn.Click += new System.EventHandler(button_Click);
                    }                    
                }
            }
            return returnButtons;
        }
        private static Control Cntrl(
            Type type,
            string[] ListItems, 
            Size size, 
            Point point)
        {
            //ComboBox
            System.Windows.Forms.ComboBox comboBox = new System.Windows.Forms.ComboBox();
            comboBox.Size = size;
            comboBox.Location = point;
            comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox.Name = "comboBox";
            if (ListItems != null)
            {
                foreach (string item in ListItems)
                    comboBox.Items.Add(item);
                comboBox.SelectedIndex = 0;
            }
            //Textbox
            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
            textBox.Size = size;
            textBox.Location = point;
            textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(textBox_KeyDown);
            textBox.Name = "textBox";
            //Set returned Control
            Control returnControl = new Control();
            switch (type)
            {
                case Type.ComboBox:
                    returnControl = comboBox;
                    break;
                case Type.TextBox:
                    returnControl = textBox;
                    break;
            }
            return returnControl;
        }
        public static void SetLanguage(Language lang)
        {
            switch (lang)
            {
                case Language.Czech:
                    buttonTextArray = "OK,Ano,Ne,Storno".Split(',');
                    break;
                case Language.German:
                    buttonTextArray = "OK,Ja,Nein,Stornieren".Split(',');
                    break;
                case Language.Spanish:
                    buttonTextArray = "OK,Sí,No,Cancelar".Split(',');
                    break;
                case Language.Slovakian:
                    buttonTextArray = "OK,Áno,Nie,Zrušit".Split(',');
                    break;
                default:
                    buttonTextArray = "OK,Yes,No,Cancel".Split(',');
                    break;
            }
        }
    }
}
