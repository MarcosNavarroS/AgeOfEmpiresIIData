using System.Threading.Tasks;
using Application.Boundaries.GetUnit;
using Domain.Units;

namespace Application.UseCases
{
    public sealed class GetUnitUseCase : IGetUnitUseCase
    {
        private readonly IUnitRepository _unitRepository;

        public GetUnitUseCase(IUnitRepository unitRepository)
        {
            _unitRepository = unitRepository;
        }

        public async Task Execute(GetUnitInput input)
        {
            IUnit unit = await _unitRepository.GetUnit(input.UnitId);
        }
    }
}