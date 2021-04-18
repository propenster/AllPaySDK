using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllPaySDK.Flutterwave.Transfers.Responses
{
    public class TransferToNigerianBankAccountResponse
    {


        public class Datum
        {
            public int id { get; set; }
            public string account_number { get; set; }
            public string bank_code { get; set; }
            public string full_name { get; set; }
            public DateTime created_at { get; set; }
            public string currency { get; set; }
            public string debit_currency { get; set; }
            public int amount { get; set; }
            public int fee { get; set; }
            public string status { get; set; }
            public string reference { get; set; }
            public object meta { get; set; }
            public string narration { get; set; }
            public string complete_message { get; set; }
            public int requires_approval { get; set; }
            public int is_approved { get; set; }
            public string bank_name { get; set; }
        }





        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public Datum Data { get; set; }
    }


    
   

}
