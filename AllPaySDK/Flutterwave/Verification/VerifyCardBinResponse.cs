using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Verification
{
    public class VerifyCardBinResponse
    {
        
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public CardData Data { get; set; }  

    }

    public class CardData
    {

        [JsonProperty("issuing_country")]
        public string IssuingCountry { get; set; }
        [JsonProperty("bin")]
        public string Bin { get; set; }
        [JsonProperty("card_type")]
        public string CardType { get; set; }
        [JsonProperty("issuer_info")]
        public string IssuerInfo { get; set; }
    }



}
