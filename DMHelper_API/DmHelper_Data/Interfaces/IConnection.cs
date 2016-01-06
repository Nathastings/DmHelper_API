using FluentNHibernate.Cfg.Db;
using System.Data;

namespace DmHelper_Data.Interfaces
{
    public interface IConnection
    {
        IPersistenceConfigurer GetConnection();
    }
}
