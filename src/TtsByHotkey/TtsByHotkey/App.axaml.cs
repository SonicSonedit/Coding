using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Common.Helpers;
using NLog;
using TtsByHotkey.ViewModels;
using TtsByHotkey.Views;

namespace TtsByHotkey;

public partial class App : Application
{
    public override void Initialize()
    {
        LogHelper.InitializeLogging("LoggerConfig.json");
        var entryPointLogger = LogManager.GetLogger(nameof(Application));
        entryPointLogger.Info("Started");
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainViewModel()
            };
        }
        else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
        {
            singleViewPlatform.MainView = new MainView
            {
                DataContext = new MainViewModel()
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}
