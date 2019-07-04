﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UrbanEngine.Infrastructure.Persistence.Data;

namespace UrbanEngine.Infrastructure.Persistence.Data.Migrations
{
    [DbContext(typeof(UrbanEngineDbContext))]
    partial class UrbanEngineDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("ue")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("UrbanEngine.Core.Application.Entities.ScheduleAggregate.Event", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateCreated")
                        .IsRequired();

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<DateTime?>("EndDate");

                    b.Property<int>("EventType");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("OrganizerId");

                    b.Property<DateTime?>("StartDate");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<long?>("VenueId");

                    b.HasKey("Id");

                    b.HasIndex("VenueId");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("UrbanEngine.Core.Application.Entities.ScheduleAggregate.EventVenue", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(100);

                    b.Property<string>("Address2")
                        .HasMaxLength(100);

                    b.Property<string>("City")
                        .HasMaxLength(75);

                    b.Property<string>("Country")
                        .HasMaxLength(75);

                    b.Property<DateTime?>("DateCreated")
                        .IsRequired();

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("PostalCode")
                        .HasMaxLength(30);

                    b.Property<int?>("Region");

                    b.Property<string>("State")
                        .HasMaxLength(75);

                    b.HasKey("Id");

                    b.ToTable("Venue");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Address = "3001 9th Avenue Southwest",
                            City = "Huntsville",
                            Country = "United States",
                            DateCreated = new DateTime(2019, 7, 4, 13, 36, 30, 837, DateTimeKind.Local).AddTicks(7132),
                            IsDeleted = false,
                            Name = "Huntsville West",
                            PostalCode = "35805",
                            Region = 1,
                            State = "AL"
                        });
                });

            modelBuilder.Entity("UrbanEngine.Core.Application.Entities.ScheduleAggregate.Event", b =>
                {
                    b.HasOne("UrbanEngine.Core.Application.Entities.ScheduleAggregate.EventVenue", "Venue")
                        .WithMany("Events")
                        .HasForeignKey("VenueId");
                });
#pragma warning restore 612, 618
        }
    }
}
