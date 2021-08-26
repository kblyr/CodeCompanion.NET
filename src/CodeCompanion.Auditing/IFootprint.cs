using System.Threading;
using System.Threading.Tasks;

namespace CodeCompanion.Auditing
{
    public interface IFootprint
    {
        void Set(FootprintValue value);
        void Set(string name, object value);
        object Get(string name);
        void Remove(string name);
        void Clear();
        Task SetAsync(FootprintValue value, CancellationToken cancellationToken = default);
        Task SetASync(string name, object value, CancellationToken cancellationToken = default);
        Task<object> GetAsync(string name, CancellationToken cancellationToken = default);
        Task RemoveAsync(string name, CancellationToken cancellationToken = default);
        Task ClearAsync(CancellationToken cancellationToken = default);
    }
}