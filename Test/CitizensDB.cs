using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class CitizensDB:DbContext
    {
        public CitizensDB()
            : base("name=Citizens")
        {

        }

        public virtual DbSet<Сitizen> Сitizens { get; set; }

    }
}
