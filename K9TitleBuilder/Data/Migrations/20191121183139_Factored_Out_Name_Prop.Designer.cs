﻿// <auto-generated />
using System;
using K9TitleBuilder.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace K9TitleBuilder.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191121183139_Factored_Out_Name_Prop")]
    partial class Factored_Out_Name_Prop
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("K9TB.Dog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AKCReg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("AgilityJumpHeight")
                        .HasColumnType("real");

                    b.Property<bool>("Altered")
                        .HasColumnType("bit");

                    b.Property<string>("Breed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BreederID")
                        .HasColumnType("int");

                    b.Property<string>("CKCReg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CallName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Coat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DamId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<long>("Edition")
                        .HasColumnType("bigint");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Height")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("ObedienceJumpHeight")
                        .HasColumnType("real");

                    b.Property<string>("Pedigree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("RallyJumpHeight")
                        .HasColumnType("real");

                    b.Property<string>("RegName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SireId")
                        .HasColumnType("int");

                    b.Property<string>("UKCReg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.HasIndex("BreederID");

                    b.HasIndex("DamId");

                    b.HasIndex("SireId");

                    b.ToTable("Dog");
                });

            modelBuilder.Entity("K9TB.Leg", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<long>("Edition")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TitleID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TitleID");

                    b.ToTable("Leg");
                });

            modelBuilder.Entity("K9TB.MediaItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DogID")
                        .HasColumnType("int");

                    b.Property<long>("Edition")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonID")
                        .HasColumnType("int");

                    b.Property<int?>("RibbonID")
                        .HasColumnType("int");

                    b.Property<int?>("RunID")
                        .HasColumnType("int");

                    b.Property<int?>("ShowEventID")
                        .HasColumnType("int");

                    b.Property<string>("Source")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int?>("VenueID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("DogID");

                    b.HasIndex("PersonID");

                    b.HasIndex("RibbonID");

                    b.HasIndex("RunID");

                    b.HasIndex("ShowEventID");

                    b.HasIndex("VenueID");

                    b.ToTable("MediaItem");
                });

            modelBuilder.Entity("K9TB.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Addr1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Addr2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DogID")
                        .HasColumnType("int");

                    b.Property<long>("Edition")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Height")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Weight")
                        .HasColumnType("int");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DogID");

                    b.ToTable("Person");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("K9TB.Ribbon", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Edition")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Ribbon");
                });

            modelBuilder.Entity("K9TB.Run", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArmBand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClassLevel")
                        .HasColumnType("int");

                    b.Property<int>("ClassPlacing")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Edition")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExperienceLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Handler")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Judge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Qualifying")
                        .HasColumnType("bit");

                    b.Property<string>("Ring")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RingTime")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("RunTime")
                        .HasColumnType("time");

                    b.Property<float>("Score")
                        .HasColumnType("real");

                    b.Property<int?>("ShowEventID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("ShowEventID");

                    b.ToTable("Run");
                });

            modelBuilder.Entity("K9TB.ShowEvent", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<long>("Edition")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VenueID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("VenueID");

                    b.ToTable("ShowEvent");
                });

            modelBuilder.Entity("K9TB.Title", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Abbreviation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DogID")
                        .HasColumnType("int");

                    b.Property<long>("Edition")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Postfix")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("DogID");

                    b.ToTable("Title");
                });

            modelBuilder.Entity("K9TB.Venue", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Edition")
                        .HasColumnType("bigint");

                    b.Property<float>("Lat")
                        .HasColumnType("real");

                    b.Property<float>("Long")
                        .HasColumnType("real");

                    b.Property<string>("MapUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddr1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddr2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Venue");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("K9TB.Breeder", b =>
                {
                    b.HasBaseType("K9TB.Person");

                    b.Property<string>("KennelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LocationID")
                        .HasColumnType("int");

                    b.HasIndex("LocationID");

                    b.HasDiscriminator().HasValue("Breeder");
                });

            modelBuilder.Entity("K9TB.Dog", b =>
                {
                    b.HasOne("K9TB.Person", "Breeder")
                        .WithMany()
                        .HasForeignKey("BreederID");

                    b.HasOne("K9TB.Dog", "Dam")
                        .WithMany()
                        .HasForeignKey("DamId");

                    b.HasOne("K9TB.Dog", "Sire")
                        .WithMany()
                        .HasForeignKey("SireId");
                });

            modelBuilder.Entity("K9TB.Leg", b =>
                {
                    b.HasOne("K9TB.Title", null)
                        .WithMany("QualifyingLegs")
                        .HasForeignKey("TitleID");
                });

            modelBuilder.Entity("K9TB.MediaItem", b =>
                {
                    b.HasOne("K9TB.Dog", null)
                        .WithMany("MediaList")
                        .HasForeignKey("DogID");

                    b.HasOne("K9TB.Person", null)
                        .WithMany("MediaList")
                        .HasForeignKey("PersonID");

                    b.HasOne("K9TB.Ribbon", null)
                        .WithMany("MediaList")
                        .HasForeignKey("RibbonID");

                    b.HasOne("K9TB.Run", null)
                        .WithMany("MediaList")
                        .HasForeignKey("RunID");

                    b.HasOne("K9TB.ShowEvent", null)
                        .WithMany("MediaList")
                        .HasForeignKey("ShowEventID");

                    b.HasOne("K9TB.Venue", null)
                        .WithMany("MediaList")
                        .HasForeignKey("VenueID");
                });

            modelBuilder.Entity("K9TB.Person", b =>
                {
                    b.HasOne("K9TB.Dog", null)
                        .WithMany("OwnerList")
                        .HasForeignKey("DogID");
                });

            modelBuilder.Entity("K9TB.Run", b =>
                {
                    b.HasOne("K9TB.ShowEvent", "ShowEvent")
                        .WithMany()
                        .HasForeignKey("ShowEventID");
                });

            modelBuilder.Entity("K9TB.ShowEvent", b =>
                {
                    b.HasOne("K9TB.Venue", "Venue")
                        .WithMany()
                        .HasForeignKey("VenueID");
                });

            modelBuilder.Entity("K9TB.Title", b =>
                {
                    b.HasOne("K9TB.Dog", null)
                        .WithMany("TitleList")
                        .HasForeignKey("DogID");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("K9TB.Breeder", b =>
                {
                    b.HasOne("K9TB.Venue", "Location")
                        .WithMany()
                        .HasForeignKey("LocationID");
                });
#pragma warning restore 612, 618
        }
    }
}