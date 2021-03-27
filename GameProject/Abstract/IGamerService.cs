using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IGamerService
    {
        void Save(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);
    }
}
