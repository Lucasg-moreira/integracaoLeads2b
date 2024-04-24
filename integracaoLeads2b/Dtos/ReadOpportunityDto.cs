using integracaoLeads2b.Entities;

namespace integracaoLeads2b.Dtos
{
    public class ReadOpportunityDto : ResultDto
    {
        public List<Opportunity> Result { get; set; }
    }
}
