using CovidRiskCalculation.Dtos;

namespace CovidRiskCalculation.BusinessLogic
{
    public interface IAdminBusinessLogic
    {
        public bool UpdateCovidResult(UpdateCovidResultRequest updateCovidResultRequest);
    }
}
