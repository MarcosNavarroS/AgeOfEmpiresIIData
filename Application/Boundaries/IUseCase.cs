using System.Threading.Tasks;

namespace Application.Boundaries
{
    public interface IUseCase<in TUseCaseInput>
    {
        Task Execute(TUseCaseInput input);
    }
}