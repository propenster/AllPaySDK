using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Payments.Card
{
   
    public class CardResponse
    {
        [JsonProperty("card_number")]
        public string card_number { get; set; }
        [JsonProperty("cvv")]
        public string Cvv { get; set; }
        [JsonProperty("expiry_month")]
        public string ExpiryMonth { get; set; }
        [JsonProperty("expiry_year")]
        public string ExpiryYear { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [JsonProperty("amount")]
        public string Amount { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("fullname")]
        public string FullName { get; set; }
        [JsonProperty("tx_ref")]
        public string TxRef { get; set; }
        [JsonProperty("redirect_url")]
        public string RedirectUrl { get; set; }
        [JsonProperty("authorization")]
        public Authorization Authorization { get; set; }
    }
}
