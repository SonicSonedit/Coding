using Common.Runtime.Hotkeys;

namespace Common.Runtime.Windows.Hotkeys
{
    /// <summary>
    /// Взять из https://learn.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes
    /// Распаршено в Notepad++ и сконвертированно в энам C# там же
    /// Актуализировано с помощью https://developer.mozilla.org/en-US/docs/Web/API/KeyboardEvent/keyCode
    /// </summary>
    public enum WindowsKey
    {
        None = 0,

        /// <Summary>
        /// Left Mouse Button
        /// </Summary>
        Lbutton = 0x01,

        /// <Summary>
        /// Right Mouse Button
        /// </Summary>
        Rbutton = 0x02,

        /// <Summary>
        /// Control-Break Processing
        /// </Summary>
        Cancel = 0x03,

        /// <Summary>
        /// Middle Mouse Button
        /// </Summary>
        Mbutton = 0x04,

        /// <Summary>
        /// X1 Mouse Button
        /// </Summary>
        Xbutton1 = 0x05,

        /// <Summary>
        /// X2 Mouse Button
        /// </Summary>
        Xbutton2 = 0x06,

        /// <Summary>
        /// Reserved
        /// </Summary>
        Unknown = 0x07,

        /// <Summary>
        /// Backspace Key
        /// </Summary>
        Backspace = 0x08,

        /// <Summary>
        /// Tab Key
        /// </Summary>
        Tab = 0x09,

        Reserved01 = 0x0A,
        Reserved02 = 0x0B,

        /// <Summary>
        /// Clear Key
        /// </Summary>
        Clear = 0x0C,

        /// <Summary>
        /// Enter Key
        /// </Summary>
        Return = 0x0D,

        Unassigned01 = 0x0E,
        Unassigned02 = 0x0F,

        /// <Summary>
        /// Shift Key
        /// </Summary>
        Shift = 0x10,

        /// <Summary>
        /// Ctrl Key
        /// </Summary>
        Control = 0x11,

        /// <Summary>
        /// Alt Key
        /// </Summary>
        Alt = 0x12,

        /// <Summary>
        /// Pause Key
        /// </Summary>
        Pause = 0x13,

        /// <Summary>
        /// Caps Lock Key
        /// </Summary>
        CapsLock = 0x14,

        /// <Summary>
        /// Ime Kana Mode
        /// </Summary>
        Kana = 0x15,

        /// <Summary>
        /// Ime Hangul Mode
        /// </Summary>
        Hangul = 0x15,

        /// <Summary>
        /// Ime On
        /// </Summary>
        Ime_On = 0x16,

        /// <Summary>
        /// Ime Junja Mode
        /// </Summary>
        Junja = 0x17,

        /// <Summary>
        /// Ime Final Mode
        /// </Summary>
        Final = 0x18,

        /// <Summary>
        /// Ime Hanja Mode
        /// </Summary>
        Hanja = 0x19,

        /// <Summary>
        /// Ime Kanji Mode
        /// </Summary>
        Kanji = 0x19,

        /// <Summary>
        /// Ime Off
        /// </Summary>
        Ime_Off = 0x1A,

        /// <Summary>
        /// Esc Key
        /// </Summary>
        Escape = 0x1B,

        /// <Summary>
        /// Ime Convert
        /// </Summary>
        Convert = 0x1C,

        /// <Summary>
        /// Ime Nonconvert
        /// </Summary>
        NonConvert = 0x1D,

        /// <Summary>
        /// Ime Accept
        /// </Summary>
        Accept = 0x1E,

        /// <Summary>
        /// Ime Mode Change Request
        /// </Summary>
        ModeChange = 0x1F,

        /// <Summary>
        /// Spacebar Key
        /// </Summary>
        Space = 0x20,

        /// <Summary>
        /// Page Up Key
        /// </Summary>
        PageUp = 0x21,

        /// <Summary>
        /// Page Down Key
        /// </Summary>
        PageDown = 0x22,

        /// <Summary>
        /// End Key
        /// </Summary>
        End = 0x23,

        /// <Summary>
        /// Home Key
        /// </Summary>
        Home = 0x24,

        /// <Summary>
        /// Left Arrow Key
        /// </Summary>
        ArrowLeft = 0x25,

        /// <Summary>
        /// Up Arrow Key
        /// </Summary>
        ArrowUp = 0x26,

