using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Payments.Card
{
    public class EncryptedCardRequest
    {
        [JsonProperty("client")]
        public string Client { get; set; }
    }
}
