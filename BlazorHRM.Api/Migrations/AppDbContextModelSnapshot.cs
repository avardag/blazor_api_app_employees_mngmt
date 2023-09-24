﻿// <auto-generated />
using System;
using BlazorHRM.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorHRM.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("BlazorHRM.Shared.Domain.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            Name = "Sweden"
                        },
                        new
                        {
                            CountryId = 2,
                            Name = "Russia"
                        },
                        new
                        {
                            CountryId = 3,
                            Name = "Netherlands"
                        },
                        new
                        {
                            CountryId = 4,
                            Name = "USA"
                        },
                        new
                        {
                            CountryId = 5,
                            Name = "Japan"
                        },
                        new
                        {
                            CountryId = 6,
                            Name = "China"
                        },
                        new
                        {
                            CountryId = 7,
                            Name = "UK"
                        },
                        new
                        {
                            CountryId = 8,
                            Name = "France"
                        },
                        new
                        {
                            CountryId = 9,
                            Name = "Brazil"
                        });
                });

            modelBuilder.Entity("BlazorHRM.Shared.Domain.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Comment")
                        .HasColumnType("TEXT");

                    b.Property<int>("CountryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ExitDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<int>("JobCategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("JoinedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double?>("Latitude")
                        .HasColumnType("REAL");

                    b.Property<double?>("Longitude")
                        .HasColumnType("REAL");

                    b.Property<int>("MaritalStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Smoker")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("EmployeeId");

                    b.HasIndex("CountryId");

                    b.HasIndex("JobCategoryId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            BirthDate = new DateTime(1999, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Stockholm",
                            Comment = "Lorem Ipsum",
                            CountryId = 1,
                            Email = "christina@mail.com",
                            FirstName = "Christina",
                            Gender = 1,
                            JobCategoryId = 2,
                            JoinedDate = new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Berg",
                            MaritalStatus = 1,
                            PhoneNumber = "0702341212",
                            Smoker = false,
                            Street = "Drottninggatan 12",
                            Zip = "13321"
                        },
                        new
                        {
                            EmployeeId = 2,
                            BirthDate = new DateTime(1986, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Moscow",
                            Comment = "Lorem Ipsum",
                            CountryId = 2,
                            Email = "ali@gmail.com",
                            FirstName = "Ali",
                            Gender = 0,
                            JobCategoryId = 1,
                            JoinedDate = new DateTime(2021, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Caceres",
                            MaritalStatus = 0,
                            PhoneNumber = "0703452121",
                            Smoker = false,
                            Street = "Alfred Nobel Str 10",
                            Zip = "13345"
                        });
                });

            modelBuilder.Entity("BlazorHRM.Shared.Domain.JobCategory", b =>
                {
                    b.Property<int>("JobCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("JobCategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("JobCategoryId");

                    b.ToTable("JobCategories");

                    b.HasData(
                        new
                        {
                            JobCategoryId = 1,
                            JobCategoryName = "Research"
                        },
                        new
                        {
                            JobCategoryId = 2,
                            JobCategoryName = "Sales"
                        },
                        new
                        {
                            JobCategoryId = 3,
                            JobCategoryName = "Management"
                        },
                        new
                        {
                            JobCategoryId = 4,
                            JobCategoryName = "Store staff"
                        },
                        new
                        {
                            JobCategoryId = 5,
                            JobCategoryName = "Finance"
                        },
                        new
                        {
                            JobCategoryId = 6,
                            JobCategoryName = "QA"
                        },
                        new
                        {
                            JobCategoryId = 7,
                            JobCategoryName = "IT"
                        },
                        new
                        {
                            JobCategoryId = 8,
                            JobCategoryName = "Cleaning"
                        },
                        new
                        {
                            JobCategoryId = 9,
                            JobCategoryName = "Bakery"
                        });
                });

            modelBuilder.Entity("BlazorHRM.Shared.Domain.Employee", b =>
                {
                    b.HasOne("BlazorHRM.Shared.Domain.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorHRM.Shared.Domain.JobCategory", "JobCategory")
                        .WithMany()
                        .HasForeignKey("JobCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("JobCategory");
                });
#pragma warning restore 612, 618
        }
    }
}