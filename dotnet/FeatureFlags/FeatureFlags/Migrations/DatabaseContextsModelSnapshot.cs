﻿// <auto-generated />
using System;
using FeatureFlags.Models.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FeatureFlags.Migrations
{
    [DbContext(typeof(DatabaseContexts))]
    partial class DatabaseContextsModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7");

            modelBuilder.Entity("FeatureFlags.Models.Constraint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Operator")
                        .HasColumnType("TEXT");

                    b.Property<string>("Property")
                        .HasColumnType("TEXT");

                    b.Property<int?>("SegmentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SegmentId");

                    b.ToTable("Constraint");
                });

            modelBuilder.Entity("FeatureFlags.Models.FeatureFlag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<bool>("DataRecordsEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Enabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EntityType")
                        .HasColumnType("TEXT");

                    b.Property<string>("Key")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FeatureFlags");
                });

            modelBuilder.Entity("FeatureFlags.Models.FeatureFlagUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsLoggedIn")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FeatureFlagUsers");
                });

            modelBuilder.Entity("FeatureFlags.Models.Segment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FeatureFlagId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Rank")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RolloutPercent")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FeatureFlagId");

                    b.ToTable("Segments");
                });

            modelBuilder.Entity("FeatureFlags.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FeatureFlagId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FeatureFlagId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("FeatureFlags.Models.Variant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FeatureFlagId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Key")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FeatureFlagId");

                    b.ToTable("Variants");
                });

            modelBuilder.Entity("FeatureFlags.Models.Constraint", b =>
                {
                    b.HasOne("FeatureFlags.Models.Segment", null)
                        .WithMany("Constraints")
                        .HasForeignKey("SegmentId");
                });

            modelBuilder.Entity("FeatureFlags.Models.Segment", b =>
                {
                    b.HasOne("FeatureFlags.Models.FeatureFlag", null)
                        .WithMany("Segments")
                        .HasForeignKey("FeatureFlagId");
                });

            modelBuilder.Entity("FeatureFlags.Models.Tag", b =>
                {
                    b.HasOne("FeatureFlags.Models.FeatureFlag", null)
                        .WithMany("Tags")
                        .HasForeignKey("FeatureFlagId");
                });

            modelBuilder.Entity("FeatureFlags.Models.Variant", b =>
                {
                    b.HasOne("FeatureFlags.Models.FeatureFlag", null)
                        .WithMany("Variants")
                        .HasForeignKey("FeatureFlagId");
                });
#pragma warning restore 612, 618
        }
    }
}
