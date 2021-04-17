using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Banks
{
    public class BanksApi : IBanksApi
    {
        private readonly FlutterwaveApi _api;

        public BanksApi(FlutterwaveApi api)
        {
            _api = api;
        }

        public GetBankBranchesResponse GetBankBranches(int id) => _api.Get<GetBankBranchesResponse>($"banks/{id}/branches");
        

        public GetBanksResponse GetBanksInCountry(string country) => _api.Get<GetBanksResponse>($"banks/{country}");
        
    }
}
