using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SwitchCheatCodeManager.FormEntity
{
    public class ComboBoxEx : ComboBox
    {
        public ComboBoxEx()
        {
            base.DropDownStyle = ComboBoxStyle.DropDownList;
            base.DrawMode = DrawMode.OwnerDrawFixed;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.State == DrawItemState.Focus)
                e.DrawFocusRectangle();
            var index = e.Index;
            if (index < 0 || index >= Items.Count)
            {
                return;
            }
            var item = Items[index];
            string text = item == null ? "(null)" : ((DropDownItem)item).Text;
            
            using (var brush = new SolidBrush(e.ForeColor))
            {
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                var newBounds = e.Bounds;
                newBounds = new Rectangle(
                    e.Bounds.X + 50,
                    e.Bounds.Y + 1,
                    e.Bounds.Width -50,
                    e.Bounds.Height);
                e.Graphics.DrawString(text, e.Font, brush, newBounds);

                if (item != null && ((DropDownItem)item).Image != null)
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawImage(((DropDownItem)item).Image,
                                         new Rectangle(
                                             e.Bounds.X + 1,
                                             e.Bounds.Y,
                                             e.Bounds.Height - 2,
                                             e.Bounds.Height - 2));
                }
                e.Graphics.DrawRectangle(Pens.LightGray, e.Bounds.X + 50, e.Bounds.Y , 
                    e.Bounds.Width - 52, e.Bounds.Height - 1);
            }
        }
    }
}
