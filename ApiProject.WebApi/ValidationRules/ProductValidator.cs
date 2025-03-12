using ApiProject.WebApi.Entities;
using FluentValidation;

namespace ApiProject.WebApi.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün adını boş geçmeyin");
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage("En az 2 karakter veri girişi yapın!");
            RuleFor(x => x.ProductName).MaximumLength(50).WithMessage("En fazla 50 karakter veri girişi yapın!");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Açıklama alanını boş geçmeyin").GreaterThan(0).WithMessage("Fiyat alanı 0'dan büyük olmalıdır").LessThan(1000).WithMessage("Ürün fiyatı bu kadar fazla olamaz");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanını boş geçmeyin");
        }
    }
}