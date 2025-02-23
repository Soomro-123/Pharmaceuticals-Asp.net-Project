﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pharmaceuticals.DbContextClass;

#nullable disable

namespace Pharmaceuticals.Migrations
{
    [DbContext(typeof(PharmaDbContextClass))]
    [Migration("20241031073727_TabletMigration")]
    partial class TabletMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Pharmaceuticals.Models.Capsules", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CapsuleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CapsuleSize")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("MachineDimension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Output")
                        .HasColumnType("int");

                    b.Property<decimal>("ShippingWeight")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("tbl_Capsules");
                });

            modelBuilder.Entity("Pharmaceuticals.Models.Tablets", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Dies")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MachineSize")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("MaxDepth")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MaxDiameter")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MaxPressure")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ModelNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("NetWeight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductionCapacity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tablets");
                });
#pragma warning restore 612, 618
        }
    }
}
