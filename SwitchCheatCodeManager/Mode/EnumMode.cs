using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwitchCheatCodeManager.Constant;
using SwitchCheatCodeManager.Model;
using SwitchCheatCodeManager.Properties;

namespace SwitchCheatCodeManager.Mode
{
    public  class EnumMode
    {
        public enum Language
        {
            NotSet = -1,
            English = 0,
            Chinese = 1,
            Japanese = 2,
        }
        
        public enum DirectoryMode 
        {
            OtherMode = 0,
            SingleMode = 1,
            ListMode = 2,
        }
        public enum VersionFileMode 
        { 
            Create, 
            Edit, 
            Update,
            None
        };

        public static string VersionFileModeText(VersionFileMode mode) =>
        mode switch
        {
            VersionFileMode.Create => Resources.VersionFileModeCreateButton_Text,
            VersionFileMode.Edit => Resources.VersionFileModeEditButton_Text,
            VersionFileMode.Update => Resources.VersionFileModeUpdateButton_Text,
            VersionFileMode.None => "Invalid",
            _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(mode)),
        };
    }
}
