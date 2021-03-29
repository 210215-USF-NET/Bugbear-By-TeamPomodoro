using BBModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDL
{
    public class BugbearRepoDB : IBugbearRepository
    {
        private readonly BugbearDBContext _context;
        public BugbearRepoDB(BugbearDBContext context)
        {
            _context = context;
        }
        public async Task<Campaign> AddCampaignAsync(Campaign newCampaign)
        {
            await _context.Campaigns.AddAsync(newCampaign);
            await _context.SaveChangesAsync();
            return newCampaign;
        }

        public async Task<Character> AddCharacterAsync(Character newCharacter)
        {
            await _context.Characters.AddAsync(newCharacter);
            await _context.SaveChangesAsync();
            return newCharacter;
        }

        public async Task<Encounter> AddEncounterAsync(Encounter newEncounter)
        {
            // We will also need to figure out how to save encounter data if we want to make it the interactive map.
            // Maybe just display the map data and have the implementation Jacob make with the map thing.
            await _context.Encounters.AddAsync(newEncounter);
            await _context.SaveChangesAsync();
            return newEncounter;
        }

        public async Task<Item> AddItemAsync(Item newItem)
        {
            await _context.Items.AddAsync(newItem);
            await _context.SaveChangesAsync();
            return newItem;
        }

        public async Task<Location> AddLocationAsync(Location newLocation)
        {
            await _context.Locations.AddAsync(newLocation);
            await _context.SaveChangesAsync();
            return newLocation;
        }

        public async Task<Map> AddMapAsync(Map newMap)
        {
            // Probably need to adjust this one because maps are more complex than just standard data. 
            // Look into how we want to save image data in the database.
            // Maybe map data is just a stream of Bytes and we save that as our data structure.
            await _context.Maps.AddAsync(newMap);
            await _context.SaveChangesAsync();
            return newMap;
        }

        public async Task<NPC> AddNPCAsync(NPC newNPC)
        {
            await _context.NPCs.AddAsync(newNPC);
            await _context.SaveChangesAsync();
            return newNPC;
        }

        public async Task<Story> AddStoryAsync(Story newStory)
        {
            await _context.Stories.AddAsync(newStory);
            await _context.SaveChangesAsync();
            return newStory;
        }

        public async Task<User> AddUserAsync(User newUser)
        {
            await _context.Users.AddAsync(newUser);
            await _context.SaveChangesAsync();
            return newUser;
        }

        public async Task<Campaign> DeleteCampaignAsync(Campaign newCampaign)
        {
            // We should probably rename all these to something like campaign to delete or dCampaign or somthing like that.
            _context.Campaigns.Remove(newCampaign);
            await _context.SaveChangesAsync();
            return newCampaign;
        }

        public async Task<Character> DeleteCharacterAsync(Character newCharacter)
        {
            _context.Characters.Remove(newCharacter);
            await _context.SaveChangesAsync();
            return newCharacter;
        }

        public async Task<Encounter> DeleteEncounterAsync(Encounter newEncounter)
        {
            _context.Encounters.Remove(newEncounter);
            await _context.SaveChangesAsync();
            return newEncounter;
        }

        public async Task<Item> DeleteItemAsync(Item newItem)
        {
            _context.Items.Remove(newItem);
            await _context.SaveChangesAsync();
            return newItem;
        }

        public async Task<Location> DeleteLocationAsync(Location newLocation)
        {
            _context.Locations.Remove(newLocation);
            await _context.SaveChangesAsync();
            return newLocation;
        }

        public async Task<Map> DeleteMapAsync(Map newMap)
        {
            _context.Maps.Remove(newMap);
            await _context.SaveChangesAsync();
            return newMap;
        }

        public async Task<NPC> DeleteNPCAsync(NPC newNPC)
        {
            _context.NPCs.Remove(newNPC);
            await _context.SaveChangesAsync();
            return newNPC;
        }

        public async Task<Story> DeleteStoryAsync(Story newStory)
        {
            _context.Stories.Remove(newStory);
            await _context.SaveChangesAsync();
            return newStory;
        }

        public async Task<User> DeleteUserAsync(User newUser)
        {
            _context.Users.Remove(newUser);
            await _context.SaveChangesAsync();
            return newUser;
        }

        /// <summary>
        /// For all these Get methods we should pass in an argument so that we know who we are getting this information for
        /// currently we get all the information from our database.
        /// </summary>
        /// <returns></returns>

        public async Task<List<Campaign>> GetCampaignsAsync()
        {
            // I think we should have an argument to get the campagin a certain user is associated with. So GetCampaigns(User user){}
            // This should return all campaign in our database.
            return await _context.Campaigns
                .Include(campaign => campaign.CampaignUsers)
                .Select(c => c).ToListAsync();
        }
        public async Task<Campaign> GetCampaignByIDAsync(int id)
        {
            //returns a Campaign given said campaign's ID
            return await _context.Campaigns.FirstOrDefaultAsync(c => c.CampaignID == id);
        }
        public async Task<Campaign> GetCampaignByNameAsync(string name)
        {
            //returns a Campaign given said Campaign's Name
            return await _context.Campaigns.FirstOrDefaultAsync(c => c.CampaignName.Equals(name));
        }

        public async Task<List<Character>> GetCharactersAsync()
        {
            // This should return all characters in our database.
            return await _context.Characters.Select(Character => Character).ToListAsync();
        }
        public async Task<Character> GetCharacterByNameAsync(string name)
        {
            return await _context.Characters.FirstOrDefaultAsync(character => character.CharacterName == name);
        }

        public async Task<Character> GetCharacterByID(int id)
        {
            return await _context.Characters.FirstOrDefaultAsync(character => character.CharacterID == id);
        }

        public async Task<List<Encounter>> GetEncountersAsync()
        {
            // This should return all Encounters in our database.
            return await _context.Encounters.Select(e => e).ToListAsync();
        }
        public async Task<Encounter> GetEncounterByIDAsync(int id)
        {
            //returns the proper Encounter from the database, given said Encounter's ID
            return await _context.Encounters.FirstOrDefaultAsync(e => e.EncounterID == id);
        }

        public async Task<List<Item>> GetItemsAsync()
        {
            // This should get all Items in our database.
            return await _context.Items.Select(i => i).ToListAsync();
        }
        public async Task<Item> GetItemByNameAsync(string name)
        {
            //returns the proper Item from the database, given said Item's name
            return await _context.Items.FirstOrDefaultAsync(i => i.ItemName.Equals(name));
        }

        public async Task<List<Location>> GetLocationsAsync()
        {
            // This should get all Locations in our database.
            return await _context.Locations.Select(l => l).ToListAsync();
        }
        public async Task<Location> GetLocationByNameAsync(string name)
        {
            // returns the proper Location from the database, given said Location's name
            return await _context.Locations.FirstOrDefaultAsync(l => l.LocationName.Equals(name));
        }

        public async Task<List<Map>> GetMapAsync()
        {
            // This should get all Map in our database.
            return await _context.Maps.Select(i => i).ToListAsync();
        }
        public async Task<Map> GetMapByTitleAsync(string title)
        {
            // returns the proper Map from the database, given said Map's name
            return await _context.Maps.FirstOrDefaultAsync(m => m.MapTitle.Equals(title));
        }

        public async Task<List<NPC>> GetNPCAsync()
        {
            // This should get all Npcs in our database.
            return await _context.NPCs.Select(n => n).ToListAsync();
        }
        public async Task<NPC> GetNPCByIDAsync(int id)
        {
            // This method returns the proper NPC from our database, given said NPC's id
            return await _context.NPCs.FirstOrDefaultAsync(n => n.NPCID == id);
        }
        public async Task<NPC> GetNPCByNameAsync(string name)
        {
            // This method returns the proper NPC from our database, given said NPC's name
            return await _context.NPCs.FirstOrDefaultAsync(n => n.NPCName.Equals(name));
        }

        public async Task<List<Story>> GetStoriesAsync()
        {
            // This should get all Storys in our database.
            return await _context.Stories.Select(s => s).ToListAsync();
        }

        public async Task<Story> GetStoryByIDAsync(int storyID)
        {
            //This should get a single story, identified by the story ID.
            return await _context.Stories.FirstOrDefaultAsync(s => s.StoryID == storyID);
        }

        public async Task<List<User>> GetUsersAsync()
        {
            // This should get all Users in our database.
            return await _context.Users.Select(u => u).ToListAsync();
        }
        public async Task<User> GetUserByEmailAsync(string email)
        {
            // This should get a certain User by email in our database.
            return await _context.Users.FirstOrDefaultAsync(user => user.Email == email);
        }

        public async Task<Campaign> UpdateCampaignAsync(Campaign campaignToBeUpdated)
        {
            Campaign oldCampaign = await _context.Campaigns.FindAsync(campaignToBeUpdated.CampaignID);
            _context.Entry(oldCampaign).CurrentValues.SetValues(campaignToBeUpdated);

            await _context.SaveChangesAsync();

            _context.ChangeTracker.Clear();
            return campaignToBeUpdated;
        }

        public async Task<Character> UpdateCharacterAsync(Character characterToBeUpdated)
        {
            Character oldCharacter = await _context.Characters.FindAsync(characterToBeUpdated.CharacterID);
            _context.Entry(oldCharacter).CurrentValues.SetValues(characterToBeUpdated);

            await _context.SaveChangesAsync();

            _context.ChangeTracker.Clear();
            return characterToBeUpdated;
        }

        public async Task<Encounter> UpdateEncounterAsync(Encounter encounterToBeUpdated)
        {
            Encounter oldEncounter = await _context.Encounters.FindAsync(encounterToBeUpdated.EncounterID);
            _context.Entry(oldEncounter).CurrentValues.SetValues(encounterToBeUpdated);

            await _context.SaveChangesAsync();

            _context.ChangeTracker.Clear();
            return encounterToBeUpdated;
        }

        public async Task<Item> UpdateItemAsync(Item itemToBeUpdated)
        {
            Item oldItem = await _context.Items.FindAsync(itemToBeUpdated.ItemID);
            _context.Entry(oldItem).CurrentValues.SetValues(itemToBeUpdated);

            await _context.SaveChangesAsync();

            _context.ChangeTracker.Clear();
            return itemToBeUpdated;
        }

        public async Task<Location> UpdateLocationAsync(Location locationToBeUpdated)
        {
            Location oldLocation = await _context.Locations.FindAsync(locationToBeUpdated.LocationID);
            _context.Entry(oldLocation).CurrentValues.SetValues(locationToBeUpdated);

            await _context.SaveChangesAsync();

            _context.ChangeTracker.Clear();
            return locationToBeUpdated;
        }

        public async Task<Map> UpdateMapAsync(Map mapToBeUpdated)
        {
            Map oldMap = await _context.Maps.FindAsync(mapToBeUpdated.MapID);
            _context.Entry(oldMap).CurrentValues.SetValues(mapToBeUpdated);

            await _context.SaveChangesAsync();

            _context.ChangeTracker.Clear();
            return mapToBeUpdated;
        }

        public async Task<NPC> UpdateNPCAsync(NPC npcToBeUpdated)
        {
            NPC oldNPC = await _context.NPCs.FindAsync(npcToBeUpdated.NPCID);
            _context.Entry(oldNPC).CurrentValues.SetValues(npcToBeUpdated);

            await _context.SaveChangesAsync();

            _context.ChangeTracker.Clear();
            return npcToBeUpdated;
        }

        public async Task<Story> UpdateStoryAsync(Story storyToBeUpdated)
        {
            Story oldStory = await _context.Stories.FindAsync(storyToBeUpdated.StoryID);
            _context.Entry(oldStory).CurrentValues.SetValues(storyToBeUpdated);

            await _context.SaveChangesAsync();

            _context.ChangeTracker.Clear();
            return storyToBeUpdated;
        }

        public async Task<User> UpdateUserAsync(User userToBeUpdated)
        {
            User oldUser = await _context.Users.FindAsync(userToBeUpdated.UserID);
            _context.Entry(oldUser).CurrentValues.SetValues(userToBeUpdated);

            await _context.SaveChangesAsync();

            _context.ChangeTracker.Clear();
            return userToBeUpdated;
        }

        public async Task<List<Character>> GetCharactersByUserIDAsync(int userID)
        {
            return await _context.Characters.AsNoTracking().Where(character => character.UserID == userID).ToListAsync();
        }
    }
}