        /// <Summary>
        /// Right Arrow Key
        /// </Summary>
        ArrowRight = 0x27,

        /// <Summary>
        /// Down Arrow Key
        /// </Summary>
        ArrowDown = 0x28,

        /// <Summary>
        /// Select Key
        /// </Summary>
        Select = 0x29,

        /// <Summary>
        /// Print Key
        /// </Summary>
        Print = 0x2A,

        /// <Summary>
        /// Execute Key
        /// </Summary>
        Execute = 0x2B,

        /// <Summary>
        /// Print Screen Key
        /// </Summary>
        PrintScreen = 0x2C,

        /// <Summary>
        /// Insert Key
        /// </Summary>
        Insert = 0x2D,

        /// <Summary>
        /// Delete Key
        /// </Summary>
        Delete = 0x2E,

        /// <Summary>
        /// Help Key
        /// </Summary>
        Help = 0x2F,

        /// <Summary>
        /// 0 Key
        /// </Summary>
        Digit0 = 0x30,

        /// <Summary>
        /// 1 Key
        /// </Summary>
        Digit1 = 0x31,

        /// <Summary>
        /// 2 Key
        /// </Summary>
        Digit2 = 0x32,

        /// <Summary>
        /// 3 Key
        /// </Summary>
        Digit3 = 0x33,

        /// <Summary>
        /// 4 Key
        /// </Summary>
        Digit4 = 0x34,

        /// <Summary>
        /// 5 Key
        /// </Summary>
        Digit5 = 0x35,

        /// <Summary>
        /// 6 Key
        /// </Summary>
        Digit6 = 0x36,

        /// <Summary>
        /// 7 Key
        /// </Summary>
        Digit7 = 0x37,

        /// <Summary>
        /// 8 Key
        /// </Summary>
        Digit8 = 0x38,

        /// <Summary>
        /// 9 Key
        /// </Summary>
        Digit9 = 0x39,

        Undefined1 = 0x3A,
        Undefined2 = 0x3B,
        Undefined3 = 0x3C,
        Undefined4 = 0x3D,
        Undefined5 = 0x3E,
        Undefined6 = 0x3F,
        Undefined8 = 0x40,

        /// <Summary>
        /// A Key
        /// </Summary>
        A = 0x41,

        /// <Summary>
        /// B Key
        /// </Summary>
        B = 0x42,

        /// <Summary>
        /// C Key
        /// </Summary>
        C = 0x43,

        /// <Summary>
        /// D Key
        /// </Summary>
        D = 0x44,

        /// <Summary>
        /// E Key
        /// </Summary>
        E = 0x45,

        /// <Summary>
        /// F Key
        /// </Summary>
        F = 0x46,

        /// <Summary>
        /// G Key
        /// </Summary>
        G = 0x47,

        /// <Summary>
        /// H Key
        /// </Summary>
        H = 0x48,

        /// <Summary>
        /// I Key
        /// </Summary>
        I = 0x49,

        /// <Summary>
        /// J Key
        /// </Summary>
        J = 0x4A,

        /// <Summary>
        /// K Key
        /// </Summary>
        K = 0x4B,

        /// <Summary>
        /// L Key
        /// </Summary>
        L = 0x4C,

        /// <Summary>
        /// M Key
        /// </Summary>
        M = 0x4D,

        /// <Summary>
        /// N Key
        /// </Summary>
        N = 0x4E,

        /// <Summary>
        /// O Key
        /// </Summary>
        O = 0x4F,

        /// <Summary>
        /// P Key
        /// </Summary>
        P = 0x50,

        /// <Summary>
        /// Q Key
        /// </Summary>
        Q = 0x51,

        /// <Summary>
        /// R Key
        /// </Summary>
        R = 0x52,

        /// <Summary>
        /// S Key
        /// </Summary>
        S = 0x53,

        /// <Summary>
        /// T Key
        /// </Summary>
        T = 0x54,

        /// <Summary>
        /// U Key
        /// </Summary>
        U = 0x55,

        /// <Summary>
        /// V Key
        /// </Summary>
        V = 0x56,

        /// <Summary>
        /// W Key
        /// </Summary>
        W = 0x57,

        /// <Summary>
        /// X Key
        /// </Summary>
        X = 0x58,

