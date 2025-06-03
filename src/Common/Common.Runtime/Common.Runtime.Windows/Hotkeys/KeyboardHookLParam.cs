using System.Runtime.InteropServices;

namespace Common.Runtime.Windows.Hotkeys
{
    [StructLayout(LayoutKind.Sequential)]
    public struct KeyboardHookLParam
    {
        public int VirtualCode;
        public int ScanCode;
        public int Flags;
        public int Time;
        public int ExtraInfo;
    }
}
