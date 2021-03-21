using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBModels
{
    public class Map
    {
        public int MapID { get; set; }
        public string MapTitle { get; set; }
        public string MapImage { get; set; } //temporarily making this a string until we figure out how to store images
        public int CampaignID { get; set; }
    }
}
