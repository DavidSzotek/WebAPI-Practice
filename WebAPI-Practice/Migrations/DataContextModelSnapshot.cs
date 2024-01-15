﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI_Practice.Data;

#nullable disable

namespace WebAPI_Practice.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MaterialPrintertype", b =>
                {
                    b.Property<int>("MaterialsId")
                        .HasColumnType("int");

                    b.Property<int>("PrintertypesId")
                        .HasColumnType("int");

                    b.HasKey("MaterialsId", "PrintertypesId");

                    b.HasIndex("PrintertypesId");

                    b.ToTable("MaterialPrintertype");
                });

            modelBuilder.Entity("WebAPI_Practice.Models.Functiontype", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Functiontypes");
                });

            modelBuilder.Entity("WebAPI_Practice.Models.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("WebAPI_Practice.Models.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<bool>("IsAlternative")
                        .HasColumnType("bit");

                    b.Property<int>("MaterialtypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("PartNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("PriceDph")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("MaterialtypeId");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("WebAPI_Practice.Models.Materialtype", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Materialtypes");
                });

            modelBuilder.Entity("WebAPI_Practice.Models.Office", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Municipality")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.HasKey("Id");

                    b.ToTable("Office");
                });

            modelBuilder.Entity("WebAPI_Practice.Models.Printer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("ActivationDate")
                        .HasColumnType("date");

                    b.Property<string>("InventaryNumber")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("PrinterstatusId")
                        .HasColumnType("int");

                    b.Property<int>("PrintertypeId")
                        .HasColumnType("int");

                    b.Property<string>("PropertyType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Room")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId");

                    b.HasIndex("PrinterstatusId");

                    b.HasIndex("PrintertypeId");

                    b.ToTable("Printer");
                });

            modelBuilder.Entity("WebAPI_Practice.Models.Printerstatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Printerstatus");
                });

            modelBuilder.Entity("WebAPI_Practice.Models.Printertype", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FunctiontypeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsA3")
                        .HasColumnType("bit");

                    b.Property<bool>("IsColor")
                        .HasColumnType("bit");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FunctiontypeId");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Printertypes");
                });

            modelBuilder.Entity("WebAPI_Practice.Models.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaterialId");

                    b.HasIndex("OfficeId");

                    b.ToTable("Stock");
                });

            modelBuilder.Entity("MaterialPrintertype", b =>
                {
                    b.HasOne("WebAPI_Practice.Models.Material", null)
                        .WithMany()
                        .HasForeignKey("MaterialsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI_Practice.Models.Printertype", null)
                        .WithMany()
                        .HasForeignKey("PrintertypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebAPI_Practice.Models.Material", b =>
                {
                    b.HasOne("WebAPI_Practice.Models.Materialtype", "Materiatltype")
                        .WithMany("Materials")
                        .HasForeignKey("MaterialtypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Materiatltype");
                });

            modelBuilder.Entity("WebAPI_Practice.Models.Printer", b =>
                {
                    b.HasOne("WebAPI_Practice.Models.Office", "Office")
                        .WithMany("Printers")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI_Practice.Models.Printerstatus", "Printerstatus")
                        .WithMany("Printers")
                        .HasForeignKey("PrinterstatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI_Practice.Models.Printertype", "Printertype")
                        .WithMany("Printers")
                        .HasForeignKey("PrintertypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Office");

                    b.Navigation("Printerstatus");

                    b.Navigation("Printertype");
                });

            modelBuilder.Entity("WebAPI_Practice.Models.Printertype", b =>
                {
                    b.HasOne("WebAPI_Practice.Models.Functiontype", "Functiontype")
                        .WithMany("Printertypes")
                        .HasForeignKey("FunctiontypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI_Practice.Models.Manufacturer", "Manufacturer")
                        .WithMany("Printertypes")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Functiontype");

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("WebAPI_Practice.Models.Stock", b =>
                {
                    b.HasOne("WebAPI_Practice.Models.Material", "Material")
                        .WithMany("Stocks")
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI_Practice.Models.Office", "Office")
                        .WithMany("Stocks")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Material");

                    b.Navigation("Office");
                });

            modelBuilder.Entity("WebAPI_Practice.Models.Functiontype", b =>
                {
                    b.Navigation("Printertypes");
                });

            modelBuilder.Entity("WebAPI_Practice.Models.Manufacturer", b =>
                {
                    b.Navigation("Printertypes");
                });

            modelBuilder.Entity("WebAPI_Practice.Models.Material", b =>
                {
                    b.Navigation("Stocks");
                });

            modelBuilder.Entity("WebAPI_Practice.Models.Materialtype", b =>
                {
                    b.Navigation("Materials");
                });

            modelBuilder.Entity("WebAPI_Practice.Models.Office", b =>
                {
                    b.Navigation("Printers");

                    b.Navigation("Stocks");
                });

            modelBuilder.Entity("WebAPI_Practice.Models.Printerstatus", b =>
                {
                    b.Navigation("Printers");
                });

            modelBuilder.Entity("WebAPI_Practice.Models.Printertype", b =>
                {
                    b.Navigation("Printers");
                });
#pragma warning restore 612, 618
        }
    }
}
