using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Deleted to db :" + gamer.FirstName);
        }

        public void Save(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Saved to db :" + gamer.FirstName);
            }
            else
            {
                throw new Exception("Not valid a person");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Updated to db :" + gamer.FirstName);
        }
    }
}
