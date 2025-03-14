using AutoMapper;
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
        private readonly IImageService _imageService;

        public TeacherService(ITeacherRepository teacherRepository, IMapper mapper, IImageService imageService)
        {
            _teacherRepository = teacherRepository;
            _mapper = mapper;
            _imageService = imageService;
        }

        public async Task<List<TeacherForGettingDto>> GetMultipleTeachers(int pageNumber, int pageSize)
        {
            List<Teacher> entityData = await _teacherRepository.GetAllAsync(pageNumber, pageSize, includeProperties: "Courses");
            List<TeacherForGettingDto> result = new();

            if (entityData.Any())
            {
                var mappedData = _mapper.Map<List<TeacherForGettingDto>>(entityData);
                result.AddRange(mappedData);
                return result;
            }
            else
            {
                throw new NotFoundException($"Teachers not found");
            }

        }

        public async Task<TeacherForGettingDto> GetSingleTeacher(int teacherId)
        {
            TeacherForGettingDto result = new();

            if (teacherId <= 0)
                throw new BadRequestException($"{teacherId} is an invalid argument");

            Teacher entityData = await _teacherRepository.GetAsync(x => x.Id == teacherId, includeProperties: "Courses");

            if (entityData is null)
                throw new NotFoundException($" teacher not found");

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

            var sameTeacher = await _teacherRepository.GetAsync(x => x.Name.ToLower().Trim() == teacherForCreatingDto.Name.ToLower().Trim());

            if (sameTeacher is not null)
            {
                throw new AmbigousNameException();
            }

            teacherForCreatingDto.ProfilePictureUrl = await _imageService.UploadResizedImage(teacherForCreatingDto.ProfilePicture);

            var entityData = _mapper.Map<Teacher>(teacherForCreatingDto);
            await _teacherRepository.AddAsync(entityData);
        }

        public async Task DeleteTeacher(int teacherId)
        {
            if (teacherId <= 0)
            {
                throw new BadRequestException($"{teacherId} is an invalid argument");
            }

            var teacherToDelete = await _teacherRepository.GetAsync(x => x.Id == teacherId);

            if (teacherToDelete is null)
            {
                throw new NotFoundException($"Teacher with id {teacherId} not found");
            }

            if (!string.IsNullOrWhiteSpace(teacherToDelete.ProfilePictureUrl))
            {
                _imageService.DeleteImage(teacherToDelete.ProfilePictureUrl);
            }

            _teacherRepository.Remove(teacherToDelete);
        }

        public async Task UpdateTeacher(TeacherForUpdatingDto teacherForUpdatingDto)
        {
            if (teacherForUpdatingDto is null)
                throw new BadRequestException($"{teacherForUpdatingDto} is an invalid argument");

            var entityData = _mapper.Map<Teacher>(teacherForUpdatingDto);
            await _teacherRepository.Update(entityData);
        }

        public async Task SaveTeacher() => await _teacherRepository.Save();
    }

}
