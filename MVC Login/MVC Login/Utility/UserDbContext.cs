using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Login.Utility
{
    class UserDbContext: DbContext
    {
        public DbSet<Model.User> user { get; set; }
        public DbSet<Model.Password> password { get; set; }
    }
}
