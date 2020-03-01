using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    public class CarControler : ICarControler
    {
        private readonly ICarServis _carServis;
        public CarControler()
        {
            _carServis = new CarServis();

        }
        public void Create(CarViewModel model)
        {
            var carmodel = new CarModel
            {
                Name = "Porsche Macan",
                Color = "Red",
                Price = 120000,
                ManufactoryModel = new ManufactoryModel
                {
                    Name = "Porsche AG",
                    LicenseNumber = 02194023948923084,
                },
                Detals = new List<DetalModel>()

            };
            _carServis.Create(carmodel);
        }

        public void Creats(DetalViewModel model)
        {
            var detalmodel = new DetalModel
            {
                Name = "Wheel",
                Model = "Pirelli",
                Price = 1200,
                ManufactoryModel = new ManufactoryModel
                {
                    Name = "Pirelli & C",
                    LicenseNumber = 0865960456,
                },
                Detals = new List<DetalModel>()
            };
        }


    }
}



