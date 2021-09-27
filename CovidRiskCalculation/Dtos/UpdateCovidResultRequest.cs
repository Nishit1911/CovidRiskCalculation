using CovidRiskCalculation.Enum;

namespace CovidRiskCalculation.Dtos
{
    public class UpdateCovidResultRequest
    {
        public string UserId { get; set; }
        public string AdminId { get; set; }
        public string CovidResult { get; set; }
    }
}
