using CovidRiskCalculation.Dtos;
using CovidRiskCalculation.Enum;

namespace CovidRiskCalculation.Repository
{
    public interface IUserBusinessLogic
    {
        public decimal DetermineRiskPercentage(SelfAssessmentRequest selfAssessmentRequest);
        public string DeterminePincodeZone(string pinCode);
    }
}
