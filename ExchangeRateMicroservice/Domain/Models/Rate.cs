using System.ComponentModel.DataAnnotations;

namespace ExchangeRateMicroservice.Domain.Models
{
    public class Rate
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CurrencyId { get; set; }
        [Required]
        public DateOnly Date { get; set; }
        [Required]
        public double CurrencyScale { get; set; }
        [Required]
        public double CurrencyOfficialRate { get; set; }
        public string CurrencyAbbreviation { get; set; } = string.Empty;
        public string CurrencyName { get; set; } = string.Empty;
    }
}
