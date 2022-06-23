﻿// <auto-generated />
using Buyer.Service.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Buyer.Service.Migrations
{
    [DbContext(typeof(BuyerApplicationDbContext))]
    partial class BuyerApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Buyer.Service.Entities.Buyer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Buyer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "ishi residencies",
                            City = "Colombo",
                            Contact = "1234567890",
                            Email = "binnie@gmail.com",
                            Name = "Binnie"
                        },
                        new
                        {
                            Id = 2,
                            Address = "lucas residencies",
                            City = "Sweden",
                            Contact = "12345675590",
                            Email = "lucas@gmail.com",
                            Name = "Lucas"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Casper residencies",
                            City = "Austrailia",
                            Contact = "12346675590",
                            Email = "casper@gmail.com",
                            Name = "Casper"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}