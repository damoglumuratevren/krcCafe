using CAFE.Business.Abstract.CategorySv;
using CAFE.DataAxcess.Abstract.CategoryDal;
using CAFE.Entity.Concrete.CategoryEn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE.Business.Concrete.CategoryMn
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public List<Category> GetList()
        {
            return _categoryDAL.List();
        }

        public void CategoryAdd(Category category)
        {

            _categoryDAL.Insert(category);
        }

        public Category GetById(int id)
        {
            return _categoryDAL.GetById(x=>x.CategoryId==id);
        }

        public void CategoryDelete(Category category)
        {
            _categoryDAL.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDAL.Update(category);
        }
    }
}
