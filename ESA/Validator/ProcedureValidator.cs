using ESA.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.Validator
{
    public class ProcedureValidator : AbstractValidator<Procedure>
    {
        public ProcedureValidator()
        {
            RuleFor(x => x.Name).NotNull();
            RuleFor(x => x.Details).NotNull();
        }
    }
}
