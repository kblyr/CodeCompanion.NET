using System;

namespace CodeCompanion.ErrorHandling
{
    public sealed class ExceptionBuilder : ExceptionBuilderBase<ExceptionBuilder>, IExceptionBuilder<Exception>
    {
        protected override ExceptionBuilder Self => this;

        public Exception Build() => new(Message, InnerException);
    }

    public abstract class ExceptionBuilderBase<TSelf> where TSelf : class 
    {
        public string Message { get; protected set; }
        public Exception InnerException { get; protected set; }

        protected abstract TSelf Self { get; }

        public virtual TSelf WithMessage(string message)
        {
            Message = message;
            return Self;
        }

        public virtual TSelf WithInnerException(Exception innerException)
        {
            InnerException = innerException;
            return Self;
        }
    }
}