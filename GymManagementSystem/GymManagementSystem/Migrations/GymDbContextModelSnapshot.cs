﻿// <auto-generated />
using System;
using GymManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GymManagementSystem.Migrations
{
    [DbContext(typeof(GymDbContext))]
    partial class GymDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("GymManagementSystem.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("BirthDate");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender");

                    b.Property<float?>("Height");

                    b.Property<DateTime?>("JoinDate");

                    b.Property<string>("LastName");

                    b.Property<int>("MembershipId");

                    b.Property<string>("PhoneNumber");

                    b.Property<int>("ScheduleId");

                    b.Property<float?>("Weight");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("MembershipId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("GymManagementSystem.Models.Membership", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Duration");

                    b.Property<decimal?>("MembershipFee");

                    b.Property<string>("MembershipType");

                    b.HasKey("Id");

                    b.ToTable("Membership");
                });

            modelBuilder.Entity("GymManagementSystem.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Day");

                    b.Property<DateTime?>("EndTime");

                    b.Property<string>("ProgramName");

                    b.Property<DateTime?>("StartTime");

                    b.Property<int>("TrainerId");

                    b.HasKey("Id");

                    b.HasIndex("TrainerId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("GymManagementSystem.Models.Trainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("BirthDate");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender");

                    b.Property<string>("LastName");

                    b.Property<decimal?>("Salary");

                    b.Property<string>("Specialty");

                    b.Property<DateTime?>("StartDate");

                    b.HasKey("Id");

                    b.ToTable("Trainers");
                });

            modelBuilder.Entity("GymManagementSystem.Models.Customer", b =>
                {
                    b.HasOne("GymManagementSystem.Models.Membership", "Membership")
                        .WithMany()
                        .HasForeignKey("MembershipId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GymManagementSystem.Models.Schedule", "Schedule")
                        .WithMany()
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GymManagementSystem.Models.Schedule", b =>
                {
                    b.HasOne("GymManagementSystem.Models.Trainer", "Trainer")
                        .WithMany()
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
