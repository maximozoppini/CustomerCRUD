﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleCRUD.Entities.DBContext;

#nullable disable

namespace Entities.Migrations
{
    [DbContext(typeof(CustomerAssestmentContext))]
    [Migration("20240909034635_20CustomerSeed")]
    partial class _20CustomerSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SimpleCRUD.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modify")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(18),
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            Modify = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(19)
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(25),
                            Email = "jane.smith@example.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            Modify = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(26)
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(31),
                            Email = "alice.johnson@example.com",
                            FirstName = "Alice",
                            LastName = "Johnson",
                            Modify = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(32)
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(35),
                            Email = "bob.williams@example.com",
                            FirstName = "Bob",
                            LastName = "Williams",
                            Modify = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(36)
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(40),
                            Email = "charlie.brown@example.com",
                            FirstName = "Charlie",
                            LastName = "Brown",
                            Modify = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(41)
                        },
                        new
                        {
                            Id = 6,
                            Created = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(45),
                            Email = "david.miller@example.com",
                            FirstName = "David",
                            LastName = "Miller",
                            Modify = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(46)
                        },
                        new
                        {
                            Id = 7,
                            Created = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(49),
                            Email = "emily.davis@example.com",
                            FirstName = "Emily",
                            LastName = "Davis",
                            Modify = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(50)
                        },
                        new
                        {
                            Id = 8,
                            Created = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(54),
                            Email = "frank.garcia@example.com",
                            FirstName = "Frank",
                            LastName = "Garcia",
                            Modify = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(55)
                        },
                        new
                        {
                            Id = 9,
                            Created = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(58),
                            Email = "grace.martinez@example.com",
                            FirstName = "Grace",
                            LastName = "Martinez",
                            Modify = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(59)
                        },
                        new
                        {
                            Id = 10,
                            Created = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(62),
                            Email = "henry.lopez@example.com",
                            FirstName = "Henry",
                            LastName = "Lopez",
                            Modify = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(63)
                        },
                        new
                        {
                            Id = 11,
                            Created = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(67),
                            Email = "irene.gonzalez@example.com",
                            FirstName = "Irene",
                            LastName = "Gonzalez",
                            Modify = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(68)
                        },
                        new
                        {
                            Id = 12,
                            Created = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(71),
                            Email = "jack.wilson@example.com",
                            FirstName = "Jack",
                            LastName = "Wilson",
                            Modify = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(72)
                        },
                        new
                        {
                            Id = 13,
                            Created = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(76),
                            Email = "karen.anderson@example.com",
                            FirstName = "Karen",
                            LastName = "Anderson",
                            Modify = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(77)
                        },
                        new
                        {
                            Id = 14,
                            Created = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(81),
                            Email = "liam.thomas@example.com",
                            FirstName = "Liam",
                            LastName = "Thomas",
                            Modify = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(82)
                        },
                        new
                        {
                            Id = 15,
                            Created = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(85),
                            Email = "mia.taylor@example.com",
                            FirstName = "Mia",
                            LastName = "Taylor",
                            Modify = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(85)
                        },
                        new
                        {
                            Id = 16,
                            Created = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(89),
                            Email = "nathan.moore@example.com",
                            FirstName = "Nathan",
                            LastName = "Moore",
                            Modify = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(90)
                        },
                        new
                        {
                            Id = 17,
                            Created = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(93),
                            Email = "olivia.jackson@example.com",
                            FirstName = "Olivia",
                            LastName = "Jackson",
                            Modify = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(94)
                        },
                        new
                        {
                            Id = 18,
                            Created = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(97),
                            Email = "paul.lee@example.com",
                            FirstName = "Paul",
                            LastName = "Lee",
                            Modify = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(98)
                        },
                        new
                        {
                            Id = 19,
                            Created = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(101),
                            Email = "quincy.harris@example.com",
                            FirstName = "Quincy",
                            LastName = "Harris",
                            Modify = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(102)
                        },
                        new
                        {
                            Id = 20,
                            Created = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(106),
                            Email = "rachel.clark@example.com",
                            FirstName = "Rachel",
                            LastName = "Clark",
                            Modify = new DateTime(2024, 9, 9, 3, 46, 35, 59, DateTimeKind.Utc).AddTicks(106)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
