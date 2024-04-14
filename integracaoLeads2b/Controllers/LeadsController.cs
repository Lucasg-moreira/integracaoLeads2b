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
        public IActionResult Get()
        {
            try
            {
                var result = _leadsService.insertRowsDb(
                DateTime.ParseExact("2024-01-01 00:00:00", "yyyy-MM-dd hh:mm:ss", null, System.Globalization.DateTimeStyles.None),
                DateTime.ParseExact("2024-03-01 00:00:00", "yyyy-MM-dd hh:mm:ss", null, System.Globalization.DateTimeStyles.None)
                );

                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest($"Erro ao baixar as informações: ${e.Message}");
            }
        }
    }
}
