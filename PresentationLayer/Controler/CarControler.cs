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
        private readonly ICarService _carService;
        public CarControler()
        {
            _carService = new CarService();

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
                {
         new DetalModel

            {
                Name = "Wheel",
                Model = "Pirelli",
                Price = 1200,
               Type = Common.DetalTypeEnum.TitanDisc

                },
                }
            };

            _carService.Create(carmodel);
        }


    }
}



