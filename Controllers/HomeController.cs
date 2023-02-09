using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //instancias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Filipe", "12345678921", "filipe@gmail.com", "Tobi" );
        Cliente cliente2 = new Cliente(02, "Jessica", "156457921", "seul@pe.edu", "lampião" );
        Cliente cliente3 = new Cliente(03, "Jesus", "12343278921", "teai@pe.edu", "Sport" );
        Cliente cliente4 = new Cliente(04, "Silva", "123487988921", "dadaai@gmailcom", "Timão" );
        Cliente cliente5 = new Cliente(05, "Simão", "12345999921", "simao123@hotmail.com", "Pumba" );

        //Lista de clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        //instancias do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "Rações S/A", "12345678/0001-21", "ração@gmail.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "Pet friend S/A", "57689485/0001-10", "pet@gmail.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "Cães bom", "58632145/0001-01", "caesbom@gmail.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "Entre cãos e gatos S/A", "85236492/0001-20", "cães&gato@gmail.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Petshop show S/A", "42356791/0001-02", "showpet@gmail.com");
        
        //Lista de fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
