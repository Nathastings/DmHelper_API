using System;
using System.Collections.Generic;
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

        List<Campaign> campaigns = new List<Campaign>();

        public IEnumerable<Campaign> GetAllCampaigns()
        {
            campaigns.Add(new Campaign() {
                Id = 1,
                Name = "Lyrentia",
                Description = "Built upon the remnants of an ancient civilization that is now lost, civilization has reached a temperate balance in the kingdom of Lyrentia."
            });

            campaigns.Add(new Campaign() {
                Id = 2,
                Name = "Seal of the Savior",
                Description = "Eons ago a great civilization was brought to its knees by a cataclysmic event. In a last ditch effort to prevent its spread the masters of the arcane trapped the force behind a massive Seal. Today, that seal is beginning to fail."
            });


            return campaigns;
        }

    }
}
