using Microsoft.AspNetCore.Mvc;
using senac_sjrp.Models;
using senac_sjrp.Repository;

[Route("[controller]")]
public class PieController : Controller
{
    private readonly IPieRepository _pieRepository;

    public PieController(IPieRepository repository)
    {
        this._pieRepository = repository;
    }

    public IActionResult Index()
    {
        var result = this._pieRepository.GetAllPies();

        return View(result);
    }

    [Route("details/{id}")]
    public IActionResult Detail(int id)
    {
        var result = this._pieRepository.GetPieById(id);
        return View(result);
    }

    [Route("create")]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [Route("create")]
    public IActionResult Create(Pie model)
    {
        if (!ModelState.IsValid)
            return View(model);

        this._pieRepository.Save(model);

        this.ViewBag.Message = "Operação realizada com sucesso!";

        return RedirectToAction("Index");
    }   
}