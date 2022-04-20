using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class MyContext:DbContext
    {
        public MyContext()
        {
            Database.Connection.ConnectionString = "server=REDHACK;database=NtierSolidDB;integrated security=true";
        }

        public DbSet<Category>Categories  { get; set; }
        public DbSet<Product>Products  { get; set; }
        public DbSet<AppUser>AppUsers  { get; set; }
    }
    
}
