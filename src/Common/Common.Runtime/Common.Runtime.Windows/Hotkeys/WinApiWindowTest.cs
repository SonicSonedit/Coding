using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Common.Runtime.Windows.Hotkeys
{
    delegate IntPtr WndProc(IntPtr hWnd, WindowsMessage msg, IntPtr wParam, IntPtr lParam);

    class WinApiWindowTest
    {
        private WndProc delegWndProc = myWndProc;

        [DllImport("user32.dll")]
        static extern IntPtr DefWindowProc(IntPtr hWnd, WindowsMessage uMsg, IntPtr wParam, IntPtr lParam);


        internal bool create()
        {
            var windowClass = new CreateWindowClass();
            windowClass.cbSize = Marshal.SizeOf(typeof(CreateWindowClass));
            windowClass.style = WindowStyles.WS_EX_NOACTIVATE;
            windowClass.hbrBackground = IntPtr.Zero;
            windowClass.cbClsExtra = 0;
            windowClass.cbWndExtra = 0;
            windowClass.hInstance = IntPtr.Zero;
            windowClass.hIcon = IntPtr.Zero;
            windowClass.hCursor = IntPtr.Zero;
            windowClass.lpszMenuName = null;
            windowClass.lpszClassName = "myClass";
            windowClass.lpfnWndProc = Marshal.GetFunctionPointerForDelegate(delegWndProc);
            windowClass.hIconSm = IntPtr.Zero;
            var regResult = WinApi.RegisterClassEx(ref windowClass);

            if (regResult == 0)
            {
                uint error = WinApi.GetLastError();
                return false;
            }


            var hWnd = WinApi.CreateWindowEx(0, windowClass.lpszClassName, "Hello Win32", WindowStyles.WS_EX_NOACTIVATE, 0, 0, 300, 400, IntPtr.Zero, IntPtr.Zero, windowClass.hInstance, IntPtr.Zero);

            Console.WriteLine($"{hWnd == IntPtr.Zero}  {Marshal.GetLastWin32Error()}");
            if (hWnd == IntPtr.Zero)
                return false;

            return true;
        }

        private static IntPtr myWndProc(IntPtr hWnd, WindowsMessage msg, IntPtr wParam, IntPtr lParam)
        {
            switch (msg)
            {
                // All GUI painting must be done here
                case WindowsMessage.WM_KEYDOWN:
                    Debugger.Break();
                    break;

                default:
                    break;
            }

            return DefWindowProc(hWnd, msg, wParam, lParam);
        }
    }
}
