using System;

namespace CodeCompanion.Auditing
{
    public class Footprint : IFootprint
    {
        public object this[string name]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Add(string name, object value)
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public void Remove(string name)
        {
            throw new System.NotImplementedException();
        }

        public bool TryAdd(string name, object value)
        {
            throw new System.NotImplementedException();
        }

        public bool TryGet(string name, out object value)
        {
            throw new System.NotImplementedException();
        }

        public bool TryRemove(string name)
        {
            throw new System.NotImplementedException();
        }

        public bool TryUpdate(string name, object value)
        {
            throw new System.NotImplementedException();
        }

        public void Update(string name, object value)
        {
            throw new System.NotImplementedException();
        }
    }
}