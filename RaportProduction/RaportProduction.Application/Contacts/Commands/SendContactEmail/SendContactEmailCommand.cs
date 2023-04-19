using MediatR;

namespace RaportProduction.Application.Contacts.Commands.SendContactEmail;

public class SendContactEmailCommand:IRequest
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Title { get; set; }
    public string Message { get; set; }

}
