using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DmHelper_Models.Models
{
    public class Image
    {
        public virtual int Id { get; set; }
        public virtual string ImageUrl { get; set; }
        public virtual bool IsDeleted { get; set; }

        //public virtual IList<World> Worlds { get; protected set; }
    }
}
