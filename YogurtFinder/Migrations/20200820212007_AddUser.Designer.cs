﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YogurtFinder.Models;

namespace YogurtFinder.Migrations
{
    [DbContext(typeof(YogurtFinderContext))]
    [Migration("20200820212007_AddUser")]
    partial class AddUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("YogurtFinder.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("Token");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("YogurtFinder.Models.Yogurt", b =>
                {
                    b.Property<int>("YogurtId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Blended");

                    b.Property<string>("Brand")
                        .IsRequired();

                    b.Property<int>("Calories");

                    b.Property<int>("Carbs");

                    b.Property<int>("Fat");

                    b.Property<string>("Flavor")
                        .IsRequired();

                    b.Property<int>("Protein");

                    b.Property<int>("Sugar");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("YogurtId");

                    b.ToTable("Yogurts");

                    b.HasData(
                        new
                        {
                            YogurtId = 1,
                            Blended = false,
                            Brand = "Ellenos",
                            Calories = 360,
                            Carbs = 38,
                            Fat = 17,
                            Flavor = "key lime",
                            Protein = 16,
                            Sugar = 30,
                            Type = "greek"
                        },
                        new
                        {
                            YogurtId = 2,
                            Blended = false,
                            Brand = "Brown Cow",
                            Calories = 130,
                            Carbs = 11,
                            Fat = 3,
                            Flavor = "plain",
                            Protein = 8,
                            Sugar = 7,
                            Type = "cream top"
                        },
                        new
                        {
                            YogurtId = 3,
                            Blended = true,
                            Brand = "Siggi",
                            Calories = 140,
                            Carbs = 11,
                            Fat = 5,
                            Flavor = "coffee",
                            Protein = 13,
                            Sugar = 8,
                            Type = "icelandic"
                        },
                        new
                        {
                            YogurtId = 4,
                            Blended = false,
                            Brand = "CoCoYo",
                            Calories = 90,
                            Carbs = 8,
                            Fat = 6,
                            Flavor = "vanilla",
                            Protein = 1,
                            Sugar = 2,
                            Type = "dairy free"
                        },
                        new
                        {
                            YogurtId = 5,
                            Blended = false,
                            Brand = "Chobani Flip",
                            Calories = 190,
                            Carbs = 24,
                            Fat = 5,
                            Flavor = "cookie dough",
                            Protein = 11,
                            Sugar = 21,
                            Type = "dessert, greek"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
