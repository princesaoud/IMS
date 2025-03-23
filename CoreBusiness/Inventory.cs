using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CoreBusiness;

public class Inventory
{

    public int InventoryId { get; set; }
    [Required]
    [StringLength(50)]
    public string InventoryName { get; set; } = string.Empty;
    [Required]
    [Range(0, 1000, ErrorMessage = "Quantity must be between 0 and 1000")]
    public int Quantity { get; set; }
    [Required]
    [Range(0, 1000, ErrorMessage = "Price must be between 0 and 1000")]
    public double Price { get; set; }
}
