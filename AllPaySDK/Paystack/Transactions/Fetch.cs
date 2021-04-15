﻿using Newtonsoft.Json;

namespace AllPaySDK.Paystack.Transactions
{
    public class TransactionFetchResponse //: HasRawResponse
    {
        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public TransactionList.Datum Data { get; set; }
    }
}