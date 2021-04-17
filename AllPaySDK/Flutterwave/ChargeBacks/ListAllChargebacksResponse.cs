using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.ChargeBacks
{
    public class ListAllChargebacksResponse
    {

        public class PageInfo
        {
            [JsonProperty("total")]
            public int Total { get; set; }
            [JsonProperty("current_page")]
            public int CurrentPage { get; set; }
            [JsonProperty("total_pages")]
            public int TotalPages { get; set; }
            [JsonProperty("page_size")]
            public int PageSize { get; set; }
        }

        public class Meta
        {
            [JsonProperty("page_info")]
            public PageInfo PageInfo { get; set; }
            [JsonProperty("uploaded_proof")]
            public object UploadedProof { get; set; }
            [JsonProperty("history")]
            public List<History> History { get; set; }
        }

        public class History
        {
            [JsonProperty("action")]
            public string Action { get; set; }
            [JsonProperty("stage")]
            public string Stage { get; set; }
            [JsonProperty("date")]
            public DateTime Date { get; set; }
            [JsonProperty("description")]
            public string Description { get; set; }
            [JsonProperty("source")]
            public string Source { get; set; }
        }

        public class Datum
        {
            [JsonProperty("id")]
            public int Id { get; set; }
            [JsonProperty("amount")]
            public int Amount { get; set; }
            [JsonProperty("flw_ref")]
            public string FlwRef { get; set; }

            [JsonProperty("status")]
            public string Status { get; set; }
            [JsonProperty("stage")]
            public string Stage { get; set; }
            [JsonProperty("comment")]
            public string Comment { get; set; }
            [JsonProperty("meta")]
            public Meta Meta { get; set; }
            [JsonProperty("due_date")]
            public DateTime DueDate { get; set; }
            [JsonProperty("settlement_id")]
            public string SettlementId { get; set; }
            [JsonProperty("created_at")]
            public DateTime CreatedAt { get; set; }
            [JsonProperty("transaction_id")]
            public int TransactionId { get; set; }
        }




        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public List<Datum> Data { get; set; }

    }



   
}
