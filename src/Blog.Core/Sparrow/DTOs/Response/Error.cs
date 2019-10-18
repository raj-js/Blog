namespace Blog.Core.Sparrow.DTOs.Response
{
    public class Error
    {
        public string Code { get; set; }

        public string Msg { get; set; }

        public static Error Create(string code, string msg) => new Error() 
        {
            Code = code, 
            Msg = msg
        };
    }
}
