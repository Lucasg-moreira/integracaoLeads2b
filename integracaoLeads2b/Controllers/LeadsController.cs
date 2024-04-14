using integracaoLeads2b.Entities;
using integracaoLeads2b.Services;
using Microsoft.AspNetCore.Mvc;

namespace integracaoLeads2b.Controllers
{
    [ApiController]
    [Route("/api/v1/leads")]
    public class LeadsController : Controller
    {

        [HttpGet("list")]
        public IEnumerable<Leads> Get()
        {
            Leads leads = new Leads();

            LeadsService leadsService = new LeadsService();

            List<Leads> result = leadsService.getLeadsByApi(
                DateTime.ParseExact("2024-01-01 00:00:00", "yyyy-MM-dd hh:mm:ss", null, System.Globalization.DateTimeStyles.None),
                DateTime.ParseExact("2024-03-01 00:00:00", "yyyy-MM-dd hh:mm:ss", null, System.Globalization.DateTimeStyles.None)
             );


            // service vai buscar na api
            // repository vai salvar

            return Enumerable.Empty<Leads>();

            //return Ok(leads);
        }
    }
}
