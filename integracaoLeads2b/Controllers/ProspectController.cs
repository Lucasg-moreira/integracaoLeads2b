using integracaoLeads2b.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace integracaoLeads2b.Controllers
{
    [Route("api/v1/prospects")]
    [ApiController]
    public class ProspectController : ControllerBase
    {
        private readonly IProspectService _prospectService;

        public ProspectController(IProspectService prospectService)
        {
            _prospectService = prospectService;
        }

        [HttpPost("down-sync")]
        public IActionResult DownloadLeads(DateTime startAt, DateTime finishAt)
        {
            try
            {
                string token = HttpContext.Request.Headers["Authorization"];

                if (token == null)
                    throw new Exception("Token não encontrado!");

                int rows = _prospectService.InsertRowsDb(
                    startAt.ToString("yyyy-MM-dd hh:mm:ss"),
                    finishAt.ToString("yyyy-MM-dd hh:mm:ss"),
                    token
                );

                return Ok($"Quantidade de registros inseridos: {rows}!");
            }
            catch (Exception e)
            {
                return BadRequest($"Erro ao baixar as informações: ${e.Message}");
            }
        }
    }
}
