﻿using Autofac;
using Avalonia;
using Avalonia.Markup.Xaml;
using Common.Helpers;
using Common.Runtime.Hotkeys;
using Common.UI;
using NLog;
using TtsByHotkey.ViewModels;

namespace TtsByHotkey;

public partial class TtsByHotkeyApplication : Application
{
    private Logger _logger;

    public Action<Autofac.ContainerBuilder> RegisterPlatformComponents { get; init; }
    public Action<WindowManager> RegisterWindows { get; init; }

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

        var container = ContainerBuilder.Build(RegisterPlatformComponents);
        var windowManager = container.Resolve<WindowManager>();
        RegisterWindows?.Invoke(windowManager);
        base.OnFrameworkInitializationCompleted();

        container.Resolve<IHotkeyManager>().Start();
        windowManager.Show<MainViewModel>();

        _logger.Info("Started");
    }
}
