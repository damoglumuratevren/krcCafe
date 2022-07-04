using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE.Entity.Concrete.CategoryEn
{
    [Table("Categories")]
    public class Category : BaseEntity
    {
        [Key, Required, Display(Name = "Kategori Id")]
        public int CategoryId { get; set; }


        [Required, StringLength(100), Display(Name = "Kategori Adı")]
        public string CategoryName { get; set; }

    }
}
