using System;
using w5_h5.Adapters;
using w5_h5.Concretes;
using w5_h5.Entities;

namespace w5_h5
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game
            {
                ID = 1,
                Name = "League of Legends",
                ReleaseDate = new DateTime(2009, 10, 27),
                Publisher = "Riot Games",
                Developer = "Riot Games",
                Price = 100
            };

            Gamer gamer = new Gamer
            {
                Id = 1,
                NationalityId = "28861499108",
                FirstName = "Engin",
                LastName = "Demiroğ",
                DateOfBirth = new DateTime(1985, 1, 6)
            };

            Campaign campaign = new Campaign
            {
                Name = "BIG CAMPAING",
                StartDate = new DateTime(2021, 7, 6),
                EndDate = new DateTime(2021, 7, 10),
                Discount = 15
            };

            GameManager gameManager = new GameManager();
            gameManager.Add(game);

            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(gamer);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);

            Sale sale = new Sale();

            SaleManager saleManager = new SaleManager();
            saleManager.MakeSell(gamer, game, campaign);
            saleManager.ShowAllSellDetails();
        }
    }
}
