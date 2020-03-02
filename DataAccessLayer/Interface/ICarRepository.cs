using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface ICarRepository
    {
        void Create(Car model);
        void Update(Car model);
        void Delete(int id);
    }
}
