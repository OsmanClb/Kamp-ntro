using OyunDemo.Abstract;
using OyunDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunDemo.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Adlı kampanya eklendi...");
        }

        public void delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Adlı kampanya silindi...");
        }

        public void update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Adlı kampanya güncellendi...");
        }

        public void Calculate(Campaign campaign, Game game)
        {
            double NewPrice = (game.UnitPrice - ((campaign.Rate / 100) * (game.UnitPrice)));
            Console.WriteLine(game.Name + " yeni fiyatı : " + NewPrice);
        }
    }
}
