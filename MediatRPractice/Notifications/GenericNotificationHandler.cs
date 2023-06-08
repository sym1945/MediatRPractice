namespace MediatRPractice.Notifications
{
    // 같은 네임스페이스에 있는 INotificationHandler보다 가장 먼저 실행됨
    public class GenericNotificationHandler : INotificationHandler<INotification>
    {
        private readonly IWritter _Writter;

        public GenericNotificationHandler(IWritter writter)
        {
            _Writter = writter;
        }

        public Task Handle(INotification notification, CancellationToken cancellationToken)
        {
            _Writter.WriteNotificationHandle(GetType().Name);

            return Task.CompletedTask;
        }
    }
}
