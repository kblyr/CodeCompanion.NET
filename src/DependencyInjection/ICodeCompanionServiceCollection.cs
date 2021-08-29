using Microsoft.Extensions.DependencyInjection;

namespace CodeCompanion
{
    public interface ICodeCompanionServiceCollection
    {
        IServiceCollection Services { get; }
    }
}
