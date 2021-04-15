using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AllPaySDK.Paystack.Responses
{
    public class ResolveAcountNumber
    {
        public class Data
        {

            [JsonPropertyName("account_number")]
            public string AccountNumber { get; set; }

            [JsonPropertyName("account_name")]
            public string AccountName { get; set; }
        }
    }

    public class ResolveAccountNumberResponse //: HasRawResponse
    {

        [JsonPropertyName("status")]
        public bool Status { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("data")]
        public ResolveAcountNumber.Data Data { get; set; }
    }
}
