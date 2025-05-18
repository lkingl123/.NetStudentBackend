using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure
{
    public class StudentRepository : IStudentRepository
    {
        private readonly List<Student> _students = new();

        public Task<Student?> GetStudentByIdAsync(string id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            return Task.FromResult(student);
        }

        public Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return Task.FromResult<IEnumerable<Student>>(_students);
        }

        public Task<Student> AddStudentAsync(Student student)
        {
            _students.Add(student);
            return Task.FromResult(student);
        }
    }
}
