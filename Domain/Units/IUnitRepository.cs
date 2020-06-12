using System.Threading.Tasks;

namespace Domain.Units
{
    public interface IUnitRepository
    {
        Task<IUnit> GetUnit(int unitId);
    }
}