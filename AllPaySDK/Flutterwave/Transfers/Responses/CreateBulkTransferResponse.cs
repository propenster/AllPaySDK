
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Transfers.Responses
{
    public class CreateBulkTransferResponse
    {
        public class Datum
        {
            public int id { get; set; }
            public DateTime created_at { get; set; }
            public string approver { get; set; }
        }

        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public Datum Data { get; set; }


    }



    

    

}
