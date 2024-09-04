
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Manager
{
    [Key] // This marks it as the primary key
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This makes it auto-increment
    public int Id { get; set; }
    public string Name { get; set; }
    public string CellPhone { get; set; }
    public string Email { get; set; }
    public string SpecialNote { get; set; }

    public List<Companny2Manager> companny2Manager { get; set; }
    public List<Manager2Supervisor> manager2Supervisor { get; set; }
    public List<Manager2Property> manager2Property { get; set; }


}
