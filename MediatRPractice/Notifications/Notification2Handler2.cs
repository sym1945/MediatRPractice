namespace MediatRPractice.Notifications
{
    public class Notification2Handler2 : INotificationHandler<Notification2>
    {
        private readonly IWritter _Writter;

        public Notification2Handler2(IWritter writter)
        {
            _Writter = writter;
        }

        public Task Handle(Notification2 notification, CancellationToken cancellationToken)
        {
            throw new Exception(GetType().Name);
        }
    }
}
