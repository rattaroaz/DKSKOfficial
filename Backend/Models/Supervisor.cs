
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Supervisor
{
    [Key] // This marks it as the primary key
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This makes it auto-increment
    public int Id { get; set; }
    public string Name { get; set; }
    public string CellPhone { get; set; }
    public string Email { get; set; }
    public string SpecialNote { get; set; }

    public List<Supervisor2Property> supervisor2Properties { get; set; }
    public List<Manager2Supervisor> manager2Supervisor { get; set; }
    public List<Companny2Supervisor> companny2Supervisor { get; set; }

}
