using System;
using System.Collections.Generic;
using System.Text;
using w5_h5.Abstract;
using w5_h5.Entities;

namespace w5_h5.Concretes
{
    public class CampaignManager : ICampaignService
    {
        List<Campaign> campaigns = new List<Campaign>();

        public void Add(Campaign campaign)
        {
            campaigns.Add(campaign);
            Console.WriteLine("Kampanya eklendi!");
        }

        public void Delete(Campaign campaign)
        {
            campaigns.Remove(campaign);
            Console.WriteLine("Kampanya silindi!");
        }

        public void ShowAllCampaigns()
        {
            foreach(Campaign campaign in campaigns)
            {
                Console.WriteLine("Kampanya adi: " + campaign.Name);
            }
        }

        public void Update(Campaign campaign)
        {
            string operation = "1. Name\n" +
                "2. Start date\n" +
                "3. End Date\n" +
                "4. Discount Amount\n" +
                "5. Devam etmek istemiyorsanız cikis icin 5'e basiniz";
            int choice;
            bool continuation = true;
            while (continuation)
            {
                Console.WriteLine("Hangi ozelligini guncellemek istiyorsunuz:");
                Console.WriteLine(operation);
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Kampanya adi: ");
                        campaign.Name = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Kampanya baslangic tarihi: ");
                        campaign.StartDate = Convert.ToDateTime(Console.ReadLine());
                        break;
                    case 3:
                        Console.Write("Kampanya bitis tarihi: ");
                        campaign.EndDate = Convert.ToDateTime(Console.ReadLine());
                        break;
                    case 4:
                        Console.Write("Kampanya indirim oranı: ");
                        campaign.Discount = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        continuation = false;
                        break;
                    default:
                        Console.WriteLine("Hatali giris");
                        break;
                }
            }
        }
    }
}
