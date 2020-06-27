using CalculoJuros.Domain.Calculo.Dtos;
using CalculoJuros.Domain.Calculo.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CalculoJuros.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculaJurosController : ApiBase
    {
        private readonly ICalculoService calculoService;

        public CalculaJurosController(ICalculoService calculoService) : base(calculoService)
        {
            this.calculoService = calculoService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(CalcularJurosRequest calcularJurosRequest)
        {
            return Response(await calculoService.CalcularJurosCompostosAsync(calcularJurosRequest));
        }
    }
}