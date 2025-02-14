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
    [Migration("20250214170014_ManyToManySeed")]
    partial class ManyToManySeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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