        /// <Summary>
        /// Y Key
        /// </Summary>
        Y = 0x59,

        /// <Summary>
        /// Z Key
        /// </Summary>
        Z = 0x5A,

        /// <Summary>
        /// Left Windows Logo Key
        /// </Summary>
        WinLeft = 0x5B,

        /// <Summary>
        /// Right Windows Logo Key
        /// </Summary>
        WinRight = 0x5C,

        /// <Summary>
        /// Application Key
        /// </Summary>
        Apps = 0x5D,

        /// <Summary>
        /// Power button
        /// </Summary>
        Power = 0x5E,

        /// <Summary>
        /// Computer Sleep Key
        /// </Summary>
        Sleep = 0x5F,

        /// <Summary>
        /// Numeric Keypad 0 Key
        /// </Summary>
        NumPad0 = 0x60,

        /// <Summary>
        /// Numeric Keypad 1 Key
        /// </Summary>
        NumPad1 = 0x61,

        /// <Summary>
        /// Numeric Keypad 2 Key
        /// </Summary>
        NumPad2 = 0x62,

        /// <Summary>
        /// Numeric Keypad 3 Key
        /// </Summary>
        NumPad3 = 0x63,

        /// <Summary>
        /// Numeric Keypad 4 Key
        /// </Summary>
        NumPad4 = 0x64,

        /// <Summary>
        /// Numeric Keypad 5 Key
        /// </Summary>
        NumPad5 = 0x65,

        /// <Summary>
        /// Numeric Keypad 6 Key
        /// </Summary>
        NumPad6 = 0x66,

        /// <Summary>
        /// Numeric Keypad 7 Key
        /// </Summary>
        NumPad7 = 0x67,

        /// <Summary>
        /// Numeric Keypad 8 Key
        /// </Summary>
        NumPad8 = 0x68,

        /// <Summary>
        /// Numeric Keypad 9 Key
        /// </Summary>
        NumPad9 = 0x69,

        /// <Summary>
        /// Multiply Key
        /// </Summary>
        Multiply = 0x6A,

        /// <Summary>
        /// Add Key
        /// </Summary>
        Add = 0x6B,

        /// <Summary>
        /// Separator Key
        /// </Summary>
        Separator = 0x6C,

        /// <Summary>
        /// Subtract Key
        /// </Summary>
        Subtract = 0x6D,

        /// <Summary>
        /// Decimal Key
        /// </Summary>
        Decimal = 0x6E,

        /// <Summary>
        /// Divide Key
        /// </Summary>
        Divide = 0x6F,

        /// <Summary>
        /// F1 Key
        /// </Summary>
        F1 = 0x70,

        /// <Summary>
        /// F2 Key
        /// </Summary>
        F2 = 0x71,

        /// <Summary>
        /// F3 Key
        /// </Summary>
        F3 = 0x72,

        /// <Summary>
        /// F4 Key
        /// </Summary>
        F4 = 0x73,

        /// <Summary>
        /// F5 Key
        /// </Summary>
        F5 = 0x74,

        /// <Summary>
        /// F6 Key
        /// </Summary>
        F6 = 0x75,

        /// <Summary>
        /// F7 Key
        /// </Summary>
        F7 = 0x76,

        /// <Summary>
        /// F8 Key
        /// </Summary>
        F8 = 0x77,

        /// <Summary>
        /// F9 Key
        /// </Summary>
        F9 = 0x78,

        /// <Summary>
        /// F10 Key
        /// </Summary>
        F10 = 0x79,

        /// <Summary>
        /// F11 Key
        /// </Summary>
        F11 = 0x7A,

        /// <Summary>
        /// F12 Key
        /// </Summary>
        F12 = 0x7B,

        /// <Summary>
        /// F13 Key
        /// </Summary>
        F13 = 0x7C,

        /// <Summary>
        /// F14 Key
        /// </Summary>
        F14 = 0x7D,

        /// <Summary>
        /// F15 Key
        /// </Summary>
        F15 = 0x7E,

        /// <Summary>
        /// F16 Key
        /// </Summary>
        F16 = 0x7F,

        /// <Summary>
        /// F17 Key
        /// </Summary>
        F17 = 0x80,

        /// <Summary>
        /// F18 Key
        /// </Summary>
        F18 = 0x81,

        /// <Summary>
        /// F19 Key
        /// </Summary>
        F19 = 0x82,

