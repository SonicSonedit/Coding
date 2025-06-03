using System.Runtime.InteropServices;
using Common.Runtime.Windows.Hotkeys;

namespace Common.Runtime.Windows
{
    public class HookIds
    {
        public readonly int Keyboard = 13;
    }

    public static partial class WinApi
    {
        public static readonly HookIds HookId = new();
        public delegate IntPtr HookCallbackDelegate(int code, IntPtr wParam, ref KeyboardHookLParam lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SetWindowsHookEx(int hookId, HookCallbackDelegate callback, IntPtr hInstance, int threadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern bool UnhookWindowsHookEx(IntPtr hookPtr);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr CallNextHookEx(IntPtr hookPtr, int code, IntPtr wParam, ref KeyboardHookLParam lParam);

        [DllImport("user32.dll")]
        public static extern bool TrackMouseEvent(ref TrackMouseEvents lpEventTrack);
    }
}
