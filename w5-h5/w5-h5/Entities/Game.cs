using System;
using System.Collections.Generic;
using System.Text;

namespace w5_h5.Entities
{
    public class Game
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string  Publisher { get; set; }
        public string Developer { get; set; }
        public double Price { get; set; }
    }
}
