using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessObjects
{
    public class Gear
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Weight { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string OwnedStatusCd { get; set; }
    }
}
