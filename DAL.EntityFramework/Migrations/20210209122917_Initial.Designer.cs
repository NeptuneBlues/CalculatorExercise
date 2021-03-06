﻿// <auto-generated />
using DAL.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.EntityFramework.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210209122917_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("DAL.EntityFramework.Entities.Calculation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Error")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FirstInput")
                        .HasColumnType("int");

                    b.Property<string>("Operator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Result")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SecondInput")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Calculations");
                });
#pragma warning restore 612, 618
        }
    }
}
