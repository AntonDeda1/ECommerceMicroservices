﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Features.Orders.Commands.CheckoutOrder
{
    public class CheckoutOrderCommandValidator : AbstractValidator<CheckoutOrderCommand>
    {
        public CheckoutOrderCommandValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("{UserName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{UserName} must not exceed 50 characters.");


            RuleFor(x => x.EmailAddress)
                .NotEmpty().WithMessage("{EmailAddress} is required.");


            RuleFor(x => x.TotalPrice)
                .NotEmpty().WithMessage("{EmailAdress} is required")
                .GreaterThan(0).WithMessage("{TotalPrice} should be greater than zero.");
        }

    }
}
