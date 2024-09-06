// DTO for the Property entity
public class CompannyDto
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Zip { get; set; }
    public string SpecialNote { get; set; }
    public List<SupervisorDto> Supervisors { get; set; } = new List<SupervisorDto>();


}