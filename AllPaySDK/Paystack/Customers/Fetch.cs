using Newtonsoft.Json;

namespace AllPaySDK.Paystack.Customers
{
    public class CustomerFetchResponse //: HasRawResponse
    {

        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public CustomerList.Datum Data { get; set; }
    }
}
