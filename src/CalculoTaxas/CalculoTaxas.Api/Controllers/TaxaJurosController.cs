using CalculoTaxas.Domain.TaxasJuros.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CalculoTaxas.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaxaJurosController : ApiBase
    {
        private readonly ITaxaJurosService taxaJurosService;

        public TaxaJurosController(ITaxaJurosService taxaJurosService ) : base(taxaJurosService)
        {
            this.taxaJurosService = taxaJurosService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Response(taxaJurosService.Obter());
        }
    }
}