using integracaoLeads2b.Entities;

namespace integracaoLeads2b.Dtos
{
    public class ReadLeadsDto: ResultDto
    {
        public List<Leads> Result { get; set; }
    }
}
