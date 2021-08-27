namespace CodeCompanion.Auditing
{
    public struct FootprintValue
    {
        public readonly string Name;
        public readonly object Value;
        public readonly bool IsOneTime;
        public readonly bool IsCached;

        public FootprintValue(string name, object value, bool isOneTime = false, bool isCached = false)
        {
            Name = name;
            Value = value;
            IsOneTime = isOneTime;
            IsCached = isCached;
        }

        public static FootprintValue Create(string name, object value) => new(name, value);
    }
}