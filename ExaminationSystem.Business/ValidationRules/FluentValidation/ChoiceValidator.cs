using ExaminationSystem.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Business.ValidationRules.FluentValidation
{
    public class ChoiceValidator : AbstractValidator<Choice>
    {
        public ChoiceValidator()
        {
            RuleFor(p => p.Text).NotEmpty();
            RuleFor(p => p.Text).MinimumLength(2);
            RuleFor(p => p.QuestionId).NotEmpty();

        }
    }
}
