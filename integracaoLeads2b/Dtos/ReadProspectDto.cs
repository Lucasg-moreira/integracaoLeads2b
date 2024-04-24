using integracaoLeads2b.Entities;

namespace integracaoLeads2b.Dtos
{
    public class ReadProspectDto
    {
        public string Status { get; set; }
        public int Code { get; set; }
        public List<string> Messages { get; set; }
        public int Offset { get; set; }
        public int Limit { get; set; }
        public int Size { get; set; }
        public List<Prospect> Result { get; set; }
    }
}
