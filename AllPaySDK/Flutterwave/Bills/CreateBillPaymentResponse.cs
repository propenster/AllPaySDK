using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Bills
{
    public class CreateBillPaymentResponse
    {


        public class Datum
        {
            [JsonProperty("phone_number")]
            public string PhoneNumber { get; set; }
            [JsonProperty("amount")]
            public int Amount { get; set; }
            [JsonProperty("network")]
            public string Network { get; set; }
            [JsonProperty("flw_ref")]
            public string FlwRef { get; set; }
            [JsonProperty("tx_ref")]
            public string TxRef { get; set; }
        }



        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public Datum Data { get; set; }
    }

    

}
