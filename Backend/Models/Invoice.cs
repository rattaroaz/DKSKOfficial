
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
    public string? GateCode { get; set; }
    public string? LockBox { get; set; }
    public int SizeBedroom {  get; set; }
    public int SizeBathroom { get; set; }
    public string? WorkOrder { get; set; }
    public string JobDescriptionChoice { get; set; }
    public string? ContractorName { get; set; }
    public int AmountCost { get; set; }
    public int Paid { get; set; }
    public int AmountPaid { get; set; }
    public DateTime DatePaid { get; set; }
    public string? PaymentHistory { get; set; }

    public DateTime? InvoiceCreatedDate { get; set; }
    public string? CheckNumber { get; set; }
    public string? SpecialNote { get; set; }
    public string? GarageRemoteCode { get; set; }
    public int Status   { get; set; }

}

public class Payment
{
    public DateTime Date { get; set; }
    public int Amount { get; set; }
    public string CheckNumber { get; set; }
}

public class InvoiceViewModel
{
    public Invoice Invoice { get; set; } // Holds the actual invoice data
    public bool IsSeparator { get; set; } // Indicates if this is a separator row
    public string SeparatorText { get; set; } // Text to display in the separator row
    public int Amount { get; set; }
    public DateTime PaidDate { get; set; }
    public string CheckNumber { get; set; }
}