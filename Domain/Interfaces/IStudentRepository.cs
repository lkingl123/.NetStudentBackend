using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IStudentRepository
    {
        Task<Student?> GetStudentByIdAsync(string id);
        Task<IEnumerable<Student>> GetAllStudentsAsync();
        Task<Student> AddStudentAsync(Student student);
    }

}
