using System;
using DmHelper_Models.Interfaces;

namespace DmHelper_Models.Models
{
    public class Adventure : IAdventure
    {
        public virtual string Description { get; set; }
        public virtual string ToolTip { get; set; }
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }
        public virtual int DefaultImageId { get; set; }
    }
}
