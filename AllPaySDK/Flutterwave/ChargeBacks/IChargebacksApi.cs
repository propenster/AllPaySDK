using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.ChargeBacks
{
    public interface IChargebacksApi
    {


        ListAllChargebacksResponse ListAllChargebacks(string status, string from, string to, int page = 1);

        AcceptOrDeclineChargebackResponse AcceptOrDeclineChargeback(string id, string action);
        ListAChargebackResponse ListAChargeback(string flw_ref);
    }

}
