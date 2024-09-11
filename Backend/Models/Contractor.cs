
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Contractor
{
    [Key] // This marks it as the primary key
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This makes it auto-increment
    public int Id { get; set; }
    public string Name { get; set; }
    public string? LicenseNumber { get; set; }
    public string? SocailSecurityNumber { get; set; }
    public string? ContractorID { get; set; }
    public string? PayrollPercent { get; set; }
    public string? CellPhone { get; set; }
    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? Zip { get; set; }

    public string? SpecialNote { get; set; }
    public bool? IsActive { get; set; }

}
