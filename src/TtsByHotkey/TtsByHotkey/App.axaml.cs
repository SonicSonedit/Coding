using Avalonia;
using Avalonia.Markup.Xaml;
using Common.Helpers;
using Common.UI.Extensions;
using NLog;
using TtsByHotkey.ViewModels;
using TtsByHotkey.Views;

namespace TtsByHotkey;

public partial class App : Application
{
    private Logger _logger;

    public override void Initialize()
    {
        LogHelper.InitializeLogging("LoggerConfig.json");
        _logger = LogManager.GetLogger(nameof(Application));
        _logger.Info("Starting...");

        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        _logger.Info("Initializing UI...");

        this.SetVisualRoot<MainWindow, MainView, MainViewModel>();
        base.OnFrameworkInitializationCompleted();

        _logger.Info("Started");
    }
}
