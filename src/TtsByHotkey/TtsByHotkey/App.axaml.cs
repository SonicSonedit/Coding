using Autofac;
using Avalonia;
using Avalonia.Markup.Xaml;
using Common.Helpers;
using Common.UI;
using NLog;
using TtsByHotkey.ViewModels;

namespace TtsByHotkey;

public partial class App : Application
{
    private Logger _logger;

    public static Action<WindowManager> RegisterWindows { get; set; }

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

        var container = ContainerBuilder.Build();
        var windowManager = container.Resolve<WindowManager>();
        RegisterWindows(windowManager);
        base.OnFrameworkInitializationCompleted();
        windowManager.Show<MainViewModel>();

        _logger.Info("Started");
    }
}
