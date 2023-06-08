using System.Runtime.CompilerServices;

namespace MediatRPractice.Generics
{
    public class GenericStreamPipelineBehavior<TRequest, TResponse> : IStreamPipelineBehavior<TRequest, TResponse>
        where TRequest : notnull
    {
        private readonly IWritter _Writter;

        public GenericStreamPipelineBehavior(IWritter writter)
        {
            _Writter = writter;
        }

        public async IAsyncEnumerable<TResponse> Handle(TRequest request, StreamHandlerDelegate<TResponse> next, [EnumeratorCancellation] CancellationToken cancellationToken)
        {
            _Writter.WriteStreamPipelineBegin(GetType().Name);
            await foreach (var response in next().WithCancellation(cancellationToken).ConfigureAwait(false))
            {
                yield return response;
            }
            _Writter.WriteStreamPipelineEnd(GetType().Name);
        }
    }
}
