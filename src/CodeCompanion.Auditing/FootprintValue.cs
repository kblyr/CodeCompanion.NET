namespace CodeCompanion.Auditing
{
    public struct FootprintValue
    {
        public readonly string Name;
        public readonly object Value;
        public readonly bool IsOneTime;
        public readonly bool IsCached;

        public FootprintValue(string name, object value, bool isOneTime, bool isCached)
        {
            Name = name;
            Value = value;
            IsOneTime = isOneTime;
            IsCached = isCached;
        }
    }


}