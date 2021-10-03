
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDAL
    {
        Context c = new Context();
        DbSet<Category> _object;

        public List<Category> List()
        {
            return _object.ToList();
        }

        public void Delete(Category item)
        {
            _object.Remove(item);
            c.SaveChanges();
        }

        public void Insert(Category item)
        {
            _object.Add(item);
            c.SaveChanges();
        }

        public void Update(Category item)
        {
            c.SaveChanges();
        }
    }
}
