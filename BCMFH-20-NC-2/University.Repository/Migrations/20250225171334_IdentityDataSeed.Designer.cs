﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using University.Repository.Data;

#nullable disable

namespace University.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250225171334_IdentityDataSeed")]
    partial class IdentityDataSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "33B7ED72-9434-434A-82D4-3018B018CB87",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "9C07F9F6-D3B0-458A-AB7F-218AA622FA5B",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "8716071C-1D9B-48FD-B3D0-F059C4FB8031",
                            RoleId = "33B7ED72-9434-434A-82D4-3018B018CB87"
                        },
                        new
                        {
                            UserId = "D514EDC9-94BB-416F-AF9D-7C13669689C9",
                            RoleId = "9C07F9F6-D3B0-458A-AB7F-218AA622FA5B"
                        },
                        new
                        {
                            UserId = "87746F88-DC38-4756-924A-B95CFF3A1D8A",
                            RoleId = "9C07F9F6-D3B0-458A-AB7F-218AA622FA5B"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", (string)null);
                });

            modelBuilder.Entity("University.Models.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Tbilisi",
                            Street = "Test street #22",
                            StudentId = 1
                        },
                        new
                        {
                            Id = 2,
                            City = "Tbilisi",
                            Street = "Test street #12",
                            StudentId = 2
                        },
                        new
                        {
                            Id = 3,
                            City = "Batumi",
                            Street = "Test street #31",
                            StudentId = 3
                        });
                });

            modelBuilder.Entity("University.Models.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "8716071C-1D9B-48FD-B3D0-F059C4FB8031",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b9ffe450-ed11-4b75-8168-11d511b7eea7",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAENNkdAveNorYJOAl/Hr/ZW/XIHroPZ5vIQ40RVlunIrI8Tt6oHOqjK9uBgffCNBq2g==",
                            PhoneNumber = "555337681",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ae42937b-ae98-4420-bea5-163bcfbc4b0b",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        },
                        new
                        {
                            Id = "D514EDC9-94BB-416F-AF9D-7C13669689C9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b6c56c28-a49f-4037-ba47-31cdca4ec6ae",
                            Email = "nika@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "NIKA@GMAIL.COM",
                            NormalizedUserName = "NIKA@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEOA3fb87gbymibF6nCm2RUfyeiPd9M/r2AKu7xRaPgdDmaCrnybRFgdtuBmYPCdA9A==",
                            PhoneNumber = "558490645",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f127618b-e4a7-4bb3-a6bd-20a432a024ad",
                            TwoFactorEnabled = false,
                            UserName = "nika@gmail.com"
                        },
                        new
                        {
                            Id = "87746F88-DC38-4756-924A-B95CFF3A1D8A",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "de78b877-700d-4848-9bd2-f00177b92e8d",
                            Email = "gio@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "GIO@GMAIL.COM",
                            NormalizedUserName = "GIO@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAED1RJEZfv16lLoskBvqMgLW44nYd7tBUIS0REQXAkSmqeczW8MO93N3uR89Gj9veVA==",
                            PhoneNumber = "551442269",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0d33dbc8-d7bc-46b3-aa33-74d0ef14377a",
                            TwoFactorEnabled = false,
                            UserName = "gio@gmail.com"
                        });
                });

            modelBuilder.Entity("University.Models.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TeacherId = 1,
                            Title = "C#"
                        },
                        new
                        {
                            Id = 2,
                            TeacherId = 1,
                            Title = "SQL"
                        },
                        new
                        {
                            Id = 3,
                            TeacherId = 2,
                            Title = "Angular"
                        },
                        new
                        {
                            Id = 4,
                            TeacherId = 2,
                            Title = "Markup"
                        });
                });

            modelBuilder.Entity("University.Models.Entities.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            Name = "BCMFH-20-NC",
                            StudentId = 1
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 1,
                            Name = "BCMFH-20-NC",
                            StudentId = 2
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 1,
                            Name = "BCMFH-20-NC",
                            StudentId = 3
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 2,
                            Name = "DBMFH-20-NC",
                            StudentId = 3
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 3,
                            Name = "FEMFH-20-NC",
                            StudentId = 3
                        },
                        new
                        {
                            Id = 6,
                            CourseId = 4,
                            Name = "FEMFH-20-NC",
                            StudentId = 1
                        },
                        new
                        {
                            Id = 7,
                            CourseId = 4,
                            Name = "FEMFH-20-NC",
                            StudentId = 2
                        });
                });

            modelBuilder.Entity("University.Models.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PersonalNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("char(11)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(2000, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Ketevan@gmail.com",
                            Name = "Ketevan Gomiashvili",
                            PersonalNumber = "01025879658"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1998, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Ilia@gmail.com",
                            Name = "Ilia Metreveli",
                            PersonalNumber = "11025879658"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1991, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "tengiz123@gmail.com",
                            Name = "Tengiz Patchkoria",
                            PersonalNumber = "21025879658"
                        });
                });

            modelBuilder.Entity("University.Models.Entities.Teacher", b =>
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

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Nika Chkarhtishvili"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Giorgi Giorgadze"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("University.Models.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("University.Models.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("University.Models.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("University.Models.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("University.Models.Entities.Address", b =>
                {
                    b.HasOne("University.Models.Entities.Student", "Student")
                        .WithOne("Address")
                        .HasForeignKey("University.Models.Entities.Address", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("University.Models.Entities.Course", b =>
                {
                    b.HasOne("University.Models.Entities.Teacher", "Teacher")
                        .WithMany("Courses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("University.Models.Entities.Group", b =>
                {
                    b.HasOne("University.Models.Entities.Course", "Course")
                        .WithMany("Groups")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("University.Models.Entities.Student", "Student")
                        .WithMany("Groups")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("University.Models.Entities.Course", b =>
                {
                    b.Navigation("Groups");
                });

            modelBuilder.Entity("University.Models.Entities.Student", b =>
                {
                    b.Navigation("Address");

                    b.Navigation("Groups");
                });

            modelBuilder.Entity("University.Models.Entities.Teacher", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
