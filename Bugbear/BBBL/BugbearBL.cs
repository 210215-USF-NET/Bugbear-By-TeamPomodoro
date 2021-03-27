using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using BBDL;
using BBModels;


namespace BBBL
{
    [ExcludeFromCodeCoverage]
    public class BugbearBL : IBugbearBL
    {
        private readonly IBugbearRepository _repo;
        public BugbearBL(IBugbearRepository repo)
        {
            _repo = repo;
        }
        public async Task<Campaign> AddCampaignAsync(Campaign newCampaign)
        {
            return await _repo.AddCampaignAsync(newCampaign);
        }

        public async Task<Character> AddCharacterAsync(Character newCharacter)
        {
            return await _repo.AddCharacterAsync(newCharacter);
        }

        public async Task<Encounter> AddEncounterAsync(Encounter newEncounter)
        {
            return await _repo.AddEncounterAsync(newEncounter);
        }

        public async Task<Item> AddItemAsync(Item newItem)
        {
            return await _repo.AddItemAsync(newItem);
        }

        public async Task<Location> AddLocationAsync(Location newLocation)
        {
            return await _repo.AddLocationAsync(newLocation);
        }

        public async Task<Map> AddMapAsync(Map newMap)
        {
            return await _repo.AddMapAsync(newMap);
        }

        public async Task<NPC> AddNPCAsync(NPC newNPC)
        {
            return await _repo.AddNPCAsync(newNPC);
        }

        public async Task<Story> AddStoryAsync(Story newStory)
        {
            return await _repo.AddStoryAsync(newStory);
        }

        public async Task<User> AddUserAsync(User newUser)
        {
            return await _repo.AddUserAsync(newUser);
        }



        public async Task<Campaign> DeleteCampaignAsync(Campaign newCampaign)
        {
            return await _repo.DeleteCampaignAsync(newCampaign);
        }

        public async Task<Character> DeleteCharacterAsync(Character newCharacter)
        {
            return await _repo.DeleteCharacterAsync(newCharacter);
        }

        public async Task<Encounter> DeleteEncounterAsync(Encounter newEncounter)
        {
            return await _repo.DeleteEncounterAsync(newEncounter);
        }

        public async Task<Item> DeleteItemAsync(Item newItem)
        {
            return await _repo.DeleteItemAsync(newItem);
        }

        public async Task<Location> DeleteLocationAsync(Location newLocation)
        {
            return await _repo.DeleteLocationAsync(newLocation);
        }

        public async Task<Map> DeleteMapAsync(Map newMap)
        {
            return await _repo.DeleteMapAsync(newMap);
        }

        public async Task<NPC> DeleteNPCAsync(NPC newNPC)
        {
            return await _repo.DeleteNPCAsync(newNPC);
        }

        public async Task<Story> DeleteStoryAsync(Story newStory)
        {
            return await _repo.DeleteStoryAsync(newStory);
        }

        public async Task<User> DeleteUserAsync(User newUser)
        {
            return await _repo.DeleteUserAsync(newUser);
        }



        public async Task<List<Campaign>> GetCampaignsAsync()
        {
            return await _repo.GetCampaignsAsync();
        }
        public async Task<Campaign> GetCampaignByIDAsync(int id)
        {
            return await _repo.GetCampaignByIDAsync(id);
        }
        public async Task<Campaign> GetCampaignByNameAsync(string name) {
            return await _repo.GetCampaignByNameAsync(name);
        }

        public async Task<List<Character>> GetCharactersAsync()
        {
            return await _repo.GetCharactersAsync();
        }
        public async Task<Character> GetCharacterByNameAsync(string name)
        {
            return await _repo.GetCharacterByNameAsync(name);
        }

        public async Task<List<Encounter>> GetEncountersAsync()
        {
            return await _repo.GetEncountersAsync();
        }
        public async Task<Encounter> GetEncounterByIDAsync(int id)
        {
            return await _repo.GetEncounterByIDAsync(id);
        }

        public async Task<List<Item>> GetItemsAsync()
        {
            return await _repo.GetItemsAsync();
        }
        public async Task<Item> GetItemByNameAsync(string name)
        {
            return await _repo.GetItemByNameAsync(name);
        }

        public async Task<List<Location>> GetLocationsAsync()
        {
            return await _repo.GetLocationsAsync();
        }
        public async Task<Location> GetLocationByNameAsync(string name)
        {
            return await _repo.GetLocationByNameAsync(name);
        }

        public async Task<List<Map>> GetMapAsync()
        {
            return await _repo.GetMapAsync();
        }
        public async Task<Map> GetMapByTitleAsync(string title)
        {
            return await _repo.GetMapByTitleAsync(title);
        }

        public async Task<List<NPC>> GetNPCAsync()
        {
            return await _repo.GetNPCAsync();
        }
        public async Task<NPC> GetNPCByIDAsync(int id)
        {
            return await _repo.GetNPCByIDAsync(id);
        }
        public async Task<NPC> GetNPCByNameAsync(string name)
        {
            return await _repo.GetNPCByNameAsync(name);
        }

        public async Task<List<Story>> GetStoriesAsync()
        {
            return await _repo.GetStoriesAsync();
        }
        public async Task<Story> GetStoryByIDAsync(int storyID)
        {
            return await _repo.GetStoryByIDAsync(storyID);
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _repo.GetUsersAsync();
        }
        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _repo.GetUserByEmailAsync(email);
        }



        public async Task<Campaign> UpdateCampaignAsync(Campaign campaignToBeUpdated)
        {
            return await _repo.UpdateCampaignAsync(campaignToBeUpdated);
        }
        public async Task<Character> UpdateCharacterAsync(Character characterToBeUpdated)
        {
            return await _repo.UpdateCharacterAsync(characterToBeUpdated);
        }
        public async Task<Encounter> UpdateEncounterAsync(Encounter encounterToBeUpdated)
        {
            return await _repo.UpdateEncounterAsync(encounterToBeUpdated);
        }

        public async Task<Item> UpdateItemAsync(Item itemToBeUpdated)
        {
            return await _repo.UpdateItemAsync(itemToBeUpdated);
        }

        public async Task<Location> UpdateLocationAsync(Location locationToBeUpdated)
        {
            return await _repo.UpdateLocationAsync(locationToBeUpdated);
        }

        public async Task<Map> UpdateMapAsync(Map mapToBeUpdated)
        {
            return await _repo.UpdateMapAsync(mapToBeUpdated);
        }

        public async Task<NPC> UpdateNPCAsync(NPC npcToBeUpdated)
        {
            return await _repo.UpdateNPCAsync(npcToBeUpdated);
        }
        public async Task<Story> UpdateStoryAsync(Story storyToBeUpdated)
        {
            return await _repo.UpdateStoryAsync(storyToBeUpdated);
        }

        public async Task<User> UpdateUserAsync(User userToBeUpdated)
        {
            return await _repo.UpdateUserAsync(userToBeUpdated);
        }
    }
}
