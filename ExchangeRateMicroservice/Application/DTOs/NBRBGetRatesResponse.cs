namespace ExchangeRateMicroservice.Application.DTOs
{
    public class NBRBGetRateResponse
    {
        public List<NBRBRate> Rates { get; set; } = new List<NBRBRate>();
    }

    public class NBRBRate
    {
        public int Cur_ID { get; set; }
        public DateOnly Date { get; set; }
        public string Cur_Abbreviation { get; set; } = string.Empty;
        public double Cur_Scale { get; set; }
        public string Cur_Name { get; set; } = string.Empty;
        public double Cur_OfficialRate { get; set; }
    }
}
