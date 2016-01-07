using System;
using System.Collections.Generic;

using NHibernate;

using DmHelper_Data.Interfaces;
using DmHelper_Models.Models;

namespace DmHelper_Data
{
    public class WorldDao : BaseDao, IWorldDao
    {

        public WorldDao(ISession connection) : base(connection) { }

        public IEnumerable<World> GetAllWorlds()
        {
            
            using (var trans = Connection.BeginTransaction())
            {
                var myWorlds = Connection.QueryOver<World>().List();
                trans.Commit();
                return myWorlds;
            }
        }

        public World GetWorld(int worldId)
        {
            using (var trans = Connection.BeginTransaction())
            {
                var myWorld = Connection.QueryOver<World>().Where(w => w.Id == worldId).SingleOrDefault();
                trans.Commit();
                return myWorld;
            }
        }
    }
}
