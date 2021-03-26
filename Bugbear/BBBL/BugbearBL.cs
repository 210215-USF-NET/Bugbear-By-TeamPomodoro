using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BBDL;
using BBModels;

namespace BBBL
{
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

        public async Task<List<Character>> GetCharactersAsync()
        {
            return await _repo.GetCharactersAsync();
        }

        public async Task<List<Encounter>> GetEncountersAsync()
        {
            return await _repo.GetEncountersAsync();
        }

        public async Task<List<Item>> GetItemsAsync()
        {
            return await _repo.GetItemsAsync();
        }

        public async Task<List<Location>> GetLocationsAsync()
        {
            return await _repo.GetLocationsAsync();
        }

        public async Task<List<Map>> GetMapAsync()
        {
            return await _repo.GetMapAsync();
        }

        public async Task<List<NPC>> GetNPCAsync()
        {
            return await _repo.GetNPCAsync();
        }

        public async Task<List<Story>> GetStoriesAsync()
        {
            return await _repo.GetStoriesAsync();
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _repo.GetUsersAsync();
        }
        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _repo.GetUserByEmailAsync(email);
        }
    }
}
