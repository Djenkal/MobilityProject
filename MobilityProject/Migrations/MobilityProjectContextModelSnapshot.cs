﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using MobilityProject.Models;
using System;

namespace MobilityProject.Migrations
{
    [DbContext(typeof(MobilityProjectContext))]
    partial class MobilityProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MobilityProject.Models.Building", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("Building");
                });

            modelBuilder.Entity("MobilityProject.Models.Room", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BuildingID");

                    b.Property<string>("Title")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.HasIndex("BuildingID");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("MobilityProject.Models.Room", b =>
                {
                    b.HasOne("MobilityProject.Models.Building", "Building")
                        .WithMany("Rooms")
                        .HasForeignKey("BuildingID");
                });
#pragma warning restore 612, 618
        }
    }
}
