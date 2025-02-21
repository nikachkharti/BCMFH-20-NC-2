using University.Models.Dtos.Course;
using University.Models.Dtos.Teacher;
using University.Models.Entities;
using University.Repository.Interfaces;
using University.Service.Exceptions;
using University.Service.Interfaces;

namespace University.Service.Implementations
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public async Task<TeacherForGettingDto> GetSingleTeacher(int teacherId)
        {
            if (teacherId <= 0)
                throw new BadRequestException($"{teacherId} is an invalid argument");

            Teacher entityData = await _teacherRepository.Get(teacherId);

            if (entityData is null)
                throw new NotFoundException($"{entityData} not found");

            List<CourseForGettingDto> courses = new();

            TeacherForGettingDto result = new();
            result.Id = entityData.Id;
            result.Name = entityData.Name;

            if (entityData.Courses.Any())
            {
                foreach (var courseEntity in entityData.Courses)
                {
                    courses.Add(new CourseForGettingDto()
                    {
                        Id = courseEntity.Id,
                        Title = courseEntity.Title
                    });
                }
            }

            result.Courses = courses;

            return result;
        }

        public async Task AddNewTeacher(TeacherForCreatingDto teacherForCreatingDto)
        {
            if (teacherForCreatingDto is null)
            {
                throw new BadRequestException($"{teacherForCreatingDto} is an invalid argument");
            }

            var entityData = new Teacher() { Name = teacherForCreatingDto.Name };
            await _teacherRepository.Add(entityData);
        }

        public async Task DeleteTeacher(int teacherId)
        {
            if (teacherId <= 0)
                throw new BadRequestException($"{teacherId} is an invalid argument");

            await _teacherRepository.Delete(teacherId);
        }

        public async Task UpdateTeacher(TeacherForUpdatingDto teacherForUpdatingDto)
        {
            if (teacherForUpdatingDto is null)
                throw new BadRequestException($"{teacherForUpdatingDto} is an invalid argument");

            Teacher entityData = new()
            {
                Id = teacherForUpdatingDto.Id,
                Name = teacherForUpdatingDto.Name
            };

            await _teacherRepository.Update(entityData);
        }
    }

}
