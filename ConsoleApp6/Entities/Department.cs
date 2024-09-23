using System.Numerics;

namespace ConsoleApp6.Entities;

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Doctor> Doctors { get; set; }
}