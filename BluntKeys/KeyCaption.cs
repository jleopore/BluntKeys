using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluntKeys
{
    class KeyCaption
    {
        public ushort Value;
        public string Caption;

        public KeyCaption(ushort scanCode)
        {
            Value = scanCode;
            Caption = StandardCaptions.TryGetValue(scanCode, out var knownCap) ? knownCap : "Unknown";
        }

        public override string ToString() => $"{Value.AsHexString()} : {Caption}";

        public static readonly Dictionary<ushort, string> StandardCaptions = new Dictionary<ushort, string>(256)
        {
            [0x0000] = "No Event",      [0x0010] = "Q",             [0x0020] = "D",
            [0x0001] = "Esc",           [0x0011] = "W",             [0x0021] = "F",
            [0x0002] = "1",             [0x0012] = "E",             [0x0022] = "G",
            [0x0003] = "2",             [0x0013] = "R",             [0x0023] = "H",
            [0x0004] = "3",             [0x0014] = "T",             [0x0024] = "J",
            [0x0005] = "4",             [0x0015] = "Y",             [0x0025] = "K",
            [0x0006] = "5",             [0x0016] = "U",             [0x0026] = "L",
            [0x0007] = "6",             [0x0017] = "I",             [0x0027] = ";",
            [0x0008] = "7",             [0x0018] = "O",             [0x0028] = "'",
            [0x0009] = "8",             [0x0019] = "P",             [0x0029] = "`",
            [0x000A] = "9",             [0x001A] = "[",             [0x002A] = "LShift",
            [0x000B] = "0",             [0x001B] = "]",             [0x002B] = "\\",
            [0x000C] = "-",             [0x001C] = "Enter",         [0x002C] = "Z",
            [0x000D] = "=",             [0x001D] = "LCtrl",         [0x002D] = "X",
            [0x000E] = "Backspace",     [0x001E] = "A",             [0x002E] = "C",
            [0x000F] = "Tab",           [0x001F] = "S",             [0x002F] = "V",

            [0x0030] = "B",             [0x0040] = "F6",            [0x0050] = "Num: 2",
            [0x0031] = "N",             [0x0041] = "F7",            [0x0051] = "Num: 3",
            [0x0032] = "M",             [0x0042] = "F8",            [0x0052] = "Num: 0",
            [0x0033] = ",",             [0x0043] = "F9",            [0x0053] = "Num: .",
            [0x0034] = ".",             [0x0044] = "F10",           [0x0054] = "Reserved",
            [0x0035] = "/",             [0x0045] = "Num Lock",      [0x0055] = "Reserved",
            [0x0036] = "RShift",        [0x0046] = "Scroll Lock",   [0x0056] = "ISO extra key",
            [0x0037] = "Num: *",        [0x0047] = "Num: 7",        [0x0057] = "F11",
            [0x0038] = "LAlt",          [0x0048] = "Num: 8",        [0x0058] = "F12",
            [0x0039] = "Space",         [0x0049] = "Num: 9",        [0x0059] = "Reserved",
            [0x003A] = "Caps Lock",     [0x004A] = "Num: -",        [0x005A] = "Reserved",
            [0x003B] = "F1",            [0x004B] = "Num: 4",        [0x005B] = "Reserved",
            [0x003C] = "F2",            [0x004C] = "Num: 5",        [0x005C] = "Reserved",
            [0x003D] = "F3",            [0x004D] = "Num: 6",        [0x005D] = "Reserved",
            [0x003E] = "F4",            [0x004E] = "Num: +",        [0x005E] = "Reserved",
            [0x003F] = "F5",            [0x004F] = "Num: 1",        [0x005F] = "Reserved",
                                                                
            [0x0060] = "Reserved",      [0x0070] = "Reserved",      [0xE001] = "Reserved",
            [0x0061] = "Reserved",      [0x0071] = "Reserved",      [0xE001] = "Reserved",
            [0x0062] = "Reserved",      [0x0072] = "Reserved",      [0xE002] = "Reserved",
            [0x0063] = "Reserved",      [0x0073] = "Reserved",      [0xE003] = "Reserved",
            [0x0064] = "F13",           [0x0074] = "Reserved",      [0xE004] = "Reserved",
            [0x0065] = "F14",           [0x0075] = "Reserved",      [0xE005] = "Reserved",
            [0x0066] = "F15",           [0x0076] = "Reserved",      [0xE006] = "Reserved",
            [0x0067] = "F16",           [0x0077] = "Reserved",      [0xE007] = "Redo",
            [0x0068] = "F17",           [0x0078] = "Reserved",      [0xE008] = "Undo",
            [0x0069] = "F18",           [0x0079] = "Reserved",      [0xE009] = "Reserved",
            [0x006A] = "F19",           [0x007A] = "Reserved",      [0xE00A] = "Reserved",
            [0x006B] = "F20",           [0x007B] = "Reserved",      [0xE00B] = "Reserved",
            [0x006C] = "F21",           [0x007C] = "Reserved",      [0xE00C] = "Reserved",
            [0x006D] = "F22",           [0x007D] = "¥",             [0xE00D] = "Reserved",
            [0x006E] = "F23",           [0x007E] = "Reserved",      [0xE00E] = "Reserved",
            [0x006F] = "F24",           [0x007F] = "Reserved",      [0xE00F] = "Reserved",

            [0xE010] = "Prev Track",    [0xE020] = "Mute",          [0xE030] = "Volume Up",
            [0xE011] = "Messenger",     [0xE021] = "Calculator",    [0xE031] = "Reserved",
            [0xE012] = "Webcam",        [0xE022] = "Play/Pause",    [0xE032] = "Homepage",
            [0xE013] = "iTouch",        [0xE023] = "Spellcheck",    [0xE033] = "Reserved",
            [0xE014] = "Shopping",      [0xE024] = "Stop",          [0xE034] = "Reserved",
            [0xE015] = "Reserved",      [0xE025] = "Reserved",      [0xE035] = "Num: /",
            [0xE016] = "Reserved",      [0xE026] = "Reserved",      [0xE036] = "Reserved",
            [0xE017] = "Reserved",      [0xE027] = "Reserved",      [0xE037] = "Print Screen",
            [0xE018] = "Reserved",      [0xE028] = "Reserved",      [0xE038] = "RAlt",
            [0xE019] = "Next Track",    [0xE029] = "Reserved",      [0xE039] = "Reserved",
            [0xE01A] = "Reserved",      [0xE02A] = "Reserved",      [0xE03A] = "Reserved",
            [0xE01B] = "Reserved",      [0xE02B] = "Reserved",      [0xE03B] = "Help",
            [0xE01C] = "Num: Enter",    [0xE02C] = "Reserved",      [0xE03C] = "Music",
            [0xE01D] = "RCtrl",         [0xE02D] = "Reserved",      [0xE03D] = "Task Pane",
            [0xE01E] = "Reserved",      [0xE02E] = "Volume Down",   [0xE03E] = "New",
            [0xE01F] = "Reserved",      [0xE02F] = "Reserved",      [0xE03F] = "Open",

            [0xE040] = "Close",         [0xE050] = "Down Arrow",    [0xE060] = "Reserved",
            [0xE041] = "Reply",         [0xE051] = "Page Down",     [0xE061] = "Reserved",
            [0xE042] = "Forward",       [0xE052] = "Insert",        [0xE062] = "Reserved",
            [0xE043] = "Send",          [0xE053] = "Delete",        [0xE063] = "ACPI Wake",
            [0xE044] = "Reserved",      [0xE054] = "Reserved",      [0xE064] = "Reserved",
            [0xE045] = "€",             [0xE055] = "Reserved",      [0xE065] = "Web: Search",
            [0xE046] = "Break",         [0xE056] = "Reserved",      [0xE066] = "Web: Favorites",
            [0xE047] = "Home",          [0xE057] = "Save",          [0xE067] = "Web: Refresh",
            [0xE048] = "Up Arrow",      [0xE058] = "Print",         [0xE068] = "Web: Stop",
            [0xE049] = "Page Up",       [0xE059] = "Reserved",      [0xE069] = "Web: Forward",
            [0xE04A] = "Reserved",      [0xE05A] = "Reserved",      [0xE06A] = "Web: Back",
            [0xE04B] = "Left Arrow",    [0xE05B] = "Left OS Key",   [0xE06B] = "My Computer",
            [0xE04C] = "Reserved",      [0xE05C] = "Right OS Key",  [0xE06C] = "E-Mail",
            [0xE04D] = "Right Arrow",   [0xE05D] = "Menu",          [0xE06D] = "Media Select",
            [0xE04E] = "Reserved",      [0xE05E] = "ACPI Power",    [0xE06E] = "Reserved",
            [0xE04F] = "End",           [0xE05F] = "ACPI Sleep",    [0xE06F] = "Reserved",

            [0xE070] = "Reserved",      
            [0xE071] = "Reserved",      
            [0xE072] = "Reserved",
            [0xE073] = "Reserved",
            [0xE074] = "Reserved",
            [0xE075] = "Reserved",
            [0xE076] = "Reserved",
            [0xE077] = "Reserved",
            [0xE078] = "Reserved",
            [0xE079] = "Reserved",
            [0xE07A] = "Reserved",
            [0xE07B] = "Reserved",
            [0xE07C] = "Reserved",
            [0xE07D] = "Reserved",
            [0xE07E] = "Reserved",
            [0xE07F] = "Reserved",
        };
    }
}
