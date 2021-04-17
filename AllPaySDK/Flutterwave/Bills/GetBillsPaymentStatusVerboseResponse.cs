using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Bills
{
    public class GetBillsPaymentStatusVerboseResponse
    {

        public class Datum
        {
            [JsonProperty("currency")]
            public string Currency { get; set; }
            [JsonProperty("customer_id")]
            public string CustomerId { get; set; }
            [JsonProperty("frequency")]
            public string Frequency { get; set; }
            [JsonProperty("amount")]
            public string Amount { get; set; }
            [JsonProperty("product")]
            public string product { get; set; }
            [JsonProperty("product_name")]
            public string ProductName { get; set; }
            [JsonProperty("commission")]
            public int Commission { get; set; }
            [JsonProperty("transaction_date")]
            public DateTime TransactionDate { get; set; }
            [JsonProperty("country")]
            public string Country { get; set; }
            [JsonProperty("tx_ref")]
            public string TxRef { get; set; }
            [JsonProperty("extra")]
            public object Extra { get; set; }
            [JsonProperty("product_details")]
            public string ProductDetails { get; set; }
            [JsonProperty("status")]
            public string Status { get; set; }
        }





        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public Datum Data { get; set; }
    }

    
    
}
