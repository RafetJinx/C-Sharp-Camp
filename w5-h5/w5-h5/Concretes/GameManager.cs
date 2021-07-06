using System;
using System.Collections.Generic;
using System.Text;
using w5_h5.Abstract;
using w5_h5.Entities;

namespace w5_h5.Concretes
{
    public class GameManager : IGameService
    {
        List<Game> games = new List<Game>();
        public void Add(Game game)
        {
            games.Add(game);
            Console.WriteLine(game.Name +  " added to system!");
        }

        public void Delete(Game game)
        {
            games.Remove(game);
            Console.WriteLine("Oyun silindi!");
        }

        public void ShowAllGames()
        {
            foreach(Game game in games)
            {
                Console.WriteLine("Oyun adi: " + game.Name);
            }
        }

        public void Update(Game game)
        {
            string operation = "1. Name\n" +
                "2. Release date\n" +
                "3. Publisher\n" +
                "4. Developer\n" +
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
                        Console.Write("Oyun adi:");
                        game.Name = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Oyunun yayınlanma tarihi: ");
                        game.ReleaseDate = Convert.ToDateTime(Console.ReadLine());
                        break;
                    case 3:
                        Console.Write("Oyunun yayımcısı: ");
                        game.Publisher = Console.ReadLine();
                        break;
                    case 4:
                        Console.Write("Oyunun geliştiricisi: ");
                        game.Developer = Console.ReadLine();
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