        /// <Summary>
        /// F20 Key
        /// </Summary>
        F20 = 0x83,

        /// <Summary>
        /// F21 Key
        /// </Summary>
        F21 = 0x84,

        /// <Summary>
        /// F22 Key
        /// </Summary>
        F22 = 0x85,

        /// <Summary>
        /// F23 Key
        /// </Summary>
        F23 = 0x86,

        /// <Summary>
        /// F24 Key
        /// </Summary>
        F24 = 0x87,

        Reserved04 = 0x88,
        Reserved05 = 0x89,
        Reserved06 = 0x8A,
        Reserved07 = 0x8B,
        Reserved08 = 0x8C,
        Reserved09 = 0x8D,
        Reserved10 = 0x8E,
        Reserved11 = 0x8F,

        /// <Summary>
        /// Num Lock Key
        /// </Summary>
        NumLock = 0x90,

        /// <Summary>
        /// Scroll Lock Key
        /// </Summary>
        ScrollLock = 0x91,

        OEM_Extra01 = 0x92,
        OEM_Extra02 = 0x93,
        OEM_Extra03 = 0x94,
        OEM_Extra04 = 0x95,
        OEM_Extra05 = 0x96,

        Unassigned03 = 0x97,
        Unassigned04 = 0x98,
        Unassigned05 = 0x99,
        Unassigned06 = 0x9A,
        Unassigned07 = 0x9B,
        Unassigned08 = 0x9C,
        Unassigned09 = 0x9D,
        Unassigned10 = 0x9E,
        Unassigned11 = 0x9F,

        /// <Summary>
        /// Left Shift Key
        /// </Summary>
        ShiftLeft = 0xA0,

        /// <Summary>
        /// Right Shift Key
        /// </Summary>
        ShiftRight = 0xA1,

        /// <Summary>
        /// Left Ctrl Key
        /// </Summary>
        Lcontrol = 0xA2,

        /// <Summary>
        /// Right Ctrl Key
        /// </Summary>
        Rcontrol = 0xA3,

        /// <Summary>
        /// Left Alt Key
        /// </Summary>
        Lmenu = 0xA4,

        /// <Summary>
        /// Right Alt Key
        /// </Summary>
        Rmenu = 0xA5,

        /// <Summary>
        /// Browser Back Key
        /// </Summary>
        BrowserBack = 0xA6,

        /// <Summary>
        /// Browser Forward Key
        /// </Summary>
        BrowserForward = 0xA7,

        /// <Summary>
        /// Browser Refresh Key
        /// </Summary>
        BrowserRefresh = 0xA8,

        /// <Summary>
        /// Browser Stop Key
        /// </Summary>
        BrowserStop = 0xA9,

        /// <Summary>
        /// Browser Search Key
        /// </Summary>
        BrowserSearch = 0xAA,

        /// <Summary>
        /// Browser Favorites Key
        /// </Summary>
        BrowserFavorites = 0xAB,

        /// <Summary>
        /// Browser Start And Home Key
        /// </Summary>
        BrowserHome = 0xAC,

        /// <Summary>
        /// Volume Mute Key
        /// </Summary>
        Volume_Mute = 0xAD,

        /// <Summary>
        /// Volume Down Key
        /// </Summary>
        Volume_Down = 0xAE,

        /// <Summary>
        /// Volume Up Key
        /// </Summary>
        Volume_Up = 0xAF,

        /// <Summary>
        /// Next Track Key
        /// </Summary>
        MediaTrackNext = 0xB0,

        /// <Summary>
        /// Previous Track Key
        /// </Summary>
        MediaTrackPrevious = 0xB1,

        /// <Summary>
        /// Stop Media Key
        /// </Summary>
        MediaStop = 0xB2,

        /// <Summary>
        /// Play/Pause Media Key
        /// </Summary>
        MediaPlayPause = 0xB3,

        /// <Summary>
        /// Start Mail Key
        /// </Summary>
        LaunchMail = 0xB4,

        /// <Summary>
        /// Select Media Key
        /// </Summary>
        MediaSelect = 0xB5,

        /// <Summary>
        /// Start Application 1 Key
        /// </Summary>
        LaunchApp1 = 0xB6,

        /// <Summary>
        /// Start Application 2 Key
        /// </Summary>
        LaunchApp2 = 0xB7,

