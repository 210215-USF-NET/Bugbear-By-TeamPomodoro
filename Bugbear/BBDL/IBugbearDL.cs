using BBModels;
using System;
using System.Collections.Generic;

namespace BBDL
{
    public interface IBugbearDL
    {
        public List<Campaign> GetCampaigns();
        public List<Character> GetCharacters();
        public List<Encounter> GetEncounters();
        public List<Item> GetItems();
        public List<Location> GetLocations();
        public List<Map> GetMap();
        public List<NPC> GetNPC();
        public List<Story> GetStories();
        public List<User> GetUsers();
        public Campaign AddCampaign(Campaign newCampaign);
        public Character AddCharacter(Character newCharacter);
        public Encounter AddEncounter(Encounter newEncounter);
        public Item AddItem(Item newItem);
        public Location AddLocation(Location newLocation);
        public Map AddMap(Map newMap);
        public NPC AddNPC(NPC newNPC);
        public Story AddStory(Story newStory);
        public User AddUser(User newUser);
        public Campaign DeleteCampaign(Campaign newCampaign);
        public Character DeleteCharacter(Character newCharacter);
        public Encounter DeleteEncounter(Encounter newEncounter);
        public Item DeleteItem(Item newItem);
        public Location DeleteLocation(Location newLocation);
        public Map DeleteMap(Map newMap);
        public NPC DeleteNPC(NPC newNPC);
        public Story DeleteStory(Story newStory);
        public User DeleteUser(User newUser);
    }
}
