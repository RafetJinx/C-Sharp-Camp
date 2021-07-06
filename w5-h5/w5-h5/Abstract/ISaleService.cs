using System;
using System.Collections.Generic;
using System.Text;
using w5_h5.Entities;

namespace w5_h5.Abstract
{
    public interface ISaleService
    {
        void MakeSell(Gamer gamer, Game game, Campaign campaign);
        void ShowAllSellDetails();
    }
}
