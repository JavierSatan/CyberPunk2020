﻿// <auto-generated />
using System;
using CyberPunk2020.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CyberPunk2020.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230512051017_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CyberPunk2020.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int?>("SkillId")
                        .HasColumnType("int");

                    b.Property<int>("StatPoints")
                        .HasColumnType("int");

                    b.Property<int?>("StatstId")
                        .HasColumnType("int");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SkillId");

                    b.HasIndex("StatstId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("CyberPunk2020.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Round")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("CyberPunk2020.Models.Npc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BTM")
                        .HasColumnType("int");

                    b.Property<int?>("GameId")
                        .HasColumnType("int");

                    b.Property<int?>("HP")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Npc");
                });

            modelBuilder.Entity("CyberPunk2020.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BTM")
                        .HasColumnType("int");

                    b.Property<int?>("GameId")
                        .HasColumnType("int");

                    b.Property<int?>("HP")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("CyberPunk2020.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AVTech")
                        .HasColumnType("int");

                    b.Property<int?>("Accounting")
                        .HasColumnType("int");

                    b.Property<int?>("AeroTech")
                        .HasColumnType("int");

                    b.Property<int?>("Anthropology")
                        .HasColumnType("int");

                    b.Property<int?>("Archery")
                        .HasColumnType("int");

                    b.Property<int?>("Athletic")
                        .HasColumnType("int");

                    b.Property<int?>("AwarenessOrNotice")
                        .HasColumnType("int");

                    b.Property<int?>("BasicTech")
                        .HasColumnType("int");

                    b.Property<int?>("Biology")
                        .HasColumnType("int");

                    b.Property<int?>("Botany")
                        .HasColumnType("int");

                    b.Property<int?>("Brawling")
                        .HasColumnType("int");

                    b.Property<int?>("Chemistry")
                        .HasColumnType("int");

                    b.Property<int?>("Composition")
                        .HasColumnType("int");

                    b.Property<int?>("CryotankOperation")
                        .HasColumnType("int");

                    b.Property<int?>("CyberTech")
                        .HasColumnType("int");

                    b.Property<int?>("CyberdeckDesign")
                        .HasColumnType("int");

                    b.Property<int?>("Dance")
                        .HasColumnType("int");

                    b.Property<int?>("Demolitions")
                        .HasColumnType("int");

                    b.Property<int?>("DiagnoseIllness")
                        .HasColumnType("int");

                    b.Property<int?>("Disguise")
                        .HasColumnType("int");

                    b.Property<int?>("DodgeAndEscape")
                        .HasColumnType("int");

                    b.Property<int?>("Driving")
                        .HasColumnType("int");

                    b.Property<int?>("EducationAndGeneralKnowledge")
                        .HasColumnType("int");

                    b.Property<int?>("ElectSecurity")
                        .HasColumnType("int");

                    b.Property<int?>("Electronics")
                        .HasColumnType("int");

                    b.Property<int?>("Endurance")
                        .HasColumnType("int");

                    b.Property<int?>("Expert")
                        .HasColumnType("int");

                    b.Property<int?>("Fencing")
                        .HasColumnType("int");

                    b.Property<int?>("FirstAid")
                        .HasColumnType("int");

                    b.Property<int?>("Forgery")
                        .HasColumnType("int");

                    b.Property<int?>("Gamble")
                        .HasColumnType("int");

                    b.Property<int?>("Geology")
                        .HasColumnType("int");

                    b.Property<int?>("GyroTech")
                        .HasColumnType("int");

                    b.Property<int?>("Handgun")
                        .HasColumnType("int");

                    b.Property<int?>("HeavyWeapons")
                        .HasColumnType("int");

                    b.Property<int?>("HideOrEvade")
                        .HasColumnType("int");

                    b.Property<int?>("History")
                        .HasColumnType("int");

                    b.Property<int?>("HumanPerception")
                        .HasColumnType("int");

                    b.Property<int?>("Interrogation")
                        .HasColumnType("int");

                    b.Property<int?>("Interview")
                        .HasColumnType("int");

                    b.Property<int?>("Intimidate")
                        .HasColumnType("int");

                    b.Property<int?>("KnowLanguages")
                        .HasColumnType("int");

                    b.Property<int?>("Leadership")
                        .HasColumnType("int");

                    b.Property<int?>("LibrarySearch")
                        .HasColumnType("int");

                    b.Property<int?>("MartialArts")
                        .HasColumnType("int");

                    b.Property<int?>("Mathematics")
                        .HasColumnType("int");

                    b.Property<int?>("Melee")
                        .HasColumnType("int");

                    b.Property<int?>("Motorcycle")
                        .HasColumnType("int");

                    b.Property<int?>("OperateHeavyMachinery")
                        .HasColumnType("int");

                    b.Property<int?>("Oratory")
                        .HasColumnType("int");

                    b.Property<int?>("PaintOrDraw")
                        .HasColumnType("int");

                    b.Property<int?>("Perform")
                        .HasColumnType("int");

                    b.Property<int?>("PersonalGrooming")
                        .HasColumnType("int");

                    b.Property<int?>("PersuasionAndFastTalk")
                        .HasColumnType("int");

                    b.Property<int?>("Pharmaceuticals")
                        .HasColumnType("int");

                    b.Property<int?>("PhotoAndFilm")
                        .HasColumnType("int");

                    b.Property<int?>("Physics")
                        .HasColumnType("int");

                    b.Property<int?>("PickLock")
                        .HasColumnType("int");

                    b.Property<int?>("PickPocket")
                        .HasColumnType("int");

                    b.Property<int?>("PilotDirigible")
                        .HasColumnType("int");

                    b.Property<int?>("PilotFixedWing")
                        .HasColumnType("int");

                    b.Property<int?>("PilotGyro")
                        .HasColumnType("int");

                    b.Property<int?>("PilotVectThrustVehicle")
                        .HasColumnType("int");

                    b.Property<int?>("PlayInstrument")
                        .HasColumnType("int");

                    b.Property<int?>("Programming")
                        .HasColumnType("int");

                    b.Property<int?>("ResistTortureOrDrugs")
                        .HasColumnType("int");

                    b.Property<int?>("Rifle")
                        .HasColumnType("int");

                    b.Property<int?>("Seduction")
                        .HasColumnType("int");

                    b.Property<int?>("ShadowOrTrack")
                        .HasColumnType("int");

                    b.Property<int?>("Social")
                        .HasColumnType("int");

                    b.Property<int?>("SpecialAbility")
                        .HasColumnType("int");

                    b.Property<int?>("SpecialAbilityLvl")
                        .HasColumnType("int");

                    b.Property<int?>("Stealth")
                        .HasColumnType("int");

                    b.Property<int?>("StockMarket")
                        .HasColumnType("int");

                    b.Property<int?>("Streetwise")
                        .HasColumnType("int");

                    b.Property<int?>("StrengthFeat")
                        .HasColumnType("int");

                    b.Property<int?>("Submachinegun")
                        .HasColumnType("int");

                    b.Property<int?>("Swimming")
                        .HasColumnType("int");

                    b.Property<int?>("SystemKnowledge")
                        .HasColumnType("int");

                    b.Property<int?>("Teaching")
                        .HasColumnType("int");

                    b.Property<int?>("WardrobeAndStyle")
                        .HasColumnType("int");

                    b.Property<int?>("WeaponsTech")
                        .HasColumnType("int");

                    b.Property<int?>("Weaponsmith")
                        .HasColumnType("int");

                    b.Property<int?>("WildernessSurvival")
                        .HasColumnType("int");

                    b.Property<int?>("Zoology")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("CyberPunk2020.Models.Stats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ATTR")
                        .HasColumnType("int");

                    b.Property<int>("BODY")
                        .HasColumnType("int");

                    b.Property<int>("BTM")
                        .HasColumnType("int");

                    b.Property<int>("COOL")
                        .HasColumnType("int");

                    b.Property<int>("Carry")
                        .HasColumnType("int");

                    b.Property<int>("EMP")
                        .HasColumnType("int");

                    b.Property<int>("Humanity")
                        .HasColumnType("int");

                    b.Property<int>("INT")
                        .HasColumnType("int");

                    b.Property<int>("LUCK")
                        .HasColumnType("int");

                    b.Property<double>("Leap")
                        .HasColumnType("float");

                    b.Property<int>("Lift")
                        .HasColumnType("int");

                    b.Property<int>("MA")
                        .HasColumnType("int");

                    b.Property<int>("REF")
                        .HasColumnType("int");

                    b.Property<int>("Run")
                        .HasColumnType("int");

                    b.Property<int>("Save")
                        .HasColumnType("int");

                    b.Property<int>("TECH")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("CyberPunk2020.Models.Character", b =>
                {
                    b.HasOne("CyberPunk2020.Models.Skill", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillId");

                    b.HasOne("CyberPunk2020.Models.Stats", "Stats")
                        .WithMany()
                        .HasForeignKey("StatstId");

                    b.Navigation("Skill");

                    b.Navigation("Stats");
                });

            modelBuilder.Entity("CyberPunk2020.Models.Npc", b =>
                {
                    b.HasOne("CyberPunk2020.Models.Game", null)
                        .WithMany("Npcs")
                        .HasForeignKey("GameId");
                });

            modelBuilder.Entity("CyberPunk2020.Models.Player", b =>
                {
                    b.HasOne("CyberPunk2020.Models.Game", null)
                        .WithMany("Players")
                        .HasForeignKey("GameId");
                });

            modelBuilder.Entity("CyberPunk2020.Models.Game", b =>
                {
                    b.Navigation("Npcs");

                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
