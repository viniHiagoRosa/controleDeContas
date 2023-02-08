using financeiro.Service.interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace financeiro.Controllers
{
    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class ControleDeContasController : ControllerBase
    {
        private readonly IControleDeContasService _controleService;

        public ControleDeContasController(IControleDeContasService controleService)
        {
            _controleService = controleService;
        }

        [EnableCors]
        [Route("ObterListaDeContas")]
        [HttpGet]
        public ActionResult<List<ControleDeContas>> ObterListaDeContas()
        {
            var response = _controleService.ObterListaDeContas();
            return Ok(response); 
        }
        [EnableCors]
        [HttpGet("exportar")]
        public FileResult ExportarContas(string arquivoNome)
        {
            var csvContent = _controleService.GerarCsv();

            var fileBytes = Encoding.UTF8.GetBytes(csvContent);
            return File(fileBytes, "text/csv", $"{arquivoNome}.csv");
        }

        [EnableCors]
        [Route("IncluirConta")]
        [HttpPost]
        public ActionResult InserirConta(ControleDeContas controleDeContas)
        {
            var response = _controleService.IncluirContas(controleDeContas);
            return Ok(response);
        }

        [EnableCors]
        [HttpGet("Persperctiva")]
        public ActionResult CalcularPersperctiva(decimal valor)
        {
            var persperctiva = _controleService.CalcularPerspectiva(valor);
            return Ok(persperctiva);
        }

        [EnableCors]
        [Route("DeletarConta")]
        [HttpDelete]
        public ActionResult DeletarConta(int id)
        {
            var response = _controleService.DeletarConta(id);
            return Ok(response);
        }

    }
}
