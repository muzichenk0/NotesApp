﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Notes.Db;

#nullable disable

namespace Notes.Db.Migrations
{
    [DbContext(typeof(NotesDbContext))]
    partial class NotesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Notes.Models.DbModels.Record", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("recordCreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("recordInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("recordName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("recordType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("recordsTable");

                    b.HasData(
                        new
                        {
                            id = 1,
                            recordCreationTime = new DateTime(2023, 5, 24, 23, 54, 54, 684, DateTimeKind.Local).AddTicks(9501),
                            recordInfo = "someText",
                            recordName = "first",
                            recordType = "defaultNote"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
