using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Common.UI.ViewModels;

namespace Common.UI.Extensions
{
    public static class ApplicationExtensions
    {
        public static IClassicDesktopStyleApplicationLifetime AsDesktop(this Application sender, bool throwIfNotDesktop = false)
        {
            var desktop = sender.ApplicationLifetime as IClassicDesktopStyleApplicationLifetime;
            if (desktop == null && throwIfNotDesktop)
                throw new InvalidOperationException($"Application lifetime is not desktop!");

            return desktop;
        }

        public static void SetMainWindow<TWindow, TViewModel>(this Application sender, bool throwIfNotDesktop = false)
            where TWindow : Window, new()
            where TViewModel : ViewModelBase, new()
        {
            var desktop = sender.AsDesktop(throwIfNotDesktop).MainWindow = new TWindow { DataContext = new TViewModel() };
        }

        public static void SetVisualRoot<TView, TViewModel>(this Application sender)
            where TView : UserControl, new()
            where TViewModel : ViewModelBase, new()
        {
            switch (sender.ApplicationLifetime)
            {
                case IClassicDesktopStyleApplicationLifetime desktop:
                    if (desktop.MainWindow == null)
                        throw new InvalidOperationException("Main window is not initialized!");
                    desktop.MainWindow.Content = CreateRootView<TView, TViewModel>();
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
