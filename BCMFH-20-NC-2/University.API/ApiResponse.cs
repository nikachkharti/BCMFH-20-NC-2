namespace University.API
{
    public class ApiResponse
    {
        public ApiResponse()
        {
        }

        public ApiResponse(string message, object result, int statusCode, bool isSuccess)
        {
            Message = message;
            Result = result;
            StatusCode = statusCode;
            IsSuccess = isSuccess;
        }

        public string Message { get; set; }
        public object Result { get; set; }
        public int StatusCode { get; set; }
        public bool IsSuccess { get; set; }
    }


    public static class ApiResponseMessage
    {
        public static string successMessage = "Request completed successfully";
    }
}
