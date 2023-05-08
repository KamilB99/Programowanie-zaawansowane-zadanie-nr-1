﻿// <auto-generated />
using System;
using AdvancedProgramming_Lesson1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AdvancedProgramming_Lesson1.Migrations.MvcSrodki
{
    [DbContext(typeof(MvcSrodkiContext))]
    partial class MvcSrodkiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdvancedProgramming_Lesson1.Models.Srodki", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cena")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data_waznosci")
                        .HasColumnType("datetime2");

                    b.Property<int>("Pojemnosc")
                        .HasColumnType("int");

                    b.Property<string>("Producent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rodzaj_srodka")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Srodki");
                });
#pragma warning restore 612, 618
        }
    }
}
