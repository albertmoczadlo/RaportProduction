using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaportProduction.Application.Contacts.Commands.SendContactEmail;

public class SendContactEmailCommand:IRequest
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Title { get; set; }
    public string Message { get; set; }

}
