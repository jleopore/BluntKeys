using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluntKeys
{
    static class Utils
    {
        public static string AsHexString(this ushort keymap) => "0x" + keymap.ToString("X4");        
    }
}
