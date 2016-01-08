using FluentNHibernate.Mapping;
using DmHelper_Models.Models;


namespace DmHelper_Data.DaoMappings
{
    public class ImageMap : ClassMap<Image>
    {
        public ImageMap()
        {
            Table("image");
            Schema("dmhelper_client");
            Id(x => x.Id).Column("imageid");
            Map(x => x.ImageUrl).Column("imageurl").Length(150);
            Map(x => x.IsDeleted).Column("isdeleted");

            //HasManyToMany(x => x.Worlds)
            //    .Cascade.All()
            //    .Inverse()
            //    .Table("world_images")
            //    .Schema("dmhelper_client")
            //    .ChildKeyColumn("worldid")
            //    .ParentKeyColumn("imageid");
        }
    }
}
