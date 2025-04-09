using SwitchCheatCodeManager.Builder;
using SwitchCheatCodeManager.CheatCode;
using SwitchCheatCodeManager.Helper;
using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using Language = SwitchCheatCodeManager.Mode.EnumMode.Language;

namespace SwitchCheatCodeManager.WinForm
{
    public partial class SettingsForm : Form
    {
        public ConfigSettings Configs { get; set; }

        private MainHelper Helper;
        private ActionHelper Action;
        private CultureInfo Culture;
        private ColorBuilder Builder;

        public SettingsForm(
            MainHelper mainHelper,
            ActionHelper actionHelper,
            CultureInfo cultureInfo
            )
        {
            this.Helper = mainHelper;
            this.Action = actionHelper;
            this.Culture = cultureInfo;
            this.Configs = actionHelper.LoadDefinedPathsConfig();
            this.Builder = new ColorBuilder();

            ResetCultureInfo();
            InitializeComponent();
            InitializeConfigValues();
        }

        public void InitializeButtons()
        {

        }
        public void InitializeConfigValues()
        {
            // Paths
            this.InputPathTextBox.Text = Configs.InputFolder;
            this.OutputPathTextBox.Text = Configs.OutputFolder;

            // Colors
            SetTitleColor(this.Configs.TitleColor);
            SetTitleEnabledColor(this.Configs.TitleColorEnabled);
            SetSectionStartColor(this.Configs.SectionStartColor);
            SetSectionEndColor(this.Configs.SectionEndColor);

            // Language
            SetFormLanguage(this.Configs.FormLanguage);
            SetImagePreferred(this.Configs.ImagePreferred);
        }


        #region Click Events
        private void InputPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Configs.InputFolder = dialog.SelectedPath;
                this.InputPathTextBox.Text = dialog.SelectedPath;
            }
        }

        private void OutputPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Configs.OutputFolder = Helper.GetPath(dialog.SelectedPath);
                this.OutputPathTextBox.Text = dialog.SelectedPath;
            }
        }

        private void ColorTitleEnabledButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = false;
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                Configs.TitleColorEnabled = colorDlg.Color;
                SetTitleEnabledColor(colorDlg.Color);
            }
        }

        private void ColorTitleButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = false;
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                Configs.TitleColor = colorDlg.Color;
                SetTitleColor(colorDlg.Color);
            }
        }

        private void ColorSectionStartButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = false;
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                Configs.SectionStartColor = colorDlg.Color;
                SetSectionStartColor(colorDlg.Color);
            }
        }

        private void ColorSectionEndButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = false;
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                Configs.SectionEndColor = colorDlg.Color;
                SetSectionEndColor(colorDlg.Color);
            }
        }
        private void FromLanguageComboBox_Changed(object sender, EventArgs e)
        {
            Configs.FormLanguage = (Language)this.LanguageComboBox.SelectedIndex;
        }

        private void ImageCheckedListBox_Click(object sender, ItemCheckEventArgs e)
        {
            // Uncheck every other items once something checked            
            if (e.NewValue == CheckState.Unchecked)
            {
                // Uncheck behavior need set the language as NotSet                
                Configs.ImagePreferred = Language.NotSet;
            }
            else
            {
                for (int i = 0; i < this.ImageCheckedListBox.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        this.ImageCheckedListBox.SetItemChecked(i, false);
                    }
                }
                Configs.ImagePreferred = (Language)e.Index;
            }
        }
        private void ResetCultureInfo()
        {
            Thread.CurrentThread.CurrentUICulture = this.Culture;
        }
        #endregion

        #region Helper

        private void SetTitleEnabledColor(Color color)
        {
            this.ColorTitleEnabledLabel.BackColor = color;
            this.ColorTitleEnabledButton.Text = this.Builder.GetHexStrFromColor(color);
        }

        private void SetTitleColor(Color color)
        {
            this.ColorTitleLabel.BackColor = color;
            this.ColorTitleButton.Text = this.Builder.GetHexStrFromColor(color);
        }

        private void SetSectionStartColor(Color color)
        {
            this.ColorSectionStartLabel.BackColor = color;
            this.ColorSectionStartButton.Text = this.Builder.GetHexStrFromColor(color);
        }

        private void SetSectionEndColor(Color color)
        {

            this.ColorSectionEndLabel.BackColor = color;
            this.ColorSectionEndButton.Text = this.Builder.GetHexStrFromColor(color);
        }

        private void SetFormLanguage(Language lang)
        {
            switch (lang)
            {
                case Language.English:
                    this.LanguageComboBox.SelectedIndex = (int)Language.English;
                    break;
                case Language.Chinese:
                    this.LanguageComboBox.SelectedIndex = (int)Language.Chinese;
                    break;
                default:
                    break;
            }
        }

        private void SetImagePreferred(Language lang)
        {
            switch (lang)
            {
                case Language.English:
                    this.ImageCheckedListBox.SetItemChecked((int)Language.English, true);
                    break;
                case Language.Chinese:
                    this.ImageCheckedListBox.SetItemChecked((int)Language.Chinese, true);
                    break;
                case Language.Japanese:
                    this.ImageCheckedListBox.SetItemChecked((int)Language.Japanese, true);
                    break;
                default:
                    break;
            }
        }
        #endregion

    }
}
