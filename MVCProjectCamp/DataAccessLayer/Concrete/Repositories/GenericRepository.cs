using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = c.Set<T>();
        }

        public void Delete(T item)
        {
            _object.Remove(item);
            c.SaveChanges();
        }

        public void Insert(T item)
        {
            _object.Add(item);
            c.SaveChanges();
        }

        public List<T> List()
        {
            // burada filter lı miltırlı bir şeyler vardı da. ben salak olduğum için yazmadım.
            // I repository kısmına ekleme yapılması gerek kekeeeee <3
        }

        public void Update(T item)
        {
            c.SaveChanges();
        }
    }
}
