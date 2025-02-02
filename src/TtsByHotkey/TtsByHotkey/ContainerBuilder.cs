using Autofac;
using Common.UI;
using TtsByHotkey.ViewModels;

namespace TtsByHotkey
{
    public static class ContainerBuilder
    {
        public static IContainer Build(Action<Autofac.ContainerBuilder> registerPlatformComponents)
        {
            var builder = new Autofac.ContainerBuilder();
            builder.RegisterType<MainViewModel>();
            builder.RegisterType<WindowManager>();

            registerPlatformComponents?.Invoke(builder);

            return builder.Build();
        }
    }
}
