using System;
using System.Collections.Generic;

using NHibernate;

using DmHelper_Data.Interfaces;
using DmHelper_Models.Models;

namespace DmHelper_Data
{
    public class CampaignDao : BaseDao, ICampaignDao
    {
        public CampaignDao( ISession connection) : base(connection) { }

        public IEnumerable<Campaign> GetAllCampaigns()
        {
            List<Campaign> campaigns = new List<Campaign>();
            campaigns.Add(new Campaign()
            {
                Id = 1,
                Name = "Lyrentia",
                Description = "Test"
            });

            campaigns.Add(new Campaign()
            {
                Id = 2,
                Name = "Seal of the Savior",
                Description = "Eons ago a great civilization was brought to its knees by a cataclysmic event. In a last ditch effort to prevent its spread the masters of the arcane trapped the force behind a massive Seal. Today, that seal is beginning to fail."
            });

            return campaigns;
        }

        public Campaign GetCampaign(int campaignId)
        {
            return new Campaign()
            {
                Id = 1,
                Name = "Lyrentia",
                Description = "Test"
            };
        }

        public IEnumerable<Campaign> GetCampaignsForWorld(int worldId)
        {
            List<Campaign> campaigns = new List<Campaign>();
            campaigns.Add(new Campaign()
            {
                Id = 1,
                Name = "Lyrentia",
                Description = "Test"
            });

            return campaigns;
        }
    }
}
