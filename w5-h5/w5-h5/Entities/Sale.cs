using System;
using System.Collections.Generic;
using System.Text;

namespace w5_h5.Entities
{
    public class Sale
    {
        public Gamer Buyer { get; set; }
        public Game Sold { get; set; }
        public Campaign Campaign { get; set; }
        public int Qunatity { get; set; }
        public double TotalPrice { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime SellBy { get; set; }
    }
}
