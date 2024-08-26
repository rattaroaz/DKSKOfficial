
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Properties
{
    [Key] // This marks it as the primary key
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This makes it auto-increment
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Zip { get; set; }
    public string GateCode { get; set; }
    public string LockBox { get; set; }
    public string SpecialNote { get; set; }

    public List<Companny2Property> companny2Properties { get; set; }
}
