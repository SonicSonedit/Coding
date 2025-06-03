using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Common.Runtime.Windows.Sound
{
    delegate nint WndProc(nint hWnd, WindowsMessage msg, nint wParam, nint lParam);

    class WinApiWindowTest
    {
        private WndProc _delegWndProc = myWndProc;

        internal bool create()
        {
            var windowClass = new CreateWindowClass();
            windowClass.cbSize = Marshal.SizeOf(typeof(CreateWindowClass));
            windowClass.style = WindowStyles.WS_EX_NOACTIVATE;
            windowClass.hbrBackground = nint.Zero;
            windowClass.cbClsExtra = 0;
            windowClass.cbWndExtra = 0;
            windowClass.hInstance = nint.Zero;
            windowClass.hIcon = nint.Zero;
            windowClass.hCursor = nint.Zero;
            windowClass.lpszMenuName = null;
            windowClass.lpszClassName = "myClass";
            windowClass.lpfnWndProc = Marshal.GetFunctionPointerForDelegate(_delegWndProc);
            windowClass.hIconSm = nint.Zero;
            var regResult = WinApi.RegisterClassEx(ref windowClass);

            if (!WinApi.CheckWinApiResult(() => regResult != 0))
                return false;

            var hWnd = WinApi.CreateWindowEx(0, windowClass.lpszClassName, "Hello Win32", WindowStyles.WS_EX_NOACTIVATE, 0, 0, 300, 400, nint.Zero, nint.Zero, windowClass.hInstance, nint.Zero);
            return WinApi.CheckWinApiResult(() => hWnd != IntPtr.Zero);
        }

        private static nint myWndProc(nint hWnd, WindowsMessage msg, nint wParam, nint lParam)
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

            return WinApi.DefWindowProc(hWnd, msg, wParam, lParam);
        }
    }
}
