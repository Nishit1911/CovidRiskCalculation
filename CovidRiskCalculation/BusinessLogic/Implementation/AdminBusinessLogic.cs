using CovidRiskCalculation.Dtos;
using CovidRiskCalculation.Repository;
using System;
using System.Linq;

namespace CovidRiskCalculation.BusinessLogic
{
    public class AdminBusinessLogic : IAdminBusinessLogic
    {
        public bool UpdateCovidResult(UpdateCovidResultRequest updateCovidResultRequest)
        {
            bool response = true;

            CustomerInformation adminDetails = CustomerRepository.customerInformations.FirstOrDefault(x => x.CustomerId == updateCovidResultRequest.AdminId && x.IsAdmin);

            if (adminDetails == null) throw new Exception("Customer is Not Registered or Is Not a Admin");

            CustomerInformation userDetails;
            if (updateCovidResultRequest.AdminId.Equals(updateCovidResultRequest.UserId))
            {
                userDetails = adminDetails;
            }
            else
            {
                userDetails = CustomerRepository.customerInformations.FirstOrDefault(x => x.CustomerId == updateCovidResultRequest.UserId);
                if (userDetails == null) throw new Exception("Customer is Not Registered");
            }

            userDetails.CovidResult = updateCovidResultRequest.CovidResult;
            CustomerRepository.customerInformations.Remove(userDetails);
            CustomerRepository.customerInformations.Add(userDetails);

            return response;
        }
    }
}
