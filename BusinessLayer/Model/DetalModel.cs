using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class DetalModel
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public ManufactoryModel ManufactoryModel { get; set; }
        public virtual ICollection<DetalModel> Detals { get; set; }
        public virtual DetalTypeEnum Type { get; set; }
    }
}
