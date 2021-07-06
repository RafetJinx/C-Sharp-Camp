using System;
using System.Collections.Generic;
using System.Text;
using w5_h5.Abstract;
using w5_h5.Entities;

namespace w5_h5.Concretes
{
    public class GamerManager : IGamerService
    {
        private IGamerCheckService _gamerCheckService;
        List<Gamer> gamers = new List<Gamer>();

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                gamers.Add(gamer);
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + ": Saved to system!");
            }
            else
            {
                //throw new Exception("Not a valid person!");
            }
        }

        public void Delete(Gamer gamer)
        {
            if (gamers.Contains(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + ": Deleted from the system!");
                gamers.Remove(gamer);
            }
            else
            {
                throw new Exception("Such a person is not registered!");
            }
        }

        public void Update(Gamer gamer)
        {
            string operation = "1. Nationality Id\n" +
                "2. First Name\n" +
                "3. Last Name\n" +
                "4. Date of birth\n" +
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
                        Console.WriteLine("Kimlik numarasi degistirilemez");
                        break;
                    case 2:
                        string tempFirstName = gamer.FirstName;
                        Console.Write("First Name: ");
                        gamer.FirstName = Console.ReadLine();
                        if (_gamerCheckService.CheckIfRealPerson(gamer))
                        {
                            Console.WriteLine("First name güncellendi");
                        }
                        else
                        {
                            gamer.FirstName = tempFirstName;
                            Console.WriteLine("Bilgileriniz güncellenemedi, lütfen bilgilerinizi dogru giriniz");
                        }
                        break;
                    case 3:
                        string tempLastName = gamer.LastName;
                        Console.Write("Last Name: ");
                        gamer.LastName = Console.ReadLine();
                        if (_gamerCheckService.CheckIfRealPerson(gamer))
                        {
                            Console.WriteLine("Last name bilginiz güncellendi");
                        }
                        else
                        {
                            gamer.LastName = tempLastName;
                            Console.WriteLine("Bilgileriniz güncellenemedi, lütfen bilgilerinizi dogru giriniz");
                        }
                        break;
                    case 4:
                        DateTime tempDateOfBirth = gamer.DateOfBirth;
                        Console.Write("Date of birth: ");
                        gamer.DateOfBirth = Convert.ToDateTime(Console.ReadLine());
                        if (_gamerCheckService.CheckIfRealPerson(gamer))
                        {
                            Console.WriteLine("Date of birth bilginiz güncellendi");
                        }
                        else
                        {
                            gamer.DateOfBirth = tempDateOfBirth;
                            Console.WriteLine("Bilgileriniz güncellenemedi, lütfen bilgilerinizi dogru giriniz");
                        }
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

        public void ShowGamers()
        {
            foreach(Gamer gamer in gamers)
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName);
            }
        }
    }
}
