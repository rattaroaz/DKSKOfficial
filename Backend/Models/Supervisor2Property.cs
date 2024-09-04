
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Supervisor2Property
{
    public int SupervisorId { get; set; }
    public int PropertiesId { get; set; }

    public Supervisor supervisor { get; set; }
    public Properties properties { get; set; }
}
