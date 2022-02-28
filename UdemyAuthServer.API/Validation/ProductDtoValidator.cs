using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyAuthServer.Core.Dtos;

namespace UnluCoAuthServer.API.Validation
{
    public class ProductDtoValidator:AbstractValidator<ProductDto>
    {
        /// <summary>
        /// olusturdugumuz hataların ne hatası oldugunu göstermek için fluent valitadion kullanıldı.
        /// </summary>
        public ProductDtoValidator()
        {

            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Image is required");
            RuleFor(x => x.ProductColor).NotEmpty().WithMessage("ProductColor is required");
            RuleFor(x => x.UsageState).NotEmpty().WithMessage("UsageState is not be defined");



        }

    }
}
