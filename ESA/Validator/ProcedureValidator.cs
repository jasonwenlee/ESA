using ESA.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESA.Validator
{
    // Author: Jason Wen Lee
    // Validate empty field. Not sure if this is needed.
    public class ProcedureValidator : AbstractValidator<Procedure>
    {
        public ProcedureValidator()
        {
            RuleFor(x => x.Name).NotNull();
            RuleFor(x => x.Details).NotNull();
        }
    }
}
