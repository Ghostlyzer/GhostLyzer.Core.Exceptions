namespace GhostLyzer.Core.Exceptions
{
    /// <summary>
    /// Represents errors that occur when a bad request is made.
    /// </summary>
    public class BadRequestException : CustomException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BadRequestException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public BadRequestException(string message) : base(message) { }
    }
}
