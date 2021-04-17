using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Bills
{
    public class CreateBillPaymentRequest
    {
        [JsonRequired]
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonRequired]
        [JsonProperty("customer")]
        public string Customer { get; set; }
        [JsonRequired]
        [JsonProperty("amount")]
        public string Amount { get; set; }
        [JsonProperty("recurrence")]
        public string Recurrence { get; set; }
        [JsonRequired]
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("reference")]
        public string Reference { get; set; }
        [JsonProperty("biller_name")]
        public string BillerName { get; set; }
    }

 }
