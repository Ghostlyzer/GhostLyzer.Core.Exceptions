namespace GhostLyzer.Core.Exceptions
{
    /// <summary>
    /// Represents errors that occur when a requested resource is not found.
    /// </summary>
    public class NotFoundException : CustomException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotFoundException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public NotFoundException(string message) : base(message) { }
    }
}
