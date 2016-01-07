using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using System.Data;

namespace DmHelper_Data.Interfaces
{
    public interface IConnection
    {
        IPersistenceConfigurer GetConnection(); //creates the configuration for my database type.
        void ModifyConfig(ref FluentConfiguration currentConfig); //makes any raw modifications to the config that are environment specific.
    }
}
