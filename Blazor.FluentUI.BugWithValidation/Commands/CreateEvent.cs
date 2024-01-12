using FluentValidation;

namespace Blazor.FluentUI.BugWithValidation.Commands
{
    public class CreateEvent
    {
        public class Command
        {
            public string Name { get; set; }
            public DateTime? Date { get; set; }
            public int? MyDictionaryItemId { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator()
            {
                RuleFor(x => x.Name)
                    .NotEmpty();

                RuleFor(x => x.Date)
                    .NotEmpty();

                RuleFor(x => x.MyDictionaryItemId)
                    .NotEmpty();
            }
        }
    }
}
