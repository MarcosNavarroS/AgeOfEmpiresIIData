using System.Threading.Tasks;
using Application.Boundaries.GetUnit;
using Domain.Units;

namespace Application.UseCases
{
    public sealed class GetUnitUseCase : IGetUnitUseCase
    {
        public IUnitRepository UnitRepository { get; }

        public GetUnitUseCase(IUnitRepository unitRepository)
        {
            UnitRepository = unitRepository;
        }

        public Task Execute(GetUnitInput input)
        {
            throw new System.NotImplementedException();
        }
    }
}