using Microsoft.EntityFrameworkCore;
using BBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDL
{
    public class BugbearDBContext : DbContext
    {
        public BugbearDBContext (DbContextOptions options) : base(options)
        {

        }

        protected BugbearDBContext ()
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
        public IEnumerable<object> Character { get; internal set; }

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
                .Property(item => item.ItemID)
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
        }
    }
}
