namespace MediatRPractice.Generics
{
    public class GenericPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : notnull
    {
        private readonly IWritter _Writter;

        public GenericPipelineBehavior(IWritter writter)
        {
            _Writter = writter;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            _Writter.WritePipelineBegin(GetType().Name);

            var response =  await next();

            _Writter.WritePipelineEnd(GetType().Name);

            return response;
        }
    }
}
