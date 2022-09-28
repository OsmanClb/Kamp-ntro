using OyunDemo.Abstract;
using OyunDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunDemo.Concrete
{
    public class GamerManager : IGamerService
    {
 
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " Adlı oyuncu ' " + gamer.NickName + "' Kullanıcı adıyla Eklendi...");
            }
            else
            {
                Console.WriteLine("Oyunucu eklenemedi...");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " Adlı oyuncu ' " + gamer.NickName + "' Kullanıcı adıyla silindi...");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " Adlı oyuncu ' " + gamer.NickName + "' Kullanıcı adıyla güncellendi...");
        }
    }
}
