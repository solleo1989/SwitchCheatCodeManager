using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwitchCheatCodeManager.Constant;

namespace SwitchCheatCodeManager.CheatCode
{
    public class ConfigSettings
    {
        public string InputFolder { get; set; }
        public string OutputFolder { get; set; }
        public bool HasInputFolder() => !string.IsNullOrEmpty(InputFolder);
        public bool HasOutputFolder() => !string.IsNullOrEmpty(OutputFolder);

        public ConfigSettings()
        {
            this.InputFolder = string.Empty;
            this.OutputFolder = string.Empty;
        }

        public string Output()
        {
            return 
                $"{Constants.DEFAULT_INPUT_PATH_PREFIX}{InputFolder}{Environment.NewLine}" +
                $"{Constants.DEFAULT_OUTPUT_PATH_PREFIX}{OutputFolder}{Environment.NewLine}";
        }
    }
}
