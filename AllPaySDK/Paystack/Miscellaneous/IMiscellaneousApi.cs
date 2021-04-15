using AllPaySDK.Paystack.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Paystack.Miscellaneous
{
    public interface IMiscellaneousApi
    {
        ListBanksResponse ListBanks(int itemsPerPage = 50, int page = 1);
        ResolveCardBinResponse ResolveCardBin(string cardBin);

        ResolveBVNResponse ResolveBVN(string bvn);

        ResolveAccountNumberResponse ResolveAccountNumber(string accountNumber, string bankCode);
    }
}
