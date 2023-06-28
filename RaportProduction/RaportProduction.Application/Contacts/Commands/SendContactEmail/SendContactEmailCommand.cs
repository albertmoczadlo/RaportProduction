using MediatR;
using System.ComponentModel.DataAnnotations;

namespace RaportProduction.Application.Contacts.Commands.SendContactEmail;

public class SendContactEmailCommand:IRequest
{
    [Required(ErrorMessage = "The name and surname field is required")]
    public string Name { get; set; }

    [Required(ErrorMessage= "The email address field is required")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Message title is required")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Message field is required")]
    public string Message { get; set; }

}
