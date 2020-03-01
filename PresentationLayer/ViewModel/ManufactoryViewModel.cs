using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
   public class ManufactoryViewModel
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public long LicenseNumber { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
