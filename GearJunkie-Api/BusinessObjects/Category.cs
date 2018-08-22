using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjects
{
    public class Category
    {
        public IEnumerable<Gear> Gears { get; set; }
    }
}
