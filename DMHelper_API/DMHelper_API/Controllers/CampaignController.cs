using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DmHelper_Data;
using DmHelper_Models.Models;

namespace DMHelper_API.Controllers
{
    public class CampaignController : ApiController
    {
        CampaignDao _campDao;

        public CampaignController()
        {
            BasicConnection baseConnection = new BasicConnection(ConfigurationManager.ConnectionStrings["DmHelperConnection"]);
            _campDao = new CampaignDao(baseConnection);
        }
        [HttpGet, ActionName("GetAll")]
        public IEnumerable<Campaign> GetAllCampaigns()
        {
            return _campDao.GetAllCampaigns();
        }

    }
}
