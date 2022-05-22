﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dinTour.Models;

namespace dinTour.Migrations
{
    [DbContext(typeof(dinTourDbContext))]
    partial class dinTourDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Beskrivelse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Navn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("BegivenhedId");

                    b.HasIndex("EventId");

                    b.ToTable("Begivenheder");
                });

            modelBuilder.Entity("dinTour.Models.Bookning", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeltagerId")
                        .HasColumnType("int");

                    b.Property<int>("ParkeringId")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.HasIndex("DeltagerId");

                    b.HasIndex("ParkeringId");

                    b.ToTable("Booknings");
                });

            modelBuilder.Entity("dinTour.Models.Deltager", b =>
                {
                    b.Property<int>("DeltagerId")
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

                    b.HasKey("DeltagerId");

                    b.ToTable("Deltagere");
                });

            modelBuilder.Entity("dinTour.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Navn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("EventId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("dinTour.Models.Parkering", b =>
                {
                    b.Property<int>("ParkeringId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Ocupied")
                        .HasColumnType("bit");

                    b.Property<int>("Pris")
                        .HasColumnType("int");

                    b.HasKey("ParkeringId");

                    b.ToTable("Parkering");
                });

            modelBuilder.Entity("dinTour.Models.Tilkøb", b =>
                {
                    b.Property<int>("TlkøbId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("ChampagneMenu")
                        .HasColumnType("bit");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeltagerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VIPId")
                        .HasColumnType("int");

                    b.HasKey("TlkøbId");

                    b.HasIndex("DeltagerId");

                    b.HasIndex("VIPId");

                    b.ToTable("Tilkøb");
                });

            modelBuilder.Entity("dinTour.Models.VIP", b =>
                {
                    b.Property<int>("VIPId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Menu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pris")
                        .HasColumnType("int");

                    b.HasKey("VIPId");

                    b.ToTable("VIPs");
                });

            modelBuilder.Entity("dinTour.Models.Begivenhed", b =>
                {
                    b.HasOne("dinTour.Models.Event", null)
                        .WithMany("Begivenheder")
                        .HasForeignKey("EventId");
                });

            modelBuilder.Entity("dinTour.Models.Bookning", b =>
                {
                    b.HasOne("dinTour.Models.Deltager", "Deltager")
                        .WithMany("Bookning")
                        .HasForeignKey("DeltagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dinTour.Models.Parkering", "Parkering")
                        .WithMany()
                        .HasForeignKey("ParkeringId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Deltager");

                    b.Navigation("Parkering");
                });

            modelBuilder.Entity("dinTour.Models.Tilkøb", b =>
                {
                    b.HasOne("dinTour.Models.Deltager", "Deltager")
                        .WithMany("Tilkøb")
                        .HasForeignKey("DeltagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dinTour.Models.VIP", "Vip")
                        .WithMany()
                        .HasForeignKey("VIPId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Deltager");

                    b.Navigation("Vip");
                });

            modelBuilder.Entity("dinTour.Models.Deltager", b =>
                {
                    b.Navigation("Bookning");

                    b.Navigation("Tilkøb");
                });

            modelBuilder.Entity("dinTour.Models.Event", b =>
                {
                    b.Navigation("Begivenheder");
                });
#pragma warning restore 612, 618
        }
    }
}
