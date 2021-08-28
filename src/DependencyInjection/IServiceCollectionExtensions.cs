using Microsoft.Extensions.DependencyInjection;

namespace CodeCompanion
{
    public static class IServiceCollectionExtensions
    {
        public static ICodeCompanionServiceCollection AddCodeCompanion(this IServiceCollection instance) => new CodeCompanionServiceCollection(instance);
    }
}
