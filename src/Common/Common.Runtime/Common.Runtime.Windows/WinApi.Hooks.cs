using System.Runtime.InteropServices;

namespace Common.Runtime.Windows
{
    public static partial class WinApi
    {
        public delegate int HookProc(int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern bool UnhookWindowsHookEx(int idHook);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int CallNextHookEx(int idHook, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetWindowsHookEx(int idHook, HookProc hookProc, IntPtr hInstance, int threadId);

        [DllImport("user32.dll")]
        public static extern bool TrackMouseEvent(ref TrackMouseEvents lpEventTrack);
    }
}
