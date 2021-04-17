using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Otps
{
    public class CreateOtpResponse
    {


        public class Datum
        {
            [JsonProperty("medium")]
            public string Medium { get; set; }
            [JsonProperty("reference")]
            public string Reference { get; set; }
            [JsonProperty("otp")]
            public string Otp { get; set; }
            [JsonProperty("expiry")]
            public DateTime Expiry { get; set; }
        }

        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public List<Datum> Data { get; set; }

    }

}
