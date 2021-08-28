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
        ValueTask SetAsync(FootprintValue value, CancellationToken cancellationToken = default);
        ValueTask SetASync(string name, object value, CancellationToken cancellationToken = default);
        ValueTask<object> GetAsync(string name, CancellationToken cancellationToken = default);
        ValueTask RemoveAsync(string name, CancellationToken cancellationToken = default);
        ValueTask ClearAsync(CancellationToken cancellationToken = default);
    }
}