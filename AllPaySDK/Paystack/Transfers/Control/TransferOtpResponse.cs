using Newtonsoft.Json;

namespace AllPaySDK.Paystack.Transfers.Control
{
    public class TransferOtpResponse //: HasRawResponse
    {

        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}