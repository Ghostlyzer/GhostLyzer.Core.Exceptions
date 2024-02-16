namespace GhostLyzer.Core.Exceptions
{
    /// <summary>
    /// Represents errors that occur when an aggregate is not found.
    /// </summary>
    public class AggregateNotFoundException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateNotFoundException"/> class with a specified type name and ID.
        /// </summary>
        /// <param name="typeName">The name of the type of the aggregate that was not found.</param>
        /// <param name="id">The ID of the aggregate that was not found.</param>
        public AggregateNotFoundException(string typeName, long id)
            : base($"{typeName} with id '{id}' was not found")
        {
        }

        /// <summary>
        /// Creates a new AggregateNotFoundException for a specific type and ID.
        /// </summary>
        /// <typeparam name="T">The type of the aggregate that was not found.</typeparam>
        /// <param name="id">The ID of the aggregate that was not found.</param>
        /// <returns>A new AggregateNotFoundException for the specified type and ID.</returns>
        public AggregateNotFoundException For<T>(long id)
        {
            return new AggregateNotFoundException(typeof(T).Name, id);
        }
    }
}
