using DAL.Context;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        MyContext db=new MyContext();

        public string Create(T model)
        {
            
            try
            {
                db.Set<T>().Add(model);
                db.SaveChanges();
                return "Veri kaydedildi";

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            
        }


        public string Delete(T id)
        {
            try
            {
                var deleted = db.Set<T>().Find(id);
                db.Set<T>().Remove(deleted);
                db.SaveChanges();
                return "Veri silindi";

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public T Find(int id)
        {
            var result = db.Set<T>().Find(id);
            db.SaveChanges();
            return result;
        }

        public List<T> GetList()
        {
           return db.Set<T>().ToList();
        }

        public string Update(T model)
        {
            try
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Veri güncellendi";

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
