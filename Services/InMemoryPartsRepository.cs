using WebAutoParts.Models;

namespace WebAutoParts.Services;

/// <summary>Stub data source; replace the hard-coded list with a real database call later.</summary>
public class InMemoryPartsRepository : IPartsRepository
{
    private static readonly List<Part> Parts =
    [
        new Part
        {
            Id = 1,
            Name = "Brake Pad Set (Front)",
            PartNumber = "BP-1042-F",
            QuantityAvailable = 42,
            Category = "Brakes",
            Manufacturer = "StopRite",
            Price = 64.99m,
            Description = "Ceramic front brake pad set with low-dust formulation and integrated wear sensors.",
            ImageUrl = "/images/parts/brake-pads.svg"
        },
        new Part
        {
            Id = 2,
            Name = "Oil Filter",
            PartNumber = "OF-3387",
            QuantityAvailable = 156,
            Category = "Engine",
            Manufacturer = "PureFlow",
            Price = 12.49m,
            Description = "Spin-on oil filter with anti-drainback valve, rated for 10,000 mile service intervals.",
            ImageUrl = "/images/parts/oil-filter.svg"
        },
        new Part
        {
            Id = 3,
            Name = "Alternator 130A",
            PartNumber = "ALT-9920",
            QuantityAvailable = 7,
            Category = "Electrical",
            Manufacturer = "VoltCore",
            Price = 219.00m,
            Description = "Remanufactured 130 amp alternator with new bearings, brushes and voltage regulator.",
            ImageUrl = "/images/parts/alternator.svg"
        },
        new Part
        {
            Id = 4,
            Name = "Spark Plug (Iridium)",
            PartNumber = "SP-7761-IR",
            QuantityAvailable = 240,
            Category = "Ignition",
            Manufacturer = "IgnitePro",
            Price = 9.75m,
            Description = "Fine-wire iridium spark plug delivering improved cold-start and fuel economy.",
            ImageUrl = "/images/parts/spark-plug.svg"
        },
        new Part
        {
            Id = 5,
            Name = "Radiator Assembly",
            PartNumber = "RAD-5510",
            QuantityAvailable = 0,
            Category = "Cooling",
            Manufacturer = "ThermaCool",
            Price = 189.95m,
            Description = "Aluminum core radiator with plastic tanks, direct-fit replacement with pre-installed drain cock.",
            ImageUrl = "/images/parts/radiator.svg"
        },
        new Part
        {
            Id = 6,
            Name = "Shock Absorber (Rear)",
            PartNumber = "SA-2208-R",
            QuantityAvailable = 18,
            Category = "Suspension",
            Manufacturer = "RideSmooth",
            Price = 78.40m,
            Description = "Twin-tube gas-charged rear shock absorber tuned for original ride height.",
            ImageUrl = "/images/parts/shock-absorber.svg"
        },
        new Part
        {
            Id = 7,
            Name = "Cabin Air Filter",
            PartNumber = "CAF-1190",
            QuantityAvailable = 63,
            Category = "HVAC",
            Manufacturer = "PureFlow",
            Price = 21.30m,
            Description = "Activated carbon cabin air filter that captures pollen, dust and odors.",
            ImageUrl = "/images/parts/cabin-filter.svg"
        },
        new Part
        {
            Id = 8,
            Name = "Timing Belt Kit",
            PartNumber = "TB-4455-K",
            QuantityAvailable = 11,
            Category = "Engine",
            Manufacturer = "DriveLine",
            Price = 142.60m,
            Description = "Complete timing belt kit including belt, idler pulleys, tensioner and water pump.",
            ImageUrl = "/images/parts/timing-belt.svg"
        }
    ];

    public IEnumerable<Part> GetParts() => Parts;

    public Part? GetPartById(int id) => Parts.FirstOrDefault(p => p.Id == id);
}
