using System.Net;
using University.Service.Exceptions;

namespace University.API.Middleware
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (Exception ex)
            {
                await HandleException(context, ex);
            }
        }

        private Task HandleException(HttpContext context, Exception ex)
        {
            ApiResponse response = new();

            switch (ex)
            {
                case AmbigousNameException:
                    response.StatusCode = Convert.ToInt32(HttpStatusCode.Conflict);
                    response.Message = ex.Message;
                    response.IsSuccess = false;
                    response.Result = null;
                    break;
                case BadRequestException:
                    response.StatusCode = Convert.ToInt32(HttpStatusCode.BadRequest);
                    response.Message = ex.Message;
                    response.IsSuccess = false;
                    response.Result = null;
                    break;
                case NotFoundException:
                    response.StatusCode = Convert.ToInt32(HttpStatusCode.NotFound);
                    response.Message = ex.Message;
                    response.IsSuccess = false;
                    response.Result = null;
                    break;
                default:
                    response.StatusCode = Convert.ToInt32(HttpStatusCode.InternalServerError);
                    response.Message = ex.Message;
                    response.IsSuccess = false;
                    response.Result = null;
                    break;
            }

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = response.StatusCode;

            return context.Response.WriteAsJsonAsync(response);
        }
    }
}
