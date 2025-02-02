using System.Runtime.InteropServices;
using System.Text;

namespace Common.Runtime.Windows.Hotkeys
{
    internal class WinApi
    {
        public const int GWL_WNDPROC = -4;
        public const uint TME_HOVER = 1;
        public const uint TME_LEAVE = 2;
        public const uint WM_CONTEXTMENU = 0x007B;
        public const uint WM_MOUSELEAVE = 0x02A3;
        public const uint WM_MOUSEHOVER = 0x02A1;
        public const uint WM_MOUSEMOVE = 0x0200;


        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr RegisterClassEx([In] ref CreateWindowClass lpWndClass);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateWindowEx
        (
            int dwExStyle,
            string lpClassName,
            string lpWindowName,
            WindowStyles dwStyle,
            int x,
            int y,
            int nWidth,
            int nHeight,
            IntPtr hWndParent,
            IntPtr hMenu,
            IntPtr hInstance,
            IntPtr lpParam
        );

        public delegate IntPtr WndProcDelegate(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr CallWindowProc(IntPtr lpPrevWndFunc, IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool DestroyWindow(IntPtr hwnd);

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SetWindowLongPtr(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool SetWindowText(IntPtr hwnd, String lpString);

        [DllImport("user32.dll")]
        public static extern bool TrackMouseEvent(ref TRACKMOUSEEVENT lpEventTrack);

        [StructLayout(LayoutKind.Sequential)]
        public struct TRACKMOUSEEVENT
        {
            public int cbSize;
            public uint dwFlags;
            public IntPtr hwndTrack;
            public uint dwHoverTime;
        }

        [DllImport("kernel32.dll")]
        public static extern uint GetLastError();

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int FormatMessage
        (
            MessageFormat dwFlags,
            string lpSource,
            uint dwMessageId,
            uint dwLanguageId,
            StringBuilder lpBuffer,
            int nSize,
            ref FormatMessageParameters vaList
         );

        public static string GetWinErrorCodeText(uint errorCode)
        {
            var buffer = new StringBuilder(512);
            var dummy = new FormatMessageParameters();

            int a = FormatMessage
            (
                MessageFormat.FORMAT_MESSAGE_FROM_SYSTEM | MessageFormat.FORMAT_MESSAGE_IGNORE_INSERTS,
                "%1",
                errorCode,
                0,
                buffer,
                buffer.Capacity,
                ref dummy
            );

            return buffer.ToString();
        }
    }
}