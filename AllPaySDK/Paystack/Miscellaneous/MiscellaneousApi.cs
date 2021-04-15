using AllPaySDK.Paystack.Interfaces;
using AllPaySDK.Paystack.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Paystack.Miscellaneous
{
    public class MiscellaneousApi : IMiscellaneousApi
    {

        private readonly PaystackApi _api;

        public MiscellaneousApi(PaystackApi api) => _api = api;

        public ListBanksResponse ListBanks(int itemsPerPage = 50, int page = 1)
        => _api.GetWithParameters<ListBanksResponse>("bank",
            new Dictionary<string, object>()
            {
                {"perPage", itemsPerPage },
                {"page", page }
            }

            );

        public ResolveAccountNumberResponse ResolveAccountNumber(string accountNumber, string bankCode) => _api.GetWithParameters<ResolveAccountNumberResponse>("bank/resolve", new Dictionary<string, object>()
        {
            {"bank_code", bankCode },
            {"account_number", accountNumber }
        });
        
        public ResolveBVNResponse ResolveBVN(string bvn)
        => _api.Get<ResolveBVNResponse>($"bank/resolve_bvn/{bvn}");

        public ResolveCardBinResponse ResolveCardBin(string cardBin)
        => _api.Get<ResolveCardBinResponse>($"decision/bin/{cardBin}");

    }
}
