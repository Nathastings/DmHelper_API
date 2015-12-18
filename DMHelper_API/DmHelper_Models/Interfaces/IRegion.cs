using System.Collections.Generic;

namespace DmHelper_Models.Interfaces
{
    public interface IRegion : IEntity
    {
        string Coordinates { get; set; }
        IEnumerable<IRegion> SubRegions { get; set; }
    }
}
