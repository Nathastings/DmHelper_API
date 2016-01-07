using System;
using NHibernate;
using DmHelper_Data.Interfaces;
namespace DmHelper_Data
{
    public class BaseDao : IBaseDao
    {
        public ISession Connection { get; private set; }

        public BaseDao(ISession connection)
        {
            Connection = connection;
        }
    }
}
