using System;

namespace CodeCompanion.ErrorHandling
{
    public interface IExceptionBuilder<T> where T : Exception
    {
        T Build();
    }
}