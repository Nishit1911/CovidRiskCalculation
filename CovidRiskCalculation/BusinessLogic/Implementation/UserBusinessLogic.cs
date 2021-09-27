using CovidRiskCalculation.Dtos;
using CovidRiskCalculation.Enum;
using System;
using System.Linq;

namespace CovidRiskCalculation.Repository
{
    public class UserBusinessLogic : IUserBusinessLogic
    {
        public string DeterminePincodeZone(string pinCode)
        {
            int postivePatientCount = CustomerRepository.customerInformations.Where(x => x.Pincode == pinCode && x.CovidResult == ECovidResult.Positive.ToString()).Count();
            EZones response;

            if (postivePatientCount == 0)
            { response = EZones.Green; }

            else if (postivePatientCount > 0 && postivePatientCount < 5)
            {
                response = EZones.Orange;
            }
            else
            {
                response = EZones.Red;
            }

            return response.ToString();
        }

        public decimal DetermineRiskPercentage(SelfAssessmentRequest selfAssessmentRequest)
        {
            int symtomsCount = selfAssessmentRequest.Symptoms.Distinct().Count();
            decimal response = 0;

            var userDetails = CustomerRepository.customerInformations.FirstOrDefault(x => x.CustomerId == selfAssessmentRequest.UserId);

            if (userDetails == null) throw new Exception("Customer is Not Registered");

            if (symtomsCount == 0 && !selfAssessmentRequest.HasTravelHistory && !selfAssessmentRequest.HasContactWithCovidPatient)
            {
                response = 5;
            }
            else if (selfAssessmentRequest.HasTravelHistory || selfAssessmentRequest.HasContactWithCovidPatient)
            {
                if (symtomsCount == 1) { response = 50; }
                else if (symtomsCount == 2) { response = 75; }
                else { response = 95; }
            }
            else
            {
                throw new Exception("InValid Input");
            }

            return response;
        }
    }
}
