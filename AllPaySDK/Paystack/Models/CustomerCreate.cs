using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Paystack.Models
{
    public class CustomerCreate
    {

        public class Data
        {
            [JsonProperty("email")]
            public string Email { get; set; }

            [JsonProperty("integration")]
            public int Integration { get; set; }

            [JsonProperty("domain")]
            public string Domain { get; set; }

            [JsonProperty("customer_code")]
            public string CustomerCode { get; set; }

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("createdAt")]
            public DateTime CreatedAt { get; set; }

            [JsonProperty("updatedAt")]
            public DateTime UpdatedAt { get; set; }
        }
        
    }
}
