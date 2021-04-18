﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Transfers.Requests
{
    public class TransferToInternationalUSRequest
    {
        public class Meta
        {
            public string AccountNumber { get; set; }
            public string RoutingNumber { get; set; }
            public string SwiftCode { get; set; }
            public string BankName { get; set; }
            public string BeneficiaryName { get; set; }
            public string BeneficiaryAddress { get; set; }
            public string BeneficiaryCountry { get; set; }
        }

        [JsonRequired]
        [JsonProperty("amount")]
        public int amount { get; set; }
        [JsonProperty("narration")]
        public string narration { get; set; }
        [JsonRequired]
        [JsonProperty("currency")]
        public string currency { get; set; }
        [JsonProperty("reference")]
        public string reference { get; set; }
        [JsonProperty("beneficiary_name")]
        public string beneficiary_name { get; set; }
        [JsonRequired]
        [JsonProperty("meta")]
        public List<Meta> meta { get; set; }


    }



}
