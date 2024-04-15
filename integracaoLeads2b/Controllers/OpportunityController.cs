using integracaoLeads2b.Interfaces;
using Microsoft.AspNetCore.Authorization;
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
                string token = HttpContext.Request.Headers["Authorization"];

                if (token == null)
                    throw new Exception("Token não encontrado!");

                int rows = _opportunityService.InsertRowsDb(
                    start_at.ToString("yyyy-MM-dd hh:mm:ss"),
                    finish_at.ToString("yyyy-MM-dd hh:mm:ss"),
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
