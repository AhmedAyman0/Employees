using FluentValidation;
using SETechnicalTask.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Validations
{
    public class EmployeeValidation: AbstractValidator<Employee>
    {
        public EmployeeValidation()
        {
            RuleFor(a => a.Name).NotEmpty().WithMessage("Employee name can not be empty");
            RuleFor(a => a.Name).Length(3, 15).WithMessage("Employee name must be between 3 and 15 characters");
            RuleFor(a => a.Email).EmailAddress().WithMessage("Email Entered is not valid");

        }
    }
}
