namespace DesignPatterns.Result.Domain.Shared
{
    internal class Result
    {
        public bool IsSuccess { get; }
        public bool IsFailure => !IsSuccess;
        public Error Error { get; }
        protected internal Result(bool isSuccess, Error error)
        {
            if (isSuccess && error != Error.None)
            {
                throw new InvalidOperationException();
            }
            if (!isSuccess && error == Error.None)
            {
                throw new InvalidOperationException();
            }
            IsSuccess = isSuccess;
            Error = error;
        }
        public static Result Success() => new Result(true, Error.None);
        public static Result<TValue> Success<TValue>(TValue value) => new Result<TValue>(value, true, Error.None);
        public static Result Failure(Error error) => new Result(false, error);
        public static Result<TValue> Failure<TValue>(Error error) => new Result<TValue>(default, false, error);
        public static Result<TValue> Create<TValue>(TValue? value)
        {
            if (value == null)
            {
                return Failure<TValue>(Error.NullValue);
            }
            return Success(value);
        }
    }
    internal class Result<TValue> : Result
    {
        public readonly TValue? _value;
        protected internal Result(TValue? value, bool isSuccess, Error error) : base(isSuccess, error)
        {
            _value = value;
        }
        public TValue Value => IsSuccess ? _value! : throw new InvalidOperationException("A failure's value can't be accessed.");
        public static implicit operator Result<TValue>(TValue? value) => Create(value);
    }
}
