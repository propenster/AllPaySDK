using AllPaySDK.Paystack.Models;
using AllPaySDK.Paystack.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Paystack.SubAccounts
{
    public class SubAccountApi : ISubAccountApi
    {

        private readonly PaystackApi _api;

        public SubAccountApi(PaystackApi api)
        {
            _api = api;
        }
        public SubAccountCreateResponse Create(SubAccountCreateRequest request) => _api.Post<SubAccountCreateResponse>("subaccount", request);

        public SubAccountCreateResponse Create(string businessName, string settlementBank, string accountNumber, string percentageCharge)
        => Create(new SubAccountCreateRequest { BusinessName = businessName, SettlementBank = settlementBank, AccountNumber = accountNumber, PercentageCharge = percentageCharge });
        //change slug to subaccouunt_code
        public SubAccountFetchResponse Fetch(string idOrSlug) => _api.Get<SubAccountFetchResponse>($"subaccount/{idOrSlug}");

        public PayStackBankResponse GetBanks(int perPage = 50, int page = 1) => _api.GetWithParameters<PayStackBankResponse>("bank", new Dictionary<string, object>()
        {
            { "per_page", perPage },
            { "page", page }
        });


        public SubAccountListResponse List(int perPage = 50, int page = 1) => _api.GetWithParameters<SubAccountListResponse>("subaccount", new Dictionary<string, object>()
        {
            {"per_page", perPage },
            {"page", page }
        });


        public SubAccountUpdateResponse Update(string idOrSlug, SubAccountUpdateRequest request) => _api.Put<SubAccountUpdateResponse>($"subaccount/{idOrSlug}", request);

    }
}
