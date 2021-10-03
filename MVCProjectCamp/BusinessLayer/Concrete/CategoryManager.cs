using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAll()
        {
            return repo.List();
        }

        public void CategoryAdd(Category item)
        {
            if (item.CategoryName == "" || item.CategoryName.Length < 4 || 
                item.CategoryName.Length > 51 || item.CategoryDescription == "")
            {
                // ErrorMessage
            }
            else
            {
                repo.Insert(item);
            }
        }
    }
}
