using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Misc
{
    public class GetBalancesPerCurrencyResponse
    {


        public class Datum
        {
            [JsonProperty("currency")]
            public string Currency { get; set; }
            [JsonProperty("available_balance")]
            public int AvailableBalance { get; set; }
            [JsonProperty("ledger_balance")]
            public double LedgerBalance { get; set; }
        }


        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public Datum Data { get; set; }

    }

    

    
}