        Reserved12 = 0xB8,
        Reserved13 = 0xB9,

        /// <Summary>
        /// Used For Miscellaneous Characters; It Can Vary By Keyboard. For The Us Standard Keyboard, The ;: Key
        /// </Summary>
        Semicolon = 0xBA,

        /// <Summary>
        /// For Any Country/Region, The + Key
        /// </Summary>
        Plus = 0xBB,

        /// <Summary>
        /// For Any Country/Region, The , Key
        /// </Summary>
        Comma = 0xBC,

        /// <Summary>
        /// For Any Country/Region, The - Key
        /// </Summary>
        Minus = 0xBD,

        /// <Summary>
        /// For Any Country/Region, The . Key
        /// </Summary>
        Period = 0xBE,

        /// <Summary>
        /// Used For Miscellaneous Characters; It Can Vary By Keyboard. For The Us Standard Keyboard, The /? Key
        /// </Summary>
        Slash = 0xBF,

        /// <Summary>
        /// Used For Miscellaneous Characters; It Can Vary By Keyboard. For The Us Standard Keyboard, The `~ Key
        /// </Summary>
        BackQuote = 0xC0,

        /// <summary>
        /// JP, BR special key
        /// </summary>
        IntlRo = 0xC1,

        Reserved15 = 0xC2,
        Reserved16 = 0xC3,
        Reserved17 = 0xC4,
        Reserved18 = 0xC5,
        Reserved19 = 0xC6,
        Reserved20 = 0xC7,
        Reserved21 = 0xC8,
        Reserved22 = 0xC9,
        Reserved23 = 0xCA,
        Reserved24 = 0xCB,
        Reserved25 = 0xCC,
        Reserved26 = 0xCE,
        Reserved27 = 0xCF,
        Reserved28 = 0xD0,
        Reserved29 = 0xD1,
        Reserved30 = 0xD2,
        Reserved31 = 0xD3,
        Reserved32 = 0xD4,
        Reserved33 = 0xD5,
        Reserved34 = 0xD6,
        Reserved35 = 0xD7,
        Reserved36 = 0xD8,
        Reserved37 = 0xD9,
        Reserved38 = 0xDA,

        /// <Summary>
        /// Used For Miscellaneous Characters; It Can Vary By Keyboard. For The Us Standard Keyboard, The [{ Key
        /// </Summary>
        BracketLeft = 0xDB,

        /// <Summary>
        /// Used For Miscellaneous Characters; It Can Vary By Keyboard. For The Us Standard Keyboard, The \\| Key
        /// </Summary>
        BackSlash = 0xDC,

        /// <Summary>
        /// Used For Miscellaneous Characters; It Can Vary By Keyboard. For The Us Standard Keyboard, The ]} Key
        /// </Summary>
        BracketRight = 0xDD,

        /// <Summary>
        /// Used For Miscellaneous Characters; It Can Vary By Keyboard. For The Us Standard Keyboard, The '" Key
        /// </Summary>
        Quote = 0xDE,

        /// <Summary>
        /// Used For Miscellaneous Characters; It Can Vary By Keyboard.
        /// </Summary>
        OEM8 = 0xDF,

        Reserved39 = 0xE0,
        Reserved40 = 0xE1,

        /// <Summary>
        /// The <> Keys On The Us Standard Keyboard, Or The \\| Key On The Non-Us 102-Key Keyboard
        /// </Summary>
        IntlBackslash = 0xE2,

        OEM_Extra06 = 0xE3,
        OEM_Extra07 = 0xE4,

        /// <Summary>
        /// Ime Process Key
        /// </Summary>
        Processkey = 0xE5,

        OEM_Extra08 = 0xE6,

        /// <Summary>
        /// Used To Pass Unicode Characters As If They Were Keystrokes. The Packet Key Is The Low Word Of A 32-Bit Virtual Key Value Used For Non-Keyboard Input Methods. For More Information, See Remark In Keybdinput, Sendinput, Wm_Keydown, And Wm_Keyup
        /// </Summary>
        Packet = 0xE7,

        Unassigned12 = 0xE8,

