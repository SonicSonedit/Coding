namespace Common.Runtime.Hotkeys
{
    public interface IHotkeyManager
    {
        public event Action<Hotkey> KeyPressed;
    }
}
