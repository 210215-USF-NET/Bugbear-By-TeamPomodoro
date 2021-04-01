using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBModels
{
    public class Encounter
    {
        public int EncounterID { get; set; }
        public string EncounterTitle { get; set; }
        public string EncounterDescription { get; set; }
        public Location Location { get; set; }
        public int CampaignID { get; set; }
    }
}
