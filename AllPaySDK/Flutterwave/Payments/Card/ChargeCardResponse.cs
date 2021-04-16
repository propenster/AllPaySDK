﻿
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Payments.Card
{
   

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Customer
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("phone_number")]
        public object PhoneNumber { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
    }

    public class Card
    {
        [JsonProperty("first_6digits")]
        public string First6digits { get; set; }
        [JsonProperty("last_4digits")]
        public string Last4digits { get; set; }
        [JsonProperty("issuer")]
        public string Issuer { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("expiry")]
        public string Expiry { get; set; }
    }

    public class Data
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("tx_ref")]
        public string TxRef { get; set; }
        [JsonProperty("flw_ref")]
        public string FlwRef { get; set; }
        [JsonProperty("device_fingerprint")]
        public string DeviceFingerprint { get; set; }
        [JsonProperty("amount")]
        public int Amount { get; set; }
        [JsonProperty("charged_amount")]
        public int ChargedAmount { get; set; }
        [JsonProperty("app_fee")]
        public double AppFee { get; set; }
        [JsonProperty("merchant_fee")]
        public int MerchantFee { get; set; }
        [JsonProperty("processor_response")]
        public string ProcessorResponse { get; set; }
        [JsonProperty("auth_model")]
        public string AuthModel { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [JsonProperty("ip")]
        public string Ip { get; set; }
        [JsonProperty("narration")]
        public string Narration { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("auth_url")]
        public string AuthUrl { get; set; }
        [JsonProperty("payment_type")]
        public string PaymentType { get; set; }
        [JsonProperty("fraud_status")]
        public string FraudStatus { get; set; }
        [JsonProperty("charge_type")]
        public string ChargeType { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("account_id")]
        public int AccountId { get; set; }
        [JsonProperty("customer")]
        public Customer Customer { get; set; }
        [JsonProperty("card")]
        public Card Card { get; set; }
    }

    public class Meta
    {
        [JsonProperty("authorization")]
        public Authorization Authorization { get; set; }
    }

    public class ChargeCardResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public Data Data { get; set; }
        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }


}
