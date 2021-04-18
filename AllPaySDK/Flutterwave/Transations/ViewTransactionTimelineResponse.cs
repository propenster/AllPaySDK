using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Transations
{
    public class ViewTransactionTimelineResponse
    {
        public class Datum
        {
            [JsonProperty("note")]
            public string Note { get; set; }
            [JsonProperty("actor")]
            public string Actor { get; set; }
            [JsonProperty("object")]
            public string Object { get; set; }
            [JsonProperty("action")]
            public string Action { get; set; }
            [JsonProperty("context")]
            public string Context { get; set; }
            [JsonProperty("created_at")]
            public DateTime CreatedAt { get; set; }
        }

        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public List<Datum> Data { get; set; }


    }



    

}
