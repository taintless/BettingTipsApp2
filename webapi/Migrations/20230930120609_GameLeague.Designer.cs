﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapi.Db;

#nullable disable

namespace webapi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230930120609_GameLeague")]
    partial class GameLeague
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("webapi.Db.Entities.Game", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("GameTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("League")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Team1Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Team2Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamToBet")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("webapi.Db.Entities.RegisteredUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegsisteredOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("RegisteredUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
