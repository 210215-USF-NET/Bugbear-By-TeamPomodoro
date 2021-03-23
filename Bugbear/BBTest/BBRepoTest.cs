using BBDL;
using BBModels;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace BBTest
{
    public class BBRepoTest
    {
        private readonly DbContextOptions<BugbearDBContext> options;

        public BBRepoTest()
        {
            options = new DbContextOptionsBuilder<BugbearDBContext>()
                .UseSqlite("Filename=Test.db")
                .Options;
            Seed();
        }

        [Fact]
        public void GetCampaignsShouldReturnAllCampaigns()
        {
            using (var context = new BugbearDBContext(options))
            {
                //Arrange
                IBugbearRepository _repo = new BugbearRepoDB(context);

                //Act
                var campaigns = _repo.GetCampaignsAsync();

                //Assert
                Assert.NotNull(campaigns);
                Assert.Equal(2, campaigns.Result.Count);
            }
        }

        [Fact]
        public void GetCharactersShouldReturnAllCharacters()
        {
            using (var context = new BugbearDBContext(options))
            {
                //Arrange
                IBugbearRepository _repo = new BugbearRepoDB(context);

                //Act
                var characters = _repo.GetCharactersAsync();

                //Assert
                Assert.NotNull(characters);
                Assert.Equal(6, characters.Result.Count);
            }
        }

        [Fact] 
        public void GetEncountersShouldReturnAllEncounters()
        {
            using (var context = new BugbearDBContext(options))
            {
                //Arrange
                IBugbearRepository _repo = new BugbearRepoDB(context);

                //Act
                var encounters = _repo.GetEncountersAsync();

                //Assert
                Assert.NotNull(encounters);
                Assert.Equal(2, encounters.Result.Count);
            }
        }

        [Fact]
        public void GetItemsShouldReturnAllItems()
        {
            using (var context = new BugbearDBContext(options))
            {
                //Arrange
                IBugbearRepository _repo = new BugbearRepoDB(context);

                //Act
                var items = _repo.GetItemsAsync();

                //Assert
                Assert.NotNull(items);
                Assert.Equal(2, items.Result.Count);
            }
        }

        [Fact]
        public void GetLocationsShouldReturnAllLocations()
        {
            using (var context = new BugbearDBContext(options))
            {
                //Arrange
                IBugbearRepository _repo = new BugbearRepoDB(context);

                //Act
                var locations = _repo.GetLocationsAsync();

                //Assert
                Assert.NotNull(locations);
                Assert.Equal(2, locations.Result.Count);
            }
        }
        [Fact]
        public void GetNPCsShouldReturnAllNPCs()
        {
            using (var context = new BugbearDBContext(options))
            {
                //Arrange
                IBugbearRepository _repo = new BugbearRepoDB(context);

                //Act
                var npcs = _repo.GetNPCAsync();

                //Assert
                Assert.NotNull(npcs);
                Assert.Equal(2, npcs.Result.Count);
            }
        }

        [Fact]
        public void GetStoriesShouldReturnAllStories()
        {
            using (var context = new BugbearDBContext(options))
            {
                //Arrange
                IBugbearRepository _repo = new BugbearRepoDB(context);

                //Act
                var stories = _repo.GetStoriesAsync();

                //Assert
                Assert.NotNull(stories);
                Assert.Equal(2, stories.Result.Count);
            }
        }

        [Fact]
        public void GetUsersShouldReturnAllUsers()
        {
            using (var context = new BugbearDBContext(options))
            {
                //Arrange
                IBugbearRepository _repo = new BugbearRepoDB(context);

                //Act
                var users = _repo.GetUsersAsync();

                //Assert
                Assert.NotNull(users);
                Assert.Equal(4, users.Result.Count);
            }
        }

        private void Seed()
        {
            using (var context = new BugbearDBContext(options))
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                context.Campaigns.AddRange(
                    new Campaign
                    {
                        CampaignID = 1,
                        CampaignName = "Balance",
                        Description = "Three friends meet in a pub looking for work.  One thing leads to another and they get sucked into a Groundhog Day loop except it's in a Old Western Town constantly about to be destroyed and they're being followed by mysterious red ghosts.",
                        GameMasterID = 4
                    },
                    new Campaign
                    {
                        CampaignID = 2,
                        CampaignName = "Graduation",
                        Description = "Three boys sign up for hero school and end up as main characters in the weirdest and most rail-roaded war plot ever written.",
                        GameMasterID = 2
                    }
                );

                context.Characters.AddRange(
                    new Character
                    {
                        CharacterID = 1,
                        CharacterName = "Taako",
                        Money = 420,
                        UserID = 1,

                        HP = 49,
                        XPLevel = 16,
                        Strength = 10,
                        Dexterity = 16,
                        Constitution = 14,
                        Intelligence = 20,
                        Wisdom = 12,
                        Charisma = 10
                    },
                    new Character
                    {
                        CharacterID = 2,
                        CharacterName = "Magnus Burnsides",
                        Money = 420,
                        UserID = 2,

                        HP = 131,
                        XPLevel = 16,
                        Strength = 20,
                        Dexterity = 14,
                        Constitution = 18,
                        Intelligence = 10,
                        Wisdom = 12,
                        Charisma = 12
                    },
                    new Character
                    {
                        CharacterID = 3,
                        CharacterName = "Merle Highchurch",
                        Money = 420,
                        UserID = 3,

                        HP = 71,
                        XPLevel = 15,
                        Strength = 14,
                        Dexterity = 12,
                        Constitution = 16,
                        Intelligence = 10,
                        Wisdom = 17,
                        Charisma = 12
                    },
                    new Character
                    {
                        CharacterID = 4,
                        CharacterName = "Firbolg",
                        Money = 420,
                        UserID = 1,

                        HP = 42,
                        XPLevel = 10,
                        Strength = 15,
                        Dexterity = 14,
                        Constitution = 13,
                        Intelligence = 11,
                        Wisdom = 17,
                        Charisma = 13
                    },
                    new Character
                    {
                        CharacterID = 5,
                        CharacterName = "Argo Keene",
                        Money = 420,
                        UserID = 3,

                        HP = 57,
                        XPLevel = 10,
                        Strength = 13,
                        Dexterity = 19,
                        Constitution = 13,
                        Intelligence = 17,
                        Wisdom = 9,
                        Charisma = 15
                    },
                    new Character
                    {
                        CharacterID = 6,
                        CharacterName = "Sir Fitzroy Maplecourt",
                        Money = 420,
                        UserID = 4,

                        HP = 38,
                        XPLevel = 10,
                        Strength = 17,
                        Dexterity = 14,
                        Constitution = 15,
                        Intelligence = 8,
                        Wisdom = 11,
                        Charisma = 15
                    }
                );

                context.Encounters.AddRange(
                    new Encounter
                    {
                        EncounterID = 1,
                        EncounterTitle = "HTBG - Gerblins Ambush Buggy",
                        EncounterDescription = "As our heroes make their way to their destination with Barry Blue Jeans, they are ambushed by a small group of Gerblins.",
                        LocationID = 2,
                        CampaignID = 1
                    },
                    new Encounter
                    {
                        EncounterID = 84,
                        EncounterTitle = "Dungeon Practice",
                        EncounterDescription = "On their first day of school, the boys practice their combat on some friendly skeletons in the practice dungeon.",
                        LocationID = 54,
                        CampaignID = 2
                    }
                );

                context.Items.AddRange(
                    new Item
                    {
                        ItemID = 1,
                        ItemName = "Taako's Fabulously Magical Umbrella",
                        ItemDescription = "An umbrella that Taako stole from a robed skeleton on their very first adventure",
                        CharacterID = 1
                    },
                    new Item
                    {
                        ItemID = 2,
                        ItemName = "Extreme Teen Bible",
                        ItemDescription = "The tome used by Merle to evangelize young teen dwarves for decades, this bible comunicates the words of Pan is a way relatable to today's youth.",
                        CharacterID = 3
                    }
                );

                context.Locations.AddRange(
                    new Location
                    {
                        LocationID = 2,
                        LocationName = "Forest Road to Phandalin",
                        LocationDescription = "A forested path that goes between Wave Echo Cave and Phandalin",
                        CampaignID = 1
                    },
                    new Location
                    {
                        LocationID = 84,
                        LocationName = "Test Dungeon",
                        LocationDescription = "A dungeon designed for students to practice their combat skills on eachother and on training dummies without consequence within the school.",
                        CampaignID = 2
                    }
                );

                context.NPCs.AddRange(
                    new NPC
                    {
                        NPCID = 1,
                        NPCName = "Barry Blue Jeans",
                        NPCDescription = "Ward to Gundrun Rockseeker, he's here to get help moving Gundrun's things to Wave Echo Cave.  He doesn't talk much, seems like he might be hiding something...",
                        CampaignID = 1,

                        HP = 69,
                        XPLevel = 18,
                        Strength = 11,
                        Dexterity = 14,
                        Constitution = 15,
                        Intelligence = 15,
                        Wisdom = 11,
                        Charisma = 16
                    },
                    new NPC
                    {
                        NPCID = 3,
                        NPCName = "Gerblin 2",
                        NPCDescription = "A Gerblin fought by tres horny boys in the first episode.",
                        CampaignID = 1,

                        HP = 7,
                        XPLevel = 1,
                        Strength = 8,
                        Dexterity = 9,
                        Constitution = 8,
                        Intelligence = 4,
                        Wisdom = 6,
                        Charisma = 3

                    }
                );

                context.Stories.AddRange(
                    new Story
                    {
                        StoryID = 1,
                        DateCreated = new DateTime(2014, 12, 14),
                        StoryTitle = "Here there be Gerblins (1)",
                        StoryDescription = "Magnus, Taako, and Merle are recruited to transport Gundrun rockseeker's belongings from Neverwinter to Phandalin by his ward Barry Bluejeans.  Along the way they are attacked by gerblins and Barry is kidnapped.",
                        CampaignID = 1
                    },
                    new Story
                    {
                        StoryID = 2,
                        DateCreated = new DateTime(2014, 12, 14),
                        StoryTitle = "Here there be Gerblins (2)",
                        StoryDescription = "After some investigation the trio discover that a Bugbear named Klarg is the leader of the band of Gerblins who kidnapped Barry.  His 2nd in command, Yeemick, tries to convince them to help him overthrow Klarg in exchange for Barry's safety.",
                        CampaignID = 1
                    }
                );

                context.Users.AddRange(
                    new User
                    {
                        UserID = 1,
                        FirstName = "Griffin",
                        LastName = "McElroy",
                        Email = "griffin@themcelroy.family",
                        Phone = "111-222-3333"
                    },
                    new User
                    {
                        UserID = 2,
                        FirstName = "Justin",
                        LastName = "McElroy",
                        Email = "justin@themcelroy.family",
                        Phone = "222-333-4444"
                    },
                    new User
                    {
                        UserID = 3,
                        FirstName = "Travis",
                        LastName = "McElroy",
                        Email = "travis@themcelroy.family",
                        Phone = "333-444-5555"
                    },
                    new User
                    {
                        UserID = 4,
                        FirstName = "Clint",
                        LastName = "McElroy",
                        Email = "clint@themcelroy.family",
                        Phone = "444-555-6666"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
