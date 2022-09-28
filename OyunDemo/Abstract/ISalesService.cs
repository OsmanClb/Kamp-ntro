using OyunDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunDemo.Abstract
{
    public  interface ISalesService
    {
        void Sale(Gamer gamer, Game game);
    }
}
