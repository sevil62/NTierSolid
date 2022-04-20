using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public int? CategoryId { get; set; }
        public int? AppUserId { get; set; }

        //Relation Property
        public Category Category { get; set; }
        public AppUser AppUser { get; set; }

    }
}
