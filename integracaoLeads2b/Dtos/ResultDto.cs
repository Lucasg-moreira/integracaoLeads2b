namespace integracaoLeads2b.Dtos
{
    public class ResultDto
    {
        public string Status { get; set; }
        public int Code { get; set; }
        public List<string> Messages { get; set; }
        public int Offset { get; set; }
        public string Limit { get; set; }
        public int Size { get; set; }
    }
}
