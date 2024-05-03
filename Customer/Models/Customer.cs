using System.ComponentModel.DataAnnotations;

public class Customer
{
    public int CustomerID { get; set; }

    [Required]
    [StringLength(30)]
    public string CustomerFName { get; set; }

    [Required]
    [StringLength(30)]
    public string CustomerLName { get; set; }

    [EmailAddress]
    public string CustomerEmail { get; set; }

    [Required]
    [StringLength(10)]
    public string CustomerContact { get; set; }
}
