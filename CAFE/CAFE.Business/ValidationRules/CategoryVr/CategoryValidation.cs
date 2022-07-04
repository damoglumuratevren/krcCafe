using FluentValidation;
using CAFE.Entity.Concrete.CategoryEn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE.Business.ValidationRules.CategoryVr
{
    public class CategoryValidation : AbstractValidator<Category>
    {
        public CategoryValidation()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adı Boş geçilemez");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("En az 3 karakter olmalıdır");
            RuleFor(x => x.CategoryName).MaximumLength(100).WithMessage("En fazla 100 karakter olmalıdır");
        }
    }
}
