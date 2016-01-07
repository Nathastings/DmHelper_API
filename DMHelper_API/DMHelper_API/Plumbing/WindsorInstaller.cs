using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using System.Configuration;

using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

using DmHelper_Data.Interfaces;
using DmHelper_Data;
using DmHelper_Data.Plumbing;


namespace DMHelper_API.Plumbing
{
    public class WindsorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var fluentFacility = new DaoFacility(new PostGresConnection(ConfigurationManager.ConnectionStrings["DmHelperConnection"]));
            container.AddFacility(fluentFacility);
            RegisterDAO(container);
            RegisterApi(container);
        }

        private void RegisterDAO(IWindsorContainer container)
        {
            container.Register(
                Classes
                .FromAssemblyContaining<BaseDao>()
                .BasedOn<IBaseDao>()
                .WithServiceDefaultInterfaces()
                .LifestyleScoped()
            );
        }

        private void RegisterApi(IWindsorContainer container)
        {
            container.Register(
                Types
                .FromThisAssembly()
                .BasedOn<ApiController>()
                .LifestyleScoped()
            );
        }


    }
}