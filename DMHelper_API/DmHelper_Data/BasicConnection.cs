using System;
using System.Configuration;
using System.Data.Common;
using System.Data;
using DmHelper_Data.Interfaces;

namespace DmHelper_Data
{
    public class BasicConnection : IConnection
    {
        
        public ConnectionStringSettings ConnString { get; set; }

        public BasicConnection(ConnectionStringSettings connString)
        {
            ConnString = connString;
        }

        public IDbConnection GetConnection()
        {
            var factory = DbProviderFactories.GetFactory(ConnString.ProviderName);
            IDbConnection connection = factory.CreateConnection();

            if (connection == null) throw new NullReferenceException("Database Connection failed to create.");

            connection.ConnectionString = ConnString.ConnectionString;
            return connection;
        }
    }
}