        OEM_Extra09 = 0xE9,
        OEM_Extra10 = 0xEA,
        OEM_Extra11 = 0xEB,
        OEM_Extra12 = 0xEC,
        OEM_Extra13 = 0xED,
        OEM_Extra14 = 0xEE,
        OEM_Extra15 = 0xEF,
        OEM_Extra16 = 0xF0,
        OEM_Extra17 = 0xF1,
        OEM_Extra18 = 0xF2,
        OEM_Extra19 = 0xF3,
        OEM_Extra20 = 0xF4,
        OEM_Extra21 = 0xF5,

        /// <Summary>
        /// Attn Key
        /// </Summary>
        Attn = 0xF6,

        /// <Summary>
        /// Crsel Key
        /// </Summary>
        Crsel = 0xF7,

        /// <Summary>
        /// Exsel Key
        /// </Summary>
        Exsel = 0xF8,

        /// <Summary>
        /// Erase Eof Key
        /// </Summary>
        Ereof = 0xF9,

        /// <Summary>
        /// Play Key
        /// </Summary>
        Play = 0xFA,

        /// <Summary>
        /// Zoom Key
        /// </Summary>
        Zoom = 0xFB,

        /// <Summary>
        /// Reserved
        /// </Summary>
        Noname = 0xFC,

        /// <Summary>
        /// Pa1 Key
        /// </Summary>
        Pa1 = 0xFD,

        /// <Summary>
        /// Clear Key
        /// </Summary>
        OEMclear = 0xFE,

        /// <Summary>
        /// Clear Key
        /// </Summary>
        IntlYen = 0xFE
    }

