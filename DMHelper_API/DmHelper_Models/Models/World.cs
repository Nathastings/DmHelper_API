﻿using System;
using System.Collections.Generic;
using DmHelper_Models.Interfaces;
namespace DmHelper_Models.Models
{
    public class World : IRegion
    {
        public virtual string Coordinates { get; set; }
        public virtual string Description { get; set; }
        public virtual string ToolTip { get; set; }
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<IRegion> SubRegions { get; set; }
        public virtual IEnumerable<Campaign> Campaigns { get; set; }
        public virtual int DefaultImageId{get; set;}
        public virtual Image DefaultImage { get; set; }
        public virtual IList<Image> Images { get; protected set; }
    }
}
