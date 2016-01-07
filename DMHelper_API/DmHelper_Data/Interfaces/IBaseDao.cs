using NHibernate;

namespace DmHelper_Data.Interfaces
{
    public interface IBaseDao
    {
        ISession Connection { get; }
    }
}
