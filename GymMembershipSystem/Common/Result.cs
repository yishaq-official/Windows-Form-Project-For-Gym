using System;

namespace GymMembershipSystem.Common
{
    /// <summary>
    /// Represents the outcome of an operation without throwing exceptions.
    /// </summary>
    public class Result
    {
        public bool IsSuccess { get; }
        public bool IsFailure => !IsSuccess;
        public string Error { get; }

        protected Result(bool isSuccess, string error)
        {
            if (isSuccess && !string.IsNullOrEmpty(error))
                throw new InvalidOperationException("A successful result cannot contain an error message.");
            if (!isSuccess && string.IsNullOrEmpty(error))
                throw new InvalidOperationException("A failed result must contain an error message.");

            IsSuccess = isSuccess;
            Error = error;
        }

        public static Result Ok() => new Result(true, string.Empty);
        public static Result Fail(string error) => new Result(false, error);
    }

    /// <summary>
    /// Represents the outcome of an operation containing a return value.
    /// </summary>
    /// <typeparam name="T">Type of the returned payload.</typeparam>
    public class Result<T> : Result
    {
        private readonly T? _value;

        public T Value
        {
            get
            {
                if (IsFailure)
                    throw new InvalidOperationException($"Cannot access Value of failed result: {Error}");
                return _value!;
            }
        }

        protected Result(bool isSuccess, T? value, string error)
            : base(isSuccess, error)
        {
            _value = value;
        }

        public static Result<T> Ok(T value) => new Result<T>(true, value, string.Empty);
        public static new Result<T> Fail(string error) => new Result<T>(false, default, error);

        public static implicit operator Result<T>(T value) => Ok(value);
    }
}
