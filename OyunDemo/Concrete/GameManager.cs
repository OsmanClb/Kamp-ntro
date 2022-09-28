using OyunDemo.Abstract;
using OyunDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunDemo.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " Oyunu eklendi...");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " Oyunu silindi...");
        }
    }
}
