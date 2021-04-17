using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Misc
{
    public class ResolveAccountDetailsResponse
    {
        public class AccountData
        {
            [JsonProperty("account_number")]
            public string AccountNumber { get; set; }
            [JsonProperty("account_name")]
            public string AccountName { get; set; }
        }


        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public AccountData Data { get; set; }
    }


    

     
    
}
