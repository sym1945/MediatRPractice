namespace MediatRPractice.Exceptions
{
    public class Request3TaskCanceledExceptionHandler : IRequestExceptionHandler<Request3, Response, TaskCanceledException>
    {
        private readonly IWritter _Writter;

        public Request3TaskCanceledExceptionHandler(IWritter writter)
        {
            _Writter = writter;
        }

        public Task Handle(Request3 request, TaskCanceledException exception, RequestExceptionHandlerState<Response> state, CancellationToken cancellationToken)
        {
            _Writter.WriteExceptionHandle(GetType().Name, exception);

            return Task.CompletedTask;
        }
    }

    public class Request3AggregateExceptionHandler : IRequestExceptionHandler<Request3, Response, AggregateException>
    {
        private readonly IWritter _Writter;

        public Request3AggregateExceptionHandler(IWritter writter)
        {
            _Writter = writter;
        }

        public Task Handle(Request3 request, AggregateException exception, RequestExceptionHandlerState<Response> state, CancellationToken cancellationToken)
        {
            _Writter.WriteExceptionHandle(GetType().Name, exception);

            state.SetHandled(new Response("Handled Request3 AggregateException"));

            return Task.CompletedTask;
        }
    }

    // 위에서 잡지못한 Exception 이나 잡았는데 Handled 되지 않은 예외는 이쪽으로...
    public class Request3ExceptionHandler : IRequestExceptionHandler<Request3, Response>
    {
        private readonly IWritter _Writter;

        public Request3ExceptionHandler(IWritter writter)
        {
            _Writter = writter;
        }

        public Task Handle(Request3 request, Exception exception, RequestExceptionHandlerState<Response> state, CancellationToken cancellationToken)
        {
            _Writter.WriteExceptionHandle(GetType().Name, exception);

            return Task.CompletedTask;
        }
    }

}
