using AllPaySDK.Flutterwave.Payments.Card;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Transations
{

    //public class Card
    //{
    //    public string first_6digits { get; set; }
    //    public string last_4digits { get; set; }
    //    public string issuer { get; set; }
    //    public string country { get; set; }
    //    public string type { get; set; }
    //    public string token { get; set; }
    //    public string expiry { get; set; }
    //}

    //public class Customer
    //{
    //    public int id { get; set; }
    //    public string name { get; set; }
    //    public string phone_number { get; set; }
    //    public string email { get; set; }
    //    public DateTime created_at { get; set; }
    //}



    //[JsonProperty("auth_url")]
    //public string AuthUrl { get; set; }

    //[JsonProperty("fraud_status")]
    //public string FraudStatus { get; set; }
    //[JsonProperty("charge_type")]
    //public string ChargeType { get; set; }

    //[JsonProperty("customer")]

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
        [JsonProperty("currency")]
        public string Currency { get; set; }
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
        [JsonProperty("ip")]
        public string Ip { get; set; }
        [JsonProperty("narration")]
        public string Narration { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("payment_type")]
        public string PaymentType { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("account_id")]
        public int AccountId { get; set; }
        [JsonProperty("amount_settled")]
        public int AmountSettled { get; set; }
        [JsonProperty("card")]
        public Card Card { get; set; }
        [JsonProperty("customer")]
        public Customer Customer { get; set; }
    }


    public class VerifyTransactionResponse
    {

        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public Data Data { get; set; }
    }


}
