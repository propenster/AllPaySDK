using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AllPaySDK.Paystack.Responses
{
    public class ListBanks
    {
        public class Datum
        {

            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("slug")]
            public string Slug { get; set; }

            [JsonPropertyName("code")]
            public string Code { get; set; }

            [JsonPropertyName("longcode")]
            public string Longcode { get; set; }

            [JsonPropertyName("gateway")]
            public string Gateway { get; set; }

            [JsonPropertyName("active")]
            public bool Active { get; set; }

            [JsonPropertyName("is_deleted")]
            public object IsDeleted { get; set; }

            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("createdAt")]
            public DateTime CreatedAt { get; set; }

            [JsonPropertyName("updatedAt")]
            public DateTime UpdatedAt { get; set; }
        }
    }

    public class ListBanksResponse //: HasRawResponse
    {

        [JsonPropertyName("status")]
        public bool Status { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("data")]
        public IList<ListBanks.Datum> Data { get; set; }
    }
}
