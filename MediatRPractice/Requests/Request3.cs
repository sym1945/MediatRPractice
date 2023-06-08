namespace MediatRPractice.Requests
{
    public class Request3 : IRequest<Response>
    {
        public bool Cancel { get; set; }
    }
}
