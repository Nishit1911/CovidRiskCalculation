using CovidRiskCalculation.Enum;

namespace CovidRiskCalculation.Dtos
{
    public class CustomerInformation
    {
        public string CustomerId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Pincode { get; set; }
        public bool IsAdmin { get; set; }
        public string CovidResult { get; set; }
    }
}
