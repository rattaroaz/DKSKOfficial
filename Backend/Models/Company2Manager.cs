
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Companny2Manager
{
    public int CompannyId { get; set; }
    public int ManagerId { get; set; }

    public Companny companny { get; set; }
    public Manager manager { get; set; }
}
