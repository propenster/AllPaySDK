using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Verification
{
    public class VerifyBvnRequest
    {
        [JsonProperty("bvn")]
        public int Bvn { get; set; }
    }
}
