﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetCoreRestMySql.models;

namespace NetCoreRestMySql.Migrations
{
    [DbContext(typeof(WeatherApiDbContext))]
    partial class WeatherApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NetCoreRestMySql.models.WeatherDataPoint", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Summary")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float>("TempC")
                        .HasColumnType("float");

                    b.Property<float>("TempF")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("WeatherDataPoint");
                });
#pragma warning restore 612, 618
        }
    }
}
