using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunDemo.Entities
{
    public class Gamer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; }
        public string NickName { get; set; }
        public DateTime YearOfBirth { get; set; }
        public string Mail { get; set; }
        public List <Game> Games { get; set; }

    }
}
