﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Phonebook.Server.Data;

#nullable disable

namespace Phonebook.Server.Migrations
{
    [DbContext(typeof(PhonebookContext))]
    partial class PhonebookContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AddressPerson", b =>
                {
                    b.Property<int>("AddressesAddressId")
                        .HasColumnType("int");

                    b.Property<int>("PersonsPersonid")
                        .HasColumnType("int");

                    b.HasKey("AddressesAddressId", "PersonsPersonid");

                    b.HasIndex("PersonsPersonid");

                    b.ToTable("AddressPerson");
                });

            modelBuilder.Entity("Phonebook.Server.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"), 1L, 1);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("PersonId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("AddressId");

                    b.HasIndex("CityId");

                    b.ToTable("addresses");
                });

            modelBuilder.Entity("Phonebook.Server.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.Property<string>("pozivni")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("cities");
                });

            modelBuilder.Entity("Phonebook.Server.Models.Person", b =>
                {
                    b.Property<int>("Personid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Personid"), 1L, 1);

                    b.Property<string>("lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Personid");

                    b.ToTable("persons");
                });

            modelBuilder.Entity("Phonebook.Server.Models.PersonalData", b =>
                {
                    b.Property<int>("PersonalDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonalDataId"), 1L, 1);

                    b.Property<int>("PersonID")
                        .HasColumnType("int");

                    b.Property<string>("oib")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonalDataId");

                    b.HasIndex("PersonID")
                        .IsUnique();

                    b.ToTable("PersonalDatas");
                });

            modelBuilder.Entity("AddressPerson", b =>
                {
                    b.HasOne("Phonebook.Server.Models.Address", null)
                        .WithMany()
                        .HasForeignKey("AddressesAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Phonebook.Server.Models.Person", null)
                        .WithMany()
                        .HasForeignKey("PersonsPersonid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Phonebook.Server.Models.Address", b =>
                {
                    b.HasOne("Phonebook.Server.Models.City", "City")
                        .WithMany("Addresses")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Phonebook.Server.Models.PersonalData", b =>
                {
                    b.HasOne("Phonebook.Server.Models.Person", "Person")
                        .WithOne("PersonalData")
                        .HasForeignKey("Phonebook.Server.Models.PersonalData", "PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Phonebook.Server.Models.City", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("Phonebook.Server.Models.Person", b =>
                {
                    b.Navigation("PersonalData")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
