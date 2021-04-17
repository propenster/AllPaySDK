using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Misc
{
    public class FxRatesResponse
    {

        public class From
        {
            [JsonProperty("currency")]
            public string Currency { get; set; }
            [JsonProperty("amount")]
            public int Amount { get; set; }
        }

        public class To
        {
            [JsonProperty("currency")]
            public string Currency { get; set; }
            [JsonProperty("amount")]
            public int Amount { get; set; }
        }

        public class Datum
        {
            [JsonProperty("rate")]
            public int Rate { get; set; }
            [JsonProperty("from")]
            public From From { get; set; }
            [JsonProperty("to")]
            public To To { get; set; }
        }

        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public Datum Data { get; set; }
    }




}
