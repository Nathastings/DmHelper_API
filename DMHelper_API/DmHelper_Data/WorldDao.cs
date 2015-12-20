using System;
using System.Collections.Generic;
using DmHelper_Data.Interfaces;
using DmHelper_Models.Models;

namespace DmHelper_Data
{
    public class WorldDao : BaseDao, IWorldDao
    {

        public WorldDao(IConnection connection) : base(connection) { }

        public IEnumerable<World> GetAllWorlds()
        {
            List<World> myWorlds = new List<World>();
            World lyrentia = new World()
            {
                Id = 1,
                Name = "Lyrentia",
                Description = "Built upon the remnants of an ancient civilization that is now lost, civilization has reached a temperate balance in the kingdom of Lyrentia."
            };

            myWorlds.Add(lyrentia);

            World arxia = new World()
            {
                Id = 1,
                Name = "Arxia",
                Description = "Egan's World."
            };
            
            myWorlds.Add(arxia);

            return myWorlds;
        }

        public World GetWorld(int worldId)
        {
            World lyrentia = new World()
            {
                Id = 1,
                Name = "Lyrentia",
                Description = "Built upon the remnants of an ancient civilization that is now lost, civilization has reached a temperate balance in the kingdom of Lyrentia."
            };

            return lyrentia;
        }
    }
}
