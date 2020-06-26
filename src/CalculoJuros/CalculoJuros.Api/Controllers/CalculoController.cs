using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CalculoJuros.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CalculoController : ApiBase
    {
        private readonly IProdutoRepository produtoRepository;

        public CalculoController(IProdutoRepository produtoRepository) : base(null)
        {
            this.produtoRepository = produtoRepository;
        }

        [HttpPost("calculajuros"")]
        public IActionResult Listar()
        {
            return Ok(produtoRepository.Listar());
        }
    }
}