using System;
using System.Collections.Generic;
using BBDL;
using BBModels;

namespace BBBL
{
    public class BugbearBL : IBugbearBL
    {
        private readonly IBugbearDL _repo;
        public BugbearBL(IBugbearDL repo)
        {
            _repo = repo;
        }
        public Campaign AddCampaign(Campaign newCampaign)
        {
            return _repo.AddCampaign(newCampaign);
        }

        public Character AddCharacter(Character newCharacter)
        {
            return _repo.AddCharacter(newCharacter);
        }

        public Encounter AddEncounter(Encounter newEncounter)
        {
            return _repo.AddEncounter(newEncounter);
        }

        public Item AddItem(Item newItem)
        {
            return _repo.AddItem(newItem);
        }

        public Location AddLocation(Location newLocation)
        {
            return _repo.AddLocation(newLocation);
        }

        public Map AddMap(Map newMap)
        {
            return _repo.AddMap(newMap);
        }

        public NPC AddNPC(NPC newNPC)
        {
            return _repo.AddNPC(newNPC);
        }

        public Story AddStory(Story newStory)
        {
            return _repo.AddStory(newStory);
        }

        public User AddUser(User newUser)
        {
            return _repo.AddUser(newUser);
        }

        public Campaign DeleteCampaign(Campaign newCampaign)
        {
            return _repo.DeleteCampaign(newCampaign);
        }

        public Character DeleteCharacter(Character newCharacter)
        {
            return _repo.DeleteCharacter(newCharacter);
        }

        public Encounter DeleteEncounter(Encounter newEncounter)
        {
            return _repo.DeleteEncounter(newEncounter);
        }

        public Item DeleteItem(Item newItem)
        {
            return _repo.DeleteItem(newItem);
        }

        public Location DeleteLocation(Location newLocation)
        {
            return _repo.DeleteLocation(newLocation);
        }

        public Map DeleteMap(Map newMap)
        {
            return _repo.DeleteMap(newMap);
        }

        public NPC DeleteNPC(NPC newNPC)
        {
            return _repo.DeleteNPC(newNPC);
        }

        public Story DeleteStory(Story newStory)
        {
            return _repo.DeleteStory(newStory);
        }

        public User DeleteUser(User newUser)
        {
            return _repo.DeleteUser(newUser);
        }

        public List<Campaign> GetCampaigns()
        {
            return _repo.GetCampaigns();
        }

        public List<Character> GetCharacters()
        {
            return _repo.GetCharacters();
        }

        public List<Encounter> GetEncounters()
        {
            return _repo.GetEncounters();
        }

        public List<Item> GetItems()
        {
            return _repo.GetItems();
        }

        public List<Location> GetLocations()
        {
            return _repo.GetLocations();
        }

        public List<Map> GetMap()
        {
            return _repo.GetMap();
        }

        public List<NPC> GetNPC()
        {
            return _repo.GetNPC();
        }

        public List<Story> GetStories()
        {
            return _repo.GetStories();
        }

        public List<User> GetUsers()
        {
            return _repo.GetUsers();
        }
    }
}
