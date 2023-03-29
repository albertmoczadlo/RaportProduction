using MediatR;

namespace RaportProduction.Application.Raports.Queries.GetRaportById;

public class GetRaportByIdQueryHandler : IRequestHandler<GetRaportByIdQuery, RaportDto>
{
    public async Task<RaportDto> Handle(GetRaportByIdQuery request, CancellationToken cancellationToken)
    {
        return new RaportDto { Id = request.Id, Name = "Name" };
    }
}
