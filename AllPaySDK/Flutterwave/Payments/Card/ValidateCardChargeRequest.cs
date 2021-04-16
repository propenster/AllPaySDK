using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Payments.Card
{
    public class ValidateCardChargeRequest
    {
        [JsonProperty("otp")]
        public string Otp { get; set; }
        [JsonProperty("flw_ref")]
        public string FlwRef { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
