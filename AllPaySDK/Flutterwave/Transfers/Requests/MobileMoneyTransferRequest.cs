using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Transfers.Requests
{
    public class MobileMoneyTransferRequest
    {
        [JsonProperty("account_bank")]
        public string account_bank { get; set; }
        [JsonProperty("account_number")]
        public string account_number { get; set; }
        [JsonProperty("amount")]
        public int amount { get; set; }
        [JsonProperty("narration")]
        public string narration { get; set; }
        [JsonProperty("currency")]
        public string currency { get; set; }
        [JsonProperty("reference")]
        public string reference { get; set; }
        [JsonProperty("beneficiary_name")]
        public string beneficiary_name { get; set; }
    }
}
