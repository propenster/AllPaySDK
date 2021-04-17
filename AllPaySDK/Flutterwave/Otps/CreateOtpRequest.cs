using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Otps
{
    public class CreateOtpRequest
    {


        public class CustomerData
        {
            [JsonProperty("name")]
            public string Name { get; set; }
            [JsonProperty("email")]
            public string Email { get; set; }
            [JsonProperty("phone")]
            public string Phone { get; set; }
        }


        [JsonProperty("length")]
        public int Length { get; set; }
        [JsonProperty("customer")]
        public CustomerData Customer { get; set; }
        [JsonProperty("sender")]
        public string Sender { get; set; }
        [JsonProperty("send")]
        public bool Send { get; set; }
        [JsonProperty("medium")]
        public List<string> Medium { get; set; }
        [JsonProperty("expiry")]
        public int Expiry { get; set; }


    }


}
