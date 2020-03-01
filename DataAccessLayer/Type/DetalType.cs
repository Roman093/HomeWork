using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DetalType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Detal> Detals { get; set; }
    }
}

