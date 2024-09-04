
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Manager2Supervisor
{
    public int ManagerId { get; set; }
    public int SupervisorId { get; set; }

    public Manager manager { get; set; }
    public Supervisor supervisor { get; set; }
}
