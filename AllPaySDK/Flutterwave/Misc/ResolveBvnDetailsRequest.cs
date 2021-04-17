using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Misc
{
    public class ResolveBvnDetailsRequest
    {
        [JsonProperty("bvn")]
        public int Bvn { get; set; }
    }
}
