﻿// <auto-generated />
using System;
using AirConditionStore.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AirConditionStore.DataAccess.Migrations
{
    [DbContext(typeof(AirConditionStoreContext))]
    [Migration("20220622082356_MistakeInBrandId")]
    partial class MistakeInBrandId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AirConditionStore.Domain.Entities.AirCondition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AirConditionTypeId")
                        .HasColumnType("int");

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int?>("CompressorId")
                        .HasColumnType("int");

                    b.Property<int>("IndoorUnitInstallationTypeId")
                        .HasColumnType("int");

                    b.Property<int>("OperationNegativeId")
                        .HasColumnType("int");

                    b.Property<int>("RoomArea")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AirConditionTypeId");

                    b.HasIndex("BrandId");

                    b.HasIndex("CompressorId");

                    b.HasIndex("IndoorUnitInstallationTypeId");

                    b.HasIndex("OperationNegativeId");

                    b.HasIndex("StatusId");

                    b.ToTable("AirConditions");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.AirConditionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AirConditionTypes");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.Capability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AirConditionId")
                        .HasColumnType("int");

                    b.Property<string>("function")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AirConditionId");

                    b.ToTable("Capabilities");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.Compressor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompressorType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Compressors");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.ControlType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AirConditionId")
                        .HasColumnType("int");

                    b.Property<string>("Control")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AirConditionId");

                    b.ToTable("ControlTypes");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.IndoorUnitInstallationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("InstallationType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("InstallationTypes");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.OperatingMode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AirConditionId")
                        .HasColumnType("int");

                    b.Property<string>("Mode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AirConditionId");

                    b.ToTable("OperatingModes");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.OperationNegativeTemperature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaxValueOfRange")
                        .HasColumnType("int");

                    b.Property<int>("MinValueOfRange")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AirConditionsTemperatures");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AirConditionId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AirConditionId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.ProducingCountry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AirConditionId")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AirConditionId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserRoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserRoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.UserInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UsersInformation");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameAlias")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.AirCondition", b =>
                {
                    b.HasOne("AirConditionStore.Domain.Entities.AirConditionType", "AirConditionType")
                        .WithMany("AirConditions")
                        .HasForeignKey("AirConditionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AirConditionStore.Domain.Entities.Brand", "Brand")
                        .WithMany("AirConditions")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AirConditionStore.Domain.Entities.Compressor", null)
                        .WithMany("AirConditions")
                        .HasForeignKey("CompressorId");

                    b.HasOne("AirConditionStore.Domain.Entities.IndoorUnitInstallationType", "IndoorUnitInstallationType")
                        .WithMany("AirConditions")
                        .HasForeignKey("IndoorUnitInstallationTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AirConditionStore.Domain.Entities.OperationNegativeTemperature", "OperationNegative")
                        .WithMany("AirConditions")
                        .HasForeignKey("OperationNegativeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AirConditionStore.Domain.Entities.Status", "Status")
                        .WithMany("AirConditions")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AirConditionType");

                    b.Navigation("Brand");

                    b.Navigation("IndoorUnitInstallationType");

                    b.Navigation("OperationNegative");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.Capability", b =>
                {
                    b.HasOne("AirConditionStore.Domain.Entities.AirCondition", "AirCondition")
                        .WithMany("Capabilities")
                        .HasForeignKey("AirConditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AirCondition");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.ControlType", b =>
                {
                    b.HasOne("AirConditionStore.Domain.Entities.AirCondition", "AirCondition")
                        .WithMany("ControlTypes")
                        .HasForeignKey("AirConditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AirCondition");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.OperatingMode", b =>
                {
                    b.HasOne("AirConditionStore.Domain.Entities.AirCondition", "AirCondition")
                        .WithMany("Modes")
                        .HasForeignKey("AirConditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AirCondition");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.Order", b =>
                {
                    b.HasOne("AirConditionStore.Domain.Entities.AirCondition", "AirCondition")
                        .WithMany("Orders")
                        .HasForeignKey("AirConditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AirCondition");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.ProducingCountry", b =>
                {
                    b.HasOne("AirConditionStore.Domain.Entities.AirCondition", "AirCondition")
                        .WithMany("Countries")
                        .HasForeignKey("AirConditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AirCondition");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.User", b =>
                {
                    b.HasOne("AirConditionStore.Domain.Entities.UserRole", "UserRole")
                        .WithMany("Users")
                        .HasForeignKey("UserRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserRole");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.UserInformation", b =>
                {
                    b.HasOne("AirConditionStore.Domain.Entities.User", "User")
                        .WithOne("Information")
                        .HasForeignKey("AirConditionStore.Domain.Entities.UserInformation", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.AirCondition", b =>
                {
                    b.Navigation("Capabilities");

                    b.Navigation("ControlTypes");

                    b.Navigation("Countries");

                    b.Navigation("Modes");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.AirConditionType", b =>
                {
                    b.Navigation("AirConditions");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.Brand", b =>
                {
                    b.Navigation("AirConditions");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.Compressor", b =>
                {
                    b.Navigation("AirConditions");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.IndoorUnitInstallationType", b =>
                {
                    b.Navigation("AirConditions");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.OperationNegativeTemperature", b =>
                {
                    b.Navigation("AirConditions");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.Status", b =>
                {
                    b.Navigation("AirConditions");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.User", b =>
                {
                    b.Navigation("Information");
                });

            modelBuilder.Entity("AirConditionStore.Domain.Entities.UserRole", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}