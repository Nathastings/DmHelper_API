using System;
using DmHelper_Models.Interfaces;

namespace DmHelper_Models.Models
{
    public class Adventure : IAdventure
    {
        public string Description { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}
