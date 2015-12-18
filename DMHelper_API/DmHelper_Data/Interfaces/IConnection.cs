using System.Data;

namespace DmHelper_Data.Interfaces
{
    public interface IConnection
    {
        IDbConnection GetConnection();
    }
}
