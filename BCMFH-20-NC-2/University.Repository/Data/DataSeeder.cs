using Microsoft.EntityFrameworkCore;
using University.Models.Entities;

namespace University.Repository.Data
{
    public static class DataSeeder
    {
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


    }
}
