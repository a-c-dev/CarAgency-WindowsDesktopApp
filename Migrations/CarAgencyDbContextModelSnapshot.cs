﻿// <auto-generated />
using System;
using CarAgency_WindowsDesktopApp.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarAgency_WindowsDesktopApp.Migrations
{
    [DbContext(typeof(CarAgencyDbContext))]
    partial class CarAgencyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarAgency_WindowsDesktopApp.Entity.Model.CarModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid?>("EngineId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("InteriorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EngineId");

                    b.HasIndex("InteriorId");

                    b.ToTable("CarModels");
                });

            modelBuilder.Entity("CarAgency_WindowsDesktopApp.Entity.Model.CarStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long?>("KmsDriven")
                        .HasColumnType("bigint");

                    b.Property<Guid?>("OwnerTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly?>("Year")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("OwnerTypeId");

                    b.ToTable("CasrStatuses");
                });

            modelBuilder.Entity("CarAgency_WindowsDesktopApp.Entity.Model.Deal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CarModelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CarStatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DealerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long?>("Price")
                        .HasColumnType("bigint");

                    b.Property<Guid?>("SellerTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CarModelId");

                    b.HasIndex("CarStatusId");

                    b.HasIndex("DealerId");

                    b.HasIndex("SellerTypeId");

                    b.ToTable("Deals");
                });

            modelBuilder.Entity("CarAgency_WindowsDesktopApp.Entity.Model.Dealer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Appellation")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("Name")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Surname")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("Id");

                    b.ToTable("Dealers");
                });

            modelBuilder.Entity("CarAgency_WindowsDesktopApp.Entity.Model.Engine", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FuelTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("MaxPowerBhp")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal?>("MileageKmpl")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int?>("PowerCC")
                        .HasColumnType("int");

                    b.Property<long?>("TorqueNm")
                        .HasColumnType("bigint");

                    b.Property<long?>("TorqueRpmMax")
                        .HasColumnType("bigint");

                    b.Property<long?>("TorqueRpmMin")
                        .HasColumnType("bigint");

                    b.Property<Guid?>("TransmissionTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("FuelTypeId");

                    b.HasIndex("TransmissionTypeId");

                    b.ToTable("Engines");
                });

            modelBuilder.Entity("CarAgency_WindowsDesktopApp.Entity.Model.Enums.FuelType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("Id");

                    b.ToTable("FuelTypes");
                });

            modelBuilder.Entity("CarAgency_WindowsDesktopApp.Entity.Model.Enums.Interior", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("SeatsNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Interiors");
                });

            modelBuilder.Entity("CarAgency_WindowsDesktopApp.Entity.Model.Enums.OwnerType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("Id");

                    b.ToTable("OwnerTypes");
                });

            modelBuilder.Entity("CarAgency_WindowsDesktopApp.Entity.Model.Enums.SellerType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("Id");

                    b.ToTable("SellerTypes");
                });

            modelBuilder.Entity("CarAgency_WindowsDesktopApp.Entity.Model.Enums.TransmissionType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("Id");

                    b.ToTable("TransmissionTypes");
                });

            modelBuilder.Entity("CarAgency_WindowsDesktopApp.Entity.Model.CarModel", b =>
                {
                    b.HasOne("CarAgency_WindowsDesktopApp.Entity.Model.Engine", "Engine")
                        .WithMany()
                        .HasForeignKey("EngineId");

                    b.HasOne("CarAgency_WindowsDesktopApp.Entity.Model.Enums.Interior", "Interior")
                        .WithMany()
                        .HasForeignKey("InteriorId");

                    b.Navigation("Engine");

                    b.Navigation("Interior");
                });

            modelBuilder.Entity("CarAgency_WindowsDesktopApp.Entity.Model.CarStatus", b =>
                {
                    b.HasOne("CarAgency_WindowsDesktopApp.Entity.Model.Enums.OwnerType", "OwnerType")
                        .WithMany()
                        .HasForeignKey("OwnerTypeId");

                    b.Navigation("OwnerType");
                });

            modelBuilder.Entity("CarAgency_WindowsDesktopApp.Entity.Model.Deal", b =>
                {
                    b.HasOne("CarAgency_WindowsDesktopApp.Entity.Model.CarModel", "CarModel")
                        .WithMany()
                        .HasForeignKey("CarModelId");

                    b.HasOne("CarAgency_WindowsDesktopApp.Entity.Model.Enums.SellerType", "CarStatus")
                        .WithMany()
                        .HasForeignKey("CarStatusId");

                    b.HasOne("CarAgency_WindowsDesktopApp.Entity.Model.Dealer", "Dealer")
                        .WithMany()
                        .HasForeignKey("DealerId");

                    b.HasOne("CarAgency_WindowsDesktopApp.Entity.Model.Enums.SellerType", "SellerType")
                        .WithMany()
                        .HasForeignKey("SellerTypeId");

                    b.Navigation("CarModel");

                    b.Navigation("CarStatus");

                    b.Navigation("Dealer");

                    b.Navigation("SellerType");
                });

            modelBuilder.Entity("CarAgency_WindowsDesktopApp.Entity.Model.Engine", b =>
                {
                    b.HasOne("CarAgency_WindowsDesktopApp.Entity.Model.Enums.FuelType", "FuelType")
                        .WithMany()
                        .HasForeignKey("FuelTypeId");

                    b.HasOne("CarAgency_WindowsDesktopApp.Entity.Model.Enums.TransmissionType", "TransmissionType")
                        .WithMany()
                        .HasForeignKey("TransmissionTypeId");

                    b.Navigation("FuelType");

                    b.Navigation("TransmissionType");
                });
#pragma warning restore 612, 618
        }
    }
}
