using System;
using DmHelper_Data.Interfaces;
namespace DmHelper_Data
{
    public class BaseDao : IBaseDao
    {
        public IConnection Connection { get; private set; }

        public BaseDao(IConnection connection)
        {
            Connection = connection;
        }
    }
}
