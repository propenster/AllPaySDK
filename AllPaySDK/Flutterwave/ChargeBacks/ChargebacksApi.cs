using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.ChargeBacks
{
    public class ChargebacksApi : IChargebacksApi
    {

        private readonly FlutterwaveApi _api;

        public ChargebacksApi(FlutterwaveApi api)
        {
            _api = api;
        }
        /// <summary>
        /// This allows you to perform actions like decline or accept chargebacks on your account
        /// </summary>
        /// <param name="id">Unique identifier for the chargeback you want to accept/decline</param>
        /// <param name="action">This is the action you want to perform on the chargeback. It can be accept or decline</param>
        /// <returns></returns>
        public AcceptOrDeclineChargebackResponse AcceptOrDeclineChargeback(string id, string action) => _api.GetWithParameters<AcceptOrDeclineChargebackResponse>($"chargebacks/{id}", new Dictionary<string, object>()
        {
            {"action", action }
        });

        public ListAChargebackResponse ListAChargeback(string flw_ref) => _api.GetWithParameters<ListAChargebackResponse>("chargebacks", new Dictionary<string, object>()
        {
            {"flw_ref", flw_ref }
        });
        


        /// <summary>
        /// This allows you to fetch all chargebacks on your account
        /// </summary>
        /// <param name="status">This specifies the status of the chargebacks you want to fetch. It can be lost, won, initiated, accepted, declined </param>
        /// <param name="from">This is the start date for the record you want to fetch. Date format is YYYY-MM-DD</param>
        /// <param name="to">This is the end date for the record you want to fetch. Date format is YYYY-MM-DD</param>
        /// <param name="page">This specifies which page you want to fetch.</param>
        /// <returns>ListAllChargebacksResponse</returns>
        public ListAllChargebacksResponse ListAllChargebacks(string status, string from, string to, int page = 1)
        => _api.GetWithParameters<ListAllChargebacksResponse>("chargebacks", new Dictionary<string, object>()
        {
            {"page", page },
            {"status", status },
            {"from", from },
            {"to", to }
        });
    }
}
