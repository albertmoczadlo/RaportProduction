using MediatR;
using RaportProduction.Application.Common.Interfaces;
using RaportProduction.Application.Dictionaries;

namespace RaportProduction.Application.Contacts.Commands.SendContactEmail;

public class SendContactEmailCommandHandler : IRequestHandler<SendContactEmailCommand>
{
    //private readonly IEmail _email;
    //private readonly IAppSettingsService _appSettingsService;

    //public SendContactEmailCommandHandler(
    //    IEmail email,
    //    IAppSettingsService appSettingsService)
    //{
    //    _email = email;
    //    _appSettingsService = appSettingsService;
    //}
    //public async Task<Unit> Handle(SendContactEmailCommand request, CancellationToken cancellationToken)
    //{
    //    var body = $"Nazwa: {request.Name}.<br /></br >E-mail sender:" +
    //        $"{request.Email}.<br /><br />Title: {request.Title}.<br /><br /" +
    //        $"Message: {request.Message}.<br /><br />Message sent from production";

    //    await _email.SendAsync($"Message from Production: {request.Title}", body, await _appSettingsService.Get(SettingsDict.AdminEmail));

    //    return Unit.Value;
    //}

    private readonly IEmail _email;
    private readonly IAppSettingsService _appSettings;

    public SendContactEmailCommandHandler(
        IEmail email,
        IAppSettingsService appSettings)
    {
        _email = email;
        _appSettings = appSettings;
    }

    public async Task<Unit> Handle(SendContactEmailCommand request, CancellationToken cancellationToken)
    {
        var body = $"Nazwa: {request.Name}.<br /></br >E-mail nadawcy: {request.Email}.<br /><br />Tytuł wiadomości: {request.Title}.<br /><br />Wiadomość: {request.Message}.<br /><br />Wysłano z: Production.";

        await _email.SendAsync(
            $"Wiadomość z Raport Production: {request.Title}",
            body,
            await _appSettings.Get(SettingsDict.AdminEmail));

        return Unit.Value;
    }
}
