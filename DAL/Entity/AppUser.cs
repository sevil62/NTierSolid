using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class AppUser
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string  Password { get; set; }
        

        //Relation Property
        public List<Category>Categories  { get; set; }
        public List<Product>Products  { get; set; }


    }
}
