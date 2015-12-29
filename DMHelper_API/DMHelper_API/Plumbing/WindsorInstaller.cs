using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using DmHelper_Data.Interfaces;
using DmHelper_Data;

namespace DMHelper_API.Plumbing
{
    public class WindsorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            throw new NotImplementedException();
        }

        private void RegisterConnection(IWindsorContainer container)
        {
            container.Register();
        }
    }
}