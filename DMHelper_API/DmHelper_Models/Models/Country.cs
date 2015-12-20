using System;
using System.Collections.Generic;
using DmHelper_Models.Interfaces;

namespace DmHelper_Models.Models
{
    public class Country : IRegion
    {
        public string Coordinates { get; set; }

        public string Description { get; set; }

        public int Id { get; set; }

        public string Name{ get; set; }
        public ICollection<IRegion> SubRegions { get; set; }
    }
}
