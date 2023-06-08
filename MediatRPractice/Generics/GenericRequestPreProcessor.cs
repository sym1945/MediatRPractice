namespace MediatRPractice.Generics
{
    public class GenericRequestPreProcessor<TRequest> : IRequestPreProcessor<TRequest>
        where TRequest : notnull
    {
        private readonly IWritter _Writter;

        public GenericRequestPreProcessor(IWritter writter)
        {
            _Writter = writter;
        }

        public Task Process(TRequest request, CancellationToken cancellationToken)
        {
            _Writter.WriteRequestPre(GetType().Name);

            return Task.CompletedTask;
        }
    }
}
