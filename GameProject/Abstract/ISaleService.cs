using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ISaleService
    {
        void Sale(Gamer gamer,Game game);
        void CampaignSale(Game game, Gamer gamer, Campaign campaign);
    }
}
