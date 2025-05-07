using AutoMapper;
using GlobalOutsourcingServices.Services.GeneralServices;

namespace GlobalOutsourcingServices.Middleware
{
    public class ExeptionMiddleware
    {
        public readonly RequestDelegate _next;
        public readonly IMapper _mapper;

        public ExeptionMiddleware(RequestDelegate next,IMapper mapper)
        {
            _next = next;
            _mapper = mapper;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = 500;
                var value = new
                {
                    Message = "Internal Server Error",
                    Details = ex.Message
                };
                await context.Response.WriteAsync(value.ToString());

            }
        }
    }
}
