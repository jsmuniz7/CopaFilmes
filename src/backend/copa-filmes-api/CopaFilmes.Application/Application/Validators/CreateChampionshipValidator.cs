using FluentValidation;

namespace CopaFilmes.Application.Application.Validators
{
    public class CreateChampionshipValidator : AbstractValidator<CreateChampionship>
    {
        public CreateChampionshipValidator()
        {
            RuleFor(x => x)
                .Must(x => x.Movies.Count == 8)
                .WithMessage("A championship requires eight movies!");

        }
    }
}
