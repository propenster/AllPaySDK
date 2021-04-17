using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Bills
{
    public class GetBillPaymentsResponse
    {
        public class Summary
        {
            [JsonProperty("currency")]
            public string Currency { get; set; }
            [JsonProperty("sum_bills")]
            public double SumBills { get; set; }
            [JsonProperty("sum_commission")]
            public double SumCommission { get; set; }
            [JsonProperty("sum_dstv")]
            public int SumDstv { get; set; }
            [JsonProperty("sum_airtime")]
            public int SumAirtime { get; set; }
            [JsonProperty("count_dstv")]
            public int CountDstv { get; set; }
            [JsonProperty("count_airtime")]
            public int CountAirtime { get; set; }
        }

        public class Transaction
        {
            [JsonProperty("currency")]
            public string Currency { get; set; }
            [JsonProperty("customer_id")]
            public string CustomerId { get; set; }
            [JsonProperty("frequency")]
            public string Frequency { get; set; }
            [JsonProperty("amount")]
            public string Amount { get; set; }
            [JsonProperty("product")]
            public string Product { get; set; }
            [JsonProperty("product_name")]
            public string ProductName { get; set; }
            [JsonProperty("commission")]
            public double Commission { get; set; }
            [JsonProperty("created_at")]
            public DateTime CreatedAt { get; set; }
            [JsonProperty("tx_id")]
            public int TxId { get; set; }
        }

        public class Datum
        {
            [JsonProperty("summary")]
            public List<Summary> Summary { get; set; }
            [JsonProperty("transactions")]
            public List<Transaction> Transactions { get; set; }
            [JsonProperty("total")]
            public int Total { get; set; }
            [JsonProperty("total_pages")]
            public int TotalPages { get; set; }
            [JsonProperty("reference")]
            public object Reference { get; set; }
        }


        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public Datum Data { get; set; }

    }




    
}
