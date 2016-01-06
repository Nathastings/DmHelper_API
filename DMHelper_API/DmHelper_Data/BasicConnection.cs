﻿using System;
using System.Configuration;
using System.Data.Common;
using System.Data;
using DmHelper_Data.Interfaces;
using FluentNHibernate.Cfg.Db;

namespace DmHelper_Data
{
    public class BasicConnection : IConnection
    {
        
        public ConnectionStringSettings ConnString { get; set; }

        public BasicConnection(ConnectionStringSettings connString)
        {
            ConnString = connString;
        }

        public IPersistenceConfigurer GetConnection()
        {
            return MsSqlConfiguration.MsSql2012.ConnectionString(ConnString.ConnectionString).ShowSql();
        }
    }
}
