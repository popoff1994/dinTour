﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dinTour.Models;

namespace dinTour.Migrations
{
    [DbContext(typeof(dinTourDbContext))]
    [Migration("20220511101924_dinTour")]
    partial class dinTour
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("dinTour.Models.Begivenhed", b =>
                {
                    b.Property<int>("BegivenhedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.HasKey("BegivenhedId");

                    b.ToTable("Begivenheder");
                });

            modelBuilder.Entity("dinTour.Models.Deltager", b =>
                {
                    b.Property<int>("DeltagerNr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tlf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeltagerNr");

                    b.ToTable("Deltagere");
                });

            modelBuilder.Entity("dinTour.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.HasKey("EventId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("dinTour.Models.Parkering", b =>
                {
                    b.Property<int>("ParkeringsNr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Ocupied")
                        .HasColumnType("bit");

                    b.Property<int>("Pris")
                        .HasColumnType("int");

                    b.HasKey("ParkeringsNr");

                    b.ToTable("Parkering");
                });
#pragma warning restore 612, 618
        }
    }
}