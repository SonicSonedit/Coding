using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Common.UI.ViewModels;

namespace Common.UI.Extensions
{
    public static class ApplicationExtensions
    {
        public static void SetVisualRoot<TWindow, TView, TViewModel>(this Application sender)
            where TWindow : Window, new()
            where TView : UserControl, new()
            where TViewModel : ViewModelBase, new()
        {
            switch (sender.ApplicationLifetime)
            {
                case IClassicDesktopStyleApplicationLifetime desktop:
                    desktop.MainWindow = new TWindow() { Content = CreateRootView<TView, TViewModel>() };
                    break;

                case ISingleViewApplicationLifetime singleViewPlatform:
                    singleViewPlatform.MainView = CreateRootView<TView, TViewModel>();
                    break;

                default:
                    throw new NotSupportedException($"Unknown {nameof(sender.ApplicationLifetime)}: {sender.ApplicationLifetime}");
            }
        }

        private static TView CreateRootView<TView, TViewModel>() where TView : UserControl, new() where TViewModel : ViewModelBase, new() => new TView() { DataContext = new TViewModel() };
    }
}
