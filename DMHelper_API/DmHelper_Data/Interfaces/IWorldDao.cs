using System.Collections.Generic;
using DmHelper_Models.Models;

namespace DmHelper_Data.Interfaces
{
    interface IWorldDao : IBaseDao
    {
        IEnumerable<World> GetAllWorlds();
        World GetWorld(int worldId);
        
    }
}
