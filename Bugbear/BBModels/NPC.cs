using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBModels
{
    public class NPC
    {
        public int NPCID { get; set; }
        public string NPCName { get; set; }
        public string NPCDescription { get; set; }
        public int CampaignID { get; set; }

        //=================================
        public int HP { get; set; }
        public int XPLevel { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

    }
}
