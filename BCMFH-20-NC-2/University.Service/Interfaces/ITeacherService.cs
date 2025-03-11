using University.Models.Dtos.Teacher;

namespace University.Service.Interfaces
{
    public interface ITeacherService
    {
        Task<List<TeacherForGettingDto>> GetMultipleTeachers(int pageNumber, int pageSize);
        Task<TeacherForGettingDto> GetSingleTeacher(int teacherId);
        Task AddNewTeacher(TeacherForCreatingDto teacherForCreatingDto);
        Task UpdateTeacher(TeacherForUpdatingDto teacherForUpdatingDto);
        Task DeleteTeacher(int teacherId);
        Task SaveTeacher();
    }
}
