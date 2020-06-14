using Application.Boundaries.GetUnit;
using Domain.Units;

namespace ConsoleApp.UseCases.GetUnits
{
    public class UnitsController
    {
        private IGetUnitUseCase GetUnitUseCase { get; }

        public UnitsController(IGetUnitUseCase getUnitUseCase)
        {
            GetUnitUseCase = getUnitUseCase;
        }

        public void GetUnit(int unitId)
        {
            GetUnitInput getUnitInput = new GetUnitInput(unitId);
            IUnit unit = GetUnitUseCase.Execute();
        }
    }
}