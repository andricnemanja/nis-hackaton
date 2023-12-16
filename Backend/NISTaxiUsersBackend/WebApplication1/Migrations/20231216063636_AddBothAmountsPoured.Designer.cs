﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.DatabaseContext;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231216063636_AddBothAmountsPoured")]
    partial class AddBothAmountsPoured
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication1.Entities.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("AmountPouredFirst")
                        .HasColumnType("float");

                    b.Property<double>("AmountPouredSecond")
                        .HasColumnType("float");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DriverName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DriverStatus")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailNotification")
                        .HasColumnType("bit");

                    b.Property<int>("FuelCombinationId")
                        .HasColumnType("int");

                    b.Property<string>("NumberOfId")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<bool>("SMSNotification")
                        .HasColumnType("bit");

                    b.Property<string>("TaxiLicence")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.HasKey("Id");

                    b.HasIndex("FuelCombinationId");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("WebApplication1.Entities.Fuel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Fuels");
                });

            modelBuilder.Entity("WebApplication1.Entities.FuelCombination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Fuel1Id")
                        .HasColumnType("int");

                    b.Property<int?>("Fuel2Id")
                        .HasColumnType("int");

                    b.Property<double>("LimitFirstFuel")
                        .HasColumnType("float");

                    b.Property<double?>("LimitLastFuel")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Fuel1Id");

                    b.HasIndex("Fuel2Id");

                    b.ToTable("FuelCombinations");
                });

            modelBuilder.Entity("WebApplication1.Entities.TaxiTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DriverId")
                        .HasColumnType("int");

                    b.Property<int>("FuelId")
                        .HasColumnType("int");

                    b.Property<string>("PlaceOfTransaction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DriverId");

                    b.HasIndex("FuelId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("WebApplication1.Entities.Driver", b =>
                {
                    b.HasOne("WebApplication1.Entities.FuelCombination", "FuelCombination")
                        .WithMany()
                        .HasForeignKey("FuelCombinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FuelCombination");
                });

            modelBuilder.Entity("WebApplication1.Entities.FuelCombination", b =>
                {
                    b.HasOne("WebApplication1.Entities.Fuel", "Fuel1")
                        .WithMany()
                        .HasForeignKey("Fuel1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Entities.Fuel", "Fuel2")
                        .WithMany()
                        .HasForeignKey("Fuel2Id");

                    b.Navigation("Fuel1");

                    b.Navigation("Fuel2");
                });

            modelBuilder.Entity("WebApplication1.Entities.TaxiTransaction", b =>
                {
                    b.HasOne("WebApplication1.Entities.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Entities.Fuel", "Fuel")
                        .WithMany()
                        .HasForeignKey("FuelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Driver");

                    b.Navigation("Fuel");
                });
#pragma warning restore 612, 618
        }
    }
}
