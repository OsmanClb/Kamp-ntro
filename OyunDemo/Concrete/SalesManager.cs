using OyunDemo.Abstract;
using OyunDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunDemo.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Sale(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.NickName + " Kullanıcı adlı oyunucu " + game.Name + " adlı oyunu satın aldı...");
        }
    }
}
