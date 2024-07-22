using DesignPatterns.Result.Domain.EstatusYTipos;

namespace DesignPatterns.Result.Domain.Shared
{
    internal class Error
    {
        public ErrorType Code { get; }
        public string Message { get; }
        public Error(ErrorType code, string message)
        {
            Code = code;
            Message = message;
        }
        public static readonly Error None = new(ErrorType.None, string.Empty);
        public static readonly Error NullValue = new(ErrorType.NullValue, "The result's value is null.");
        public static implicit operator string(Error error) => error.Code.ToString();
        public static bool operator ==(Error? left, Error? right)
        {
            if (left is null && right is null)
            {
                return true;
            }
            if (left is null || right is null)
            {
                return false;
            }
            return left.Equals(right);
        }
        public static bool operator !=(Error left, Error right) => !(left == right);
    }
}
