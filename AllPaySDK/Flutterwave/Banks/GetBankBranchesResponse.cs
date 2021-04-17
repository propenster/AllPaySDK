using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Banks
{
    public class GetBankBranchesResponse
    {

        public class Datum
        {
            [JsonProperty("id")]
            public int Id { get; set; }
            [JsonProperty("branch_code")]
            public string BranchCode { get; set; }
            [JsonProperty("branch_name")]
            public string BranchName { get; set; }
            [JsonProperty("swift_code")]
            public string SwiftCode { get; set; }
            [JsonProperty("bic")]
            public string BIC { get; set; }
            [JsonProperty("bank_id")]
            public int BankId { get; set; }
        }

        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public List<Datum> Data { get; set; }

    }

    

}
