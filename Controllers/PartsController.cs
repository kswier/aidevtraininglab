using Microsoft.AspNetCore.Mvc;
using WebAutoParts.Services;

namespace WebAutoParts.Controllers;

public class PartsController : Controller
{
    private readonly IPartsRepository _repository;

    public PartsController(IPartsRepository repository)
    {
        _repository = repository;
    }

    public IActionResult Index()
    {
        return View(_repository.GetParts().ToList());
    }

    public IActionResult Details(int id)
    {
        var part = _repository.GetPartById(id);
        if (part is null)
        {
            return NotFound();
        }

        return View(part);
    }
}
