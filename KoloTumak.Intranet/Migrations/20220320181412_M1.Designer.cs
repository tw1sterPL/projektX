﻿// <auto-generated />
using System;
using KoloTumak.Intranet.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KoloTumak.Intranet.Migrations
{
    [DbContext(typeof(KoloTumakIntranetContext))]
    [Migration("20220320181412_M1")]
    partial class M1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("KoloTumak.Intranet.Models.CMS.EventsAllUser", b =>
                {
                    b.Property<int>("IdEvents")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEvents"), 1L, 1);

                    b.Property<int>("Contact")
                        .HasMaxLength(22)
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateStart")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("NameSurnameResponsiblePerson")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdEvents");

                    b.ToTable("EventsAllUser");
                });

            modelBuilder.Entity("KoloTumak.Intranet.Models.CMS.HuntersList", b =>
                {
                    b.Property<int>("IdHunters")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdHunters"), 1L, 1);

                    b.Property<int>("Contact")
                        .HasMaxLength(22)
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdHunters");

                    b.ToTable("HuntersList");
                });

            modelBuilder.Entity("KoloTumak.Intranet.Models.CMS.Main", b =>
                {
                    b.Property<int>("IdStrony")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdStrony"), 1L, 1);

                    b.Property<string>("Contents")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("LinkName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.HasKey("IdStrony");

                    b.ToTable("Main");
                });

            modelBuilder.Entity("KoloTumak.Intranet.Models.CMS.News", b =>
                {
                    b.Property<int>("IdNews")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdNews"), 1L, 1);

                    b.Property<string>("Contents")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<DateTime?>("DateStart")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("IdPosition")
                        .HasColumnType("int");

                    b.Property<string>("NameSurnameAdd")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdNews");

                    b.ToTable("News");
                });
#pragma warning restore 612, 618
        }
    }
}
