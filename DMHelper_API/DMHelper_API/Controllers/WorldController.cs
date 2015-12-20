using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DmHelper_Data;
using DmHelper_Models.Models;

namespace DMHelper_API.Controllers
{
    public class WorldController: ApiController
    {
        private CampaignDao _campDao;
        private WorldDao _worldDao;

        public WorldController()
        {
            BasicConnection baseConnection = new BasicConnection(ConfigurationManager.ConnectionStrings["DmHelperConnection"]);
            _campDao = new CampaignDao(baseConnection);
            _worldDao = new WorldDao(baseConnection);
        }
        
        public IEnumerable<World> GetAllWorlds()
        {
            var worlds = _worldDao.GetAllWorlds();
            if (worlds == null)  worlds = new List<World>();

            if (worlds.Count() > 0)
            {
                //fill in my campaign information.
                foreach(World myWorld in worlds)
                {
                    myWorld.Campaigns = FetchWorldCampaigns(myWorld.Id);
                }
            }

            return worlds;
        }

        public World GetWorld_ByID(int id) {

            var world = _worldDao.GetWorld(id);
            if (world == null) return new World();

            world.Campaigns = FetchWorldCampaigns(world.Id);

            return world;
        }

        private IEnumerable<Campaign> FetchWorldCampaigns(int worldId) {
            return _campDao.GetCampaignsForWorld(worldId);
        }
    }
}