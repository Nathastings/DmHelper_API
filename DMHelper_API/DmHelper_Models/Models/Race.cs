using DmHelper_Models.Interfaces;
using System.Collections.Generic;

namespace DmHelper_Models.Models
{
    public class Race : IRace
    {
        public string Description {get; set;}

        public int Id { get; set; }

        public string Name { get; set; }
    }
}
