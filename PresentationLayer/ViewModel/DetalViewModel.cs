using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    public class DetalViewModel
    {
        public string Model { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public IEnumerable<DetalViewModel> Detales { get; set; }
}
}
