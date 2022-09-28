using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunDemo.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Producer { get; set; }
        public double UnitPrice { get; set; }
        public int UnitStock { get; set; }
       
    }
}
