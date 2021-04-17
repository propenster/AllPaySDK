using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Bills
{
    public class GetBillPaymentStatusNormalResponse
    {
        public class Datum
        {
            [JsonProperty("tx_ref")]
            public string TxRef { get; set; }
            [JsonProperty("amount")]
            public int Amount { get; set; }
            [JsonProperty("fee")]
            public int Fee { get; set; }
            [JsonProperty("currency")]
            public object Currency { get; set; }
            [JsonProperty("extra")]
            public object Extra { get; set; }
            [JsonProperty("flw_ref")]
            public string FlwRef { get; set; }
            [JsonProperty("token")]
            public object Token { get; set; }
        }



        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public Datum Data { get; set; }
    }

    
    

}
