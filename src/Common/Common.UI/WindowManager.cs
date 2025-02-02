using Autofac;
using Avalonia;
using Avalonia.Controls;
using Common.Extensions;
using Common.UI.Extensions;
using Common.UI.ViewModels;

namespace Common.UI
{
    public class WindowManager
    {
        private readonly IComponentContext _container;
        private readonly Dictionary<Type, Func<Window>> _registrations;
        private readonly Dictionary<Window, ViewModelBase> _windows;
        private readonly Dictionary<ViewModelBase, HashSet<Window>> _windowsByViewModel;

        public Action<ViewModelBase> Closed;

        public WindowManager(IComponentContext container)
        {
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _registrations = [];
            _windows = [];
            _windowsByViewModel = [];
        }

        public void Register<TViewModel, TWindow>(Func<TWindow> windowFactroy = null) where TViewModel : ViewModelBase where TWindow : Window, new()
        {
            if (!_container.IsRegistered<TViewModel>())
                throw new InvalidOperationException($"ViewModel {typeof(TViewModel).Name} is not registered in provided dependency injection container!");

            _registrations.Add(typeof(TViewModel), windowFactroy ?? (() => new TWindow()));
        }

        public void Show<TViewModel>() where TViewModel : ViewModelBase => Show(_container.Resolve<TViewModel>());
        public void Show<TViewModel>(TViewModel viewModel) where TViewModel : ViewModelBase
        {
            CheckMainWindowIsTracked();

            var viewModelType = typeof(TViewModel);
            var window = _registrations[viewModelType]();
            TrackWindow(window, viewModel);
            window.DataContext = viewModel;
            window.Closed += OnWindowClosed;
            window.Show();
        }

        public void Close<TViewModel>() where TViewModel : ViewModelBase
        {
            var viewModelType = typeof(TViewModel);
            _windowsByViewModel.Keys.Where(viewModel => viewModel.GetType() == viewModelType).ForEach(Close);
        }

        public void Close<TViewModel>(TViewModel viewModel) where TViewModel : ViewModelBase
        {
            _windowsByViewModel.GetValueOrDefault(viewModel)?.ForEach(window => window.Close());
        }

        private void OnWindowClosed(object sender, EventArgs e)
        {
            var window = (Window)sender;
            var viewModel = _windows.GetValueOrDefault(window);
            if (viewModel != null)
            {
                var existing = _windowsByViewModel.GetValueOrDefault(viewModel);
                if (existing != null)
                {
                    existing.Remove(window);
                    if (existing.Count == 0)
                        _windowsByViewModel.Remove(viewModel);
                }
            }

            _windows.Remove(window);
            Closed?.Invoke(viewModel);
        }

        private void CheckMainWindowIsTracked()
        {
            var mainWindow = Application.Current.AsDesktop()?.MainWindow;
            if (mainWindow != null && !_windows.ContainsKey(mainWindow))
                TrackWindow(mainWindow, mainWindow.DataContext as ViewModelBase);
        }

        private void TrackWindow<TWindow, TViewModel>(TWindow window, TViewModel viewModel) where TWindow : Window where TViewModel : ViewModelBase
        {
            _windows.Add(window, viewModel);
            if (viewModel != null)
            {
                if (!_windowsByViewModel.ContainsKey(viewModel))
                    _windowsByViewModel.Add(viewModel, []);
                _windowsByViewModel[viewModel].Add(window);
            }
        }
    }
}
