using CovidRiskCalculation.Dtos;
using System;
using System.Collections.Generic;

namespace CovidRiskCalculation.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public static List<CustomerInformation> customerInformations = new List<CustomerInformation>();

        public string RegisterCustomer(CustomerInformation customerInformation)
        {
            var customerId = Guid.NewGuid().ToString();
            customerInformation.CustomerId = customerId;
            customerInformations.Add(customerInformation);
            return customerId;
        }

    }
}
