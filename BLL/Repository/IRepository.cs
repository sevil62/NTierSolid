using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public interface IRepository<T> where T : BaseEntity//Adminin yapacağı işlemler
    {
        // Create
        string Create(T model);
        //List
        List<T> GetList();
        //Update
        string Update(T model);
        //Delete
        string Delete(T id);

        //Custom
        T Find(int id);

    }
}
