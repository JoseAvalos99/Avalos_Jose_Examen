﻿// <auto-generated />
using Avalos_Jose_Examen.Model.Enums;
using Avalos_Jose_Examen.Repository.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Avalos_Jose_Examen.Repository.Migrations
{
    [DbContext(typeof(DataDbContext))]
    [Migration("20191024013404_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Avalos_Jose_Examen.Model.Model.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Mesagge")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("Avalos_Jose_Examen.Model.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Gender")
                        .HasMaxLength(10);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<int?>("YearsOld");

                    b.HasKey("Id");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}