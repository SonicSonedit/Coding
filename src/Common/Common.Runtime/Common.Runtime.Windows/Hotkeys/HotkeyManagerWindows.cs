using System.Diagnostics;
using System.Runtime.InteropServices;
using Common.Runtime.Hotkeys;
using static Common.Runtime.Windows.Hotkeys.WinApi;

namespace Common.Runtime.Windows.Hotkeys
{
    public class HotkeyManagerWindows : IHotkeyManager
    {
        public event Action<Hotkey> KeyPressed;
        private volatile SynchronizationContext _synchronizationContext;
        private volatile WndProcDelegate _wndProc;
        private volatile IntPtr _hwnd;
        private volatile bool _working = false;
        private volatile IntPtr _classHandle = IntPtr.Zero;

        public void Start()
        {
            AssertSynchronizationContext();

            if (_working)
                return;

            _synchronizationContext = SynchronizationContext.Current;


            var a = new WinApiWindowTest();
            a.create();
        }

        public void Stop()
        {
            AssertSynchronizationContext();

            if (!_working)
                return;

            WinApi.DestroyWindow(_hwnd);
            _synchronizationContext = null;
        }

        private void AssertSynchronizationContext()
        {
            if (SynchronizationContext.Current == null)
                throw new InvalidOperationException($"{nameof(SynchronizationContext)} is null! Try calling from UI thread.");

            if (_synchronizationContext != null && _synchronizationContext != SynchronizationContext.Current)
                throw new InvalidOperationException("Call from invalid thread! Call from the same thread manager was started in!");
        }

        private void HandleKeyPress(IntPtr wParam)
        {
            Debugger.Break();
            var test1 = (Key)wParam;
            var test2 = (PhysicalKey)wParam;
            var test3 = (WindowsKey)wParam;
        }

        private void HandleKeyPress(IntPtr wParam, IntPtr lParam)
        {
            var testw1 = (Key)wParam;
            var testw2 = (PhysicalKey)wParam;
            var testw3 = (KeyModifiers)wParam;
            var testw4 = (WindowsKey)wParam;

            var testl1 = (Key)lParam;
            var testl2 = (PhysicalKey)lParam;
            var testl3 = (KeyModifiers)lParam;
            var testl4 = (WindowsKey)lParam;
        }

        public void Dispose() => Stop();
    }
}
