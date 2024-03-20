using Cadastro_a.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Cadastro_a.Services;

namespace Cadastro_a.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            return View();
        }

       
        public IActionResult Resultados(string nomeFormatado, string enderecoFormatado, string telefoneFormatado)
        {
            // Instanciar o serviço FormatacaoService
            var dadosFormatadosService = new FormatacaoService();

            // Formatar os dados usando o serviço
            var dadosFormatados = dadosFormatadosService.FormatarDados(nomeFormatado, enderecoFormatado, telefoneFormatado);

            // Passar os dados formatados para a view
            ViewBag.DadosFormatados = dadosFormatados;

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
}
