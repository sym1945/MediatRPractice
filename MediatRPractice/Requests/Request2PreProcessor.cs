namespace MediatRPractice.Requests
{
    public class Request2PreProcessor : IRequestPreProcessor<Request2>
    {
        private readonly IWritter _Writter;

        public Request2PreProcessor(IWritter writter)
        {
            _Writter = writter;
        }

        public Task Process(Request2 request, CancellationToken cancellationToken)
        {
            _Writter.WriteRequestPre(GetType().Name);

            return Task.CompletedTask;
        }
    }
}
