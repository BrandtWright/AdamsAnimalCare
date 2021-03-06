﻿namespace AdamsAnimalCareConsmerWebsite.Infrastructure.Windsor
{
    using System.Web.Mvc;
    using Castle.MicroKernel.Registration;
    using Castle.MicroKernel.SubSystems.Configuration;
    using Castle.Windsor;

    public class ControllerFactoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component
                    .For<DefaultControllerFactory>()
                    .ImplementedBy<CastleControllerFactory>()
            );
        }
    }
}