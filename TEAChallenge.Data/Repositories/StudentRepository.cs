using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using TEAChallenge.Data.DataContexts;
using TEAChallenge.Data.Models;

namespace TEAChallenge.Data.Repositories;

public class StudentRepository : IStudentRepository
{
    private readonly SchoolContext _context;
    
    public StudentRepository(SchoolContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<StudentGPA>> GetStudentGPAsAsync()
    {
        Debug.Assert(_context.StudentGrades != null);

        var grades = _context.StudentGrades
            .Include(s => s.Student)
            .Where(s => s.Grade != null);

        return await grades
            .GroupBy(s => s.Student)
            .Select(group => new StudentGPA
            {
                Student = group.Key,
                GPA = group.Average(s => s.Grade ?? 0)
            }).ToListAsync();
    }
}