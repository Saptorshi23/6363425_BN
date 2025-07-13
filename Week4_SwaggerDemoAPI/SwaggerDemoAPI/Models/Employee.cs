namespace EmployeeApi.Models;

public class Employee
{
    public int Id { get; set; }
    public string? Name { get; set; }                // 👈 Make string nullable
    public int Salary { get; set; }
    public bool Permanent { get; set; }
    public Department? Department { get; set; }      // 👈 Nullable object
    public List<Skill>? Skills { get; set; }         // 👈 Nullable list
    public DateTime DateOfBirth { get; set; }
}
