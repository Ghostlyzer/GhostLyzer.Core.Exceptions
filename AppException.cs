using System.Net;

namespace GhostLyzer.Core.Exceptions
{
    /// <summary>
    /// Represents errors that occur during application execution related to the application's logic.
    /// </summary>
    public class AppException : CustomException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppException"/> class with a specified error message and a code.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="code">The code that represents the error.</param>
        public AppException(string message, string code = default!) : base(message) { Code = code; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppException"/> class.
        /// </summary>
        public AppException() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public AppException(string message) : base(message) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppException"/> class with a specified error message and a status code.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="statusCode">The status code that represents the error.</param>
        public AppException(string message, HttpStatusCode statusCode) : base(message, statusCode) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppException"/> class with a specified error message, a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        public AppException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Gets the code that represents the error.
        /// </summary>
        public string Code { get; }
    }
}
