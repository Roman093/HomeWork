using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CarRepository : ICarRepository
    {
        private readonly CarContext _ctx;

        public CarRepository()
        {
            _ctx = new CarContext();
        }

        public void Create(Car model)
        {
            _ctx.Cars.Add(model);
            _ctx.SaveChanges();
        }
            public void Update(Car model)
            {
                _ctx.Entry(model).State = EntityState.Modified;
            }

            public IEnumerable<Car> Find(Func<Car, Boolean> predicate)
            {
                return _ctx.Cars.Where(predicate).ToList();
            }

            public void Delete(int id)
            {
                Car model = _ctx.Cars.Find(id);
                if (model != null)
                    _ctx.Cars.Remove(model);
            }
    }
}

