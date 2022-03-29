using System;
using System.Collections.Generic;
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
            string text = (item == null) ? "(null)" : item.ToString();
            using (var brush = new System.Drawing.SolidBrush(e.ForeColor))
            {
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                var newBounds = e.Bounds;
                newBounds = new System.Drawing.Rectangle(
                    e.Bounds.X + 20,
                    e.Bounds.Y + 3,
                    e.Bounds.Width,
                    e.Bounds.Height);
                e.Graphics.DrawString(text, e.Font, brush, newBounds);
            }
        }
    }
}
