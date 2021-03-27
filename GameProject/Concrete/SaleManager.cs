using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class SaleManager : ISaleService
    {
        public void CampaignSale(Game game, Gamer gamer, Campaign campaign)
        {
            
            double reducedPrice = game.GamePrice - (game.GamePrice * campaign.CampaignDiscount) / 100;
            Console.WriteLine(game.GameName +" adlı oyun "+gamer.FirstName + " " + gamer.LastName+" isimli oyuncu tarafından % "+ campaign.CampaignDiscount+ " indirimle satın alındı.");
        }

        public void Sale(Gamer gamer,Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun " + gamer.FirstName + " " + gamer.LastName + " isimli oyuncu tarafından satın alındı.");
        }
    }
}
