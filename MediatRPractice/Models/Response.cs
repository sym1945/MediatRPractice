namespace MediatRPractice.Models
{
    public class Response
    {
        public string Desc { get; set; } = string.Empty;

        public Response(string desc)
        {
            Desc = desc;
        }


        public override string ToString()
        {
            return Desc;
        }
    }

}
