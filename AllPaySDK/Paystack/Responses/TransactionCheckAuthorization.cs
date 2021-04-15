using System.Text.Json.Serialization;

namespace AllPaySDK.Paystack.Responses
{
    public class CheckAuthorizationRequest
    {

        [JsonPropertyName("authorization_code")]
        public string AuthorizationCode { get; set; }

        public string Currency { get; set; }

        [JsonPropertyName("amount")]
        public int AmountInKobo { get; set; }

        public string Email { get; set; }

    }

    public class CheckAuthorizationResponse //: HasRawResponse
    {
        [JsonPropertyName("status")]
        public bool Status { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("data")]
        public CheckAuthorizationData Data { get; set; }
    }

    public class CheckAuthorizationData
    {
        [JsonPropertyName("amount")]
        public string AmountInKobo { get; set; }
        public string Currency { get; set; }
    }
}
