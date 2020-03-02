using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CarContext : DbContext
    {
        public CarContext() : base(@"Data Source=.\SQLEXPRESS; Initial Catalog=Car; Integrated Security=true ")
        {
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Detal> Detals { get; set; }
        public DbSet<Manufactory> Manufactories { get; set; }
        public DbSet<DetalType>DetalTypes { get; set; }
        }
    }

