
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Bills
{
    public class GetBillCategoriesResponse
    {

        public class Datum
        {
            [JsonProperty("id")]
            public int id { get; set; }
            [JsonProperty("biller_code")]
            public string biller_code { get; set; }
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("default_commission")]
            public double default_commission { get; set; }
            [JsonProperty("date_added")]
            public DateTime date_added { get; set; }
            [JsonProperty("country")]
            public string country { get; set; }
            [JsonProperty("is_airtime")]
            public bool is_airtime { get; set; }
            [JsonProperty("biller_name")]
            public string biller_name { get; set; }
            [JsonProperty("item_code")]
            public string item_code { get; set; }
            [JsonProperty("short_name")]
            public string short_name { get; set; }
            [JsonProperty("fee")]
            public int fee { get; set; }
            [JsonProperty("commission_on_fee")]
            public bool commission_on_fee { get; set; }
            [JsonProperty("label_name")]
            public string label_name { get; set; }
            [JsonProperty("amount")]
            public int amount { get; set; }
        }


        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public List<Datum> Data { get; set; }
    }




}
