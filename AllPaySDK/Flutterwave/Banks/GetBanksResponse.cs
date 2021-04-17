using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Banks
{
    public class GetBanksResponse
    {


        public class Datum
        {
            [JsonProperty("id")]
            public int Id { get; set; }
            [JsonProperty("code")]
            public string Code { get; set; }
            [JsonProperty("name")]
            public string Name { get; set; }
        }

        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public List<Datum> Data { get; set; }
    }

    

    

}
