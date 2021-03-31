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
        public List<Character> CampaignCharacters { get; set; }
        public List<Encounter> CampaignEncounters { get; set; }
        public List<Location> CampaignLocations { get; set; }
        public List<Map> CampaignMaps { get; set; }
        public List<NPC> CampaignNPCs { get; set; }
        public List<Story> CampaignStories { get; set; }
        public List<Chat> CampaignChats { get; set; }
    }
}