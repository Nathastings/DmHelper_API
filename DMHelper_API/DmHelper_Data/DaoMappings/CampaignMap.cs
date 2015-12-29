using FluentNHibernate.Mapping;
using DmHelper_Models.Models;

namespace DmHelper_Data.DaoMappings
{
    public class CampaignMap: ClassMap<Campaign>
    {
        public CampaignMap()
        {
            Id(x => x.Id);
            Map(x => x.Description).Column("longDescription");
            Map(x => x.ToolTip).Column("shortDescription");
            Schema("dmhelper_client");
            Table("campaign");
        }
    }
}
