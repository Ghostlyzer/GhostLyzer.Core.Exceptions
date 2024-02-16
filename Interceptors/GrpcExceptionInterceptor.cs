using Grpc.Core;
using Grpc.Core.Interceptors;
using Microsoft.Extensions.Logging;

namespace GhostLyzer.Core.Exceptions.Interceptors
{
    /// <summary>
    /// Intercepts exceptions in gRPC calls and converts them to gRPC status codes.
    /// </summary>
    public class GrpcExceptionInterceptor : Interceptor
    {
        private readonly ILogger<GrpcExceptionInterceptor> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="GrpcExceptionInterceptor"/> class with a specified logger.
        /// </summary>
        /// <param name="logger">The logger used to log information about exceptions.</param>
        public GrpcExceptionInterceptor(ILogger<GrpcExceptionInterceptor> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Intercepts a unary call and handles any exceptions that occur during its execution.
        /// </summary>
        /// <typeparam name="TRequest">The type of the request message.</typeparam>
        /// <typeparam name="TResponse">The type of the response message.</typeparam>
        /// <param name="request">The request message.</param>
        /// <param name="context">The call context.</param>
        /// <param name="continuation">The next handler in the pipeline.</param>
        /// <returns>The response message.</returns>
        /// <exception cref="RpcException">Thrown when an exception occurs during the execution of the call.</exception>
        public override async Task<TResponse> UnaryServerHandler<TRequest, TResponse>(
            TRequest request,
            ServerCallContext context,
            UnaryServerMethod<TRequest, TResponse> continuation)
        {
            try
            {
                return await continuation(request, context);
            }
            catch (Exception exception)
            {
                throw new RpcException(new Status(StatusCode.Cancelled, exception.Message));
            }
        }
    }
}
