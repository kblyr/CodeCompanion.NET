using System;

namespace CodeCompanion.ErrorHandling
{
    public sealed class ArgumentExceptionBuilder : ArgumentExceptionBuilderBase<ArgumentExceptionBuilder>, IExceptionBuilder<ArgumentException>
    {
        protected override ArgumentExceptionBuilder Self => this;

        public ArgumentException Build() => new(Message, ParamName, InnerException);
    }

    public abstract class ArgumentExceptionBuilderBase<TSelf> : SystemExceptionBuilderBase<TSelf> where TSelf : class
    {
        public string ParamName { get; protected set; }

        public virtual TSelf WithParamName(string paramName)
        {
            ParamName = paramName;
            return Self;
        }
    }
}