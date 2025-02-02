using Autofac;
using Common.UI;
using TtsByHotkey.ViewModels;

namespace TtsByHotkey
{
    public static class ContainerBuilder
    {
        public static IContainer Build()
        {
            var builder = new Autofac.ContainerBuilder();
            builder.RegisterType<MainViewModel>();
            builder.RegisterType<WindowManager>();
            return builder.Build();
        }
    }
}
