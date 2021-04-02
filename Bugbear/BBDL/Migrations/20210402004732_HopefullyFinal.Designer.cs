﻿// <auto-generated />
using System;
using BBDL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BBDL.Migrations
{
    [DbContext(typeof(BugbearDBContext))]
    [Migration("20210402004732_HopefullyFinal")]
    partial class HopefullyFinal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("BBModels.Campaign", b =>
                {
                    b.Property<int>("CampaignID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CampaignName")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("GameMasterID")
                        .HasColumnType("integer");

                    b.HasKey("CampaignID");

                    b.ToTable("Campaigns");
                });

            modelBuilder.Entity("BBModels.Character", b =>
                {
                    b.Property<int>("CharacterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CampaignID")
                        .HasColumnType("integer");

                    b.Property<string>("CharacterName")
                        .HasColumnType("text");

                    b.Property<int>("Charisma")
                        .HasColumnType("integer");

                    b.Property<int>("Constitution")
                        .HasColumnType("integer");

                    b.Property<int>("Dexterity")
                        .HasColumnType("integer");

                    b.Property<int>("HP")
                        .HasColumnType("integer");

                    b.Property<int>("Intelligence")
                        .HasColumnType("integer");

                    b.Property<int>("Money")
                        .HasColumnType("integer");

                    b.Property<int>("Strength")
                        .HasColumnType("integer");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.Property<int>("Wisdom")
                        .HasColumnType("integer");

                    b.Property<int>("XPLevel")
                        .HasColumnType("integer");

                    b.HasKey("CharacterID");

                    b.HasIndex("CampaignID");

                    b.HasIndex("UserID");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("BBModels.Encounter", b =>
                {
                    b.Property<int>("EncounterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CampaignID")
                        .HasColumnType("integer");

                    b.Property<string>("EncounterDescription")
                        .HasColumnType("text");

                    b.Property<string>("EncounterTitle")
                        .HasColumnType("text");

                    b.Property<int>("LocationID")
                        .HasColumnType("integer");

                    b.HasKey("EncounterID");

                    b.HasIndex("CampaignID");

                    b.ToTable("Encounters");
                });

            modelBuilder.Entity("BBModels.Item", b =>
                {
                    b.Property<int>("ItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CharacterID")
                        .HasColumnType("integer");

                    b.Property<string>("ItemDescription")
                        .HasColumnType("text");

                    b.Property<string>("ItemName")
                        .HasColumnType("text");

                    b.HasKey("ItemID");

                    b.HasIndex("CharacterID");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("BBModels.Location", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CampaignID")
                        .HasColumnType("integer");

                    b.Property<string>("LocationDescription")
                        .HasColumnType("text");

                    b.Property<string>("LocationName")
                        .HasColumnType("text");

                    b.HasKey("LocationID");

                    b.HasIndex("CampaignID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("BBModels.Map", b =>
                {
                    b.Property<int>("MapID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CampaignID")
                        .HasColumnType("integer");

                    b.Property<byte[]>("MapImage")
                        .HasColumnType("bytea");

                    b.Property<string>("MapTitle")
                        .HasColumnType("text");

                    b.HasKey("MapID");

                    b.HasIndex("CampaignID");

                    b.ToTable("Maps");
                });

            modelBuilder.Entity("BBModels.NPC", b =>
                {
                    b.Property<int>("NPCID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CampaignID")
                        .HasColumnType("integer");

                    b.Property<int>("Charisma")
                        .HasColumnType("integer");

                    b.Property<int>("Constitution")
                        .HasColumnType("integer");

                    b.Property<int>("Dexterity")
                        .HasColumnType("integer");

                    b.Property<int>("HP")
                        .HasColumnType("integer");

                    b.Property<int>("Intelligence")
                        .HasColumnType("integer");

                    b.Property<string>("NPCDescription")
                        .HasColumnType("text");

                    b.Property<string>("NPCName")
                        .HasColumnType("text");

                    b.Property<int>("Strength")
                        .HasColumnType("integer");

                    b.Property<int>("Wisdom")
                        .HasColumnType("integer");

                    b.Property<int>("XPLevel")
                        .HasColumnType("integer");

                    b.HasKey("NPCID");

                    b.HasIndex("CampaignID");

                    b.ToTable("NPCs");
                });

            modelBuilder.Entity("BBModels.Story", b =>
                {
                    b.Property<int>("StoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CampaignID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("StoryDescription")
                        .HasColumnType("text");

                    b.Property<string>("StoryTitle")
                        .HasColumnType("text");

                    b.HasKey("StoryID");

                    b.HasIndex("CampaignID");

                    b.ToTable("Stories");
                });

            modelBuilder.Entity("BBModels.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CampaignID")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.HasKey("UserID");

                    b.HasIndex("CampaignID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BBModels.Character", b =>
                {
                    b.HasOne("BBModels.Campaign", null)
                        .WithMany("CampaignCharacters")
                        .HasForeignKey("CampaignID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BBModels.User", null)
                        .WithMany("Characters")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BBModels.Encounter", b =>
                {
                    b.HasOne("BBModels.Campaign", null)
                        .WithMany("CampaignEncounters")
                        .HasForeignKey("CampaignID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BBModels.Item", b =>
                {
                    b.HasOne("BBModels.Character", null)
                        .WithMany("Items")
                        .HasForeignKey("CharacterID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BBModels.Location", b =>
                {
                    b.HasOne("BBModels.Campaign", null)
                        .WithMany("CampaignLocations")
                        .HasForeignKey("CampaignID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BBModels.Map", b =>
                {
                    b.HasOne("BBModels.Campaign", null)
                        .WithMany("CampaignMaps")
                        .HasForeignKey("CampaignID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BBModels.NPC", b =>
                {
                    b.HasOne("BBModels.Campaign", null)
                        .WithMany("CampaignNPCs")
                        .HasForeignKey("CampaignID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BBModels.Story", b =>
                {
                    b.HasOne("BBModels.Campaign", null)
                        .WithMany("CampaignStories")
                        .HasForeignKey("CampaignID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BBModels.User", b =>
                {
                    b.HasOne("BBModels.Campaign", null)
                        .WithMany("CampaignUsers")
                        .HasForeignKey("CampaignID");
                });

            modelBuilder.Entity("BBModels.Campaign", b =>
                {
                    b.Navigation("CampaignCharacters");

                    b.Navigation("CampaignEncounters");

                    b.Navigation("CampaignLocations");

                    b.Navigation("CampaignMaps");

                    b.Navigation("CampaignNPCs");

                    b.Navigation("CampaignStories");

                    b.Navigation("CampaignUsers");
                });

            modelBuilder.Entity("BBModels.Character", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("BBModels.User", b =>
                {
                    b.Navigation("Characters");
                });
#pragma warning restore 612, 618
        }
    }
}
