using System;

namespace CodeCompanion.Auditing
{
    public class FootprintValueBuilder
    {
        protected string Name { get; set; }
        protected object Value { get; set; }
        protected bool IsOneTime { get; set; }
        protected bool IsCached { get; set; }
        protected TimeSpan? CacheExpiration { get; set; }

        public FootprintValueBuilder(string name)
        {
            Name = name;
        }

        public FootprintValue Build() => new(Name, Value, IsOneTime, IsCached, CacheExpiration);

        public FootprintValueBuilder WithValue(object value)
        {
            Value = value;
            return this;
        }

        public FootprintValueBuilder AsOneTime()
        {
            IsOneTime = true;
            return this;
        }

        public FootprintValueBuilder AsCached(TimeSpan cacheExpiration)
        {
            IsCached = true;
            CacheExpiration = cacheExpiration;
            return this;
        }
    }
}