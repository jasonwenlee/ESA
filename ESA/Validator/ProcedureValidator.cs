﻿using ESA.Models;
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
            RuleFor(x => x.Category).NotNull().WithMessage("Procedure category required");
            RuleFor(x => x.Name).NotNull().WithMessage("Procedure name required");
            RuleFor(x => x.Details).NotNull().WithMessage("Procedure details required");
        }
    }
}
