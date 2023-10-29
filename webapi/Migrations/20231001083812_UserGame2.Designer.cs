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
    [Migration("20231001083812_UserGame2")]
    partial class UserGame2
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

                    b.ToTable("Games");
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

            modelBuilder.Entity("webapi.Db.Entities.UserGame", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FailureMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("GameId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RegisteredUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Succeed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("RegisteredUserId");

                    b.ToTable("UserGames");
                });

            modelBuilder.Entity("webapi.Db.Entities.UserGame", b =>
                {
                    b.HasOne("webapi.Db.Entities.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webapi.Db.Entities.RegisteredUser", "RegisteredUser")
                        .WithMany()
                        .HasForeignKey("RegisteredUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("RegisteredUser");
                });
#pragma warning restore 612, 618
        }
    }
}
