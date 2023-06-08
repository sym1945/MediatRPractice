namespace MediatRPractice.Requests
{
    public class Request4Handler : IRequestHandler<Request4>
    {
        private readonly IWritter _Writter;

        public Request4Handler(IWritter writter)
        {
            _Writter = writter;
        }

        public Task Handle(Request4 request, CancellationToken cancellationToken)
        {
            throw new Exception(GetType().Name);
        }
    }
}
