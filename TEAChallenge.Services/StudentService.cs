using System.Diagnostics;
using TEAChallenge.Data.Repositories;
using TEAChallenge.Services.Models;

namespace TEAChallenge.Services;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;
    
    public StudentService(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }
    
    public async Task<IEnumerable<Student>> GetStudentGPAsAsync()
    {
        Debug.Assert(_studentRepository != null);
        
        var students = await _studentRepository.GetStudentGPAsAsync();
        
        return students.Select(s => new Student
        {
            StudentId = s.Student.PersonId,
            FirstName = s.Student.FirstName,
            LastName = s.Student.LastName,
            GPA = s.GPA
        }).ToList();
    }
}