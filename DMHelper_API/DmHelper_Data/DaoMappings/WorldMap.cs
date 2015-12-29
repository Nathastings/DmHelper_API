﻿using FluentNHibernate.Mapping;
using DmHelper_Models.Models;

namespace DmHelper_Data.DaoMappings
{
    public class WorldMap: ClassMap<World>
    {
        public WorldMap()
        {
            Table("world");
            Schema("dmhelper_client");
            Id(x => x.Id);
            Map(x => x.ToolTip).Column("shortdescription");
            Map(x => x.Description).Column("longdescription");
            Map(x => x.Name).Column("name");
            Map(x => x.DefaultImageId).Column("defaultimageid");
        }
    }
}