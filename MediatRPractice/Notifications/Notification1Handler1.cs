namespace MediatRPractice.Notifications
{
    public class Notification1Handler1 : INotificationHandler<Notification1>
    {
        private readonly IWritter _Writter;

        public Notification1Handler1(IWritter writter)
        {
            _Writter = writter;
        }

        public Task Handle(Notification1 notification, CancellationToken cancellationToken)
        {
            _Writter.WriteNotificationHandle(GetType().Name);

            return Task.CompletedTask;
        }
    }
}
