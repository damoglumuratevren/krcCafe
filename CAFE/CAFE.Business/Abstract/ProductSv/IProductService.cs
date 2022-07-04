using CAFE.Entity.Concrete.ProductEn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE.Business.Abstract.ProductSv
{
    public interface IProductService
    {
        List<Product> GetList();
        void addProduct(Product product);
        void deleteProduct(Product product);
        void updateProduct(Product product);
        Product GetById(int id);
    }
}
