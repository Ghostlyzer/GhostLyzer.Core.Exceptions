using System.Net;

namespace GhostLyzer.Core.Exceptions
{
    /// <summary>
    /// Represents errors that occur during identity operations.
    /// </summary>
    public class IdentityException : CustomException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityException"/> class with a specified error message and a status code.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="statusCode">The status code that represents the error.</param>
        public IdentityException(string message = default, HttpStatusCode statusCode = default)
            : base(message, statusCode)
        {
        }
    }
}
