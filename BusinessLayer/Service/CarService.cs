using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarService()
        {
            _carRepository = new CarRepository();

        }
        public void Create(CarModel model)
        {
            var car = new Car
            {
                Name = model.Name,
                Price = model.Price,

                Detals = model.Detals.Select(x => new Detal
                {
                    Model = x.Model,
                    Name = x.Name,
                    DetalTypeId = (int)x.Type,
                    Price = x.Price
                }).ToList()
            };
            _carRepository.Create(car);
        }
    }
}

