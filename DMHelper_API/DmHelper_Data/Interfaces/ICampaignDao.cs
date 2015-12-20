using System.Collections.Generic;
using DmHelper_Models.Models;

namespace DmHelper_Data.Interfaces
{
    public interface ICampaignDao: IBaseDao
    {
        IEnumerable<Campaign> GetAllCampaigns();
        Campaign GetCampaign(int campaignId);
        IEnumerable<Campaign> GetCampaignsForWorld(int worldId);
    }
}
