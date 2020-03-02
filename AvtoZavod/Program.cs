using PresentationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoZavod
{
    class Program
    {
        static void Main(string[] args)
        {
            var carsControler = new CarControler();
            carsControler.Create(null);
            carsControler.Creats(null);

        }
    }
}


