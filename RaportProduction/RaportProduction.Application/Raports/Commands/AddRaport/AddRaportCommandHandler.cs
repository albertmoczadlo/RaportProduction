using MediatR;

namespace RaportProduction.Application.Raports.Commands.AddRaport
{
    public class AddRaportCommandHandler : IRequestHandler<AddRaportCommand>
    {
        public async Task<Unit> Handle(AddRaportCommand request, CancellationToken cancellationToken)
        {
            //var raport = new Raport();
            //raport.Name = request.Name;

            return Unit.Value;
        }
    }
}
