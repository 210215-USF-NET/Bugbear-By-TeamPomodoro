using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBModels
{
    public class Campaign
    {
        public int CampaignID { get; set; }
        public string CampaignName { get; set; }
        public string Description { get; set; }
        public int GameMasterID { get; set; }
        public List<User> CampaignUsers { get; set; }
    }
}
