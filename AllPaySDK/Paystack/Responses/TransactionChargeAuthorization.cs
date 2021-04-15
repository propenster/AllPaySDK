using AllPaySDK.Paystack.Models;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace AllPaySDK.Paystack.Responses
{
    public class ChargeAuthorizationRequest : RequestMetadataExtender
    {
        public string Reference { get; set; }

        [JsonPropertyName("authorization_code")]
        public string AuthorizationCode { get; set; }

        public string Currency { get; set; }

        [JsonPropertyName("amount")]
        public int AmountInKobo { get; set; }

        public string Email { get; set; }

        public string SubAccount { get; set; }

        [JsonPropertyName("transaction_charge")]
        public int TransactionCharge { get; set; }

        public string Bearer { get; set; }
    }

    public class ChargeAuthorizationResponse //: HasRawResponse
    {
        [JsonPropertyName("status")]
        public bool Status { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("data")]
        public TransactionList.Datum Data { get; set; }
    }
}
