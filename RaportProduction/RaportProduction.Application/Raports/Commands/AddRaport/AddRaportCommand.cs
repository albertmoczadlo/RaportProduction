using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaportProduction.Application.Raports.Commands.AddRaport
{
    public class AddRaportCommand : IRequest
    {
        public string Name { get; set; }
    }
}
