using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class CarModel
    {
        public int ID { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int ManufactoryId { get; set; }
        public ManufactoryModel ManufactoryModel { get; set; }
        public int CarTypeId { get; set; }

        public virtual ICollection<DetalModel> Detals { get; set; }
    }
}
