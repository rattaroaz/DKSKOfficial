
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Manager2Property
{
    public int ManagerId { get; set; }
    public int PropertiesId { get; set; }

    public Manager manager { get; set; }
    public Properties properties { get; set; }
}
