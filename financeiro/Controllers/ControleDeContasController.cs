using financeiro.Service.interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        [HttpPost]
        public ActionResult InserirConta(ControleDeContas controleDeContas)
        {
            var response = _controleService.IncluirContas(controleDeContas);
            return Ok(response);
        }
        [Route("DeletarConta")]
        [HttpDelete]
        public ActionResult DeletarConta(int id)
        {
            var response = _controleService.DeletarConta(id);
            return Ok(response);
        }
        [Route("ObterListaDeContas")]
        [HttpGet]
        public ActionResult<List<ControleDeContas>> ObterListaDeContas()
        {
            var response = _controleService.ObterListaDeContas();
            return Ok(response); 
        }
    }
}
