using Microsoft.Extensions.DependencyInjection;

namespace CodeCompanion
{
    internal sealed class CodeCompanionServiceCollection : ICodeCompanionServiceCollection
    {
        public IServiceCollection Services { get; }

        public CodeCompanionServiceCollection(IServiceCollection services)
        {
            Services = services;
        }
    }
}
