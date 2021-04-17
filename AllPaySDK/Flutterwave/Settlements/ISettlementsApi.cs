using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Settlements
{
    public interface ISettlementsApi
    {
        GetAllSettlementsResponse GetAllSettlements(DateTime from, int page = 1, string to = null, string subaccount_id = null);

        GetSingleSettlementResponse GetSingleSettlement(int id, string from = null, string to = null);
    }
}
