using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AllPaySDK.Paystack.Responses
{
    public class TransactionExportRequest
    {
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public bool? Settled { get; set; }

        // Had to go against the rule here (use of underscore), because of query params!
        public string Payment_Page { get; set; }

        public int? Customer { get; set; }

        public string Currency { get; set; }

        public int? Settlement { get; set; }

        public int? Amount { get; set; }

        public string Status { get; set; }
    }

    public class TransactionExport
    {
        public class Data
        {
            [JsonPropertyName("path")]
            public string Path { get; set; }
        }
    }

    public class TransactionExportResponse //: HasRawResponse
    {
        [JsonPropertyName("status")]
        public bool Status { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("data")]
        public TransactionExport.Data Data { get; set; }
    }
}
