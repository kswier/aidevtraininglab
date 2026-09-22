using WebAutoParts.Models;

namespace WebAutoParts.Services;

public interface IPartsRepository
{
    IEnumerable<Part> GetParts();

    Part? GetPartById(int id);
}
