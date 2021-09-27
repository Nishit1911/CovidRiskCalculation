using System.Collections.Generic;

namespace CovidRiskCalculation.Dtos
{
    public class SelfAssessmentRequest
    {
        public string UserId { get; set; }
        public List<string> Symptoms { get; set; }
        public bool HasTravelHistory { get; set; }
        public bool HasContactWithCovidPatient { get; set; }
    }
}
