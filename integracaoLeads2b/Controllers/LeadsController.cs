using integracaoLeads2b.Entities;
using integracaoLeads2b.Interfaces;
using integracaoLeads2b.Services;
using Microsoft.AspNetCore.Mvc;

namespace integracaoLeads2b.Controllers
{
    [ApiController]
    [Route("/api/v1/leads")]
    public class LeadsController : Controller
    {
        private readonly ILeadsService _leadsService;

        public LeadsController(ILeadsService leadsService)
        {
            _leadsService = leadsService;
        }

        [HttpPost("down-sync")]
        public IActionResult DownloadLeads(DateTime startAt, DateTime finishAt)
        {
            try
            {
                string token = HttpContext.Request.Headers["Authorization"];

                if (token == null)
                    throw new Exception("Token não encontrado!");

                int rows = _leadsService.InsertRowsDb(
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
