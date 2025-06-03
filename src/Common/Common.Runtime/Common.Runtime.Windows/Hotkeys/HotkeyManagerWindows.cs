using System.Diagnostics;
using Common.Runtime.Hotkeys;


namespace Common.Runtime.Windows.Hotkeys
{
    public class HotkeyManagerWindows : IHotkeyManager
    {
        public event Action<Hotkey> KeyPressed;
        private readonly WinApi.HookCallbackDelegate _keyboardHookCallback;
        private volatile IntPtr _hookPtr;
        private volatile SynchronizationContext _synchronizationContext;
        private volatile bool _working = false;

        public HotkeyManagerWindows()
        {
            _keyboardHookCallback = KeyboardHookCallback;  // надо запинить в памяти функцию
        }

        public void Start()
        {
            AssertSynchronizationContext();

            if (_working)
                return;

            _synchronizationContext = SynchronizationContext.Current;
            _hookPtr = WinApi.SetWindowsHookEx(WinApi.HookId.Keyboard, KeyboardHookCallback, IntPtr.Zero, 0);  // надо запинить в памяти указатель на хук
            WinApi.CheckWinApiResult(() => _hookPtr != IntPtr.Zero);
        }

        public void Stop()
        {
            AssertSynchronizationContext();

            if (!_working)
                return;

            _synchronizationContext = null;
        }

        private IntPtr KeyboardHookCallback(int code, IntPtr wParam, ref KeyboardHookLParam lParam)
        {
            if (code != 0)
                return WinApi.CallNextHookEx(_hookPtr, code, wParam, ref lParam);

            var wParamKey = (WindowsKey)wParam;
            var wParamEvent = (KeyboardEvent)(wParam.ToInt32());
            var wParamEvent2 = (KeyboardEvent)wParam;
            var lParamVirtualCode = (WindowsKey)lParam.VirtualCode;
            var lParamScanCode = (WindowsKey)lParam.ScanCode;

            var virtualKey = (WindowsKey)lParam.VirtualCode;
            if (virtualKey != WindowsKey.ShiftLeft)
            {
                var a = ";";
            }
            if (virtualKey == WindowsKey.Packet)  // packet opcode, надо смотреть lParam.ScanCode
            {
                //var keyboardEvent = (KeyboardEvent)(wParam.ToInt32());
                //if (keyboardEvent == KeyboardEvent.KeyDown || keyboardEvent == KeyboardEvent.SysKeyDown)
                //{
                //    // todo?
                //}
                //if (keyboardEvent == KeyboardEvent.KeyUp || keyboardEvent == KeyboardEvent.SysKeyUp)
                //{
                //    // todo?
                //}
                return WinApi.CallNextHookEx(_hookPtr, code, wParam, ref lParam);
            }

            return WinApi.CallNextHookEx(_hookPtr, code, wParam, ref lParam);
        }

        private void AssertSynchronizationContext()
        {
            if (SynchronizationContext.Current == null)
                throw new InvalidOperationException($"{nameof(SynchronizationContext)} is null! Try calling from UI thread.");

            if (_synchronizationContext != null && _synchronizationContext != SynchronizationContext.Current)
                throw new InvalidOperationException("Call from invalid thread! Call from the same thread manager was started in!");
        }

        public void Dispose() => Stop();
    }
}
