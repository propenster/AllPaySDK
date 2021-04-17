using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Settlements
{
    public class SettlementsApi : ISettlementsApi
    {
        private readonly FlutterwaveApi _api;

        public SettlementsApi(FlutterwaveApi api)
        {
            _api = api;
        }
        /// <summary>
        /// This utility fetches all settlements
        /// </summary>
        /// <param name="from">This is the specified date to start the list from. YYYY-MM-DD</param>
        /// <param name="page">This is the page number to retrieve e.g. setting 1 retrieves the first page</param>
        /// <param name="to">The is the specified end period for the search . YYYY-MM-DD</param>
        /// <param name="subaccount_id">This is the unique id of the sub account you want to fetch. It is returned in the call to create a sub account</param>
        /// <returns>GetAllSettlementsResponse</returns>
        public GetAllSettlementsResponse GetAllSettlements(DateTime from, int page = 1, string to = null, string subaccount_id = null)
        => _api.GetWithParameters<GetAllSettlementsResponse>("settlements", new Dictionary<string, object>()
        {
            {"page", 1 },
            {"from", from },
            {"to", to },
            {"subaccount_id", subaccount_id }
        });
        /// <summary>
        /// This allows you to fetch and search all your settlements
        /// </summary>
        /// <param name="id">This is a unique identifier for the particular settlement you want to fetch. It is returned in the call to list all settlements as data.id</param>
        /// <param name="from">The start date range to retrieve data from. YYYY:MM:DD</param>
        /// <param name="to">The end date range to retrieve data. YYYY:MM:DD</param>
        /// <returns>GetSingleSettlementResponse</returns>
        public GetSingleSettlementResponse GetSingleSettlement(int id, string from = null, string to = null)
        => _api.GetWithParameters<GetSingleSettlementResponse>($"settlements/{id}", new Dictionary<string, object>()
        {
            {"from", from },
            {"to", to }
        });
    }


}
