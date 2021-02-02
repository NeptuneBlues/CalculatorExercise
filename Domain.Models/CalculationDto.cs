namespace Domain.Models
{
    public class CalculationDto
    {
        public int FirstInput { get; set; }
        public int SecondInput { get; set; }
        public string Operator { get; set; }
        public decimal Result { get; set; }
        public string Error { get; set; }
    }
}