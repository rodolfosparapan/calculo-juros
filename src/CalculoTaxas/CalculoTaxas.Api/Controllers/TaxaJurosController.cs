using CalculoTaxas.Domain.TaxasJuros.interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CalculoTaxas.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class TaxaJurosController : ApiBase
    {
        private readonly ITaxaJurosService taxaJurosService;

        public TaxaJurosController(ITaxaJurosService taxaJurosService ) : base(null)
        {
            this.taxaJurosService = taxaJurosService;
        }

        [HttpGet("taxaJuros")]
        public IActionResult Obter()
        {
            return Ok(taxaJurosService.Obter());
        }
    }
}