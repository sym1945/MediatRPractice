namespace MediatRPractice.Notifications
{
    public class Notification2Handler3 : INotificationHandler<Notification2>
    {
        private readonly IWritter _Writter;

        public Notification2Handler3(IWritter writter)
        {
            _Writter = writter;
        }

        public Task Handle(Notification2 notification, CancellationToken cancellationToken)
        {
            _Writter.WriteNotificationHandle(GetType().Name);

            return Task.CompletedTask;
        }
    }
}
