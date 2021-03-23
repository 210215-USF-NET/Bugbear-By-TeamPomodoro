using BBModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BBDL
{
    public interface IBugbearRepository
    {
        Task<Campaign> AddCampaignAsync(Campaign newCampaign);
        Task<Character> AddCharacterAsync(Character newCharacter);
        Task<Encounter> AddEncounterAsync(Encounter newEncounter);
        Task<Item> AddItemAsync(Item newItem);
        Task<Location> AddLocationAsync(Location newLocation);
        Task<Map> AddMapAsync(Map newMap);
        Task<NPC> AddNPCAsync(NPC newNPC);
        Task<Story> AddStoryAsync(Story newStory);
        Task<User> AddUserAsync(User newUser);
        Task<Campaign> DeleteCampaignAsync(Campaign newCampaign);
        Task<Character> DeleteCharacterAsync(Character newCharacter);
        Task<Encounter> DeleteEncounterAsync(Encounter newEncounter);
        Task<Item> DeleteItemAsync(Item newItem);
        Task<Location> DeleteLocationAsync(Location newLocation);
        Task<Map> DeleteMapAsync(Map newMap);
        Task<NPC> DeleteNPCAsync(NPC newNPC);
        Task<Story> DeleteStoryAsync(Story newStory);
        Task<User> DeleteUserAsync(User newUser);
        Task<List<Campaign>> GetCampaignsAsync();
        Task<List<Character>> GetCharactersAsync();
        Task<List<Encounter>> GetEncountersAsync();
        Task<List<Item>> GetItemsAsync();
        Task<List<Location>> GetLocationsAsync();
        Task<List<Map>> GetMapAsync();
        Task<List<NPC>> GetNPCAsync();
        Task<List<Story>> GetStoriesAsync();
        Task<List<User>> GetUsersAsync();
    }
}