using FluentValidation;
using SETechnicalTask.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Validations
{
    public class SkillValidation:AbstractValidator<Skill>
    {
        public SkillValidation()
        {
            RuleFor(a => a.Name).NotEmpty().WithMessage("Enter Skill name");
        }
    }
}
