using System.Threading.Tasks;

namespace Application.Boundaries
{
    public interface IUseCase<TUseCaseInput>
    {
        Task Execute(TUseCaseInput input);
    }
}