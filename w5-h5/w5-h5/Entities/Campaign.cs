using System;
using System.Collections.Generic;
using System.Text;

namespace w5_h5.Entities
{
    public class Campaign
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Discount { get; set; }
    }
}
