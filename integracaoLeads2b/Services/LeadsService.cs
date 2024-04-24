using integracaoLeads2b.Entities;
using integracaoLeads2b.Helpers;
using integracaoLeads2b.Interfaces;
using integracaoLeads2b.Repository;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Identity.Client;
using System.Net;
using System.Net.Http.Headers;
using System.Text.Json;

namespace integracaoLeads2b.Services
{

    public class LeadsService : ILeadsService
    {
        private readonly ILeadsRepository _leadsRepository;

        private IIntegracaoHelper _integracaoHelper;

        public LeadsService(
            ILeadsRepository leadsRepository,
            IIntegracaoHelper integracaoHelper
            )
        {
            _leadsRepository = leadsRepository;
            _integracaoHelper = integracaoHelper;
        }

        public int InsertRowsDb(string startAt, string finishAt, string token)
        {
            List<Leads> list = _integracaoHelper.GetLeads(startAt, finishAt, token);

            _leadsRepository.AddRange(list);

            int result = _leadsRepository.SaveChanges();

            return result;
        }
    }
}

