using AllPaySDK.Paystack.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AllPaySDK.Paystack.Responses
{
    public class ReAuthorizationRequest : RequestMetadataExtender
    {
        public string Reference { get; set; }

        [JsonPropertyName("authorization_code")]
        public string AuthorizationCode { get; set; }

        public string Currency { get; set; }

        [JsonPropertyName("amount")]
        public int AmountInKobo { get; set; }

        public string Email { get; set; }
    }

    public class ReAuthorizationResponse //: HasRawResponse
    {
        [JsonPropertyName("status")]
        public bool Status { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("data")]
        public ReAuthorizationData Data { get; set; }
    }

    public class ReAuthorizationData
    {
        [JsonPropertyName("reauthorization_url")]
        public string ReAuthorizationUrl { get; set; }

        public string Reference { get; set; }
    }
}
