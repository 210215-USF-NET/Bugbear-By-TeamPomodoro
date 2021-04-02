using BBDL;
using BBModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public void AddCampaignShouldAddNewCampaign()
        {
            using (var context = new BugbearDBContext(options))
            {
                //Arrange
                IBugbearRepository _repo = new BugbearRepoDB(context);

                //Act
                _repo.AddCampaignAsync(
                    new Campaign
                    {
                        CampaignID = 6,
                        CampaignName = "Cool New Campaign",
                        Description = "A cool new campaign that only my friends get to enjoy!",
                        GameMasterID = 2
                    }
                );
            }

            using (var assertContext = new BugbearDBContext(options))
            {
                //Assert
                var result = assertContext.Campaigns.Select(c => c).OrderBy(c => c.CampaignID).LastOrDefaultAsync();

                Assert.NotNull(result.Result);
                Assert.Equal("Cool New Campaign", result.Result.CampaignName);
            }
        }

        [Fact]
        public void AddCharacterShouldAddNewCharacter()
        {
            using (var context = new BugbearDBContext(options))
            {
                //Arrange
                IBugbearRepository _repo = new BugbearRepoDB(context);

                //Act
                _repo.AddCharacterAsync(
                    new Character
                    {
                        CharacterID = 42,
                        CharacterName = "Lola Bunny",
                        Money = 999,
                        HP = 666,
                        UserID = 2,
                        XPLevel = 20,
                        Strength = 18,
                        Dexterity = 20,
                        Constitution = 8,
                        Intelligence = 16,
                        Wisdom = 11,
                        Charisma = 20,
                        CampaignID = 2
                    }
                );
            }

            using (var assertContext = new BugbearDBContext(options))
            {
                //Assert
                var result = assertContext.Characters.Select(c => c).OrderBy(c => c.CharacterID).LastOrDefaultAsync();

                Assert.NotNull(result.Result);
                Assert.Equal("Lola Bunny", result.Result.CharacterName);
            }
        }

        [Fact]
        public void AddEncounterShouldAddNewEncounter()
        {
            using (var context = new BugbearDBContext(options))
            {
                //Arrange
                IBugbearRepository _repo = new BugbearRepoDB(context);

                //Act
                _repo.AddEncounterAsync(
                    new Encounter
                    {
                        EncounterID = 999,
                        EncounterTitle = "Portals",
                        EncounterDescription = "Captain America is ready to stand alone against Thanos, when he is suddenly joined by thousands of Wakandans and Superheroes from around the world.",
                        CampaignID = 2
                    }
                );
            }

            using (var assertContext = new BugbearDBContext(options))
            {
                //Assert
                var result = assertContext.Encounters.Select(e => e).OrderBy(e => e.EncounterID).LastOrDefaultAsync();

                Assert.NotNull(result.Result);
                Assert.Equal("Portals", result.Result.EncounterTitle);
            }
        }

        [Fact]
        public void AddItemShouldAddNewItem()
        {
            using (var context = new BugbearDBContext(options))
            {
                //Arrange
                IBugbearRepository _repo = new BugbearRepoDB(context);

                //Act
                _repo.AddItemAsync(
                    new Item
                    {
                        ItemID = 999,
                        ItemName = "Infinity Gauntlet",
                        ItemDescription = "Contains and harnesses the power of the 6 Infinity Stones"
                    }
                );
            }

            using (var assertContext = new BugbearDBContext(options))
            {
                //Assert
                var result = assertContext.Items.Select(i => i).OrderBy(i => i.ItemID).LastOrDefaultAsync();

                Assert.NotNull(result.Result);
                Assert.Equal("Infinity Gauntlet", result.Result.ItemName);
            }
        }

        [Fact]
        public void AddLocationShouldAddLocation()
        {
            using (var context = new BugbearDBContext(options))
            {
                //Arrange
                IBugbearRepository _repo = new BugbearRepoDB(context);

                //Act
                _repo.AddLocationAsync(
                    new Location
                    {
                        LocationID = 999,
                        LocationName = "Avengers Tower",
                        LocationDescription = "The place where all the magic happens.",
                        CampaignID = 2
                    }
                );
            }

            using (var assertContext = new BugbearDBContext(options))
            {
                //Assert
                var result = assertContext.Locations.Select(e => e).OrderBy(e => e.LocationID).LastOrDefaultAsync();

                Assert.NotNull(result.Result);
                Assert.Equal("Avengers Tower", result.Result.LocationName);
            }
        }

        //[Fact]
        //public void AddMapShouldAddNewMap()
        //{
        //}

        [Fact]
        public void AddNPCShouldAddNewNPC()
        {
            using (var context = new BugbearDBContext(options))
            {
                //Arrange
                IBugbearRepository _repo = new BugbearRepoDB(context);

                //Act
                _repo.AddNPCAsync(
                    new NPC
                    {
                        NPCID = 42,
                        NPCName = "Lola Bunny",
                        NPCDescription = "A cute bunny who's really good at basketball.",
                        HP = 666,
                        XPLevel = 20,
                        Strength = 18,
                        Dexterity = 20,
                        Constitution = 8,
                        Intelligence = 16,
                        Wisdom = 11,
                        Charisma = 20,
                        CampaignID = 2
                    }
                );
            }

            using (var assertContext = new BugbearDBContext(options))
            {
                //Assert
                var result = assertContext.NPCs.Select(e => e).OrderBy(e => e.NPCID).LastOrDefaultAsync();

                Assert.NotNull(result.Result);
                Assert.Equal("Lola Bunny", result.Result.NPCName);
            }
        }

        [Fact]
        public void AddStoryShouldAddNewStory()
        {
            using (var context = new BugbearDBContext(options))
            {
                //Arrange
                IBugbearRepository _repo = new BugbearRepoDB(context);

                //Act
                _repo.AddStoryAsync(
                    new Story
                    {
                        StoryID = 999,
                        DateCreated = DateTime.Now,
                        StoryTitle = "Thanos' Quest",
                        StoryDescription = "Thanos spent his life trying to do what he thought was right.  he knew there were too many people, and the only way to deal with them was to cull the herd.  Randomly, the only fair way.",
                        CampaignID = 2
                    }
                );
            }

            using (var assertContext = new BugbearDBContext(options))
            {
                //Assert
                var result = assertContext.Stories.Select(e => e).OrderBy(e => e.StoryID).LastOrDefaultAsync();

                Assert.NotNull(result.Result);
                Assert.Equal("Thanos' Quest", result.Result.StoryTitle);
            }
        }

        [Fact]
        public void AddUserShouldAddNewUser()
        {
            using (var context = new BugbearDBContext(options))
            {
                //Arrange
                IBugbearRepository _repo = new BugbearRepoDB(context);

                //Act
                _repo.AddUserAsync(
                    new User
                    {
                        UserID = 999,
                        Email = "jack.long@revature.net"
                    }
                );
            }

            using (var assertContext = new BugbearDBContext(options))
            {
                //Assert
                var result = assertContext.Users.Select(e => e).OrderBy(e => e.UserID).LastOrDefaultAsync();

                Assert.NotNull(result.Result);
                Assert.Equal("jack.long@revature.net", result.Result.Email);
            }
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

        //[Fact]
        //public void GetMapsShouldReturnAllMaps()
        //{
        //}

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

        //[Fact]
        //public void GetStoryByIDReturnsTheCorrectStory()
        //{
        //    using (var context = new BugbearDBContext(options))
        //    {
        //        //Arrange
        //        IBugbearRepository _repo = new BugbearRepoDB(context);

        //        //Act
        //        var story = _repo.GetStoryByIDAsync(1);

        //        //Assert
        //        Assert.NotNull(story);
        //        Assert.Equal("Here there be Gerblins (1)", story.Result.StoryTitle);
        //    }
        //}

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

        [Fact]
        public void DeleteCampaignRemovesTheCampaign()
        {
            using (var context = new BugbearDBContext(options))
            {
                //Arrange
                IBugbearRepository _repo = new BugbearRepoDB(context);

                //Act
                _repo.DeleteCampaignAsync(
                    new Campaign
                    {
                        CampaignID = 1,
                        CampaignName = "Balance",
                        Description = "Three friends meet in a pub looking for work.  One thing leads to another and they get sucked into a Groundhog Day loop except it's in a Old Western Town constantly about to be destroyed and they're being followed by mysterious red ghosts.",
                        GameMasterID = 4
                    }
                );
            }

            using (var assertContext = new BugbearDBContext(options))
            {
                //Assert
                var campaigns = assertContext.Campaigns.Select(c => c).ToList();
                Assert.Single(campaigns);
            }
        }

        [Fact]
        public void DeleteCharacterRemovesTheCharacter()
        {
            using (var context = new BugbearDBContext(options))
            {
                //Arrange
                IBugbearRepository _repo = new BugbearRepoDB(context);

                //Act
                _repo.DeleteCharacterAsync(
                    new Character
                    {
                        CharacterID = 2,
                        CharacterName = "Magnus Burnsides",
                        Money = 420,
                        HP = 131,
                        XPLevel = 16,
                        UserID = 2,
                        Strength = 20,
                        Dexterity = 14,
                        Constitution = 18,
                        Intelligence = 10,
                        Wisdom = 12,
                        Charisma = 12,
                        CampaignID = 2
                    }
                );
            }

            using (var assertContext = new BugbearDBContext(options))
            {
                //Assert
                var characters = assertContext.Characters.Select(c => c).ToList();
                Assert.Equal(5, characters.Count);
            }
        }

        [Fact]
        public void DeleteEncounterRemovesTheEncounter()
        {
            using (var context = new BugbearDBContext(options))
            {
                //Arrange
                IBugbearRepository _repo = new BugbearRepoDB(context);

                //Act
                _repo.DeleteEncounterAsync(
                    new Encounter
                    {
                        EncounterID = 1,
                        EncounterTitle = "HTBG - Gerblins Ambush Buggy",
                        EncounterDescription = "As our heroes make their way to their destination with Barry Blue Jeans, they are ambushed by a small group of Gerblins.",
                        CampaignID = 2
                    }
                );
            }

            using (var assertContext = new BugbearDBContext(options))
            {
                //Assert
                var encounters = assertContext.Encounters.Select(c => c).ToList();
                Assert.Single(encounters);
            }
        }

        [Fact]
        public void DeleteItemRemovesTheItem()
        {
            using (var context = new BugbearDBContext(options))
            {
                //Arrange
                IBugbearRepository _repo = new BugbearRepoDB(context);

                //Act
                _repo.DeleteItemAsync(
                    new Item
                    {
                        ItemID = 1,
                        ItemName = "Taako's Fabulously Magical Umbrella",
                        ItemDescription = "An umbrella that Taako stole from a robed skeleton on their very first adventure"
                    }
                );
            }

            using (var assertContext = new BugbearDBContext(options))
            {
                //Assert
                var items = assertContext.Items.Select(c => c).ToList();
                Assert.Single(items);
            }
        }

        [Fact]
        public void DeleteLocationRemovesTheLocation()
        {
            using (var context = new BugbearDBContext(options))
            {
                //Arrange
                IBugbearRepository _repo = new BugbearRepoDB(context);

                //Act
                _repo.DeleteLocationAsync(
                    new Location
                    {
                        LocationID = 2,
                        LocationName = "Forest Road to Phandalin",
                        LocationDescription = "A forested path that goes between Wave Echo Cave and Phandalin",
                        CampaignID = 2
                    }
                );
            }

            using (var assertContext = new BugbearDBContext(options))
            {
                //Assert
                var locations = assertContext.Locations.Select(c => c).ToList();
                Assert.Single(locations);
            }
        }

        //[Fact]
        //public void DeleteMapRemovesTheMap()
        //{
        //}

        [Fact]
        public void DeleteNPCRemovesTheNPC()
        {
            using (var context = new BugbearDBContext(options))
            {
                //Arrange
                IBugbearRepository _repo = new BugbearRepoDB(context);

                //Act
                _repo.DeleteNPCAsync(
                    new NPC
                    {
                        NPCID = 1,
                        NPCName = "Barry Blue Jeans",
                        NPCDescription = "Ward to Gundrun Rockseeker, he's here to get help moving Gundrun's things to Wave Echo Cave.  He doesn't talk much, seems like he might be hiding something...",

                        HP = 69,
                        XPLevel = 18,
                        Strength = 11,
                        Dexterity = 14,
                        Constitution = 15,
                        Intelligence = 15,
                        Wisdom = 11,
                        Charisma = 16
                    }
                );
            }

            using (var assertContext = new BugbearDBContext(options))
            {
                //Assert
                var npcs = assertContext.NPCs.Select(c => c).ToList();
                Assert.Single(npcs);
            }
        }

        [Fact]
        public void DeleteStoryRemovesTheStory()
        {
            using (var context = new BugbearDBContext(options))
            {
                //Arrange
                IBugbearRepository _repo = new BugbearRepoDB(context);

                //Act
                _repo.DeleteStoryAsync(
                    new Story
                    {
                        StoryID = 1,
                        DateCreated = new DateTime(2014, 12, 14),
                        StoryTitle = "Here there be Gerblins (1)",
                        StoryDescription = "Magnus, Taako, and Merle are recruited to transport Gundrun rockseeker's belongings from Neverwinter to Phandalin by his ward Barry Bluejeans.  Along the way they are attacked by gerblins and Barry is kidnapped.",
                        CampaignID = 2
                    }
                );
            }

            using (var assertContext = new BugbearDBContext(options))
            {
                //Assert
                var stories = assertContext.Stories.Select(c => c).ToList();
                Assert.Single(stories);
            }
        }

        [Fact]
        public void DeleteUserRemovesTheUser()
        {
            using (var context = new BugbearDBContext(options))
            {
                //Arrange
                IBugbearRepository _repo = new BugbearRepoDB(context);

                //Act
                _repo.DeleteUserAsync(
                    new User
                    {
                        UserID = 1,
                        Email = "griffin@themcelroy.family"
                    }
                );
            }

            using (var assertContext = new BugbearDBContext(options))
            {
                //Assert
                var users = assertContext.Users.Select(c => c).ToList();
                Assert.Equal(3, users.Count);
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
                        HP = 49,
                        UserID = 2,
                        XPLevel = 16,
                        Strength = 10,
                        Dexterity = 16,
                        Constitution = 14,
                        Intelligence = 20,
                        Wisdom = 12,
                        Charisma = 10,
                        CampaignID = 2
                    },
                    new Character
                    {
                        CharacterID = 2,
                        CharacterName = "Magnus Burnsides",
                        Money = 420,
                        HP = 131,
                        XPLevel = 16,
                        UserID = 2,
                        Strength = 20,
                        Dexterity = 14,
                        Constitution = 18,
                        Intelligence = 10,
                        Wisdom = 12,
                        Charisma = 12,
                        CampaignID = 2
                    },
                    new Character
                    {
                        CharacterID = 3,
                        CharacterName = "Merle Highchurch",
                        Money = 420,
                        HP = 71,
                        XPLevel = 15,
                        UserID = 4,
                        Strength = 14,
                        Dexterity = 12,
                        Constitution = 16,
                        Intelligence = 10,
                        Wisdom = 17,
                        Charisma = 12,
                        CampaignID = 1
                    },
                    new Character
                    {
                        CharacterID = 4,
                        CharacterName = "Firbolg",
                        Money = 420,
                        HP = 42,
                        XPLevel = 10,
                        UserID = 4,
                        Strength = 15,
                        Dexterity = 14,
                        Constitution = 13,
                        Intelligence = 11,
                        Wisdom = 17,
                        Charisma = 13,
                        CampaignID = 1
                    },
                    new Character
                    {
                        CharacterID = 5,
                        CharacterName = "Argo Keene",
                        Money = 420,
                        HP = 57,
                        UserID = 3,
                        XPLevel = 10,
                        Strength = 13,
                        Dexterity = 19,
                        Constitution = 13,
                        Intelligence = 17,
                        Wisdom = 9,
                        Charisma = 15,
                        CampaignID = 1
                    },
                    new Character
                    {
                        CharacterID = 6,
                        CharacterName = "Sir Fitzroy Maplecourt",
                        Money = 420,
                        HP = 38,
                        XPLevel = 10,
                        UserID = 3,
                        Strength = 17,
                        Dexterity = 14,
                        Constitution = 15,
                        Intelligence = 8,
                        Wisdom = 11,
                        Charisma = 15,
                        CampaignID = 2
                    }
                );

                context.Encounters.AddRange(
                    new Encounter
                    {
                        EncounterID = 1,
                        EncounterTitle = "HTBG - Gerblins Ambush Buggy",
                        EncounterDescription = "As our heroes make their way to their destination with Barry Blue Jeans, they are ambushed by a small group of Gerblins.",
                        CampaignID = 2
                    },
                    new Encounter
                    {
                        EncounterID = 84,
                        EncounterTitle = "Dungeon Practice",
                        EncounterDescription = "On their first day of school, the boys practice their combat on some friendly skeletons in the practice dungeon.",
                        CampaignID = 1
                    }
                );

                context.Items.AddRange(
                    new Item
                    {
                        ItemID = 1,
                        ItemName = "Taako's Fabulously Magical Umbrella",
                        ItemDescription = "An umbrella that Taako stole from a robed skeleton on their very first adventure"
                    },
                    new Item
                    {
                        ItemID = 2,
                        ItemName = "Extreme Teen Bible",
                        ItemDescription = "The tome used by Merle to evangelize young teen dwarves for decades, this bible comunicates the words of Pan is a way relatable to today's youth."
                    }
                );

                context.Locations.AddRange(
                    new Location
                    {
                        LocationID = 2,
                        LocationName = "Forest Road to Phandalin",
                        LocationDescription = "A forested path that goes between Wave Echo Cave and Phandalin",
                        CampaignID = 2
                    },
                    new Location
                    {
                        LocationID = 84,
                        LocationName = "Test Dungeon",
                        LocationDescription = "A dungeon designed for students to practice their combat skills on eachother and on training dummies without consequence within the school.",
                        CampaignID = 1
                    }
                );

                context.NPCs.AddRange(
                    new NPC
                    {
                        NPCID = 1,
                        NPCName = "Barry Blue Jeans",
                        NPCDescription = "Ward to Gundrun Rockseeker, he's here to get help moving Gundrun's things to Wave Echo Cave.  He doesn't talk much, seems like he might be hiding something...",

                        HP = 69,
                        XPLevel = 18,
                        Strength = 11,
                        Dexterity = 14,
                        Constitution = 15,
                        Intelligence = 15,
                        Wisdom = 11,
                        Charisma = 16,
                        CampaignID = 2
                    },
                    new NPC
                    {
                        NPCID = 3,
                        NPCName = "Gerblin 2",
                        NPCDescription = "A Gerblin fought by tres horny boys in the first episode.",

                        HP = 7,
                        XPLevel = 1,
                        Strength = 8,
                        Dexterity = 9,
                        Constitution = 8,
                        Intelligence = 4,
                        Wisdom = 6,
                        Charisma = 3,
                        CampaignID = 1
                    }
                );

                context.Stories.AddRange(
                    new Story
                    {
                        StoryID = 1,
                        DateCreated = new DateTime(2014, 12, 14),
                        StoryTitle = "Here there be Gerblins (1)",
                        StoryDescription = "Magnus, Taako, and Merle are recruited to transport Gundrun rockseeker's belongings from Neverwinter to Phandalin by his ward Barry Bluejeans.  Along the way they are attacked by gerblins and Barry is kidnapped.",
                        CampaignID = 2
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
                        Email = "griffin@themcelroy.family"
                    },
                    new User
                    {
                        UserID = 2,
                        Email = "justin@themcelroy.family"
                    },
                    new User
                    {
                        UserID = 3,
                        Email = "travis@themcelroy.family"
                    },
                    new User
                    {
                        UserID = 4,
                        Email = "clint@themcelroy.family"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}