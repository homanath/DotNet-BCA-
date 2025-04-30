
namespace exceptionHandlingExample
{
    [Serializable]
    internal class DividedByZeroException : Exception
    {
        public DividedByZeroException()
        {
        }

        public DividedByZeroException(string? message) : base(message)
        {
        }

        public DividedByZeroException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}