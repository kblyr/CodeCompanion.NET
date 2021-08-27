using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CodeCompanion.Auditing
{
    internal sealed class Footprint : IFootprint
    {
        private readonly object _lock = new();
        private readonly Dictionary<string, FootprintValue> _source = new();
        private readonly IFootprintValidator _validator;

        public Footprint(IFootprintValidator validator)
        {
            _validator = validator;
        }

        public void Clear() => InternalClear();

        public ValueTask ClearAsync(CancellationToken cancellationToken = default)
        {
            InternalClear();
            return ValueTask.CompletedTask;
        }

        public object Get(string name)
        {
            _validator.ValidateName(name);
            return InternalGet(name);
        }

        public ValueTask<object> GetAsync(string name, CancellationToken cancellationToken = default) 
        {
            _validator.ValidateName(name);
            return ValueTask.FromResult(InternalGet(name));
        }

        public void Remove(string name)
        {
            _validator.ValidateName(name);
            InternalRemove(name);
        }

        public ValueTask RemoveAsync(string name, CancellationToken cancellationToken = default)
        {
            _validator.ValidateName(name);
            InternalRemove(name);
            return ValueTask.CompletedTask;
        }

        public void Set(FootprintValue value)
        {
            _validator.ValidateName(value.Name);
            InternalSet(value);
        }

        public void Set(string name, object value)
        {
            _validator.ValidateName(name);
            InternalSet(name, value);
        }

        public ValueTask SetAsync(FootprintValue value, CancellationToken cancellationToken = default)
        {
            _validator.ValidateName(value.Name);
            InternalSet(value);
            return ValueTask.CompletedTask;
        }

        public ValueTask SetASync(string name, object value, CancellationToken cancellationToken = default)
        {
            _validator.ValidateName(name);
            InternalSet(name, value);
            return ValueTask.CompletedTask;
        }

        private void InternalClear()
        {
            lock (_lock)
            {
                _source.Clear();
            }
        }

        private object InternalGet(string name)
        {
            lock (_lock)
            {
                if (_source.ContainsKey(name))
                {
                    var footprintValue = _source[name];

                    if (footprintValue.IsOneTime)
                        _source.Remove(footprintValue.Name);

                    return footprintValue.Value;
                }

                return null;
            }
        }

        private void InternalRemove(string name)
        {
            lock (_lock)
            {
                if (_source.ContainsKey(name))
                    _source.Remove(name);
            }
        }

        private void InternalSet(FootprintValue value)
        {
            lock (_lock)
            {
                if (_source.ContainsKey(value.Name))
                    _source[value.Name] = value;
                else
                    _source.Add(value.Name, value);
            }
        }

        private void InternalSet(string name, object value)
        {
            lock (_lock)
            {
                if (_source.ContainsKey(name))
                {
                    var footprintValue = _source[name];
                    _source[name] = footprintValue.Copy(value);
                }
                else
                {
                    _source.Add(name, new FootprintValue(name, value, false, false));
                }
            }
        }
    }
}