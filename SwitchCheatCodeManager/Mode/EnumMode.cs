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

        public enum ASMOperationType
        { 
            StoreStaticValueToMemory = 0,
            BeginConditionalBlock = 1,
            EndConditionalBlock = 2,
            LoopStartEnd = 3,
            LoadRegisterWithStaticValue = 4,
            LoadRegisterWithMemoryValue = 5,
            StoreStaticValueToRegister = 6,
            ApplyLegacyArithmeticOperation = 7,
            ButtonActivatorBlock = 8,
            ApplyArithmeticOperationToRegister = 9,
            StoreRegisterToMemoryAddress = 10,
        }
    }
}
