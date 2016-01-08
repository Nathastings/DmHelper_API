using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using DmHelper_Data.Interfaces;
using DmHelper_Models.Models;

namespace DMHelper_API.Controllers
{
    
    public class WorldController: ApiController
    {
        private readonly IWorldDao _dao;

        public WorldController(IWorldDao dao)
        {
            _dao = dao;
        }
        
        [HttpGet, ActionName("GetAll")]
        //[EnableCors(origins: "*", headers: "*", methods: "GET")]
        public IEnumerable<World> GetAllWorlds()
        {
            var worlds = _dao.GetAllWorlds();
            if (worlds == null)  worlds = new List<World>();

            if (worlds.Count() > 0)
            {
                foreach(World w in worlds)
                {
                    w.DefaultImage = w.Images.Where(x => x.Id == w.DefaultImageId).FirstOrDefault();
                }
            }

            return worlds;
        }

        [HttpGet, ActionName("GetOne")]
        public World GetWorld_ByID(int id) {

            var world = _dao.GetWorld(id);
            if (world == null) return new World();

        

            return world;
        }
        
    }
}