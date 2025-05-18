using Domain.Entities;
using Domain.Interfaces;

namespace Application.Handlers;

public class GetAllStudentsHandler
{
    private readonly IStudentRepository _repo;

    public GetAllStudentsHandler(IStudentRepository repo)
    {
        _repo = repo;
    }

    public Task<IEnumerable<Student>> HandleAsync()
    {
        return _repo.GetAllStudentsAsync();
    }
}
