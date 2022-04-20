using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }
        public int? AppUserId { get; set; }

        //Relation Property
        public List<Product>Products  { get; set; }
        public AppUser AppUser { get; set; }



    }
}
