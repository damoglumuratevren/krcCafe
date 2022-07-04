using CAFE.Business.Abstract.ProductSv;
using CAFE.DataAxcess.Abstract.ProductDal;
using CAFE.Entity.Concrete.ProductEn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE.Business.Concrete.ProductMn
{
    public class ProductManager : IProductService
    {
        IProductDAL _productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public void addProduct(Product product)
        {
            _productDAL.Insert(product);
        }

        public void deleteProduct(Product product)
        {
            product.IsActive = false;
            _productDAL.Update(product);
        }

        public Product GetById(int id)
        {
            return _productDAL.GetById(z => z.ProductId == id);
        }

        public List<Product> GetList()
        {
            return _productDAL.List();
        }

        public void updateProduct(Product product)
        {
            _productDAL.Update(product);
        }
    }
}
