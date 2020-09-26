using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Validators
{
    public static class ValidatorExtensions
    {
        public static IRuleBuilder<T, string> Password<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            var options = ruleBuilder
                .NotEmpty()
                .MinimumLength(6).WithMessage("Passwor must be at least 6 characters")
                .Matches("[A-Z]").WithMessage("Password must contain at least 1 upper case letter")
                .Matches("[a-z]").WithMessage("Password must contain at least 1 lower case letter")
                .Matches("[0-9]").WithMessage("Password must contain a number")
                .Matches("[^a-zA-z0-9]").WithMessage("Password must contain a non alphanumeric digit");

            return options;
        }
    }
}
