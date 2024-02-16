using Microsoft.AspNetCore.Http;
using Hellang.Middleware.ProblemDetails;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Grpc.Core;

namespace GhostLyzer.Core.Exceptions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCustomProblemDetails(this IServiceCollection services)
        {
            services.AddProblemDetails(x =>
            {
                // Include the exception details if the application
                // is running in dev or staging mode
                x.IncludeExceptionDetails = (ctx, _) =>
                {
                    var env = ctx.RequestServices.GetRequiredService<IHostEnvironment>();
                    return env.IsDevelopment() || env.IsStaging();
                };
                x.Map<ConflictException>(ex => new ProblemDetails
                {
                    Title = "Application Rules Are Broken",
                    Status = StatusCodes.Status409Conflict,
                    Detail = ex.Message,
                    Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.8"
                });

                // Map each of the exception types
                x.Map<ValidationException>(ex => new ProblemDetails
                {
                    Title = "Input Validation Rules Are Broken",
                    Status = StatusCodes.Status400BadRequest,
                    Detail = ex.Message,
                    Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.1"
                });

                x.Map<BadRequestException>(ex => new ProblemDetails
                {
                    Title = "Bad Request Exception",
                    Status = StatusCodes.Status400BadRequest,
                    Detail = ex.Message,
                    Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.1"
                });

                x.Map<NotFoundException>(ex => new ProblemDetails
                {
                    Title = "Not Found Exception",
                    Status = StatusCodes.Status404NotFound,
                    Detail = ex.Message,
                    Type = "https://tools.ietf.org/html/rfc7231#section-6.5.4"
                });

                x.Map<InternalServerException>(ex => new ProblemDetails
                {
                    Title = "API Server Exception",
                    Status = StatusCodes.Status400BadRequest,
                    Detail = ex.Message,
                    Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.1"
                });

                x.Map<AppException>(ex => new ProblemDetails
                {
                    Title = "Application Exception",
                    Status = StatusCodes.Status500InternalServerError,
                    Detail = ex.Message,
                    Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.6.1"
                });

                x.Map<IdentityException>(ex => new ProblemDetails
                {
                    Title = "Identity Exception",
                    Status = (int)ex.StatusCode,
                    Detail = ex.Message,
                    Type = "https://datatracker.ietf.org/doc/html/rfc7231"
                });

                x.Map<RpcException>(ex => new ProblemDetails
                {
                    Title = "gRPC Exception",
                    Status = StatusCodes.Status400BadRequest,
                    Detail = ex.Status.Detail,
                    Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.1"
                });

                x.MapToStatusCode<ArgumentNullException>(StatusCodes.Status400BadRequest);
            });

            return services;
        }
    }
}
