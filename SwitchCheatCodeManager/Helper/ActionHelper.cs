using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;
using SwitchCheatCodeManager.CheatCode;
using Resources = SwitchCheatCodeManager.Properties.Resources;

namespace SwitchCheatCodeManager.Helper
{
    public class ActionHelper
    {
        //
        public void OpenGameDirectory(string path)
        {
            if (!String.IsNullOrEmpty(path))
            {
                Process.Start(Environment.GetEnvironmentVariable("WINDIR") + @"\explorer.exe", path);
            }
        }

        /// <summary>
        /// Open directory from a given image.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="image"></param>
        public void OpenGameDirectoryFromImage(string path, Image image)
        {
            if (String.IsNullOrEmpty(path))
            {
                return;
            }
            else if (image != null)
            {
                Process.Start("explorer.exe", path);
            }
            else
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Images (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";// + "All files (*.*)|*.*";
                    // Allow the user to select multiple images.
                    openFileDialog.Multiselect = true;
                    openFileDialog.Title = Resources.ChoosePreviewImagesOpenDialogue_Title;

                    DialogResult dr = openFileDialog.ShowDialog();                    
                    if (dr == System.Windows.Forms.DialogResult.OK)
                    {
                        MainHelper helper = new MainHelper();
                        var gameDir = helper.GetDirectoryPath(path);
                        // Read images files
                        foreach (String file in openFileDialog.FileNames)
                        {
                            FileInfo fi = new FileInfo(file);
                            fi.CopyTo(helper.GetPath(gameDir) + fi.Name);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Insert new game directory by given path.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public DirectoryInfo InsertNewDirectory(string path)
        {
            var dir = new DirectoryInfo(path);
            if (!dir.Exists)
            {
                dir.Create();
            }
            return dir;
        }

        /// <summary>
        /// Create a new cheat file.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="gameName"></param>
        /// <param name="version"></param>
        public void SaveNewCheatFile(string path, string gameName, string version)
        {
            using (StreamWriter sw = new StreamWriter(File.Open(path, FileMode.Create), Encoding.ASCII))
            {
                string title = $"[{gameName} v{version}]\r\n";

                sw.WriteLine(title);
            }
        }

        /// <summary>
        /// Create a new cheat index file.
        /// </summary>
        /// <param name="path"></param>
        public void SaveNewCheatIndexFile(string path)
        {
            using (StreamWriter sw = new StreamWriter(File.Open(path, FileMode.Create), Encoding.ASCII))
            {
                sw.WriteLine();
            }
        }

        /// <summary>
        /// Load version file and create a mapping for pid to version number.
        /// i.e. 3CA12DFAAF9C82DA   1.0.0
        ///      F5DCCDDB37E97724   1.2.0
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public Dictionary<string, string> LoadVersionFile(string path)
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                var items = line.Split("\t");
                if (items.Length == 2)
                {
                    map.Add(items[0], items[1]);
                }
            }
            return map;
        }

        /// <summary>
        /// Load the DB files from the provided DB file.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public IList<Games> LoadGamesDBFile(string path)
        {
            var file = new FileInfo(path + "\\GAMES.md");
            var games = new List<Games>();
            if (file.Exists)
            {
                string[] lines = File.ReadAllLines(file.FullName);
                foreach (string line in lines)
                {
                    if (line.StartsWith("|") && line.EndsWith("|"))
                    {
                        var parts = line.Split('|');
                        //i.e. | No | NAME | TITLE ID | BUILD ID |
                        if (parts.Length == 6 && !parts[1].Contains("---") && !parts[1].Contains("No"))
                        {
                            var game = new Games(parts[1].Trim(), parts[2].Trim(), parts[3].Trim(), parts[4].Trim());
                            games.Add(game);
                        }
                    }
                }
            }

            return games;
        }

        /// <summary>
        /// Helper to resize image
        /// </summary>
        /// <param name="imgToResize"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public Image ResizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
    }
}
