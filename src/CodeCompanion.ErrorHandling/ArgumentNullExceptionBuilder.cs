using System.Reflection;
using System.Reflection.Emit;
using System;

namespace CodeCompanion.ErrorHandling
{
    public sealed class ArgumentNullExceptionBuilder : ArgumentNullExceptionBuilderBase<ArgumentNullExceptionBuilder>, IExceptionBuilder<ArgumentNullException>
    {
        protected override ArgumentNullExceptionBuilder Self => this;

        public ArgumentNullException Build() => string.IsNullOrEmpty(ParamName) ? new(Message, InnerException) : new(ParamName, Message);
    }

    public abstract class ArgumentNullExceptionBuilderBase<TSelf> : ArgumentExceptionBuilderBase<TSelf> where TSelf : class
    {
    }
}