namespace GhostLyzer.Core.Exceptions
{
    /// <summary>
    /// Represents errors that occur when a conflict is encountered.
    /// </summary>
    public class ConflictException : CustomException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConflictException"/> class with a specified error message and a code.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="code">The code that represents the error.</param>
        public ConflictException(string message, string code = default!) : base(message) { }

        /// <summary>
        /// Gets the code that represents the error.
        /// </summary>
        public virtual string Code { get; }
    }
}
