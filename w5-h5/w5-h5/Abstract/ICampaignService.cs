using System;
using System.Collections.Generic;
using System.Text;
using w5_h5.Entities;

namespace w5_h5.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
        void ShowAllCampaigns();
    }
}
