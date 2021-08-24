using System;

namespace CodeCompanion.ErrorHandling
{
    public sealed class ArgumentOutOfRangeExceptionBuilder : ArgumentOutOfRangeExceptionBuilderBase<ArgumentOutOfRangeExceptionBuilder>, IExceptionBuilder<ArgumentOutOfRangeException>
    {
        protected override ArgumentOutOfRangeExceptionBuilder Self => this;

        public ArgumentOutOfRangeException Build() => new(ParamName, ActualValue, Message);
    }

    public abstract class ArgumentOutOfRangeExceptionBuilderBase<TSelf> : ArgumentExceptionBuilderBase<TSelf> where TSelf : class
    {
        public object ActualValue { get; protected set; }

        public virtual TSelf WithActualValue(object actualValue)
        {
            ActualValue = actualValue;
            return Self;
        }
    }
}