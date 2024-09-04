
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Companny2Supervisor
{
    public int CompannyId { get; set; }
    public int SupervisorId { get; set; }

    public Companny companny { get; set; }
    public Supervisor supervisor { get; set; }
}
