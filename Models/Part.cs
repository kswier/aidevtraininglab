namespace WebAutoParts.Models;

public class Part
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string PartNumber { get; set; } = string.Empty;

    public int QuantityAvailable { get; set; }

    public string Category { get; set; } = string.Empty;

    public string Manufacturer { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public string Description { get; set; } = string.Empty;

    /// <summary>Site-relative path to the part photo.</summary>
    public string ImageUrl { get; set; } = string.Empty;

    public bool InStock => QuantityAvailable > 0;
}
