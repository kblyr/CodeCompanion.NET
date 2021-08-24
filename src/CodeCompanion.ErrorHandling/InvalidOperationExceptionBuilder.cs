using System;

namespace CodeCompanion.ErrorHandling
{
    public sealed class InvalidOperationExceptionBuilder : InvalidOperationExceptionBuilderBase<InvalidOperationExceptionBuilder>, IExceptionBuilder<InvalidOperationException>
    {
        protected override InvalidOperationExceptionBuilder Self => this;

        public InvalidOperationException Build() => new(Message, InnerException);
    }

    public abstract class InvalidOperationExceptionBuilderBase<TSelf> : SystemExceptionBuilderBase<TSelf> where TSelf : class
    {
    }
}