using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Misc
{
    public interface IMiscApi
    {
        GetAllWalletBalancesResponse GetAllWalletBalances();
        GetBalancesPerCurrencyResponse GetBalancesPerCurrrency(string currency);
        ResolveAccountDetailsResponse ResolveAccountDetails(ResolveAccountDetailsRequest resolveAccountDetailsRequest);
        ResolveAccountDetailsResponse ResolveAccountDetails(string account_number, string account_bank);
        ResolveBVNDetailsResponse ResolveBVNDetails(ResolveBvnDetailsRequest resolveBvnDetailsRequest);
        ResolveBVNDetailsResponse ResolveBVNDetails(string bvn);
        ResolveCardBinsResponse ResolveCardBins(int bin);
        FxRatesResponse FxRates(string from, string to, int amount);

    }
}
