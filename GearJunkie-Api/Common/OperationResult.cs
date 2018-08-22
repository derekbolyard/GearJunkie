using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class OperationResult
    {
        public bool Success { get; set; }
        public IEnumerable<string> Messages { get; set; }
    }
}
