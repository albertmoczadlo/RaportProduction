using FluentValidation;

namespace RaportProduction.Application.Contacts.Commands.SendContactEmail;

public class SendContactEmailCommandValidator:AbstractValidator<SendContactEmailCommand>
{
	public SendContactEmailCommandValidator()
	{
		RuleFor(x => x.Name)
			.NotEmpty().WithMessage("Name and surname field is mandatory");
	}
}
