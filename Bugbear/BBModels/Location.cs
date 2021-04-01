using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBModels
{
    public class Location
    {
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public string LocationDescription {get; set;}
        public int CampaignID { get; set; }
    }
}
