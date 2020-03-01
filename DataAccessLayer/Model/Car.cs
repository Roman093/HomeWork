using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class Car
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public int ManufactoryId { get; set; }
        public Manufactory Manufactory { get; set; }
        public int CarTypeId { get; set; }

        public virtual ICollection<Detal> Detals { get; set; }
    }
}
