using integracaoLeads2b.Entities;

namespace integracaoLeads2b.Dtos
{
    public class ReadProspectDto : ResultDto
    {
        
        public List<Prospect> Result { get; set; }
    }
}
