namespace MediatRPractice.Requests
{
    public class Request3Handler : IRequestHandler<Request3, Response>
    {
        private readonly IWritter _Writter;

        public Request3Handler(IWritter writter)
        {
            _Writter = writter;
        }

        public Task<Response> Handle(Request3 request, CancellationToken cancellationToken)
        {
            if (request.Cancel)
                throw new TaskCanceledException();
            else
                throw new AggregateException(nameof(Request3Handler));
        }
    }
}
