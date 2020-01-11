using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRUDcomEntityFramework.EF
{
    class Context : DbContext
    {
        public DbSet<Users> Users { set; get; }

    }
}
