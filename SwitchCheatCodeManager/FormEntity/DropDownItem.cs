using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace SwitchCheatCodeManager.FormEntity
{
    public class DropDownItem : UserControl
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public Image Image { get; set; }
        public override string ToString() { return Text; }

        public DropDownItem()
        { 
        }

        public DropDownItem(string value, string text)
        {
            this.Value = value;
            this.Text = text;
            this.Image = new Bitmap(50, 50);
        }

        public DropDownItem(string value, string text, FileInfo image) : this(value, text)
        {
            if (image != null)
            {
                Image prevImg = Image.FromFile(image.FullName);                
                this.Image = ResizeImage(prevImg, new Size(50, 50));
            }
        }

        private Image ResizeImage(Image imgToResize, Size size) => (Image)(new Bitmap(imgToResize, size));
        
    }
}
