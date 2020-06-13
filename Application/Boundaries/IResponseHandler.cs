namespace Application.Boundaries
{
    public interface IResponseHandler<in TResponse>
    {
        public void Handle(TResponse response);
    }
}