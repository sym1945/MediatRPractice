namespace MediatRPractice.Exceptions
{
    public class Request4ExceptionActnion : IRequestExceptionAction<Request4>
    {
        private readonly IWritter _Writter;

        public Request4ExceptionActnion(IWritter writter)
        {
            _Writter = writter;
        }

        public Task Execute(Request4 request, Exception exception, CancellationToken cancellationToken)
        {
            _Writter.WriteExceptionHandle(GetType().Name, exception);

            return Task.CompletedTask;
        }
    }
}
