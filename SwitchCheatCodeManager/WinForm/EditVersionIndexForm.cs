using SwitchCheatCodeManager.Comparator;
using SwitchCheatCodeManager.Helper;
using SwitchCheatCodeManager.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SwitchCheatCodeManager.WinForm
{
    public partial class EditVersionIndexForm : Form
    {
        public Dictionary<string, string> Versions { get; set; }

        private FileInfo CurrentVersionFile;

        private MainHelper Helper;
        private ActionHelper Action;
        private CultureInfo Culture;

        public EditVersionIndexForm(
            MainHelper mainHelper,
            ActionHelper actionHelper,
            CultureInfo cultureInfo)
        {
            this.Helper = mainHelper;
            this.Action = actionHelper;
            this.Culture = cultureInfo;

            ResetCultureInfo();
            InitializeComponent();           

            this.Load += new EventHandler(Form_Load);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Keys keyOnly = keyData & ~Keys.Modifiers;
            Keys modifiersOnly = Control.ModifierKeys & (Keys.Shift | Keys.Control | Keys.Alt);
            if (modifiersOnly == 0)
            {
                // Key alone
            }
            else if ((modifiersOnly & Keys.Control) != 0)
            {
                // Control + key
                switch (keyOnly)
                {
                    case Keys.S:
                        SaveVersionFile();
                        return true;
                    case Keys.N:
                        AddANewRow();
                        return true;
                    case Keys.D:
                        DeleteSelectedRows();
                        return true;
                    default:
                        return base.ProcessCmdKey(ref msg, keyData);
                }
            }
            

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm() 
        {
            //SetupLayout();
            SetupDataGridView();
            PopulateDataGridView();
        }

        /// <summary>
        /// Formatting BuildId and Versions
        /// Todo: Need to format this function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VersionBuildIdDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e?.Value != null && this.VersionBuildIdDataGridView.Columns[e.ColumnIndex].Name == "Version")
            {
                try
                {
                    e.Value = DateTime.Parse(e.Value.ToString()).ToLongDateString();
                    e.FormattingApplied = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine(Resources.EDIT_VERSION_BUILD_FORM_ERROR_MESSAGE, e.Value.ToString());
                }
            }
        }

        private void SetupDataGridView()
        {
            this.VersionBuildIdDataGridView.Columns[0].Name = Resources.VersionBuildIdDataGridView_BuildId_Text;
            this.VersionBuildIdDataGridView.Columns[1].Name = Resources.VersionBuildIdDataGridView_Version_Text;
            this.VersionBuildIdDataGridView.Columns[1].DefaultCellStyle.Font = new Font(this.VersionBuildIdDataGridView.DefaultCellStyle.Font, FontStyle.Italic);
        }

        private void PopulateDataGridView()
        {
            var infoFile = MainForm.CurrentVersionFile;
            this.VersionBuildIdDataGridView.Rows.Clear();
            if (infoFile != null)
            {
                this.Versions = Action.LoadVersionFile(infoFile.FullName);
                this.CurrentVersionFile = infoFile;

                foreach (var kv in this.Versions)
                {
                    string[] row = { kv.Key.Trim().ToUpperInvariant(), kv.Value.Trim() };
                    this.VersionBuildIdDataGridView.Rows.Add(row);
                }
            }
        }

        /**
        private void SetupLayout()
        {
            //this.Size = new Size(300, 500);
        }*/

        private void SaveVersionFile()
        {
            if (this.VersionBuildIdDataGridView.Rows.Count >= 0)
            {
                this.Versions = new Dictionary<string, string>();
                var temp = new Dictionary<string, string>();
                foreach (DataGridViewRow row in this.VersionBuildIdDataGridView.Rows)
                {
                    if (!String.IsNullOrEmpty((string)row.Cells[0].Value))
                    {
                        this.Versions.Add((string)row.Cells[0].Value, (string)row.Cells[1].Value);
                    }
                }

                // Sort version number
                var orderedValues = OrderVersionFileList(this.Versions).ToArray();
                var contents = new StringBuilder();
                for (var i = 0; i < orderedValues.Count(); i++)
                {
                    string line = this.Versions.First(kv => kv.Value.Equals(orderedValues[i])).Key + "\t" + orderedValues[i];
                    contents.Append(line + "\n");
                }
                foreach (var kv in this.Versions)
                {
                    if (!orderedValues.Contains(kv.Value))
                    { 
                        string line = kv.Key + "\t" + kv;
                        contents.Append(line + "\n");
                    }
                }
                if (this.CurrentVersionFile != null)
                {
                    using (StreamWriter sw = new StreamWriter(File.Open(this.CurrentVersionFile.FullName, FileMode.Create), Encoding.ASCII))
                    {
                        sw.Write(contents);
                    }
                }

                this.Close();
            }
        }

        private void AddANewRow()
        {
            this.VersionBuildIdDataGridView.Rows.Add();
        }

        /// <summary>
        /// Delete selected rows, they could be multiple rows.
        /// </summary>
        private void DeleteSelectedRows()
        {
            var deletedRows = new HashSet<int>();
            if (this.VersionBuildIdDataGridView.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell selectedCell in this.VersionBuildIdDataGridView.SelectedCells)
                {
                    deletedRows.Add(selectedCell.RowIndex);
                }
                var sortedArray = deletedRows.ToArray();

                Array.Sort(sortedArray);
                Array.Reverse(sortedArray);
                if (sortedArray.Length > 0)
                {
                    for (var i = 0; i < sortedArray.Length; i++)
                    {
                        if (sortedArray[i] < this.VersionBuildIdDataGridView.Rows.Count - 1)
                        {
                            this.VersionBuildIdDataGridView.Rows.RemoveAt(sortedArray[i]);
                        }
                    }
                }
            }
        }

        #region Actions

        private void SaveButton_Click(object sender, EventArgs e) => SaveVersionFile();

        private void AddRowButton_Click(object sender, EventArgs e) => AddANewRow();
        
        private void DeleteRowButton_Click(object sender, EventArgs e) => DeleteSelectedRows();
        #endregion

        private IEnumerable<string> OrderVersionFileList(IDictionary<string, string> versions, bool isDescendingOrder = false)
        {
            List<string> values = new List<string>();
            values.AddRange(versions.Values);
            var orderedValues = values.OrderBy(v => v, new VersionComparator()).ToArray();

            if (isDescendingOrder)
            {
                orderedValues = orderedValues.Reverse().ToArray();
            }

            return orderedValues;
        }

        private void ResetCultureInfo()
        {
            Thread.CurrentThread.CurrentUICulture = this.Culture;
        }
    }
}
