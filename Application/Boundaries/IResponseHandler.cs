namespace Application.Boundaries
{
    public interface IResponseHandler<TResponse>
    {
        public void Handle(TResponse response);
    }
}