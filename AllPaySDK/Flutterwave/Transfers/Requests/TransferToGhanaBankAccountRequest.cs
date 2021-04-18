using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Transfers.Requests
{
    public class TransferToGhanaBankAccountRequest
    {
        [JsonRequired]
        [JsonProperty("account_bank")]
        public string account_bank { get; set; }
        [JsonRequired]
        [JsonProperty("account_number")]
        public string account_number { get; set; }
        [JsonRequired]
        [JsonProperty("amount")]
        public int amount { get; set; }
        [JsonProperty("narration")]
        public string narration { get; set; }
        [JsonRequired]
        [JsonProperty("currency")]
        public string currency { get; set; }
        [JsonProperty("reference")]
        public string reference { get; set; }
        [JsonProperty("callback_url")]
        public string callback_url { get; set; }
        [JsonProperty("destination_branch_code")]
        public string destination_branch_code { get; set; }
        [JsonProperty("beneficiary_name")]
        public string beneficiary_name { get; set; }


    }


}
