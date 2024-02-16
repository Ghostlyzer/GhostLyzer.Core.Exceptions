using System.Globalization;

namespace GhostLyzer.Core.Exceptions
{
    /// <summary>
    /// Represents errors that occur during server operations.
    /// </summary>
    public class InternalServerException : CustomException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InternalServerException"/> class.
        /// </summary>
        public InternalServerException() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalServerException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public InternalServerException(string message) : base(message) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalServerException"/> class with a specified error message and arguments.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="args">An array of objects to insert into the format string.</param>
        public InternalServerException(string message, params object[] args)
            : base(string.Format(CultureInfo.CurrentCulture, message, args)) { }
    }
}
