using FluentNHibernate.Mapping;
using DmHelper_Models.Models;

namespace DmHelper_Data.DaoMappings
{
    public class WorldMap: ClassMap<World>
    {
        public WorldMap()
        {
            Table("world");
            Schema("dmhelper_client");
            Id(x => x.Id).Column("worldid");
            Map(x => x.ToolTip).Column("shortdescription");
            Map(x => x.Description).Column("longdescription");
            Map(x => x.Name).Column("name");
            Map(x => x.DefaultImageId).Column("defaultimageid");

            HasManyToMany(x => x.Images)
                .Cascade.All()
                .Table("world_images")
                .Schema("dmhelper_client")
                .ChildKeyColumn("imageid")
                .ParentKeyColumn("worldid");
        }
    }
}
