using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new MerniseServiceAdapter());
            Gamer gamer = new Gamer() { Id = 1, FirstName = "Merve Büşra", LastName = "Durmuş", NationalityId = "1111111111111", DateOfBirth= new DateTime(1995, 8, 20) };

            gamerManager.Save(gamer);
            gamerManager.Delete(gamer);
            gamerManager.Update(gamer);

            GameManager gameManager = new GameManager();
            Game game = new Game() {Id=1 , GameName="DOOM",GamePrice=100,GameDescription= "Doom is a first-person shooter presented with early 3D graphics."};
            gameManager.Add(game);
            gameManager.Delete(game);
            gameManager.Update(game);


            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign = new Campaign() { Id = 1, CampaignName = "Doom campaign 1" ,CampaignDiscount=10};

            campaignManager.Add(campaign);
            campaignManager.Delete(campaign);
            campaignManager.Update(campaign);

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(gamer, game);
            saleManager.CampaignSale(game, gamer, campaign);
           
        }
    }
}
