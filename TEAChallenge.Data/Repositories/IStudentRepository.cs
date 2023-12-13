using TEAChallenge.Data.Models;

namespace TEAChallenge.Data.Repositories;

public interface IStudentRepository
{
    public Task<IEnumerable<StudentGPA>> GetStudentGPAsAsync();
}