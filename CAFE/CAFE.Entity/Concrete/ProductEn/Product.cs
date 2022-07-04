using CAFE.Entity.Concrete.CategoryEn;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE.Entity.Concrete.ProductEn
{
    [Table("Products")]
    public class Product : BaseEntity
    {
        [Key, Required, Display(Name = "Ürün Id")]
        public int ProductId { get; set; }

        [Display(Name = "Kategori  Id")]
        public int CategoryId { get; set; } = 1;
        public virtual Category Category { get; set; }

        [Required, StringLength(100), Display(Name = "Ürün Adı")]
        public string ProductName { get; set; }

        [Required, Display(Name = "Ürün Fiyatı")]
        public decimal Price { get; set; }

        [Required, StringLength(250), Display(Name = "Resim Linki")]
        public string ImagePath { get; set; }


    }
}
