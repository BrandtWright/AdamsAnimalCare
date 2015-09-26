namespace AdamsAnimalCareConsmerWebsite.Infrastructure.Windsor
{
    using System.Web.Mvc;
    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;

    /// <summary>
    /// Performs the installation in the IWindsorContainer" />.
    /// </summary>
    /// <exception cref="System.NotImplementedException"></exception>
    public class ControllerInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly()
                .BasedOn<IController>()
                .Unless(x => x.Name.EndsWith("SessionlessController"))
                .LifestyleTransient());
        }
    }
}