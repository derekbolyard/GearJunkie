using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class OperationResultOfT<T> where T: new()
    {
        public OperationResultOfT()
        {
            Entity = new T();
        }
        public bool Success { get; set; }
        public IEnumerable<string> Messages { get; set; }
        public T Entity { get; set; }
    }
}
