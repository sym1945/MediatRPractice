namespace MediatRPractice
{
    public static class Runner
    {
        public static async Task Run(IMediator mediator, IWritter writter)
        {
            writter.Write("Start Application");

            writter.WriteDivider();

            // Send Request with response
            writter.Write(nameof(Request1));
            var res = await mediator.Send(new Request1());
            writter.Write(res.Desc);

            writter.WriteDivider();

            // Send Request without response
            writter.Write(nameof(Request2));
            await mediator.Send(new Request2());

            writter.WriteDivider();

            // Send Request with response (Exception)
            try
            {
                writter.Write(nameof(Request3));
                var res2 = await mediator.Send(new Request3());
                writter.Write(res2.Desc);
            }
            catch (Exception ex)
            {
                writter.WriteException(ex);
            }

            writter.WriteDivider();

            // Send Request with response (TaskCancelledException)
            try
            {
                writter.Write(nameof(Request3));
                var res2 = await mediator.Send(new Request3 { Cancel = true });
                writter.Write(res2.Desc);
            }
            catch (Exception ex)
            {
                writter.WriteException(ex);
            }

            writter.WriteDivider();

            // Send Request without response (Exception)
            try
            {
                writter.Write(nameof(Request4));
                await mediator.Send(new Request4());
            }
            catch (Exception ex)
            {
                writter.WriteException(ex);
            }

            writter.WriteDivider();

            // Send StreamRequest
            writter.Write(nameof(StreamRequest1));
            var stream = mediator.CreateStream(new StreamRequest1());
            await foreach (var streamRes in stream)
            { 
                writter.Write(streamRes.Desc);
            }

            writter.WriteDivider();

            // Publish
            writter.Write(nameof(Notification1));
            await mediator.Publish(new Notification1());

            writter.WriteDivider();

            // Publish (Exception)
            try
            {
                writter.Write(nameof(Notification2));
                await mediator.Publish(new Notification2());
            }
            catch (Exception ex)
            {
                writter.WriteException(ex);
            }

            writter.WriteDivider();

            writter.Write("End Application");
        }

    }
}
