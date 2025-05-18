using Domain.Entities;
using Domain.Interfaces;

namespace Application.Handlers
{
    public class GetStudentHandler
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<Student?> HandleAsync(string id)
        {
            return await _studentRepository.GetStudentByIdAsync(id);
        }
    }
}
