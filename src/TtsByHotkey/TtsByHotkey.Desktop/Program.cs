using Autofac;
using Avalonia;
using Avalonia.ReactiveUI;
using Common.Runtime.Hotkeys;
using Common.Runtime.Windows.Hotkeys;
using Common.UI;
using TtsByHotkey.ViewModels;
using TtsByHotkey.Views;

namespace TtsByHotkey.Desktop;

class Program
{
    private static TtsByHotkeyApplication CreateApplication() => new()
    {
        RegisterPlatformComponents = RegisterPlatformComponents,
        RegisterWindows = RegisterWindows
    };

    [STAThread]
    public static void Main(string[] args) => BuildAvaloniaApp()
        .StartWithClassicDesktopLifetime(args);

    public static AppBuilder BuildAvaloniaApp()
    {
        return AppBuilder.Configure(CreateApplication)
                .UsePlatformDetect()
                .WithInterFont()
                .LogToTrace()
                .UseReactiveUI();
    }

    private static void RegisterPlatformComponents(Autofac.ContainerBuilder builder)
    {
        builder.RegisterType<HotkeyManagerWindows>().As<IHotkeyManager>();
    }

    private static void RegisterWindows(WindowManager windowManager)
    {
        windowManager.Register<MainViewModel, MainWindow>();
    }
}
