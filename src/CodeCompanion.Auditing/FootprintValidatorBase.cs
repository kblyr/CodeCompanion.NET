using System;

namespace CodeCompanion.Auditing
{
    public abstract class FootprintValidatorBase
    {
        public virtual void ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be null or white-space", nameof(name));
        }
    }
}