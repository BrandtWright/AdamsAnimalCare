using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdamsAnimalCareConsmerWebsite.Infrastructure.Windsor
{
    using Castle.MicroKernel;
    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;

    public class ContainerInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IWindsorContainer>().Instance(container));
            container.Register(Component.For<IKernel>().Instance(container.Kernel));
        }
    }
}