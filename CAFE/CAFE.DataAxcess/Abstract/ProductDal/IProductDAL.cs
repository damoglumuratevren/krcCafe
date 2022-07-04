using CAFE.Entity.Concrete.ProductEn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE.DataAxcess.Abstract.ProductDal
{
    public interface IProductDAL : IRepository<Product>
    {
    }
}
