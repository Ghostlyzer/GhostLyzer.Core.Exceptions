using System.Net;

namespace GhostLyzer.Core.Exceptions
{
    /// <summary>
    /// Represents errors that occur during application execution.
    /// </summary>
    public class CustomException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomException"/> class with a specified error message and a status code.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="statusCode">The status code that represents the error.</param>
        public CustomException(
            string message,
            HttpStatusCode statusCode = HttpStatusCode.BadRequest) 
                : base(message) 
        {
            StatusCode = statusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomException"/> class with a specified error message, a reference to the inner exception that is the cause of this exception, and a status code.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        /// <param name="statusCode">The status code that represents the error.</param>
        public CustomException(
            string message,
            Exception innerException,
            HttpStatusCode statusCode = HttpStatusCode.BadRequest) 
                : base(message, innerException)
        {
            StatusCode = statusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomException"/> class with a status code.
        /// </summary>
        /// <param name="statusCode">The status code that represents the error.</param>
        public CustomException(HttpStatusCode statusCode = HttpStatusCode.BadRequest) : base()
        {
            StatusCode = statusCode;
        }

        /// <summary>
        /// Gets the status code that represents the error.
        /// </summary>
        public HttpStatusCode StatusCode { get; }
    }
}
