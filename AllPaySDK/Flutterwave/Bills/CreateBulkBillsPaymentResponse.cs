using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Bills
{
    public class CreateBulkBillsPaymentResponse
    {
        public class Datum
        {
            [JsonProperty("batch_reference")]
            public string BatchReference { get; set; }
        }

        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public Datum Data { get; set; }
    }

    
}
