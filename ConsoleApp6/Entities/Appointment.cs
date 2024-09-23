namespace ConsoleApp6.Entities;

public class Appointment
{
    public int Id { get; set; }
    public int DoctorId { get; set; }
    public Doctor Doctor { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public DateTime AppointmentDate { get; set; }
    public TimeSlot TimeSlot { get; set; }
    public bool IsReserved { get; set; }
}
public enum TimeSlot
{
    Morning = 0, // 09:00-11:00
    Noon = 1,    // 12:00-14:00
    Afternoon = 2 // 15:00-17:00
}