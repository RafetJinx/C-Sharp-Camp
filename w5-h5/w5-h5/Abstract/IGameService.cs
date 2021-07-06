using System;
using System.Collections.Generic;
using System.Text;
using w5_h5.Entities;

namespace w5_h5.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
        void ShowAllGames();
    }
}
