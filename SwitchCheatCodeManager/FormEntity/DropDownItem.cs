using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchCheatCodeManager.FormEntity
{
    public class DropDownItem
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public override string ToString() { return Text; }

        public DropDownItem()
        { 
        }

        public DropDownItem(string value, string text)
        {
            this.Value = value;
            this.Text = text;
        }
    }
}
