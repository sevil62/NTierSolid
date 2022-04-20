using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public interface IListRepository<T> where T : AppUser//Kullanıcı işlemleri
    {
        //List
        List<T> GetList();

    }
}
