using BBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDL
{
    public class BugbearRepoDB : IBugbearDL
    {
        private readonly BugbearDBContext _context;
        public BugbearRepoDB (BugbearDBContext context)
        {
             _context = context;
        }
        public Campaign AddCampaign(Campaign newCampaign)
        {
            //_context.Campaign.Add(newCampaign);
            //_context.SaveChanges();
            //return newCampaign;
            throw new NotImplementedException();
        }

        public Character AddCharacter(Character newCharacter)
        {
            // _context.Character.Add(newCharacter);
            // _context.SaveChanges();
            // return newCharacter;
            throw new NotImplementedException();
        }

        public Encounter AddEncounter(Encounter newEncounter)
        {
            // We will also need to figure out how to save encounter data if we want to make it the interactive map.
            // Maybe just display the map data and have the implementation Jacob make with the map thing.
            // _context.Encounter.Add(newEncounter);
            // _context.SaveChanges();
            // return newEncounter;
            throw new NotImplementedException();
        }

        public Item AddItem(Item newItem)
        {
            // _context.Item.Add(newItem);
            // _context.SaveChanges();
            // return newItem;
            throw new NotImplementedException();
        }

        public Location AddLocation(Location newLocation)
        {
            // _context.Location.Add(newLocation);
            // _context.SaveChanges();
            // return newLocation;
            throw new NotImplementedException();
        }

        public Map AddMap(Map newMap)
        {
            // Probably need to adjust this one because maps are more complex than just standard data. 
            // Look into how we want to save image data in the database.
            // Maybe map data is just a stream of Bytes and we save that as our data structure.
            // _context.Map.Add(newMap);
            // _context.SaveChanges();
            // return newMap;
            throw new NotImplementedException();
        }

        public NPC AddNPC(NPC newNPC)
        {
            // _context.NPC.Add(newNPC);
            // _context.SaveChanges();
            // return newNPC;
            throw new NotImplementedException();
        }

        public Story AddStory(Story newStory)
        {
            // _context.Story.Add(newStory);
            // _context.SaveChanges();
            // return newStory;
            throw new NotImplementedException();
        }

        public User AddUser(User newUser)
        {
            // _context.User.Add(newUser);
            // _context.SaveChanges();
            // return newUser;
            throw new NotImplementedException();
        }

        public Campaign DeleteCampaign(Campaign newCampaign)
        {
            // We should probably rename all these to something like campaign to delete or dCampaign or somthing like that.
            // _context.Campaign.Remove(newCampaign);
            // _context.SaveChanges();
            // return newCampaign;
            throw new NotImplementedException();
        }

        public Character DeleteCharacter(Character newCharacter)
        {
            // _context.Character.Remove(newCharacter);
            // _context.SaveChanges();
            // return newCharacter;
            throw new NotImplementedException();
        }

        public Encounter DeleteEncounter(Encounter newEncounter)
        {
            // _context.Encounter.Remove(newEncounter);
            // _context.SaveChanges();
            // return newEncounter;
            throw new NotImplementedException();
        }

        public Item DeleteItem(Item newItem)
        {
            // _context.Item.Remove(newItem);
            // _context.SaveChanges();
            // return newItem;
            throw new NotImplementedException();
        }

        public Location DeleteLocation(Location newLocation)
        {
            // _context.Location.Remove(newLocation);
            // _context.SaveChanges();
            // return newLocation;
            throw new NotImplementedException();
        }

        public Map DeleteMap(Map newMap)
        {
            // _context.Map.Remove(newMap);
            // _context.SaveChanges();
            // return newMap;
            throw new NotImplementedException();
        }

        public NPC DeleteNPC(NPC newNPC)
        {
            // _context.NPC.Remove(newNPC);
            // _context.SaveChanges();
            // return newDeleteNPC;
            throw new NotImplementedException();
        }

        public Story DeleteStory(Story newStory)
        {
            // _context.Story.Remove(newStory);
            // _context.SaveChanges();
            // return newStory;
            throw new NotImplementedException();
        }

        public User DeleteUser(User newUser)
        {
            // _context.User.Remove(newUser);
            // _context.SaveChanges();
            // return newUser;
            throw new NotImplementedException();
        }

        /// <summary>
        /// For all these Get methods we should pass in an arugment so that we know who we are getting this information for
        /// currently we get all the information from our database.
        /// </summary>
        /// <returns></returns>

        public List<Campaign> GetCampaigns()
    {
            // I think we should have an argument to get the campagin a certain user is associated with. So GetCampaigns(User user){}
            // This should return all campaign in our database.
            // List<Campaign> allCampaigns = _context.Campaign.Select(c => c).ToList();
            // return allCampaigns;
            throw new NotImplementedException();
        }

        public List<Character> GetCharacters()
        {
            // This should return all characters in our database.
            // List<Character> allCharacters = _context.Character.Select(c => c).ToList();
            // return allCharacters;
            throw new NotImplementedException();
        }

        public List<Encounter> GetEncounters()
        {
            // This should return all Encounters in our database.
            // List<Encounter> allEncounters = _context.Encounter.Select(e => e).ToList();
            // return allEncounters;
            throw new NotImplementedException();
        }

        public List<Item> GetItems()
        {
            // This should get all Items in our database.
            // List<Item> allItems = _context.Item.Select(i => i).ToList();
            // return allItems;
            throw new NotImplementedException();
        }

        public List<Location> GetLocations()
        {
            // This should get all Locations in our database.
            // List<Location> allLocations = _context.Location.Select(l => l).ToList();
            // return allLocations;
            throw new NotImplementedException();
        }

        public List<Map> GetMap()
        {
            // This should get all Map in our database.
            // List<Map> allMaps = _context.Map.Select(i => i).ToList();
            // return allMaps;
            throw new NotImplementedException();
        }

        public List<NPC> GetNPC()
        {
            // This should get all Npcs in our database.
            // List<NPC> allNPCs = _context.NPC.Select(n => n).ToList();
            // return allNPCs;
            throw new NotImplementedException();
        }

        public List<Story> GetStories()
        {
            // This should get all Storys in our database.
            // List<Story> allStorys = _context.Story.Select(s => s).ToList();
            // return allStorys;
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            // This should get all Users in our database.
            // List<User> allUsers = _context.User.Select(u => u).ToList();
            // return allUsers;
            throw new NotImplementedException();
        }
    }
}
