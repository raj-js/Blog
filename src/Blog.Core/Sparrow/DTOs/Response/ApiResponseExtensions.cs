namespace Blog.Core.Sparrow.DTOs.Response
{
    public static class ApiResponseExtensions
    {
        public static void AddError(this ApiResponse response, string code, string msg)
        {
            response.Errors.Add(Error.Create(code, msg));
        }
    }
}
