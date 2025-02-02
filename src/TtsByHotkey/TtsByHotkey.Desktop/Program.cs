using Avalonia;
using Avalonia.ReactiveUI;
using Common.UI;
using TtsByHotkey.ViewModels;
using TtsByHotkey.Views;

namespace TtsByHotkey.Desktop;

class Program
{
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args) => BuildAvaloniaApp()
        .StartWithClassicDesktopLifetime(args);

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure(() => new TtsByHotkeyApplication { RegisterWindows = RegisterWindows })
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace()
            .UseReactiveUI();

    private static void RegisterWindows(WindowManager windowManager)
    {
        windowManager.Register<MainViewModel, MainWindow>();
    }
}
