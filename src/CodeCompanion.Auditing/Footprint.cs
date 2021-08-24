namespace CodeCompanion.Auditing
{
    public struct Footprint
    {
        public readonly string Name;
        public readonly object Value;

        public Footprint(string name, object value)
        {
            Name = name;
            Value = value;
        }
    }
}