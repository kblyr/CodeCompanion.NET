namespace CodeCompanion.Auditing
{
    public interface IFootprint
    {
        object this[string name] { get; set; }
        void Clear();
        void Add(string name, object value);
        void Update(string name, object value);
        void Remove(string name);
        bool TryAdd(string name, object value);
        bool TryUpdate(string name, object value);
        bool TryRemove(string name);
        bool TryGet(string name, out object value);
    }
}