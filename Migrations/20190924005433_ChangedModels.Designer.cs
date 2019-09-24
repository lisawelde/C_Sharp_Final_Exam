﻿// <auto-generated />
using System;
using BeltExam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BeltExam.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20190924005433_ChangedModels")]
    partial class ChangedModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BeltExam.Models.Join", b =>
                {
                    b.Property<int>("JoinId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("PlanId");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("UserId");

                    b.HasKey("JoinId");

                    b.HasIndex("PlanId");

                    b.HasIndex("UserId");

                    b.ToTable("Joins");
                });

            modelBuilder.Entity("BeltExam.Models.Plan", b =>
                {
                    b.Property<int>("PlanId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int>("Duration");

                    b.Property<int>("PlannerId");

                    b.Property<DateTime>("Time");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("UserId");

                    b.HasKey("PlanId");

                    b.HasIndex("PlannerId");

                    b.ToTable("Plans");
                });

            modelBuilder.Entity("BeltExam.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Password");

                    b.Property<int>("PlanId");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BeltExam.Models.Join", b =>
                {
                    b.HasOne("BeltExam.Models.Plan", "JoinedPlan")
                        .WithMany("AttendingUsers")
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BeltExam.Models.User", "Joiner")
                        .WithMany("AttendingPlans")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BeltExam.Models.Plan", b =>
                {
                    b.HasOne("BeltExam.Models.User", "Planner")
                        .WithMany("PlannedActivities")
                        .HasForeignKey("PlannerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
