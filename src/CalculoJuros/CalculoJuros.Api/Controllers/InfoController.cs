using Microsoft.AspNetCore.Mvc;

namespace CalculoJuros.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InfoController : ApiBase
    {
        public InfoController() : base(null)
        {
        }

        [HttpGet("showmethecode")]
        public IActionResult ObterGitHub()
        {
            return Response("https://github.com/rodolfosparapan/calculo-juros");
        }
    }
}