using AutoMapper;
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
        private readonly IMapper _mapper;
        public TeacherService(ITeacherRepository teacherRepository, IMapper mapper)
        {
            _teacherRepository = teacherRepository;
            _mapper = mapper;
        }

        public async Task<List<TeacherForGettingDto>> GetMultipleTeachers()
        {
            List<Teacher> entityData = await _teacherRepository.GetAll();
            List<TeacherForGettingDto> result = new();

            if (entityData.Any())
            {
                var mappedData = _mapper.Map<List<TeacherForGettingDto>>(entityData);
                result.AddRange(mappedData);
            }

            return result;
        }

        public async Task<TeacherForGettingDto> GetSingleTeacher(int teacherId)
        {
            TeacherForGettingDto result = new();

            if (teacherId <= 0)
                throw new BadRequestException($"{teacherId} is an invalid argument");

            Teacher entityData = await _teacherRepository.Get(teacherId);

            if (entityData is null)
                throw new NotFoundException($"{entityData} not found");

            if (entityData.Courses.Any())
            {
                result = _mapper.Map<TeacherForGettingDto>(entityData);
            }

            return result;
        }

        public async Task AddNewTeacher(TeacherForCreatingDto teacherForCreatingDto)
        {
            if (teacherForCreatingDto is null)
            {
                throw new BadRequestException($"{teacherForCreatingDto} is an invalid argument");
            }

            var entityData = _mapper.Map<Teacher>(teacherForCreatingDto);
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

            var entityData = _mapper.Map<Teacher>(teacherForUpdatingDto);
            await _teacherRepository.Update(entityData);
        }
    }

}
