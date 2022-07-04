using CAFE.DataAxcess.Abstract.CategoryDal;
using CAFE.DataAxcess.Repositories;
using CAFE.Entity.Concrete.CategoryEn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE.DataAxcess.EntityFremework.CategoryEf
{
    public class EFCategoryDal : GenericRepository<Category>, ICategoryDAL
    {
    }
}
