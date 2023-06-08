namespace MediatRPractice.Requests
{
    public class Request2Handler : IRequestHandler<Request2>
    {
        private readonly IWritter _Writter;

        public Request2Handler(IWritter writter)
        {
            _Writter = writter;
        }

        public Task Handle(Request2 request, CancellationToken cancellationToken)
        {
            _Writter.WriteRequestHandle(nameof(Request2));

            return Task.CompletedTask;
        }
    }
}
