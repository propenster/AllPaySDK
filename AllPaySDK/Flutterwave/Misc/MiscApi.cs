using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Misc
{
    public class MiscApi : IMiscApi
    {
        private readonly FlutterwaveApi _api;

        public MiscApi(FlutterwaveApi api)
        {
            _api = api;
        }

        public FxRatesResponse FxRates(string from, string to, int amount) => _api.GetWithParameters<FxRatesResponse>("rates", new Dictionary<string, object>()
        {
            {"from", from },
            {"to", to },
            {"amount", amount }
        });
        

        public GetAllWalletBalancesResponse GetAllWalletBalances() => _api.Get<GetAllWalletBalancesResponse>("balances");

        public GetBalancesPerCurrencyResponse GetBalancesPerCurrrency(string currency) => _api.Get<GetBalancesPerCurrencyResponse>($"balances/{currency}");

        public ResolveAccountDetailsResponse ResolveAccountDetails(ResolveAccountDetailsRequest resolveAccountDetailsRequest) => _api.Post<ResolveAccountDetailsResponse>("accounts/resolve", resolveAccountDetailsRequest);


        public ResolveAccountDetailsResponse ResolveAccountDetails(string account_number, string account_bank)
        => ResolveAccountDetails(new ResolveAccountDetailsRequest
        {
            AccountNumber = account_number,
            AccountBank = account_bank
        });

        public ResolveBVNDetailsResponse ResolveBVNDetails(ResolveBvnDetailsRequest resolveBvnDetailsRequest)

        => _api.Get<ResolveBVNDetailsResponse>($"kyc/bvns/{resolveBvnDetailsRequest.Bvn}"); //I'll still remove this

        public ResolveBVNDetailsResponse ResolveBVNDetails(string bvn) => _api.Get<ResolveBVNDetailsResponse>($"kyc/bvns/{bvn}");

        public ResolveCardBinsResponse ResolveCardBins(int bin) => _api.Get<ResolveCardBinsResponse>($"card-bins/{bin}");
        
    }
}
