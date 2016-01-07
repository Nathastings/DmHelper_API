using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DmHelper_Data;
using DmHelper_Data.Interfaces;
using DmHelper_Models.Models;

namespace DMHelper_API.Controllers
{
    public class CampaignController : ApiController
    {
        private readonly ICampaignDao _dao;

        public CampaignController(ICampaignDao dao)
        {
            _dao = dao;
        }
        [HttpGet, ActionName("GetAll")]
        public IEnumerable<Campaign> GetAllCampaigns()
        {
            return _dao.GetAllCampaigns();
        }

    }
}
