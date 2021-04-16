using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Payments.Card
{
    public class CardPaymentRequest
    {
        [JsonProperty("tx_ref")]
        public string TxRef { get; set; }
        [JsonProperty("amount")]
        public string Amount { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [JsonProperty("card_number")]
        public string CardNumber { get; set; }
        [JsonProperty("cvv")]
        public string Cvv { get; set; }
        [JsonProperty("expiry_month")]
        public string ExpiryMonth { get; set; }
        [JsonProperty("expiry_year")]
        public string ExpiryYear { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
        [JsonProperty("client_ip")]
        public string ClientIp { get; set; }
        [JsonProperty("device_fingerprint")]
        public string DeviceFingerprint { get; set; }
        [JsonProperty("meta")]
        public object Meta { get; set; }
        [JsonProperty("fullname")]
        public string FullName { get; set; }
        [JsonProperty("authorization")]
        public Authorization Authorization { get; set; }
        [JsonProperty("preauthorize")]
        public bool Preauthorize { get; set; }
        [JsonProperty("mode")]
        public string Mode { get; set; }
        [JsonProperty("redirect_url")]
        public string RedirectUrl { get; set; }
    }

    public class Authorization
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
        [JsonProperty("pin")]
        public string Pin { get; set; }
    }



}
