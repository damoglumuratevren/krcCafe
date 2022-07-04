using CAFE.Entity.Concrete.CategoryEn;
using CAFE.Entity.Concrete.ProductEn;
using CAFE.Entity.Concrete.UserEn;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE.DataAxcess.Concrete
{
    public class CafeContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductProperty> ProductProperties { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
