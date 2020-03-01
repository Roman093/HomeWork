using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    public class CarViewModel
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public IEnumerable<DetalViewModel> Detales { get; set; }
        public ManufactoryViewModel Manufactory { get; set; }

    }
}
