using System;

namespace CodeCompanion.ErrorHandling
{
    public sealed class SystemExceptionBuilder : SystemExceptionBuilderBase<SystemExceptionBuilder>, IExceptionBuilder<SystemException>
    {
        protected override SystemExceptionBuilder Self => this;

        public SystemException Build() => new(Message, InnerException);
    }

    public abstract class SystemExceptionBuilderBase<TSelf> : ExceptionBuilderBase<TSelf> where TSelf : class
    {
    }
}