using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaportProduction.Application.Raports.Queries.GetRaportById;

public class GetRaportByIdQuery : IRequest<RaportDto>
{
    public int Id { get; set; }
}

