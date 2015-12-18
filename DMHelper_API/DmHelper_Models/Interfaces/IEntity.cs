using System;

namespace DmHelper_Models.Interfaces
{
    public interface IEntity
    {
        int Id {get; set; }
        string Name { get; set; }
        string Description { get; set; }
    }
}
