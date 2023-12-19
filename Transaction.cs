using System.ComponentModel.DataAnnotations;

public class Transaction
{   
    [Key]
    public string? referenceId { get; set; }
    public string? mobileNumber { get; set; }
    public int amount { get; set; }

}