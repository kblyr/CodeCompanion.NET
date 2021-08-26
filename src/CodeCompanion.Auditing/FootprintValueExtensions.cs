namespace CodeCompanion.Auditing
{
    public static class FootprintValueExtensions
    {
        public static FootprintValue Copy(this FootprintValue instance, object newValue) => new(instance.Name, newValue, instance.IsOneTime);
    }
}