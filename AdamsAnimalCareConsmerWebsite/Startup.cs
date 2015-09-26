using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdamsAnimalCareConsmerWebsite.Startup))]
namespace AdamsAnimalCareConsmerWebsite
{
    using System.Web.Mvc;
    using Infrastructure.Windsor;
    using Castle.Windsor;
    using Castle.Windsor.Installer;

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var container = new WindsorContainer();
            container.Kernel.Resolver.AddSubResolver(new AppSettingsConvention());
            container.Install(FromAssembly.This());

            var controllerFactory = container.Resolve<DefaultControllerFactory>();
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);

            ConfigureAuth(app);
        }
    }
}
