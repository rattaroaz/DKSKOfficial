
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Companny
{
    [Key] // This marks it as the primary key
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This makes it auto-increment
    public int Id { get; set; }
    public string Name { get; set; }
    public string Ownner { get; set; }
    public string CellPhone { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Zip {  get; set; }
    public string SpecialNote { get; set; }

    public List<Companny2Property> companny2Properties { get; set; }
    public List<Companny2Manager> companny2Manager { get; set; }
    public List<Companny2Supervisor> companny2Supervisor { get; set; }

}
