using CovidRiskCalculation.Dtos;

namespace CovidRiskCalculation.Repository
{
   public interface ICustomerRepository
    {
        public string RegisterCustomer(CustomerInformation customerInformation);
    }
}
