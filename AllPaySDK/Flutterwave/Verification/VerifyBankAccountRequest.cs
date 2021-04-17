using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Verification
{
    public class VerifyBankAccountRequest
    {
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }
        [JsonProperty("account_bank")]
        public string AccountBank { get; set; }
    }
}
