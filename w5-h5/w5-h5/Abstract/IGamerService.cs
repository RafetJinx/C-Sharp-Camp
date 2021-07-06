using System;
using System.Collections.Generic;
using System.Text;
using w5_h5.Entities;

namespace w5_h5.Abstract
{
    public interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
        void ShowGamers();
    }
}
