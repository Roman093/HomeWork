using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class DetalType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<DetalModel> DetalModels { get; set; }
    }
}
