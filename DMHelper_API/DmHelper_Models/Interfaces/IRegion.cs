using System.Collections.Generic;

namespace DmHelper_Models.Interfaces
{
    public interface IRegion : IEntity
    {
        string Coordinates { get; set; }
        ICollection<IRegion> SubRegions { get; set; }
    }
}
