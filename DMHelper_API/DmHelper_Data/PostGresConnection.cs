using System;
using System.Configuration;
using DmHelper_Data.Interfaces;
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
            return PostgreSQLConfiguration.PostgreSQL82.ConnectionString(ConnString.ConnectionString).ShowSql();
        }
    }
}
