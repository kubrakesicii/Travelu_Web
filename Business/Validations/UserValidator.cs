using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validations
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Fullname).MaximumLength(255).MinimumLength(3).NotNull();
            RuleFor(x => x.Email).MaximumLength(255).MinimumLength(10).NotNull();
        }
    }
}
