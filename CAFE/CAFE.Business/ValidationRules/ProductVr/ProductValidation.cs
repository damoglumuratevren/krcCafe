using CAFE.Entity.Concrete.ProductEn;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE.Business.ValidationRules.ProductVr
{
    public class ProductValidation : AbstractValidator<Product>
    {
        public ProductValidation()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün Adı Boş geçilemez");
            RuleFor(x => x.ProductName).MinimumLength(3).WithMessage("En az 3 karakter olmalıdır");
            RuleFor(x => x.ProductName).MaximumLength(100).WithMessage("En fazla 100 karakter olmalıdır");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Ürün fiyatı Boş geçilemez");
            //RuleFor(x => x.Price).ExclusiveBetween(1,300).WithMessage("Fiyatı 1 ₺ ile 300 ₺ arası olmalıdır.");

            RuleFor(x => x.ImagePath).NotEmpty().WithMessage("Ürün Resmi Boş geçilemez");
            RuleFor(x => x.ImagePath).MinimumLength(3).WithMessage("En az 3 karakter olmalıdır");
            RuleFor(x => x.ImagePath).MaximumLength(250).WithMessage("En fazla 250 karakter olmalıdır");
        }
    }
}
