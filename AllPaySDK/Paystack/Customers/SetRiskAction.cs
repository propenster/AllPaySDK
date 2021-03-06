using Newtonsoft.Json;

namespace AllPaySDK.Paystack.Customers
{
    public class CustomerSetRiskActionData : CustomerList.Datum
    {
        [JsonProperty("risk_action")]
        public string RiskAction { get; set; }
    }

    public class CustomerSetRiskActionRequest
    {
        /// <summary>
        ///     Customer's ID, Code, or Email Address
        /// </summary>
        public string Customer { get; set; }

        /// <summary>
        ///     One of the possible risk actions. 'allow' to whitelist. 'deny' to blacklist.
        /// </summary>
        [JsonProperty("risk_action")]
        public string RiskAction { get; set; }
    }

    public class CustomerSetRiskActionResponse //: HasRawResponse
    {
        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public CustomerSetRiskActionData Data { get; set; }
    }
}