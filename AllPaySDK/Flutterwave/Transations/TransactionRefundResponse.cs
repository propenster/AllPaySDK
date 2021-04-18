using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Transations
{
    public class TransactionRefundResponse
    {
        public class Meta
        {
            [JsonProperty("source")]
            public string Source { get; set; }
        }


        public class Datum
        {
            [JsonProperty("id")]
            public int Id { get; set; }
            [JsonProperty("account_id")]
            public int AccountId { get; set; }
            [JsonProperty("tx_id")]
            public int TxId { get; set; }
            [JsonProperty("flw_ref")]
            public string FlwRef { get; set; }
            [JsonProperty("wallet_id")]
            public int WalletId { get; set; }
            [JsonProperty("amount_refunded")]
            public int AmountRefunded { get; set; }
            [JsonProperty("status")]
            public string Status { get; set; }
            [JsonProperty("destination")]
            public string Destination { get; set; }
            [JsonProperty("meta")]
            public Meta Meta { get; set; }
            [JsonProperty("created_at")]
            public DateTime CreatedAt { get; set; }
        }






        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public Datum Data { get; set; }



    }





    
}
