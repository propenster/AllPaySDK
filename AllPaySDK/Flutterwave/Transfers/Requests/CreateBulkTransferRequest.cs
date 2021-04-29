
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Transfers.Requests
{
    public class CreateBulkTransferRequest
    {
        public class BulkData
        {
            public string bank_code { get; set; }
            public string account_number { get; set; }
            public int amount { get; set; }
            public string currency { get; set; }
            public string narration { get; set; }
            public string reference { get; set; }
        }


        public string title { get; set; }
        [JsonProperty("bulk_data")]
        public List<BulkData> bulk_data { get; set; }


    }



}
