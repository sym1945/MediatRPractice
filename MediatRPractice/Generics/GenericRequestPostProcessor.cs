namespace MediatRPractice.Generics
{
    public class GenericRequestPostProcessor<TRequest, TResponse> : IRequestPostProcessor<TRequest, TResponse>
        where TRequest : notnull
    {
        private readonly IWritter _Writter;

        public GenericRequestPostProcessor(IWritter writer)
        {
            _Writter = writer;
        }

        public Task Process(TRequest request, TResponse response, CancellationToken cancellationToken)
        {
            _Writter.WriteRequestPost(GetType().Name);

            return Task.CompletedTask;
        }
    }
}
