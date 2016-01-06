using System;
using DmHelper_Data.DaoMappings;
using DmHelper_Data.Interfaces;

using Castle.Core.Internal;
using Castle.MicroKernel.Facilities;
using Castle.MicroKernel.Registration;

using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using FluentNHibernate.Mapping;

namespace DmHelper_Data.Plumbing
{
    class DaoFacility : AbstractFacility
    {
        private IConnection currentConnection;

        public DaoFacility(IConnection connection) : base()
        {
            currentConnection = connection;
        }

        protected override void Init()
        {
            var config = BuildDatabaseConfiguration();
            Kernel.Register(
                Component.For<ISessionFactory>()
                .UsingFactoryMethod(_ => config.BuildSessionFactory()),
                Component.For<ISession>()
                .UsingFactoryMethod(k => k.Resolve<ISessionFactory>().OpenSession()).LifestylePerWebRequest()
                );
        }


        private Configuration BuildDatabaseConfiguration()
        {
            var config = Fluently.Configure();
            config.Database(PostgreSQLConfiguration.PostgreSQL82
                .ConnectionString(currentConnection.GetConnectionString()));
            config.Mappings(m => m.FluentMappings.AddFromAssemblyOf<WorldMap>());
            config.ExposeConfiguration(x => x.SetProperty("hbm2ddl.keywords", "auto-quote")); //need this to work with postgres
            return config.BuildConfiguration();
        }
    }
}
