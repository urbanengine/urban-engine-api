﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using UrbanEngine.Infrastructure.Data;

namespace UrbanEngine.Infrastructure.Data.Migrations
{
    [DbContext(typeof(UrbanEngineDbContext))]
    [Migration("20200228035910_AddRoomsEntity")]
    partial class AddRoomsEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("ue")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("UrbanEngine.Core.Entities.CheckInEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTimeOffset>("CheckedInAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateCreated")
                        .IsRequired()
                        .HasColumnType("timestamp without time zone");

                    b.Property<long?>("EventId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("CheckIn");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CheckedInAt = new DateTimeOffset(new DateTime(2020, 2, 27, 22, 59, 9, 982, DateTimeKind.Unspecified).AddTicks(5784), new TimeSpan(0, -5, 0, 0, 0)),
                            DateCreated = new DateTime(2020, 2, 27, 22, 59, 9, 982, DateTimeKind.Local).AddTicks(5097),
                            EventId = 1L,
                            IsDeleted = false,
                            UserId = 0L
                        });
                });

            modelBuilder.Entity("UrbanEngine.Core.Entities.EventEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("DateCreated")
                        .IsRequired()
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<DateTimeOffset?>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("EventType")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("OrganizerId")
                        .HasColumnType("text");

                    b.Property<long?>("RoomId")
                        .HasColumnType("bigint");

                    b.Property<DateTimeOffset?>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("VenueId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.HasIndex("VenueId");

                    b.ToTable("Event");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DateCreated = new DateTime(2020, 2, 27, 22, 59, 9, 981, DateTimeKind.Local).AddTicks(6540),
                            EndDate = new DateTimeOffset(new DateTime(2020, 2, 27, 22, 59, 9, 981, DateTimeKind.Unspecified).AddTicks(2571), new TimeSpan(0, -5, 0, 0, 0)),
                            EventType = 1,
                            IsDeleted = false,
                            Name = "show256",
                            RoomId = 4L,
                            StartDate = new DateTimeOffset(new DateTime(2020, 2, 27, 22, 59, 9, 981, DateTimeKind.Unspecified).AddTicks(2480), new TimeSpan(0, -5, 0, 0, 0)),
                            VenueId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            DateCreated = new DateTime(2020, 2, 27, 22, 59, 9, 982, DateTimeKind.Local).AddTicks(2159),
                            EndDate = new DateTimeOffset(new DateTime(2020, 2, 27, 22, 59, 9, 982, DateTimeKind.Unspecified).AddTicks(2130), new TimeSpan(0, -5, 0, 0, 0)),
                            EventType = 1,
                            IsDeleted = false,
                            Name = "Designer's Corner",
                            RoomId = 2L,
                            StartDate = new DateTimeOffset(new DateTime(2020, 2, 27, 22, 59, 9, 982, DateTimeKind.Unspecified).AddTicks(2116), new TimeSpan(0, -5, 0, 0, 0)),
                            VenueId = 1L
                        },
                        new
                        {
                            Id = 3L,
                            DateCreated = new DateTime(2020, 2, 27, 22, 59, 9, 982, DateTimeKind.Local).AddTicks(2250),
                            EndDate = new DateTimeOffset(new DateTime(2020, 2, 27, 22, 59, 9, 982, DateTimeKind.Unspecified).AddTicks(2246), new TimeSpan(0, -5, 0, 0, 0)),
                            EventType = 1,
                            IsDeleted = false,
                            Name = "Huntsville AI",
                            RoomId = 5L,
                            StartDate = new DateTimeOffset(new DateTime(2020, 2, 27, 22, 59, 9, 982, DateTimeKind.Unspecified).AddTicks(2243), new TimeSpan(0, -5, 0, 0, 0)),
                            VenueId = 1L
                        });
                });

            modelBuilder.Entity("UrbanEngine.Core.Entities.EventVenueEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Address2")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("City")
                        .HasColumnType("character varying(75)")
                        .HasMaxLength(75);

                    b.Property<string>("Country")
                        .HasColumnType("character varying(75)")
                        .HasMaxLength(75);

                    b.Property<DateTime?>("DateCreated")
                        .IsRequired()
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string>("PostalCode")
                        .HasColumnType("character varying(30)")
                        .HasMaxLength(30);

                    b.Property<int?>("Region")
                        .HasColumnType("integer");

                    b.Property<string>("State")
                        .HasColumnType("character varying(75)")
                        .HasMaxLength(75);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Venue");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Address = "3001 9th Avenue Southwest",
                            City = "Huntsville",
                            Country = "United States",
                            DateCreated = new DateTime(2020, 2, 27, 22, 59, 9, 974, DateTimeKind.Local).AddTicks(9153),
                            IsAvailable = false,
                            IsDeleted = false,
                            Name = "Huntsville West",
                            PostalCode = "35805",
                            Region = 1,
                            State = "AL"
                        });
                });

            modelBuilder.Entity("UrbanEngine.Core.Entities.RoomEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("Capacity")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("DateCreated")
                        .IsRequired()
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<bool?>("HasTVOrProjector")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Resources")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<long?>("VenueId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("VenueId");

                    b.ToTable("Room");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DateCreated = new DateTime(2020, 2, 27, 22, 59, 9, 983, DateTimeKind.Local).AddTicks(1999),
                            Description = "Cafe Conference Room",
                            HasTVOrProjector = true,
                            IsDeleted = false,
                            Name = "Cafe Conference Room",
                            VenueId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            DateCreated = new DateTime(2020, 2, 27, 22, 59, 9, 983, DateTimeKind.Local).AddTicks(6174),
                            Description = "Front Conference Room",
                            HasTVOrProjector = true,
                            IsDeleted = false,
                            Name = "Front Conference Room",
                            VenueId = 1L
                        },
                        new
                        {
                            Id = 3L,
                            DateCreated = new DateTime(2020, 2, 27, 22, 59, 9, 983, DateTimeKind.Local).AddTicks(6246),
                            Description = "Corner Conference Room",
                            HasTVOrProjector = true,
                            IsDeleted = false,
                            Name = "Corner Conference Room",
                            VenueId = 1L
                        },
                        new
                        {
                            Id = 4L,
                            DateCreated = new DateTime(2020, 2, 27, 22, 59, 9, 983, DateTimeKind.Local).AddTicks(6251),
                            Description = "Library",
                            HasTVOrProjector = false,
                            IsDeleted = false,
                            Name = "Library",
                            VenueId = 1L
                        },
                        new
                        {
                            Id = 5L,
                            DateCreated = new DateTime(2020, 2, 27, 22, 59, 9, 983, DateTimeKind.Local).AddTicks(6253),
                            Description = "Training Room",
                            HasTVOrProjector = true,
                            IsDeleted = false,
                            Name = "Training Room",
                            VenueId = 1L
                        });
                });

            modelBuilder.Entity("UrbanEngine.Core.Entities.CheckInEntity", b =>
                {
                    b.HasOne("UrbanEngine.Core.Entities.EventEntity", "Event")
                        .WithMany("CheckIns")
                        .HasForeignKey("EventId");
                });

            modelBuilder.Entity("UrbanEngine.Core.Entities.EventEntity", b =>
                {
                    b.HasOne("UrbanEngine.Core.Entities.RoomEntity", "Room")
                        .WithMany("Events")
                        .HasForeignKey("RoomId");

                    b.HasOne("UrbanEngine.Core.Entities.EventVenueEntity", "Venue")
                        .WithMany("Events")
                        .HasForeignKey("VenueId");
                });

            modelBuilder.Entity("UrbanEngine.Core.Entities.RoomEntity", b =>
                {
                    b.HasOne("UrbanEngine.Core.Entities.EventVenueEntity", "Venue")
                        .WithMany("Rooms")
                        .HasForeignKey("VenueId");
                });
#pragma warning restore 612, 618
        }
    }
}
