﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using TDSKP.API.Infrastructure.Contexts;

#nullable disable

namespace TDSKP.API.Migrations
{
    [DbContext(typeof(PhotosContext))]
    [Migration("20250310144237_photos")]
    partial class photos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TDSKP.API.Infrastructure.Persistence.Photo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("RAW(16)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("Photos", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
