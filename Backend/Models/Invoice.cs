
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Invoice
{
    [Key] // This marks it as the primary key
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This makes it auto-increment
    public int Id { get; set; }
    public DateTime TodaysDate { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime AnticipatedEndDate { get; set; }

    public string CompanyName { get; set; }
    public string PropertyAddress { get; set; }
    public string Unit { get; set; }
    public string GateCode { get; set; }
    public string LockBox { get; set; }
    public string Size {  get; set; }
    public string WorkOrder { get; set; }
    public string JobDescriptionChoice { get; set; }
    public string ContractorName { get; set; }
    public string AmountCost { get; set; }
    public string Paid { get; set; }
    public string AmountPaid { get; set; }
    public string CheckNumber { get; set; }

}
