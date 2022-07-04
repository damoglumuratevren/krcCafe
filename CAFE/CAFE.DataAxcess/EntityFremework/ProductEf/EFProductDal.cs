using CAFE.DataAxcess.Abstract;
using CAFE.DataAxcess.Abstract.ProductDal;
using CAFE.DataAxcess.Repositories;
using CAFE.Entity.Concrete.ProductEn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE.DataAxcess.EntityFremework.ProductEf
{
    public class EFProductDal : GenericRepository<Product>, IProductDAL
    {
    }
}
