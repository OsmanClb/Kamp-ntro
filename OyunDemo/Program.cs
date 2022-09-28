using OyunDemo.Abstract;
using OyunDemo.Concrete;
using OyunDemo.Entities;
using System.Security.Cryptography;

namespace OyunDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //oyun oluşturuldu
            Game game1 = new Game();

            game1.Id = 1;
            game1.Name = "CS GO";
            game1.Producer = "Valve";
            game1.UnitPrice = 123;
            game1.UnitStock = 12345;

            List<Game> games = new List<Game>(); 
            games.Add(game1);

            GameManager gameManager = new GameManager();

            foreach (Game game in games) //oyun-oyunlar sisteme eklendi
            {
                gameManager.Add(game);
            }
            
            Gamer gamer1 = new Gamer();  //oyunucu oluşturuldu

            gamer1.Id = 1;
            gamer1.FirstName = "Osman";
            gamer1.LastName = "Çelebi";
            gamer1.NickName = "EdgeBlue";
            gamer1.YearOfBirth = new DateTime(2000, 1, 1);
            gamer1.NationalId = "12345678901";
            gamer1.Mail = "asdasd@gmail.com";
            gamer1.Games = new List<Game>();

            GamerManager gamerManager = new GamerManager(new GamerCheckManager());  // sisteme oyunucu eklendi
            gamerManager.Add(gamer1);


            Campaign campaign = new Campaign();   //kampanya oluşturuldu
            campaign.Id = 1;
            campaign.Name = "Kış Sezonu";
            campaign.Rate = 25;

            CampaignManager campaignManager = new CampaignManager();  //kampanya sisteme eklendi
            campaignManager.add(campaign);
            campaignManager.Calculate(campaign, game1);


            SalesManager salesManager = new SalesManager();  //oyun satın alındı.
            salesManager.Sale(gamer1, game1);



            
        }
    }
}