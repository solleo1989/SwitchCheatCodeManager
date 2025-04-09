using Microsoft.Win32;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static SwitchCheatCodeManager.Mode.EnumMode;

namespace SwitchCheatCodeManager.Helper
{
    public class ASMHelper
    {
        private string DefaultTemplate0 = "Write [{0}]byte(s) static value [{1}] to memory address on [{2}] with offset [{3}] at register [{4}]";
        private string DefaultTemplate1 = "Performs a [{0}] comparison of [{1}]byte(s) contents of memory on [{2}] with offset [{3}] to a static value [{4}].";
        private string DefaultTemplate2 = "Marks the [{0}] of a conditional block";
        private string DefaultTemplate3 = "Allows for [{0}] loop encoding for [{1}] number of times on register [{2}]";
        private string DefaultTemplate4 = "Allows setting a register [{0}] to a constant value [{1}]";
        private string[] MemString = { "Main NSO", "Heap", "Alias", "Aslr" };
        
        public ASMHelper() 
        { 
                
        }

        public string ToString(ASMOperationType type, string input)
        {
            switch (type) { 
                case ASMOperationType.StoreStaticValueToMemory:
                    // 0TMR00AA AAAAAAAA VVVVVVVV
                    // 0TMR00AA AAAAAAAA VVVVVVVV (VVVVVVVV)
                    // Write T(1/2/4/8 bytes) static value (VVVVVVVV)
                    // to memory address on (Main/Heap/Alias/Aslr)
                    // with offset (AA AAAAAAAA) at register R(0~F)
                    String  reg0 = 
                        "^0([1248]{1})([0123]{1})([0-9a-fA-F]{1})"  // 0TMR
                        + "00([0-9a-fA-F]{2})[\\s]{1}"              // 00AA_
                        + "([0-9a-fA-F]{8})[\\s]{1}"                // AAAAAAAA_
                        + "([0-9a-fA-F]{8}[\\s]{1}){0,1}"           // VVVVVVVV_ {0,1}
                        + "([0-9a-fA-F]{8})";                       // VVVVVVVV
                    
                    Regex re0 = new Regex(reg0);
                    Match m0 = re0.Match(input);
                    if (m0.Success)
                    {
                        string T = m0.Groups[1].Value;
                        int value = -1;
                        Int32.TryParse(m0.Groups[2].Value, out value);
                        string M = value < 0 ? string.Empty : MemString[value];                        
                        string R = m0.Groups[3].Value;
                        string A = m0.Groups[4].Value + m0.Groups[5].Value;
                        string V = string.IsNullOrEmpty(m0.Groups[6].Value)
                            ? m0.Groups[7].Value
                            : m0.Groups[6].Value.Trim() + m0.Groups[7].Value;
                        return string.Format(DefaultTemplate0, T, V, M, A, R);
                    }
                    return String.Empty;
                case ASMOperationType.BeginConditionalBlock:
                    // 1TMC00AA AAAAAAAA VVVVVVVV
                    // 1TMC00AA AAAAAAAA VVVVVVVV (VVVVVVVV)
                    // Performs a C(greater/greater or equal to/smaller/smaller or equal to/equal to/not euqal to) comparison of
                    // T(1/2/4/8 bytes) contents of memory on (Main/Heap/Alias/Aslr) with offset AAAA
                    // to a static value V.
                    string[] comparison = { 
                        "greater", "greater or equal to", 
                        "smaller", "smaller or equal to", 
                        "equal to", "not equal to"};
                    String reg1 =
                        "^1([1248]{1})([0123]{1})([1-6]{1})"        // 1TMC
                        + "00([0-9a-fA-F]{2})[\\s]{1}"              // 00AA_
                        + "([0-9a-fA-F]{8})[\\s]{1}"                // AAAAAAAA_
                        + "([0-9a-fA-F]{8}[\\s]{1}){0,1}"           // VVVVVVVV_ {0,1}
                        + "([0-9a-fA-F]{8})";                       // VVVVVVVV
                    Regex re1 = new Regex(reg1);
                    Match m1 = re1.Match(input);
                    if (m1.Success)
                    {
                        string T = m1.Groups[1].Value;
                        int value = -1;
                        Int32.TryParse(m1.Groups[2].Value, out value);
                        string M = value < 0 ? string.Empty : MemString[value];
                        value = -1;
                        Int32.TryParse(m1.Groups[3].Value, out value);
                        string C = comparison[value - 1];
                        string A = m1.Groups[4].Value + m1.Groups[5].Value;
                        string V = string.IsNullOrEmpty(m1.Groups[6].Value)
                            ? m1.Groups[7].Value
                            : m1.Groups[6].Value.Trim() + m1.Groups[7].Value;
                        return string.Format(DefaultTemplate1, C, T, M, A, V);
                    }
                    return String.Empty;
                case ASMOperationType.EndConditionalBlock:
                    // 2X000000
                    // X: End type(0 = End, 1 = Else).
                    // Marks the end/else of a conditional block
                    string[] condition = { "end", "else" };
                    String reg2 = "^2([01]{1})000000";
                    Regex re2 = new Regex(reg2);
                    Match m2 = re2.Match(input);
                    if (m2.Success)
                    {
                        int value = -1;
                        Int32.TryParse(m2.Groups[1].Value, out value);
                        string X = value < 0 ? string.Empty : condition[value];
                        return string.Format(DefaultTemplate2, X);
                    }
                    return string.Empty;
                case ASMOperationType.LoopStartEnd:
                    // Start Loop Encoding
                    //  300R0000 VVVVVVVV
                    // R: Register to use as loop counter.
                    // V: Number of iterations to loop.
                    // End Loop Encoding
                    //  310R0000
                    // Allows for start/end loop encoding for V number of times on register R.
                    string[] loopencoding = { "start", "end" };
                    String reg3 = "^3([01]{1})0([0-9a-fA-F]{1})0000"
                        + "([\\s]{1}[0-9a-fA-F]{8}){0,1}";           // VVVVVVVV {0,1}
                    Regex re3 = new Regex(reg3);
                    Match m3 = re3.Match(input);
                    if (m3.Success)
                    {
                        int value = -1;
                        Int32.TryParse(m3.Groups[1].Value, out value);
                        string L = value < 0 ? string.Empty : loopencoding[value];
                        string R = m3.Groups[2].Value;
                        string V = string.IsNullOrEmpty(m3.Groups[3].Value) ? "0" : m3.Groups[3].Value.Trim();
                        return string.Format(DefaultTemplate3, L, V, R);
                    }
                    return "";
                case ASMOperationType.LoadRegisterWithStaticValue:
                    // 400R0000 VVVVVVVV VVVVVVVV
                    // R: Register to use.
                    // V: Value to load.
                    // Allows setting a register R to a constant value VVVVVVVV VVVVVVVV.
                    String reg4 = "^400([0-9a-fA-F]{1})0000"
                        + "([\\s]{1}[0-9a-fA-F]{8}){1}"             // VVVVVVVV {1}
                        + "([\\s]{1}[0-9a-fA-F]{8}){1}";            // VVVVVVVV {1}
                    Regex re4 = new Regex(reg4);
                    Match m4 = re4.Match(input);
                    if (m4.Success)
                    {
                        string R = m4.Groups[1].Value;
                        string V = m4.Groups[2].Value.Trim() + m4.Groups[3].Value.Trim();
                        return string.Format(DefaultTemplate4, R, V);
                    }
                    return "";
                case ASMOperationType.LoadRegisterWithMemoryValue:
                    return "";
                case ASMOperationType.StoreStaticValueToRegister:
                    return "";
                case ASMOperationType.ApplyLegacyArithmeticOperation:
                    return "";
                case ASMOperationType.ButtonActivatorBlock:
                    return "";
                case ASMOperationType.ApplyArithmeticOperationToRegister:
                    return "";
                case ASMOperationType.StoreRegisterToMemoryAddress:
                    return "";
                default:
                    return "";
            }
        }
    }
}
