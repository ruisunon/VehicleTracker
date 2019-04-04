﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VehicleTracker.VehicleData.Infra.Data.Context;

namespace VehicleTracker.VehicleData.Infra.Data.Migrations
{
    [DbContext(typeof(VehicleDataContext))]
    partial class VehicleDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VehicleTracker.VehicleData.Domain.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<string>("Address");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("10000a0b-ddd6-44c0-8f19-963e5ca783dd"),
                            Address = "Cementvägen 8, 111 11 Södertälje",
                            Name = "Kalles Grustransporter AB"
                        },
                        new
                        {
                            Id = new Guid("20000a0b-ddd6-44c0-8f19-963e5ca783dd"),
                            Address = "Balkvägen 12, 222 22 Stockholm ",
                            Name = "Johans Bulk AB  "
                        },
                        new
                        {
                            Id = new Guid("30000a0b-ddd6-44c0-8f19-963e5ca783dd"),
                            Address = "Budgetvägen 1, 333 33 Uppsala",
                            Name = "Haralds Värdetransporter AB"
                        });
                });

            modelBuilder.Entity("VehicleTracker.VehicleData.Domain.Models.Vehicle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CustomerId");

                    b.Property<string>("RegNumber");

                    b.Property<string>("VehicleId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Vehicles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("40000a0b-ddd6-44c0-8f19-963e5ca783dd"),
                            CustomerId = new Guid("10000a0b-ddd6-44c0-8f19-963e5ca783dd"),
                            RegNumber = "ABC123",
                            VehicleId = "YS2R4X20005399401"
                        },
                        new
                        {
                            Id = new Guid("50000a0b-ddd6-44c0-8f19-963e5ca783dd"),
                            CustomerId = new Guid("10000a0b-ddd6-44c0-8f19-963e5ca783dd"),
                            RegNumber = "DEF456",
                            VehicleId = "VLUR4X20009093588"
                        },
                        new
                        {
                            Id = new Guid("60000a0b-ddd6-44c0-8f19-963e5ca783dd"),
                            CustomerId = new Guid("10000a0b-ddd6-44c0-8f19-963e5ca783dd"),
                            RegNumber = "GHI789",
                            VehicleId = "VLUR4X20009048066"
                        },
                        new
                        {
                            Id = new Guid("70000a0b-ddd6-44c0-8f19-963e5ca783dd"),
                            CustomerId = new Guid("20000a0b-ddd6-44c0-8f19-963e5ca783dd"),
                            RegNumber = "JKL012",
                            VehicleId = "YS2R4X20005388011"
                        },
                        new
                        {
                            Id = new Guid("80000a0b-ddd6-44c0-8f19-963e5ca783dd"),
                            CustomerId = new Guid("20000a0b-ddd6-44c0-8f19-963e5ca783dd"),
                            RegNumber = "MNO345",
                            VehicleId = "YS2R4X20005387949"
                        },
                        new
                        {
                            Id = new Guid("90000a0b-ddd6-44c0-8f19-963e5ca783dd"),
                            CustomerId = new Guid("30000a0b-ddd6-44c0-8f19-963e5ca783dd"),
                            RegNumber = "PQR678",
                            VehicleId = "VLUR4X20009048066"
                        },
                        new
                        {
                            Id = new Guid("01000a0b-ddd6-44c0-8f19-963e5ca783dd"),
                            CustomerId = new Guid("30000a0b-ddd6-44c0-8f19-963e5ca783dd"),
                            RegNumber = "STU901",
                            VehicleId = "YS2R4X20005387055"
                        });
                });

            modelBuilder.Entity("VehicleTracker.VehicleData.Domain.Models.Vehicle", b =>
                {
                    b.HasOne("VehicleTracker.VehicleData.Domain.Models.Customer", "Customer")
                        .WithMany("Vehicles")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
