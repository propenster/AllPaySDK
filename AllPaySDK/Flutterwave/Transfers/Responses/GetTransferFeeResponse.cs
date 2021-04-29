using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Transfers.Responses
{
    public class GetTransferFeeResponse
    {

        public class Datum
        {
            public string fee_type { get; set; }
            public string currency { get; set; }
            public double fee { get; set; }
        }

        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("messsage")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public List<Datum> Data { get; set; }


    }


}
