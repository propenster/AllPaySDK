using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Bills
{
    public class ValidateBillServiceResponse
    {

        public class Datum
        {
            [JsonProperty("response_code")]
            public string ResponseCode { get; set; }
            [JsonProperty("address")]
            public object Address { get; set; }
            [JsonProperty("response_message")]
            public string ResponseMessage { get; set; }
            [JsonProperty("name")]
            public string Name { get; set; }
            [JsonProperty("biller_code")]
            public string BillerCode { get; set; }
            [JsonProperty("customer")]
            public string Customer { get; set; }
            [JsonProperty("product_code")]
            public string ProductCode { get; set; }
            [JsonProperty("email")]
            public object Email { get; set; }
            [JsonProperty("fee")]
            public int Fee { get; set; }
            [JsonProperty("maximum")]
            public int Maximum { get; set; }
            [JsonProperty("minimum")]
            public int Minimum { get; set; }
        }


        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public Datum Data { get; set; }
    }

    

   
}
