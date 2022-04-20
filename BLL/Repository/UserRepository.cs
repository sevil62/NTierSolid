using DAL.Context;
using DAL.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public class UserRepository<T> : IListRepository<T> where T : AppUser
    {
        MyContext db=new MyContext();

        public List<T> GetList()
        {
            return db.Set<T>().ToList();
            
        }
    }
}
