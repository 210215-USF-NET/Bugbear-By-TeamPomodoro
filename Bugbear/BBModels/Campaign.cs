using System.Collections.Generic;

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