    public static class WindowsKeyExtensions
    {
        public static WindowsKey ToWindowsKey(this UniversalKey key)
        {
            switch (key)
            {
                case UniversalKey.None: return WindowsKey.None;
                case UniversalKey.BackQuote: return WindowsKey.BackQuote;
                case UniversalKey.BackSlash: return WindowsKey.BackSlash;
                case UniversalKey.BracketLeft: return WindowsKey.BracketLeft;
                case UniversalKey.BracketRight: return WindowsKey.BracketRight;
                case UniversalKey.Comma: return WindowsKey.Comma;
                case UniversalKey.Digit0: return WindowsKey.Digit0;
                case UniversalKey.Digit1: return WindowsKey.Digit1;
                case UniversalKey.Digit2: return WindowsKey.Digit2;
                case UniversalKey.Digit3: return WindowsKey.Digit3;
                case UniversalKey.Digit4: return WindowsKey.Digit4;
                case UniversalKey.Digit5: return WindowsKey.Digit5;
                case UniversalKey.Digit6: return WindowsKey.Digit6;
                case UniversalKey.Digit7: return WindowsKey.Digit7;
                case UniversalKey.Digit8: return WindowsKey.Digit8;
                case UniversalKey.Digit9: return WindowsKey.Digit9;
                case UniversalKey.Equal: return WindowsKey.Plus;
                case UniversalKey.IntlBackslash: return WindowsKey.IntlBackslash;
                case UniversalKey.IntlRo: return WindowsKey.IntlRo;
                case UniversalKey.IntlYen: return WindowsKey.IntlYen;
                case UniversalKey.A: return WindowsKey.A;
                case UniversalKey.B: return WindowsKey.B;
                case UniversalKey.C: return WindowsKey.C;
                case UniversalKey.D: return WindowsKey.D;
                case UniversalKey.E: return WindowsKey.E;
                case UniversalKey.F: return WindowsKey.F;
                case UniversalKey.G: return WindowsKey.G;
                case UniversalKey.H: return WindowsKey.H;
                case UniversalKey.I: return WindowsKey.I;
                case UniversalKey.J: return WindowsKey.J;
                case UniversalKey.K: return WindowsKey.K;
                case UniversalKey.L: return WindowsKey.L;
                case UniversalKey.M: return WindowsKey.M;
                case UniversalKey.N: return WindowsKey.N;
                case UniversalKey.O: return WindowsKey.O;
                case UniversalKey.P: return WindowsKey.P;
                case UniversalKey.Q: return WindowsKey.Q;
                case UniversalKey.R: return WindowsKey.R;
                case UniversalKey.S: return WindowsKey.S;
                case UniversalKey.T: return WindowsKey.T;
                case UniversalKey.U: return WindowsKey.U;
                case UniversalKey.V: return WindowsKey.V;
                case UniversalKey.W: return WindowsKey.W;
                case UniversalKey.X: return WindowsKey.X;
                case UniversalKey.Y: return WindowsKey.Y;
                case UniversalKey.Z: return WindowsKey.Z;
                case UniversalKey.Minus: return WindowsKey.Minus;
                case UniversalKey.Period: return WindowsKey.Period;
                case UniversalKey.Quote: return WindowsKey.Quote;
                case UniversalKey.Semicolon: return WindowsKey.Semicolon;
                case UniversalKey.Slash: return WindowsKey.Slash;
                case UniversalKey.AltLeft: return WindowsKey.Alt;
                case UniversalKey.AltRight: return WindowsKey.Alt;
                case UniversalKey.Backspace: return WindowsKey.Backspace;
                case UniversalKey.CapsLock: return WindowsKey.CapsLock;
                case UniversalKey.ContextMenu: return WindowsKey.Apps;
                case UniversalKey.ControlLeft: return WindowsKey.Control;
                case UniversalKey.ControlRight: return WindowsKey.Control;
                case UniversalKey.Enter: return WindowsKey.Return;
                case UniversalKey.MetaLeft: return WindowsKey.WinLeft;
                case UniversalKey.MetaRight: return WindowsKey.WinRight;
                case UniversalKey.ShiftLeft: return WindowsKey.ShiftLeft;
                case UniversalKey.ShiftRight: return WindowsKey.ShiftRight;
                case UniversalKey.Space: return WindowsKey.Space;
                case UniversalKey.Tab: return WindowsKey.Tab;
                case UniversalKey.Convert: return WindowsKey.Convert;
                case UniversalKey.KanaMode: return WindowsKey.Kana;
                case UniversalKey.Lang1: return WindowsKey.Hangul;
                case UniversalKey.Lang2: return WindowsKey.Hanja;
                case UniversalKey.Lang3: return WindowsKey.CapsLock;
                case UniversalKey.Lang4: return WindowsKey.PageUp;
                case UniversalKey.Lang5: return WindowsKey.BackQuote;
                case UniversalKey.NonConvert: return WindowsKey.NonConvert;
                case UniversalKey.Delete: return WindowsKey.Delete;
                case UniversalKey.End: return WindowsKey.End;
                case UniversalKey.Help: return WindowsKey.Help;
                case UniversalKey.Home: return WindowsKey.Home;
                case UniversalKey.Insert: return WindowsKey.Insert;
                case UniversalKey.PageDown: return WindowsKey.PageDown;
                case UniversalKey.PageUp: return WindowsKey.PageUp;
                case UniversalKey.ArrowDown: return WindowsKey.ArrowDown;
                case UniversalKey.ArrowLeft: return WindowsKey.ArrowLeft;
                case UniversalKey.ArrowRight: return WindowsKey.ArrowRight;
                case UniversalKey.ArrowUp: return WindowsKey.ArrowUp;
                case UniversalKey.NumLock: return WindowsKey.NumLock;
                case UniversalKey.NumPad0: return WindowsKey.NumPad0;
                case UniversalKey.NumPad1: return WindowsKey.NumPad1;
                case UniversalKey.NumPad2: return WindowsKey.NumPad2;
                case UniversalKey.NumPad3: return WindowsKey.NumPad3;
                case UniversalKey.NumPad4: return WindowsKey.NumPad4;
                case UniversalKey.NumPad5: return WindowsKey.NumPad5;
                case UniversalKey.NumPad6: return WindowsKey.NumPad6;
                case UniversalKey.NumPad7: return WindowsKey.NumPad7;
                case UniversalKey.NumPad8: return WindowsKey.NumPad8;
                case UniversalKey.NumPad9: return WindowsKey.NumPad9;
                case UniversalKey.NumPadAdd: return WindowsKey.Add;
                case UniversalKey.NumPadClear: return WindowsKey.NumPad5;
                case UniversalKey.NumPadComma: return WindowsKey.Decimal;
                case UniversalKey.NumPadDecimal: return WindowsKey.Decimal;
                case UniversalKey.NumPadDivide: return WindowsKey.Divide;
                case UniversalKey.NumPadEnter: return WindowsKey.Return;
                case UniversalKey.NumPadEqual: return WindowsKey.Plus;
                case UniversalKey.NumPadMultiply: return WindowsKey.Multiply;
                case UniversalKey.NumPadParenLeft: return WindowsKey.NumPad4;
                case UniversalKey.NumPadParenRight: return WindowsKey.NumPad6;
                case UniversalKey.NumPadSubtract: return WindowsKey.Subtract;
                case UniversalKey.Escape: return WindowsKey.Escape;
                case UniversalKey.F1: return WindowsKey.F1;
                case UniversalKey.F2: return WindowsKey.F2;
                case UniversalKey.F3: return WindowsKey.F3;
                case UniversalKey.F4: return WindowsKey.F4;
                case UniversalKey.F5: return WindowsKey.F5;
                case UniversalKey.F6: return WindowsKey.F6;
                case UniversalKey.F7: return WindowsKey.F7;
                case UniversalKey.F8: return WindowsKey.F8;
                case UniversalKey.F9: return WindowsKey.F9;
                case UniversalKey.F10: return WindowsKey.F10;
                case UniversalKey.F11: return WindowsKey.F11;
                case UniversalKey.F12: return WindowsKey.F12;
                case UniversalKey.F13: return WindowsKey.F13;
                case UniversalKey.F14: return WindowsKey.F14;
                case UniversalKey.F15: return WindowsKey.F15;
                case UniversalKey.F16: return WindowsKey.F16;
                case UniversalKey.F17: return WindowsKey.F17;
                case UniversalKey.F18: return WindowsKey.F18;
                case UniversalKey.F19: return WindowsKey.F19;
                case UniversalKey.F20: return WindowsKey.F20;
                case UniversalKey.F21: return WindowsKey.F21;
                case UniversalKey.F22: return WindowsKey.F22;
                case UniversalKey.F23: return WindowsKey.F23;
                case UniversalKey.F24: return WindowsKey.F24;
                case UniversalKey.PrintScreen: return WindowsKey.PrintScreen;
                case UniversalKey.ScrollLock: return WindowsKey.ScrollLock;
                case UniversalKey.Pause: return WindowsKey.Pause;
                case UniversalKey.BrowserBack: return WindowsKey.BrowserBack;
                case UniversalKey.BrowserFavorites: return WindowsKey.BrowserFavorites;
                case UniversalKey.BrowserForward: return WindowsKey.BrowserForward;
                case UniversalKey.BrowserHome: return WindowsKey.BrowserHome;
                case UniversalKey.BrowserRefresh: return WindowsKey.BrowserRefresh;
                case UniversalKey.BrowserSearch: return WindowsKey.BrowserSearch;
                case UniversalKey.BrowserStop: return WindowsKey.BrowserStop;
                case UniversalKey.Eject: return WindowsKey.Escape;
                case UniversalKey.LaunchApp1: return WindowsKey.Apps;
                case UniversalKey.LaunchApp2: return WindowsKey.Apps;
                case UniversalKey.LaunchMail: return WindowsKey.LaunchMail;
                case UniversalKey.MediaPlayPause: return WindowsKey.MediaPlayPause;
                case UniversalKey.MediaSelect: return WindowsKey.MediaSelect;
                case UniversalKey.MediaStop: return WindowsKey.MediaStop;
                case UniversalKey.MediaTrackNext: return WindowsKey.MediaTrackNext;
                case UniversalKey.MediaTrackPrevious: return WindowsKey.MediaTrackPrevious;
                case UniversalKey.Power: return WindowsKey.Power;
                case UniversalKey.Sleep: return WindowsKey.Sleep;
                case UniversalKey.AudioVolumeMute: return WindowsKey.MediaSelect;
                case UniversalKey.AudioVolumeDown: return WindowsKey.LaunchApp1;
                case UniversalKey.AudioVolumeUp: return WindowsKey.LaunchApp2;
                case UniversalKey.WakeUp: return WindowsKey.NumPad3;
                case UniversalKey.Again: return WindowsKey.None;
                case UniversalKey.Copy: return WindowsKey.None;
                case UniversalKey.Cut: return WindowsKey.None;
                case UniversalKey.Find: return WindowsKey.None;
                case UniversalKey.Open: return WindowsKey.None;
                case UniversalKey.Paste: return WindowsKey.None;
                case UniversalKey.Props: return WindowsKey.Apps;
                case UniversalKey.Select: return WindowsKey.Select;
                case UniversalKey.Undo: return WindowsKey.None;
                default: return WindowsKey.None;
            }
        }
    }
}
