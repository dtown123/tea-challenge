using TEAChallenge.Services.Models;

namespace TEAChallenge.Services;

public interface IStudentService
{
    public Task<IEnumerable<Student>> GetStudentGPAsAsync();
}