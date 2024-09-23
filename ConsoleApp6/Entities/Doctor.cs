namespace ConsoleApp6.Entities;

public class Doctor
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Experience { get; set; }
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
    public List<Appointment> Appointments { get; set; }
}