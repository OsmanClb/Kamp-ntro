﻿using OyunDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunDemo.Abstract
{
    public interface IGamerService
    {
        void Add(Gamer gamer);
        void Delete (Gamer gamer);
        void Update (Gamer gamer);
        
    }
}
