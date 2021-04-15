using AllPaySDK.Paystack.Customers;
using AllPaySDK.Paystack.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Paystack.Customers
{
    public class CustomersApi : ICustomersApi
    {
        private readonly PaystackApi _api;

        public CustomersApi(PaystackApi api)
        {
            _api = api;
        }

        public CustomerCreateResponse Create(CustomerCreateRequest request) => _api.Post<CustomerCreateResponse>("customer", request);


        public CustomerCreateResponse Create(string email) => Create(new CustomerCreateRequest { Email = email });
       

        public CustomerFetchResponse Fetch(string customerIdOrCustomerCode) =>
            _api.Get<CustomerFetchResponse>($"customer/{customerIdOrCustomerCode}");

        public CustomerListResponse List(int perPage = 50, int page = 1) => _api.GetWithParameters<CustomerListResponse>("customer",

            new Dictionary<string, object>()
            {
                {"perPage", perPage  },
                {"page",  page }
            });
               

        public CustomerUpdateResponse Update(string customerIdOrCode, string firstName = null, string lastName = null, string phone = null)
        =>
            _api.Put<CustomerUpdateResponse>($"customer/{customerIdOrCode}", 
                new CustomerUpdateRequest()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Phone = phone,
                }
                );

        public CustomerUpdateResponse Update(string customerIdOrCode, CustomerUpdateRequest request) => _api.Put<CustomerUpdateResponse>($"customer/{customerIdOrCode}", request);
        
        public CustomerSetRiskActionResponse SetRiskAction(string customerIdCodeOrEmail, string riskAction)
        =>
            _api.Post<CustomerSetRiskActionResponse>(
                "customer/set_risk_action",
                new CustomerSetRiskActionRequest { Customer = customerIdCodeOrEmail, RiskAction = riskAction }
            );
        public CustomerSetRiskActionResponse WhiteList(string customerIdCodeOrEmail) => SetRiskAction(customerIdCodeOrEmail, "allow");
        public CustomerSetRiskActionResponse BlackList(string customerIdCodeOrEmail) => SetRiskAction(customerIdCodeOrEmail, "deny");

    }
}
