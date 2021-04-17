using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Bills
{
    public class CreateBulkBillsPaymentRequest
    {

        public class BulkDatum
        {
            [JsonProperty("country")]
            public string Country { get; set; }
            [JsonProperty("customer")]
            public string Customer { get; set; }
            [JsonProperty("amount")]
            public int Amount { get; set; }
            [JsonProperty("recurrence")]
            public string Recurrence { get; set; }
            [JsonProperty("type")]
            public string Type { get; set; }
            [JsonProperty("reference")]
            public string Reference { get; set; }

        }


        [JsonProperty("bulk_reference")]
        public string BulkReference { get; set; }
        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }
        [JsonProperty("bulk_data")]
        public List<BulkDatum> BulkData { get; set; }
    }
}
