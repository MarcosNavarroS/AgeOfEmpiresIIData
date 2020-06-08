using System.Threading.Tasks;

namespace Domain.Units
{
    public interface IUnitRepository
    {
        Task<Unit> GetUnit(int unitId);
    }
}