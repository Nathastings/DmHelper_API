using System;
using System.Configuration;
using DmHelper_Data.Interfaces;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;


namespace DmHelper_Data
{
    public class PostGresConnection : IConnection
    {
        public ConnectionStringSettings ConnString { get; set; }
        public PostGresConnection(ConnectionStringSettings connString)
        {
            ConnString = connString;
        }
        public IPersistenceConfigurer GetConnection()
        {
            return PostgreSQLConfiguration.Standard
                //.ConnectionString(c=>
                //c.Host("localhost")
                //.Port(5432)
                //.Database("DmHelper")
                //.Username("dm_web_owner")
                //.Password("X4fhEibF2A!K")
                //)
                .ConnectionString(ConnString.ConnectionString)
                .ShowSql();
        }

        public void ModifyConfig(ref FluentConfiguration currentConfig)
        {
            currentConfig.ExposeConfiguration(x => x.SetProperty("hbm2ddl.keywords", "auto-quote")); //need this to work with postgres
        }
    }
}
