using OyunDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunDemo.Abstract
{
    public interface ICampaignService
    {
        void add(Campaign campaign);
        void delete(Campaign campaign);
        void update(Campaign campaign);
    }
}
