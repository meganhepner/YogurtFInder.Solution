﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Yogurt.Models;

namespace Yogurt.Migrations
{
    [DbContext(typeof(YogurtContext))]
    [Migration("20200817182314_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Yogurt.Models.Nutrition", b =>
                {
                    b.Property<int>("NutritionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Calories");

                    b.Property<string>("Carbs");

                    b.Property<string>("Fat");

                    b.Property<string>("Protein");

                    b.Property<string>("Sugar");

                    b.Property<int>("YogurtId");

                    b.HasKey("NutritionId");

                    b.ToTable("Nutrition");
                });

            modelBuilder.Entity("Yogurt.Models.Yogurt", b =>
                {
                    b.Property<int>("YogurtId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Blended");

                    b.Property<string>("Brand");

                    b.Property<string>("Flavor");

                    b.Property<int>("NutritionId");

                    b.Property<int?>("NutritionId1");

                    b.Property<string>("Type");

                    b.HasKey("YogurtId");

                    b.HasIndex("NutritionId1");

                    b.ToTable("Yogurts");
                });

            modelBuilder.Entity("Yogurt.Models.Yogurt", b =>
                {
                    b.HasOne("Yogurt.Models.Nutrition", "Nutrition")
                        .WithMany()
                        .HasForeignKey("NutritionId1");
                });
#pragma warning restore 612, 618
        }
    }
}
