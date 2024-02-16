using GhostLyzer.Core.Validation.Models;

namespace GhostLyzer.Core.Exceptions
{
    /// <summary>
    /// Represents errors that occur during validation operations.
    /// </summary>
    public class ValidationException : CustomException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationException"/> class with a specified validation result model.
        /// </summary>
        /// <param name="validationResultModel">The result of the validation operation.</param>
        public ValidationException(ValidationResultModel validationResultModel)
        {
            ValidationResultModel = validationResultModel;
        }

        /// <summary>
        /// Gets the result of the validation operation.
        /// </summary>
        public ValidationResultModel ValidationResultModel { get; }
    }
}
