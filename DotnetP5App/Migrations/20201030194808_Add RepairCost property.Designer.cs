﻿// <auto-generated />
using System;
using DotnetP5App.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DotnetP5App.Migrations
{
    [DbContext(typeof(CarDBContext))]
    [Migration("20201030194808_Add RepairCost property")]
    partial class AddRepairCostproperty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DotnetP5App.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LotDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePicture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PurchasePrice")
                        .HasColumnType("int");

                    b.Property<string>("RepairCost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SaleDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SellingPrice")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Vin")
                        .HasColumnType("int");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("DotnetP5App.Models.FileModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Extension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UploadedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("FileModel");
                });

            modelBuilder.Entity("DotnetP5App.Models.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Profit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("SaleDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalCost")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("DotnetP5App.Models.RepairCar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CarId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("RepairCost")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("RepairCars");
                });

            modelBuilder.Entity("DotnetP5App.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("DotnetP5App.Services.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("DotnetP5App.Models.FileModel", b =>
                {
                    b.HasOne("DotnetP5App.Models.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DotnetP5App.Models.RepairCar", b =>
                {
                    b.HasOne("DotnetP5App.Models.Car", null)
                        .WithMany("Repairs")
                        .HasForeignKey("CarId");
                });

            modelBuilder.Entity("DotnetP5App.Services.Review", b =>
                {
                    b.HasOne("DotnetP5App.Models.Car", "Cars")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
