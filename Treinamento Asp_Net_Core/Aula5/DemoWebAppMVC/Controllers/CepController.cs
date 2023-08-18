namespace DemoWebAppMVC.Controllers;

using Microsoft.AspNetCore.Mvc;
using DemoWebAppMVC.Services;
using DemoWebAppMVC.Models;


public class CepController : Controller
{
    private readonly ICepRepository _cepRepository;

    public CepController(ICepRepository cepRepository)
    {
        _cepRepository = cepRepository;
    }

    //GET .../Cep/Index ou .../Cep
    public IActionResult Index()
    {
        var ceps = _cepRepository.ConsultarTodos();
        var cepsviewmodel = ceps.Select(c => CepModel.ParaViewModel(c)).OrderBy(c => c.Cidade);
        return View(cepsviewmodel);
    }

    //GET .../Cep/Search/
    public IActionResult Search(string id)
    {
        ViewData["id"] = id;
        CepModel? cep = null;
        if(!String.IsNullOrWhiteSpace(id))
        {
            cep = _cepRepository.ConsultarPorCodigoCep(id);
        }
        return View(cep is not null ? CepModel.ParaViewModel(cep) : cep);
    }

    //GET .../Cep/Create
    public IActionResult Create()
    {
        return View();
    }

    //POST .../Cep/Create
    [HttpPost]
    public IActionResult Create(CepViewModel viewModel)
    {
        if(!ModelState.IsValid)
        {
            return View(viewModel);
        }
        var model = CepModel.ParaModel(viewModel);
        _cepRepository.Cadastrar(model);
        return RedirectToAction(nameof(Index));
    }
}