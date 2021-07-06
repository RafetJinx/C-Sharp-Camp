using System;
using System.Collections.Generic;
using System.Text;
using w5_h5.Abstract;
using w5_h5.Entities;

namespace w5_h5.Concretes
{
    public class SaleManager : ISaleService
    {
        private List<Sale> sales = new List<Sale>();
        private Sale sale;
        public void MakeSell(Gamer gamer, Game game, Campaign campaign)
        {
            sale = new Sale();
            sale.Buyer = gamer;
            sale.Sold = game;
            sale.Campaign = campaign;
            Console.Write("Kac adet alacaksınız: ");
            sale.Qunatity = Convert.ToInt32(Console.ReadLine());
            sale.TotalPrice = game.Price * ((100-campaign.Discount) * 0.01) * sale.Qunatity;
            Console.Write("Odeme methodu: ");
            sale.PaymentMethod = Console.ReadLine();
            sale.SellBy = DateTime.Now;
            sales.Add(sale);
        }

        public void ShowAllSellDetails()
        {
            Console.WriteLine("---------------Satis detaylari---------------");
            foreach(Sale sale in sales)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Sellby: " + sale.SellBy);
                Console.WriteLine("Buyer: " + sale.Buyer.FirstName + " " + sale.Buyer.LastName);
                Console.WriteLine("Sold: " + sale.Sold.Name);
                Console.WriteLine("Campaign: " + sale.Campaign.Name);
                Console.WriteLine("Quantity: " + sale.Qunatity);
                Console.WriteLine("Payment Method: " + sale.PaymentMethod);
                Console.WriteLine("Total Price:" + sale.TotalPrice + " TL");
            }
        }
    }
}
