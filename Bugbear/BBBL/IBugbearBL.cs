using BBModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BBBL
{
    public interface IBugbearBL
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
        Task<Chat> AddChatAsync(Chat newChat);


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
        Task<Campaign> GetCampaignByIDAsync(int id);
        Task<Campaign> GetCampaignByNameAsync(string name);
        Task<List<Character>> GetCharactersAsync();
        Task<Character> GetCharacterByNameAsync(string name);
        Task<Character> GetCharacterByIDAsync(int id);
        Task<List<Encounter>> GetEncountersAsync();
        Task<Encounter> GetEncounterByIDAsync(int id);
        Task<List<Item>> GetItemsAsync();
        Task<Item> GetItemByNameAsync(string name);
        Task<List<Location>> GetLocationsAsync();
        Task<Location> GetLocationByNameAsync(string name);
        Task<List<Map>> GetMapAsync();
        Task<Map> GetMapByTitleAsync(string title);
        Task<List<NPC>> GetNPCAsync();
        Task<NPC> GetNPCByIDAsync(int id);
        Task<NPC> GetNPCByNameAsync(string name);
        Task<List<Story>> GetStoriesAsync();
        Task<Story> GetStoryByIDAsync(int storyID);
        Task<List<User>> GetUsersAsync();
        Task<User> GetUserByEmailAsync(string email);



        Task<Campaign> UpdateCampaignAsync(Campaign campaignToBeUpdated);
        Task<Character> UpdateCharacterAsync(Character characterToBeUpdated);
        Task<Encounter> UpdateEncounterAsync(Encounter encounterToBeUpdated);
        Task<Item> UpdateItemAsync(Item itemToBeUpdated);
        Task<Location> UpdateLocationAsync(Location locationToBeUpdated);
        Task<Map> UpdateMapAsync(Map mapToBeUpdated);
        Task<NPC> UpdateNPCAsync(NPC npcToBeUpdated);
        Task<Story> UpdateStoryAsync(Story storyToBeUpdated);
        Task<User> UpdateUserAsync(User userToBeUpdated);
    }
}