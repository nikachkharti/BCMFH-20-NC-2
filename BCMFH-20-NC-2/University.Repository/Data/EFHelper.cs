using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using University.Models.Entities;

namespace University.Repository.Data
{
    public static class EFHelper
    {

        public static void ChangeDefaultTableNames(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>(entity => entity.ToTable(name: "Users"));
            modelBuilder.Entity<IdentityRole>(entity => entity.ToTable(name: "Roles"));
            modelBuilder.Entity<IdentityUserRole<string>>(entity => entity.ToTable(name: "UserRoles"));
            modelBuilder.Entity<IdentityUserClaim<string>>(entity => entity.ToTable(name: "UserClaims"));
            modelBuilder.Entity<IdentityUserLogin<string>>(entity => entity.ToTable(name: "UserLogins"));
            modelBuilder.Entity<IdentityRoleClaim<string>>(entity => entity.ToTable(name: "RoleClaims"));
            modelBuilder.Entity<IdentityUserToken<string>>(entity => entity.ToTable(name: "UserTokens"));
        }

        public static void ConfigureStudents(this ModelBuilder modelBuilder)
        {
            //Student Entity
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(s => s.Id);
                entity
                    .Property(s => s.Id)
                    .ValueGeneratedOnAdd()
                    .IsRequired();

                entity
                    .Property(s => s.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity
                    .Property(s => s.PersonalNumber)
                    .IsRequired()
                    .HasColumnType("char(11)")
                    .HasMaxLength(11);

                entity
                    .Property(s => s.Email)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasMaxLength(50);

                entity
                    .Property(s => s.BirthDate)
                    .HasColumnType("datetime2");

                entity
                    .HasOne(s => s.Address)
                    .WithOne(a => a.Student)
                    .HasForeignKey<Address>(a => a.StudentId);

                entity
                    .HasMany(s => s.Groups)
                    .WithOne(g => g.Student)
                    .HasForeignKey(g => g.StudentId);
            });
        }
        public static void ConfiugreAddresses(this ModelBuilder modelBuilder)
        {
            //Address Entity
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(a => a.Id);
                entity
                    .Property(a => a.Id)
                    .ValueGeneratedOnAdd()
                    .IsRequired();

                entity
                    .Property(a => a.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity
                    .Property(a => a.Street)
                    .IsRequired()
                    .HasMaxLength(50);

                entity
                    .HasOne(a => a.Student)
                    .WithOne(s => s.Address)
                    .HasForeignKey<Address>(a => a.StudentId);
            });
        }
        public static void ConfiugreTeachers(this ModelBuilder modelBuilder)
        {
            //Teacher Entity
            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasKey(t => t.Id);
                entity
                    .Property(t => t.Id)
                    .ValueGeneratedOnAdd()
                    .IsRequired();

                entity
                    .Property(t => t.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity
                    .HasMany(t => t.Courses)
                    .WithOne(c => c.Teacher)
                    .HasForeignKey(c => c.TeacherId);
            });
        }
        public static void ConfiugreGroups(this ModelBuilder modelBuilder)
        {
            //Group Entity
            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasKey(g => g.Id);
                entity
                    .Property(g => g.Id)
                    .ValueGeneratedOnAdd()
                    .IsRequired();

                entity
                    .Property(g => g.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity
                    .HasOne(g => g.Student)
                    .WithMany(s => s.Groups)
                    .HasForeignKey(g => g.StudentId);

                entity
                    .HasOne(g => g.Course)
                    .WithMany(c => c.Groups)
                    .HasForeignKey(g => g.CourseId);
            });
        }
        public static void ConfiugreCourses(this ModelBuilder modelBuilder)
        {
            //Course Entity
            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity
                    .Property(c => c.Id)
                    .ValueGeneratedOnAdd()
                    .IsRequired();

                entity
                    .Property(c => c.Title)
                    .IsRequired()
                    .HasMaxLength(70);

                entity
                    .HasOne(c => c.Teacher)
                    .WithMany(t => t.Courses)
                    .HasForeignKey(c => c.TeacherId);

                entity
                    .HasMany(c => c.Groups)
                    .WithOne(g => g.Course)
                    .HasForeignKey(g => g.CourseId);
            });
        }

        public static void SeedStudents(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                    new Student()
                    {
                        Id = 1,
                        Name = "Ketevan Gomiashvili",
                        BirthDate = DateTime.Parse("2000-12-12"),
                        Email = "Ketevan@gmail.com",
                        PersonalNumber = "01025879658"
                    },
                    new Student()
                    {
                        Id = 2,
                        Name = "Ilia Metreveli",
                        BirthDate = DateTime.Parse("1998-12-12"),
                        Email = "Ilia@gmail.com",
                        PersonalNumber = "11025879658"
                    },
                    new Student()
                    {
                        Id = 3,
                        Name = "Tengiz Patchkoria",
                        BirthDate = DateTime.Parse("1991-01-22"),
                        Email = "tengiz123@gmail.com",
                        PersonalNumber = "21025879658"
                    }
                );
        }
        public static void SeedAddresses(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>().HasData(
                    new Address()
                    {
                        Id = 1,
                        City = "Tbilisi",
                        Street = "Test street #22",
                        StudentId = 1,
                    },
                    new Address()
                    {
                        Id = 2,
                        City = "Tbilisi",
                        Street = "Test street #12",
                        StudentId = 2,
                    },
                    new Address()
                    {
                        Id = 3,
                        City = "Batumi",
                        Street = "Test street #31",
                        StudentId = 3
                    }
                );
        }
        public static void SeedTeachers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>().HasData(
                    new Teacher()
                    {
                        Id = 1,
                        Name = "Nika Chkarhtishvili"
                    },
                    new Teacher()
                    {
                        Id = 2,
                        Name = "Giorgi Giorgadze"
                    }
                );
        }
        public static void SeedCourses(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                    new Course()
                    {
                        Id = 1,
                        Title = "C#",
                        TeacherId = 1
                    },
                    new Course()
                    {
                        Id = 2,
                        Title = "SQL",
                        TeacherId = 1
                    },
                    new Course()
                    {
                        Id = 3,
                        Title = "Angular",
                        TeacherId = 2
                    },
                    new Course()
                    {
                        Id = 4,
                        Title = "Markup",
                        TeacherId = 2
                    }
                );
        }
        public static void SeedGroups(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>().HasData(
            #region Backend
                            new Group()
                            {
                                Id = 1,
                                Name = "BCMFH-20-NC",
                                CourseId = 1,
                                StudentId = 1
                            },
                    new Group()
                    {
                        Id = 2,
                        Name = "BCMFH-20-NC",
                        CourseId = 1,
                        StudentId = 2
                    },
                    new Group()
                    {
                        Id = 3,
                        Name = "BCMFH-20-NC",
                        CourseId = 1,
                        StudentId = 3
                    },
            #endregion
            #region SQL
                            new Group()
                            {
                                Id = 4,
                                Name = "DBMFH-20-NC",
                                CourseId = 2,
                                StudentId = 3
                            },
            #endregion
            #region Frontend
                            new Group()
                            {
                                Id = 5,
                                Name = "FEMFH-20-NC",
                                CourseId = 3,
                                StudentId = 3
                            },
                    new Group()
                    {
                        Id = 6,
                        Name = "FEMFH-20-NC",
                        CourseId = 4,
                        StudentId = 1
                    },
                    new Group()
                    {
                        Id = 7,
                        Name = "FEMFH-20-NC",
                        CourseId = 4,
                        StudentId = 2
                    }
                    #endregion
                );
        }
        public static void SeedRoles(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "33B7ED72-9434-434A-82D4-3018B018CB87", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "9C07F9F6-D3B0-458A-AB7F-218AA622FA5B", Name = "Customer", NormalizedName = "CUSTOMER" }
            );
        }
        public static void SeedUsers(this ModelBuilder modelBuilder)
        {
            PasswordHasher<ApplicationUser> hasher = new();

            modelBuilder.Entity<ApplicationUser>().HasData(
                    new ApplicationUser()
                    {
                        Id = "8716071C-1D9B-48FD-B3D0-F059C4FB8031",
                        UserName = "admin@gmail.com",
                        NormalizedUserName = "ADMIN@GMAIL.COM",
                        Email = "admin@gmail.com",
                        NormalizedEmail = "ADMIN@GMAIL.COM",
                        EmailConfirmed = false,
                        PasswordHash = hasher.HashPassword(null, "Admin123!"),
                        PhoneNumber = "555337681",
                        PhoneNumberConfirmed = false,
                        TwoFactorEnabled = false,
                        LockoutEnd = null,
                        LockoutEnabled = true,
                        AccessFailedCount = 0
                    },
                    new ApplicationUser()
                    {
                        Id = "D514EDC9-94BB-416F-AF9D-7C13669689C9",
                        UserName = "nika@gmail.com",
                        NormalizedUserName = "NIKA@GMAIL.COM",
                        Email = "nika@gmail.com",
                        NormalizedEmail = "NIKA@GMAIL.COM",
                        EmailConfirmed = false,
                        PasswordHash = hasher.HashPassword(null, "Nika123!"),
                        PhoneNumber = "558490645",
                        PhoneNumberConfirmed = false,
                        TwoFactorEnabled = false,
                        LockoutEnd = null,
                        LockoutEnabled = true,
                        AccessFailedCount = 0
                    },
                    new ApplicationUser()
                    {
                        Id = "87746F88-DC38-4756-924A-B95CFF3A1D8A",
                        UserName = "gio@gmail.com",
                        NormalizedUserName = "GIO@GMAIL.COM",
                        Email = "gio@gmail.com",
                        NormalizedEmail = "GIO@GMAIL.COM",
                        EmailConfirmed = false,
                        PasswordHash = hasher.HashPassword(null, "Gio123!"),
                        PhoneNumber = "551442269",
                        PhoneNumberConfirmed = false,
                        TwoFactorEnabled = false,
                        LockoutEnd = null,
                        LockoutEnabled = true,
                        AccessFailedCount = 0
                    }
                );
        }
        public static void SeedUserRoles(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                    new IdentityUserRole<string> { RoleId = "33B7ED72-9434-434A-82D4-3018B018CB87", UserId = "8716071C-1D9B-48FD-B3D0-F059C4FB8031" },
                    new IdentityUserRole<string> { RoleId = "9C07F9F6-D3B0-458A-AB7F-218AA622FA5B", UserId = "D514EDC9-94BB-416F-AF9D-7C13669689C9" },
                    new IdentityUserRole<string> { RoleId = "9C07F9F6-D3B0-458A-AB7F-218AA622FA5B", UserId = "87746F88-DC38-4756-924A-B95CFF3A1D8A" }
                );
        }
    }
}
