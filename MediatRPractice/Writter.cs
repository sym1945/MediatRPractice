namespace MediatRPractice
{
    public interface IWritter
    { 
        void Write(string message);

        void WriteDivider();

        void WriteRequestPre(string processorName);

        void WriteRequestHandle(string handleName);

        void WriteRequestPost(string processorName);

        void WriteNotificationHandle(string handleName);

        void WritePipelineBegin(string pipelineName);

        void WritePipelineEnd(string pipelineName);

        void WriteStreamRequestHandle(string handleName);

        void WriteStreamPipelineBegin(string pipelineName);

        void WriteStreamPipelineEnd(string pipelineName);

        void WriteException(Exception exception);

        void WriteExceptionHandle(string handleName, Exception exception);
    }

    public class Writter : IWritter
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }

        public void WriteRequestPre(string processorName)
        {
            Console.WriteLine($"- RequestPre ({processorName})");
        }

        public void WriteRequestHandle(string handleName)
        {
            Console.WriteLine($"--- RequestHandle ({handleName})");
        }

        public void WriteRequestPost(string processorName)
        {
            Console.WriteLine($"- RequestPost ({processorName})");
        }

        public void WriteNotificationHandle(string handleName)
        {
            Console.WriteLine($"--- NotificationHandle ({handleName})");
        }

        public void WriteDivider()
        {
            Console.WriteLine($"=============================================================");
        }

        public void WritePipelineBegin(string pipelineName)
        {
            Console.WriteLine($"-- BeginHandle ({pipelineName})");
        }

        public void WritePipelineEnd(string pipelineName)
        {
            Console.WriteLine($"-- EndHandle ({pipelineName})");
        }

        public void WriteStreamRequestHandle(string handleName)
        {
            Console.WriteLine($"--- StreamRequestHandle ({handleName})");
        }

        public void WriteStreamPipelineBegin(string pipelineName)
        {
            Console.WriteLine($"-- BeginStreamHandle ({pipelineName})");
        }

        public void WriteStreamPipelineEnd(string pipelineName)
        {
            Console.WriteLine($"-- EndStreamHandle ({pipelineName})");
        }

        public void WriteException(Exception exception)
        {
            Console.WriteLine($"Exception: {exception.Message}");
        }

        public void WriteExceptionHandle(string handleName, Exception exception)
        {
            Console.WriteLine($"--- ExceptionHandle ({handleName}) : {exception.Message}");
        }
    }
}
