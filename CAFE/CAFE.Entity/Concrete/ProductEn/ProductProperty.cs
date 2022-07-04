using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE.Entity.Concrete.ProductEn
{
    [Table("ProductProperties")]
    public class ProductProperty : BaseEntity
    {
        [Key, Required, Display(Name = "Özellik Id")]
        public int PropertyID { get; set; }

        [Display(Name = "Ürün Id")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        [Required, StringLength(30), Display(Name = "Ürün Özellik Anahtarı")]
        public string Keyy { get; set; }

        [Required, StringLength(30), Display(Name = "Ürün Özellik Değeri")]
        public string Value { get; set; }

    }
}
