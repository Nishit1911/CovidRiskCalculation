using CovidRiskCalculation.BusinessLogic;
using CovidRiskCalculation.Dtos;
using CovidRiskCalculation.Enum;
using CovidRiskCalculation.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CovidRiskCalculation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CovidRiskController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUserBusinessLogic _userBusinessLogic;
        private readonly IAdminBusinessLogic _adminBusinessLogic;
        public CovidRiskController(ICustomerRepository customerRepository, IUserBusinessLogic userBusinessLogic, IAdminBusinessLogic adminBusinessLogic) { _customerRepository = customerRepository; _userBusinessLogic = userBusinessLogic; _adminBusinessLogic = adminBusinessLogic; }

        [HttpPost]
        [Route("RegisterCustomer")]
        public string RegisterCustomer(CustomerInformation customerInformation)
        {
            return _customerRepository.RegisterCustomer(customerInformation);
        }

        [HttpPost]
        [Route("DetermineZone")]
        public string DetermineZone(string pinCode)
        {
            return _userBusinessLogic.DeterminePincodeZone(pinCode);
        }

        [HttpPost]
        [Route("TakeSelfAssessmentTest")]
        public decimal TakeSelfAssessmentTest(SelfAssessmentRequest selfAssessment)
        {
            return _userBusinessLogic.DetermineRiskPercentage(selfAssessment);
        }

        [HttpPost]
        [Route("UpdateCovidResult")]
        public bool DetermineZone(UpdateCovidResultRequest updateCovidResult)
        {
            return _adminBusinessLogic.UpdateCovidResult(updateCovidResult);
        }

    }
}
