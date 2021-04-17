using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Banks
{
    public interface IBanksApi
    {
        GetBanksResponse GetBanksInCountry(string country);
        GetBankBranchesResponse GetBankBranches(int id);
    }
}
