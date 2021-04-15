using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AllPaySDK.Paystack.Responses
{
    public class ResolveBVN
    {
        public class Data
        {
            [JsonPropertyName("first_name")]
            public string FirstName { get; set; }

            [JsonPropertyName("last_name")]
            public string LastName { get; set; }

            [JsonPropertyName("dob")]
            public string Dob { get; set; }

            [JsonPropertyName("mobile")]
            public string Mobile { get; set; }

            [JsonPropertyName("bvn")]
            public string Bvn { get; set; }
        }

        public class Meta
        {

            [JsonPropertyName("calls_this_month")]
            public int CallsThisMonth { get; set; }

            [JsonPropertyName("free_calls_left")]
            public int FreeCallsLeft { get; set; }
        }
    }

    public class ResolveBVNResponse //: HasRawResponse
    {

        [JsonPropertyName("status")]
        public bool Status { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("data")]
        public ResolveBVN.Data Data { get; set; }

        [JsonPropertyName("meta")]
        public ResolveBVN.Meta Meta { get; set; }
    }
}
