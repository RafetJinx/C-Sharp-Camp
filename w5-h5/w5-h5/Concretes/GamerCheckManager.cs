using System;
using System.Collections.Generic;
using System.Text;
using w5_h5.Abstract;
using w5_h5.Entities;

namespace w5_h5.Concretes
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
