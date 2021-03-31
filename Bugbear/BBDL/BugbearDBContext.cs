using BBModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BBDL
{
    public class BugbearDBContext : DbContext
    {
        public BugbearDBContext(DbContextOptions options) : base(options)
        {
        }

        protected BugbearDBContext()
        {
        }

        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Encounter> Encounters { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<NPC> NPCs { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Chat> Chats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Campaign>()
                .Property(camp => camp.CampaignID)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Character>()
                .Property(c => c.CharacterID)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Encounter>()
                .Property(e => e.EncounterID)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Item>()
                .Property(i => i.ItemID)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Location>()
                .Property(l => l.LocationID)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Map>()
                .Property(map => map.MapID)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<NPC>()
                .Property(npc => npc.NPCID)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Story>()
                .Property(s => s.StoryID)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<User>()
                .Property(u => u.UserID)
                .ValueGeneratedOnAdd();

            //campaign relationships
            modelBuilder.Entity<Campaign>()
                .HasMany(c => c.CampaignUsers);

            modelBuilder.Entity<Campaign>()
                .HasMany(c => c.CampaignEncounters)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Campaign>()
                .HasMany(c => c.CampaignCharacters)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Campaign>()
                .HasMany(c => c.CampaignLocations)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Campaign>()
                .HasMany(c => c.CampaignMaps)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Campaign>()
                .HasMany(c => c.CampaignNPCs)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Campaign>()
                .HasMany(c => c.CampaignStories)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Campaign>()
               .HasMany(c => c.CampaignChats)
               .WithOne()
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Character>()
                .HasMany(c => c.Items)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(c => c.Characters)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Chat>()
                .HasOne(c => c.User);
        }
    }
}