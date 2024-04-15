using integracaoLeads2b.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace integracaoLeads2b.Controllers
{
    [Route("api/v1/opportunities")]
    [ApiController]
    public class OpportunityController : ControllerBase
    {
        private IOpportunityService _opportunityService;
        public OpportunityController(IOpportunityService opportunityService) {
            _opportunityService = opportunityService;
        }
        [HttpPost("down-sync")]
        public IActionResult DownloadOpportunity(DateTime start_at, DateTime finish_at)
        {
            try
            {
                _opportunityService.InsertRowsDb(
                    start_at.ToString("yyyy-MM-dd hh:mm:ss"),
                    finish_at.ToString("yyyy-MM-dd hh:mm:ss")
                );

                return Ok("Registros inseridos!");
            }
            catch (Exception e)
            {
                return BadRequest($"Erro ao baixar as informações: ${e.Message}");
            }
        }
    }
}
