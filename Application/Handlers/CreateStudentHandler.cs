
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Handlers
{
    public class CreateStudentHandler
    {
        private readonly IStudentRepository _studentRepository;
        public CreateStudentHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<Student> HandleAsync(string firstName, string lastName, string? email)
        {
            var student = new Student(firstName, lastName, email);
            await _studentRepository.AddStudentAsync(student);
            return student;
        }
    }
}
