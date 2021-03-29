using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        [NotMapped]
        public List<int> CampaignUsers { get; set; }
    }
}
