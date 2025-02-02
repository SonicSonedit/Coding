namespace Common.Runtime.Hotkeys
{
    public interface IHotkeyManager : IDisposable
    {
        event Action<Hotkey> KeyPressed;
        void Start();
        void Stop();
    }
}
