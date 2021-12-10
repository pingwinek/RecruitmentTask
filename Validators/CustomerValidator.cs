using FluentValidation;
using RecruitmentTask.Model;

namespace RecruitmentTask.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("The Customer Id must be greather than 0.");  
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Age).NotEmpty();
            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress();
            RuleFor(x => x.IsActive).NotEmpty();
        }
    }
}