﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestAPI_Server.Data;

namespace RestAPI_Server.Migrations
{
    [DbContext(typeof(ChartContext))]
    [Migration("20200512071332_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RestAPI_Server.Models.Chart", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlarmMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Val01")
                        .HasColumnType("float");

                    b.Property<double>("Val02")
                        .HasColumnType("float");

                    b.Property<double>("Val03")
                        .HasColumnType("float");

                    b.Property<double>("Val04")
                        .HasColumnType("float");

                    b.Property<double>("Val05")
                        .HasColumnType("float");

                    b.Property<double>("Val06")
                        .HasColumnType("float");

                    b.Property<double>("Val07")
                        .HasColumnType("float");

                    b.Property<double>("Val08")
                        .HasColumnType("float");

                    b.Property<double>("Val09")
                        .HasColumnType("float");

                    b.Property<double>("Val10")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Charts");
                });
#pragma warning restore 612, 618
        }
    }
}
