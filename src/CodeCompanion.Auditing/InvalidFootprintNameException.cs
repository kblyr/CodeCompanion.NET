using System.Reflection.Emit;
using System;

namespace CodeCompanion.Auditing
{
    public class InvalidFootprintNameException : Exception
    {
        public virtual string FootprintName { get; }

        public InvalidFootprintNameException(string footprintName)
        {
            FootprintName = footprintName;
        }

        public InvalidOperationException(string footprintName, string message) : base(message)
        {
            FootprintName = footprintName;
        }

        public InvalidFootprintNameException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}