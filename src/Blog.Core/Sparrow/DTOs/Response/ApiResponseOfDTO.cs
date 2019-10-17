namespace Blog.Core.Sparrow.DTOs.Response
{
    public class ApiResponse<TDTO> : ApiResponse
    {
        public TDTO Data { get; set; }
    }
}
