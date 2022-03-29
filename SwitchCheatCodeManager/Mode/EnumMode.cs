using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCheatCodeManager.Mode
{
    public  class EnumMode
    {
        public enum Language
        {
            English,
            Spanish,
            Chinese
        }
        public enum DirectoryMode 
        {
            OtherMode = 0,
            SingleMode = 1,
            ListMode = 2,
        }
        public enum VersionFileMode 
        { 
            Creat, 
            Edit, 
            Update,
            None
        };

        public static string VersionFileModeText(VersionFileMode mode) =>
        mode switch
        {
            VersionFileMode.Creat => "Creat",
            VersionFileMode.Edit => "Edit",
            VersionFileMode.Update => "Update",
            VersionFileMode.None => "Invalid",
            _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(mode)),
        };
    }
}
