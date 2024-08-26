
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Companny2Property
{
    public int CompannyId { get; set; }
    public int PropertiesId { get; set; }

    public Companny companny { get; set; }
    public Properties properties { get; set; }
}
