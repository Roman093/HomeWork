using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class Manufactory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        

        public long LicenseNumber { get; set; }
        public virtual ICollection<Detal> Detals { get; set; }
    }
}
