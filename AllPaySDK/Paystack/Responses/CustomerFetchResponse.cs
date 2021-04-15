﻿using AllPaySDK.Paystack.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Paystack.Responses
{
    
        public class CustomerFetchResponse 
        {

            [JsonProperty("status")]
            public bool Status { get; set; }

            [JsonProperty("message")]
            public string Message { get; set; }

            [JsonProperty("data")]
            public CustomerList.Datum Data { get; set; }
        }
    
}
