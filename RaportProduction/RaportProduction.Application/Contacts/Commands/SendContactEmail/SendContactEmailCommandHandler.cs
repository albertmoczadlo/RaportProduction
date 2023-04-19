using MediatR;
using RaportProduction.Application.Common.Interfaces;

namespace RaportProduction.Application.Contacts.Commands.SendContactEmail;

public class SendContactEmailCommandHandler : IRequestHandler<SendContactEmailCommand>
{
    private readonly IEmail _email;

    public SendContactEmailCommandHandler(IEmail email)
    {
        _email = email;
    }
    public async Task<Unit> Handle(SendContactEmailCommand request, CancellationToken cancellationToken)
    {
        var body = $"Nazwa: {request.Name}.<br /></br >E-mail sender:" +
            $"{request.Email}.<br /><br />Title: {request.Title}.<br /><br /" +
            $"Message: {request.Message}.<br /><br />Message sent from production";

        await _email.SendAsync($"Message from Production: {request.Title}", body, "albertmoczadlo@gmail.com");

        return Unit.Value;
    }
}
