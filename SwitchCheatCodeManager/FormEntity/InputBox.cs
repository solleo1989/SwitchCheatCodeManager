using SwitchCheatCodeManager.Constant;
using SwitchCheatCodeManager.Properties;
using System;
using System.Drawing;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SwitchCheatCodeManager
{
    public class DialogueButton : Button
    {
        public DialogueButton(string name, string text)
        { 
            this.Name = name;
            this.Text = text;
        }
    }

    public class InputBox
    {
        private static Form frm = new Form();
        public static string ResultValue;
        private static DialogResult DialogRes;
        private static string[] buttonTextArray = { 
            Resources.DIALOGUE_BUTTON_TEXT_OK,
            Resources.DIALOGUE_BUTTON_TEXT_YES,
            Resources.DIALOGUE_BUTTON_TEXT_NO,
            Resources.DIALOGUE_BUTTON_TEXT_CANCEL
        };

        public static Control GameNameTextbox;
        public static Control GameIdTextbox;
        public static Control BuildIdTextbox;
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

        public class InputBoxResult
        {
            public string GameName;
            public string GameID;
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
        /// Add a MessageBox form for game name, game ID and build ID input dialog.
        /// This is used for insert new cheat code scenario.
        /// </summary>
        /// <param name="title">title of dialog (as System.String)</param>
        /// <param name="gameNameLabelMessage">message in dialog(as System.String)</param>
        /// <param name="gameIdLabelMessage">message in dialog(as System.String)</param>
        /// <param name="buildIdLabelMessage">message in dialog(as System.String)</param>
        /// <param name="buttons">Select icon (as InputBox.Buttons)</param>
        /// <param name="formFont">Font in form (as Font)</param>
        /// <returns>A DialogResult</returns>        
        public static DialogResult ShowGameIdBuildIdDialog(
            string title,
            string gameNameLabelMessage,
            string gameIdLabelMessage,
            string buildIdLabelMessage,
            Buttons buttons = Buttons.Ok,
            Font formFont = null)
        {
            InitializeForm(title, new Size(520, 320));
            Panel panel = CreateDefaultPanel();
            frm.Controls.Add(panel);

            //Label definition (message)
            Label gameNameLabel = new Label();
            gameNameLabel.Text = gameNameLabelMessage;
            gameNameLabel.Size = new Size(70, 40);
            gameNameLabel.Location = new Point(20, 30);
            gameNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            panel.Controls.Add(gameNameLabel);

            Label gameIdLabel = new Label();
            gameIdLabel.Text = gameIdLabelMessage;
            gameIdLabel.Size = new Size(70, 40);
            gameIdLabel.Location = new Point(20, 80);
            gameIdLabel.TextAlign = ContentAlignment.MiddleLeft;
            panel.Controls.Add(gameIdLabel);

            Label buildIdLabel = new Label();
            buildIdLabel.Text = buildIdLabelMessage;
            buildIdLabel.Size = new Size(70, 40);
            buildIdLabel.Location = new Point(20, 130);
            buildIdLabel.TextAlign = ContentAlignment.MiddleLeft;
            panel.Controls.Add(buildIdLabel);

            // Add input textbox
            GameNameTextbox = ControlItem(Type.TextBox, null, new Size(350, 22), new Point(90, 30));
            ((TextBox)GameNameTextbox).MaxLength = 100;
            ((TextBox)GameNameTextbox).PlaceholderText = Resources.INSERT_GAME_BUILD_DIALOGUE_GAMENAME_PLACEHOLDER_MESSAGE;
            panel.Controls.Add(GameNameTextbox);

            GameIdTextbox = ControlItem(Type.TextBox, null, new Size(350, 22), new Point(90, 80));
            ((TextBox)GameIdTextbox).PlaceholderText = Resources.INSERT_GAME_BUILD_DIALOGUE_GAMEID_PLACEHOLDER_MESSAGE;
            panel.Controls.Add(GameIdTextbox);

            BuildIdTextbox = ControlItem(Type.TextBox, null, new Size(350, 22), new Point(90, 130));
            ((TextBox)BuildIdTextbox).PlaceholderText = Resources.INSERT_GAME_BUILD_DIALOGUE_BUILDID_PLACEHOLDER_MESSAGE;
            panel.Controls.Add(BuildIdTextbox);

            //Set label font
            if (formFont != null)
            {
                gameNameLabel.Font = formFont;
                gameIdLabel.Font = formFont;
                buildIdLabel.Font = formFont;
            }

            //Add buttons to the form
            foreach (Button btn in ButtonItems(buttons))
            {
                if (btn != null)
                {
                    btn.Size = new Size(90, 50);
                    btn.Click += new EventHandler(button_Click);
                }
                frm.Controls.Add(btn);
            }

            frm.ShowDialog();
            //Return text value
            if (DialogRes == DialogResult.OK || DialogRes == DialogResult.Yes)
            {
                ResultValue = GameNameTextbox.Text + "??" + GameIdTextbox.Text + "??" + BuildIdTextbox.Text;
            }
            return DialogRes;
        }

        /// <summary>
        /// Add a MessageBox form for build ID and version number input dialog.
        /// This could be used for insert and update/edit scenarios.
        /// </summary>
        /// <param name="title">title of dialog (as System.String)</param>
        /// <param name="buildIdLabelmessage">message in dialog(as System.String)</param>
        /// <param name="versionLabelmessage">message in dialog(as System.String)</param>
        /// <param name="icon">Select icon (as InputBox.Icon)</param>
        /// <param name="buttons">Select icon (as InputBox.Buttons)</param>
        /// <param name="formFont">Font in form (as Font)</param>
        /// <returns></returns>
        /// 
        public static DialogResult ShowBuildIDVersionDialog(
            string title,
            string buildIdLabelmessage,
            string versionLabelmessage,
            Icon icon = Icon.Information,
            Buttons buttons = Buttons.Ok,
            Font formFont = null,
            string buildPlaceholder = null,
            string versionPlaceholder = null)
        {
            InitializeForm(title, new Size(470, 320));            
            Panel panel = CreateDefaultPanel();
            frm.Controls.Add(panel);

            //Label definition (message)
            Label buildLabel = new Label();
            buildLabel.Text = buildIdLabelmessage;
            buildLabel.Size = new Size(385, 40);
            buildLabel.Location = new Point(30, 10);
            buildLabel.TextAlign = ContentAlignment.MiddleLeft;
            panel.Controls.Add(buildLabel);

            Label txtLabel = new Label();
            txtLabel.Text = Constants.TXT_FILE_SUFFIX;
            txtLabel.Size = new Size(60, 40);
            txtLabel.Location = new Point(280, 45);
            txtLabel.TextAlign = ContentAlignment.MiddleLeft;
            panel.Controls.Add(txtLabel);

            Label versionLabel = new Label();
            versionLabel.Text = versionLabelmessage;
            versionLabel.Size = new Size(345, 40);
            versionLabel.Location = new Point(30, 80);
            versionLabel.TextAlign = ContentAlignment.MiddleLeft;
            panel.Controls.Add(versionLabel);

            //Add ComboBox or TextBox to the form
            BuildIdTextbox = ControlItem(Type.TextBox, null, new Size(300, 22), new Point(30, 50));
            ((TextBox)BuildIdTextbox).Text = !string.IsNullOrEmpty(buildPlaceholder) ? buildPlaceholder : string.Empty;
            panel.Controls.Add(BuildIdTextbox);

            VersionTextbox = ControlItem(Type.TextBox, null, new Size(170, 22), new Point(30, 120));
            ((TextBox)VersionTextbox).Text = !string.IsNullOrEmpty(buildPlaceholder) ? versionPlaceholder : string.Empty;
            panel.Controls.Add(VersionTextbox);            

            //Set label font
            if (formFont != null)
            {
                buildLabel.Font = formFont;
                versionLabel.Font = formFont;
            }

            //Add buttons to the form
            foreach (Button btn in ButtonItems(buttons))
            {
                if (btn != null)
                {
                    if (btn.Name == "OK")
                    {
                        btn.Size = new Size(90, 50);
                        btn.Click += new EventHandler(buttonVerify_Click);

                    }
                    else
                    {
                        btn.Size = new Size(90, 50);
                        btn.Click += new EventHandler(button_Click);
                    }
                }
                frm.Controls.Add(btn);
            }

            frm.ShowDialog();
            //Return text value
            if (DialogRes == DialogResult.OK || DialogRes == DialogResult.Yes)
            {
                ResultValue = BuildIdTextbox.Text + "??" + VersionTextbox.Text;
            }

            return DialogRes;
        }

        /// <summary>
        /// Add a MessageBox form for sub-section input dialog. 
        /// </summary>
        /// <param name="title">title of dialog (as System.String)</param>
        /// <param name="message">message in dialog(as System.String)</param>
        /// <param name="icon">Select icon (as InputBox.Icon)</param>
        /// <param name="buttons">Select icon (as InputBox.Buttons)</param>
        /// <param name="font">Font in form (as Font)</param>
        /// <returns>Result from the user action.</returns>
        public static DialogResult InputSubSectionNameDialog(
            string title,
            string message,
            Icon icon = Icon.Information,
            Buttons buttons = Buttons.Ok,
            Font font = null)
        {
            InitializeForm(title, new Size(550, 320));
            Panel panel = CreateDefaultPanel();
            frm.Controls.Add(panel);

            //Label definition (message)
            Label textLabel = new Label();
            textLabel.Font = font != null ? font : null;
            textLabel.Text = message;
            textLabel.Size = new Size(385, 40);
            textLabel.Location = new Point(30, 50);
            textLabel.TextAlign = ContentAlignment.MiddleLeft;
            panel.Controls.Add(textLabel);

            BuildIdTextbox = ControlItem(Type.TextBox, null, new Size(460, 30), new Point(30, 100));
            panel.Controls.Add(BuildIdTextbox);
            frm.ActiveControl = BuildIdTextbox;

            //Add buttons to the form
            foreach (Button btn in ButtonItems(buttons))
            {
                if (btn != null)
                {
                    btn.Size = new Size(90, 50);
                    btn.Click += new EventHandler(button_Click);
                }
                frm.Controls.Add(btn);
            }

            frm.ShowDialog();
            if (DialogRes == DialogResult.OK || DialogRes == DialogResult.Yes)
            {
                ResultValue = BuildIdTextbox.Text;
            }
            return DialogRes;
        }

        /// <summary>
        /// Add a MessageBox form for sub-section input dialog. 
        /// </summary>
        /// <param name="title">title of dialog (as System.String)</param>
        /// <param name="message">message in dialog(as System.String)</param>
        /// /// <param name="message">previous sub section name(as System.String)</param>
        /// <param name="icon">Select icon (as InputBox.Icon)</param>
        /// <param name="buttons">Select icon (as InputBox.Buttons)</param>
        /// <param name="font">Font in form (as Font)</param>
        /// <returns>Result from the user action.</returns>
        public static DialogResult UpdateSubSectionNameDialog(
            string title,
            string message,
            string sectionName,
            Icon icon = Icon.Information,
            Buttons buttons = Buttons.Ok,
            Font font = null)
        {
            InitializeForm(title, new Size(550, 320));
            Panel panel = CreateDefaultPanel();
            frm.Controls.Add(panel);

            //Label definition (message)
            Label textLabel = new Label();
            textLabel.Font = font != null ? font : null;
            textLabel.Text = message;
            textLabel.Size = new Size(385, 40);
            textLabel.Location = new Point(30, 50);
            textLabel.TextAlign = ContentAlignment.MiddleLeft;
            panel.Controls.Add(textLabel);

            BuildIdTextbox = ControlItem(Type.TextBox, null, new Size(460, 30), new Point(30, 100));
            ((TextBox)BuildIdTextbox).Text = sectionName;
            panel.Controls.Add(BuildIdTextbox);
            frm.ActiveControl = BuildIdTextbox;

            //Add buttons to the form
            foreach (Button btn in ButtonItems(buttons))
            {
                if (btn != null)
                {
                    btn.Size = new Size(90, 50);
                    btn.Click += new EventHandler(button_Click);
                }
                frm.Controls.Add(btn);
            }

            frm.ShowDialog();
            if (DialogRes == DialogResult.OK || DialogRes == DialogResult.Yes)
            {
                ResultValue = BuildIdTextbox.Text;
            }
            return DialogRes;
        }

        private static void InitializeForm(string title, Size size)
        {
            frm.Controls.Clear();

            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.FormBorderStyle = FormBorderStyle.FixedDialog;
            frm.Size = size;
            frm.ShowIcon = false;
            frm.ShowInTaskbar = true;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Text = title;
            frm.FormClosing += new FormClosingEventHandler(frm_FormClosing);

            ResultValue = "";
        }

        private static Panel CreateDefaultPanel()
        {
            Panel panel = new Panel();
            panel.Location = new Point(0, 0);
            panel.Size = new Size(530, 180);
            panel.BackColor = Color.White;
            //TODO: Add icon in to panel
            //panel.Controls.Add(Picture(Icon.Information));
            return panel;
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
                    
                    if (BuildIdTextbox.Text?.Length > 0 && !Regex.Match(BuildIdTextbox.Text, "^[a-fA-F0-9]{16}$").Success)
                    {
                        MessageBox.Show(Resources.DEFAULT_INSERT_NEW_CHEAT_FILE_NAME_INVALID_MESSAGE, 
                            Resources.ERROR_MESSAGE_TITLE_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        hasError = true;
                    }
                    if (VersionTextbox.Text?.Length > 0 && !Regex.Match(VersionTextbox.Text, @"\d{1}\.\d{1,3}\.\d{1,10}").Success)
                    {
                        MessageBox.Show(Resources.DEFAULT_INSERT_NEW_CHEAT_VERSION_NAME_INVALID_MESSAGE, 
                            Resources.ERROR_MESSAGE_TITLE_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        hasError = true;
                    }

                    if (!hasError)
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

        private static void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogRes = DialogResult.OK;
                frm.Close();
            }
        }
        private static void frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogRes != null)
            {
                // Closing doing nothing
            }
            else DialogRes = DialogResult.None;
        }
        private static PictureBox Picture(Icon icon)
        {
            PictureBox picture = new PictureBox();
            var assembly = Assembly.GetExecutingAssembly();
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
            picture.Image = Image.FromStream(stream);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.Size = new Size(60, 60);
            picture.Location = new Point(10, 10);
            return picture;
        }
        
        private static Button[] ButtonItems(Buttons button)
        {
            //Buttons field for return
            Button[] returnButtons = new Button[3];
            //Buttons instances
            Button OkButton = new DialogueButton("OK", buttonTextArray[0]);
            Button StornoButton = new DialogueButton("Cancel", buttonTextArray[3]);
            Button AnoButton = new DialogueButton("Yes", buttonTextArray[1]);
            Button NeButton = new DialogueButton("No", buttonTextArray[2]);
            //Set buttons position
            switch (button)
            {
                case Buttons.Ok:
                    OkButton.Location = new Point(250, 190);
                    OkButton.Size = new Size(120, 80);
                    returnButtons[0] = OkButton;
                    break;
                case Buttons.OkCancel:
                    OkButton.Location = new Point(150, 190);
                    OkButton.Size = new Size(120, 80);
                    returnButtons[0] = OkButton;
                    StornoButton.Location = new Point(250, 190);
                    StornoButton.Size = new Size(120, 80);
                    returnButtons[1] = StornoButton;
                    break;
                case Buttons.YesNo:
                    AnoButton.Location = new Point(150, 190);
                    AnoButton.Size = new Size(120, 80);
                    returnButtons[0] = AnoButton;
                    NeButton.Location = new Point(250, 190);
                    NeButton.Size = new Size(120, 80);
                    returnButtons[1] = NeButton;
                    break;
                case Buttons.YesNoCancel:
                    AnoButton.Location = new Point(50, 190);
                    AnoButton.Size = new Size(120, 80);
                    returnButtons[0] = AnoButton;
                    NeButton.Location = new Point(150, 190);
                    NeButton.Size = new Size(120, 80);
                    returnButtons[1] = NeButton;
                    StornoButton.Location = new Point(250, 190);
                    StornoButton.Size = new Size(120, 80);
                    returnButtons[2] = StornoButton;
                    break;
            }

            return returnButtons;
        }

        private static Control ControlItem(
            Type type,
            string[] listItems,
            Size size,
            Point point)
        {
            Control returnControl = new Control();
            switch (type)
            {
                case Type.ComboBox:
                    //ComboBox
                    ComboBox comboBox = new ComboBox();
                    comboBox.Size = size;
                    comboBox.Location = point;
                    comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBox.Name = "comboBox";
                    if (listItems != null)
                    {
                        foreach (string item in listItems)
                            comboBox.Items.Add(item);
                        comboBox.SelectedIndex = 0;
                    }
                    returnControl = comboBox;
                    break;
                case Type.TextBox:
                    //Textbox
                    TextBox textBox = new TextBox();
                    textBox.Size = size;
                    textBox.Location = point;
                    textBox.KeyDown += new KeyEventHandler(textBox_KeyDown);
                    textBox.Name = "textBox";
                    textBox.MaxLength = 29;
                    returnControl = textBox;
                    break;
            }
            return returnControl;
        }

    }
}
