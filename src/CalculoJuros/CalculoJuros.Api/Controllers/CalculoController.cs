using CalculoJuros.Domain.Calculo.Dtos;
using CalculoJuros.Domain.Calculo.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CalculoJuros.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CalculoController : ApiBase
    {
        private readonly ICalculoService calculoService;

        public CalculoController(ICalculoService calculoService) : base(calculoService)
        {
            this.calculoService = calculoService;
        }

        [HttpPost("calculajuros")]
        public async Task<IActionResult> CalcularJurosCompostosAsync(CalcularJurosRequest calcularJurosRequest)
        {
            return Ok(await calculoService.CalcularJurosCompostosAsync(calcularJurosRequest));
        }
    }
}