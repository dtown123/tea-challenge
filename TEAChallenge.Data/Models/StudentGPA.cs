using TEAChallenge.Data.Entities;

namespace TEAChallenge.Data.Models;

public class StudentGPA
{
    public Person Student { get; set; } = null!;
    public decimal GPA { get; set; }
}