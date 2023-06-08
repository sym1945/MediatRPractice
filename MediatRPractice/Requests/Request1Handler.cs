namespace MediatRPractice.Requests
{
    public class Request1Handler : IRequestHandler<Request1, Response>
    {
        private readonly IWritter _Writter;

        public Request1Handler(IWritter writter)
        {
            _Writter = writter;
        }

        public Task<Response> Handle(Request1 request, CancellationToken cancellationToken)
        {
            _Writter.WriteRequestHandle(GetType().Name);

            var response = new Response($"{typeof(Response).Name} from {GetType().Name}");

            return Task.FromResult(response);
        }
    }
}
