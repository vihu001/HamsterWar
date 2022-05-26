﻿// <auto-generated />
using System;
using HamsterApp.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HamsterApp.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220524222217_FirstSeedingOfHamstersToDB")]
    partial class FirstSeedingOfHamstersToDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HamsterApp.Entities.Models.ApiUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "e7eabebd-e10c-4da9-b6aa-2db9cad6b84d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fe5a2197-03b0-4c40-91f7-5025506231ce",
                            Email = "admin@hamsters.com",
                            EmailConfirmed = false,
                            FirstName = "System",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@HAMSTERS.COM",
                            NormalizedUserName = "ADMIN@HAMSTERS.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEL78kr0r7ScxChi0JIjHEL7IbgCC9f0FqhVHGcUYJZPfXEoOLlKUg+42howftcR6tQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "109572bd-fa75-4e83-9244-ee8256647b8d",
                            TwoFactorEnabled = false,
                            UserName = "admin@hamsters.com"
                        },
                        new
                        {
                            Id = "087f2124-f507-4642-a8f7-84442abb3d70",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "938fbba7-1382-4e86-a466-7b35f8a854f3",
                            Email = "user@hamsters.com",
                            EmailConfirmed = false,
                            FirstName = "System",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@HAMSTERS.COM",
                            NormalizedUserName = "USER@HAMSTERS.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEE7cBHZxWSf7vXL3X0Ii8fRE0r2+EbX2/UbTkSEqHS38Jvrffiikg1H+DaoHXxcfOg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6ec78a6d-535c-402b-a0bf-6c649d2c46fe",
                            TwoFactorEnabled = false,
                            UserName = "user@hamsters.com"
                        });
                });

            modelBuilder.Entity("HamsterApp.Entities.Models.Hamster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FavFood")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Games")
                        .HasColumnType("int");

                    b.Property<string>("ImgName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Losses")
                        .HasColumnType("int");

                    b.Property<string>("Loves")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Wins")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Hamsters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 2,
                            FavFood = "Eating1",
                            Games = 0,
                            ImgName = "",
                            Losses = 0,
                            Loves = "Losing1",
                            Name = "Hamster1",
                            Wins = 0
                        },
                        new
                        {
                            Id = 2,
                            Age = 3,
                            FavFood = "Eating2",
                            Games = 0,
                            ImgName = "",
                            Losses = 0,
                            Loves = "Losing2",
                            Name = "Hamster2",
                            Wins = 0
                        },
                        new
                        {
                            Id = 3,
                            Age = 2,
                            FavFood = "Eating3",
                            Games = 0,
                            ImgName = "",
                            Losses = 0,
                            Loves = "Losing3",
                            Name = "Hamster3",
                            Wins = 0
                        },
                        new
                        {
                            Id = 4,
                            Age = 1,
                            FavFood = "Eating4",
                            Games = 0,
                            ImgName = "",
                            Losses = 0,
                            Loves = "Losing4",
                            Name = "Hamster4",
                            Wins = 0
                        },
                        new
                        {
                            Id = 5,
                            Age = 2,
                            FavFood = "Eating5",
                            Games = 0,
                            ImgName = "",
                            Losses = 0,
                            Loves = "Losing5",
                            Name = "Hamster5",
                            Wins = 0
                        },
                        new
                        {
                            Id = 6,
                            Age = 2,
                            FavFood = "Eating6",
                            Games = 0,
                            ImgName = "",
                            Losses = 0,
                            Loves = "Losing6",
                            Name = "Hamster6",
                            Wins = 0
                        },
                        new
                        {
                            Id = 7,
                            Age = 3,
                            FavFood = "Eating7",
                            Games = 0,
                            ImgName = "",
                            Losses = 0,
                            Loves = "Losing7",
                            Name = "Hamster7",
                            Wins = 0
                        },
                        new
                        {
                            Id = 8,
                            Age = 2,
                            FavFood = "Eating8",
                            Games = 0,
                            ImgName = "",
                            Losses = 0,
                            Loves = "Losing8",
                            Name = "Hamster8",
                            Wins = 0
                        },
                        new
                        {
                            Id = 9,
                            Age = 1,
                            FavFood = "Eating9",
                            Games = 0,
                            ImgName = "",
                            Losses = 0,
                            Loves = "Losing9",
                            Name = "Hamster9",
                            Wins = 0
                        },
                        new
                        {
                            Id = 10,
                            Age = 2,
                            FavFood = "Eating10",
                            Games = 0,
                            ImgName = "",
                            Losses = 0,
                            Loves = "Losing10",
                            Name = "Hamster10",
                            Wins = 0
                        },
                        new
                        {
                            Id = 11,
                            Age = 3,
                            FavFood = "Eating11",
                            Games = 0,
                            ImgName = "",
                            Losses = 0,
                            Loves = "Losing11",
                            Name = "Hamster11",
                            Wins = 0
                        },
                        new
                        {
                            Id = 12,
                            Age = 2,
                            FavFood = "Eating12",
                            Games = 0,
                            ImgName = "",
                            Losses = 0,
                            Loves = "Losing12",
                            Name = "Hamster12",
                            Wins = 0
                        },
                        new
                        {
                            Id = 13,
                            Age = 3,
                            FavFood = "Eating13",
                            Games = 0,
                            ImgName = "",
                            Losses = 0,
                            Loves = "Losing13",
                            Name = "Hamster13",
                            Wins = 0
                        },
                        new
                        {
                            Id = 14,
                            Age = 1,
                            FavFood = "Eating14",
                            Games = 0,
                            ImgName = "",
                            Losses = 0,
                            Loves = "Losing14",
                            Name = "Hamster14",
                            Wins = 0
                        },
                        new
                        {
                            Id = 15,
                            Age = 1,
                            FavFood = "Eating15",
                            Games = 0,
                            ImgName = "",
                            Losses = 0,
                            Loves = "Losing15",
                            Name = "Hamster15",
                            Wins = 0
                        },
                        new
                        {
                            Id = 16,
                            Age = 3,
                            FavFood = "Eating16",
                            Games = 0,
                            ImgName = "",
                            Losses = 0,
                            Loves = "Losing16",
                            Name = "Hamster16",
                            Wins = 0
                        });
                });

            modelBuilder.Entity("HamsterApp.Entities.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("HamsterId")
                        .HasColumnType("int");

                    b.Property<int>("LoseId")
                        .HasColumnType("int");

                    b.Property<int>("WinId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HamsterId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "3845d87b-b230-41ff-a1a7-84bbd7ec821d",
                            ConcurrencyStamp = "9dd64476-1bfc-49ca-85c0-5cec51d429d8",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "985f4930-21ad-4249-abaf-e4251b1553d9",
                            ConcurrencyStamp = "2174ada1-575b-4a25-9e65-39199ac7ff91",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "087f2124-f507-4642-a8f7-84442abb3d70",
                            RoleId = "3845d87b-b230-41ff-a1a7-84bbd7ec821d"
                        },
                        new
                        {
                            UserId = "e7eabebd-e10c-4da9-b6aa-2db9cad6b84d",
                            RoleId = "985f4930-21ad-4249-abaf-e4251b1553d9"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("HamsterApp.Entities.Models.Match", b =>
                {
                    b.HasOne("HamsterApp.Entities.Models.Hamster", "Hamster")
                        .WithMany("Matches")
                        .HasForeignKey("HamsterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hamster");
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
                    b.HasOne("HamsterApp.Entities.Models.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HamsterApp.Entities.Models.ApiUser", null)
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

                    b.HasOne("HamsterApp.Entities.Models.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HamsterApp.Entities.Models.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HamsterApp.Entities.Models.Hamster", b =>
                {
                    b.Navigation("Matches");
                });
#pragma warning restore 612, 618
        }
    }
}