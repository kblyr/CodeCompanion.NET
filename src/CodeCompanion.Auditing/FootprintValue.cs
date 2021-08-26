namespace CodeCompanion.Auditing
{
    public struct FootprintValue
    {
        public readonly string Name;
        public readonly object Value;
        public readonly bool IsOneTime;

        public FootprintValue(string name, object value, bool isOneTime)
        {
            Name = name;
            Value = value;
            IsOneTime = isOneTime;
        }
    }


}