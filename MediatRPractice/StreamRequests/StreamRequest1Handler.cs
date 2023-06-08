using System.Runtime.CompilerServices;

namespace MediatRPractice.StreamRequests
{
    internal class StreamRequest1Handler : IStreamRequestHandler<StreamRequest1, Response>
    {
        private readonly IWritter _Writter;

        public StreamRequest1Handler(IWritter writter)
        {
            _Writter = writter;
        }

        public async IAsyncEnumerable<Response> Handle(StreamRequest1 request, [EnumeratorCancellation] CancellationToken cancellationToken)
        {
            _Writter.WriteStreamRequestHandle(nameof(StreamRequest1));

            var resName = typeof(Response).Name;

            int i = 0;

            yield return new Response($"{resName} from {nameof(StreamRequest1Handler)}{++i}");
            await Task.Delay(500, cancellationToken);
            yield return new Response($"{resName} from {nameof(StreamRequest1Handler)}{++i}");
            await Task.Delay(500, cancellationToken);
            yield return new Response($"{resName} from {nameof(StreamRequest1Handler)}{++i}");
            await Task.Delay(500, cancellationToken);
        }
    }
}
