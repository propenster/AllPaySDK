using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AllPaySDK.Paystack.Responses
{
    public class ResolveCardBin
    {
        public class Data
        {
            [JsonPropertyName("bin")]
            public string Bin { get; set; }

            [JsonPropertyName("brand")]
            public string Brand { get; set; }

            [JsonPropertyName("sub_brand")]
            public string SubBrand { get; set; }

            [JsonPropertyName("country_code")]
            public string CountryCode { get; set; }

            [JsonPropertyName("country_name")]
            public string CountryName { get; set; }

            [JsonPropertyName("card_type")]
            public string CardType { get; set; }

            [JsonPropertyName("bank")]
            public string Bank { get; set; }

            [JsonPropertyName("linked_bank_id")]
            public int? LinkedBankId { get; set; }
        }
    }

    public class ResolveCardBinResponse //: HasRawResponse
    {
        [JsonPropertyName("status")]
        public bool Status { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("data")]
        public ResolveCardBin.Data Data { get; set; }
    }
}
